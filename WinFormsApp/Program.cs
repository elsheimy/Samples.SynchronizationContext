using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Control.CheckForIllegalCrossThreadCalls = true;

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      // SynchronizationContext is still null here
      Debug.Assert(SynchronizationContext.Current == null);

      var frm = new ConfigureAwaitForm();

      // Now SynchronizationContext is installed
      Debug.Assert(SynchronizationContext.Current != null &&
        SynchronizationContext.Current is WindowsFormsSynchronizationContext);


      Application.Run(frm);
    }
  }
}
