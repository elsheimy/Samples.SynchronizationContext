using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace TestWebMvc.Controllers
{
  public class HomeController : Controller
  {
    private List<string> results = new List<string>();

    public async Task<ActionResult> Index(bool configureAwait = false)
    {
      await AsyncTest(configureAwait);
      return View(results);
    }


    private async Task AsyncTest(bool configureAwait)
    {
      results.Add($"Async test started, ConfigureAwait = {configureAwait}");

      if (null == System.Web.HttpContext.Current)
        results.Add($"HttpContext.Current is null");
      else
        results.Add($"HttpContext.Current is NOT null");

      results.Add($"Current thread ID = {Thread.CurrentThread.ManagedThreadId}");

      results.Add("Awaiting task...");

      await Task.Delay(1000).ConfigureAwait(configureAwait);

      results.Add("Task completed");

      results.Add($"Current thread ID = {Thread.CurrentThread.ManagedThreadId}");

      if (null == System.Web.HttpContext.Current)
        results.Add($"HttpContext.Current is null");
      else
        results.Add($"HttpContext.Current is NOT null");
    }


  }
}