using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
  public partial class ConfigureAwaitForm : Form
  {

    public ConfigureAwaitForm()
    {
      InitializeComponent();
    }



    private void ConfigureTrueButton_Click(object sender, EventArgs e)
    {
      AsyncTest(true);
    }

    private void ConfigureFalseButton_Click(object sender, EventArgs e)
    {
      AsyncTest(false);
    }


    private async void AsyncTest(bool configureAwait)
    {
      this.ResultsListBox.Items.Clear();
      try
      {
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar-EG");


        this.ResultsListBox.Items.Add("Async test started");
        this.ResultsListBox.Items.Add(string.Format("configureAwait = {0}", configureAwait));

        this.ResultsListBox.Items.Add(string.Format("Current thread ID = {0}", Thread.CurrentThread.ManagedThreadId));
        this.ResultsListBox.Items.Add(string.Format("Current culture = {0}", Thread.CurrentThread.CurrentCulture));

        this.ResultsListBox.Items.Add("Awaiting a task...");
        await Task.Delay(500).ConfigureAwait(configureAwait);

        this.ResultsListBox.Items.Add("Task completed");
        this.ResultsListBox.Items.Add(string.Format("Current thread ID: {0}", Thread.CurrentThread.ManagedThreadId));
        this.ResultsListBox.Items.Add(string.Format("Current culture: {0}", Thread.CurrentThread.CurrentCulture));

      }
      catch (InvalidOperationException ex)
      {
        var threadId = Thread.CurrentThread.ManagedThreadId;

        this.ResultsListBox.BeginInvoke((Action)(() =>
        {
          this.ResultsListBox.Items.Add($"{ex.GetType().Name} caught from thread {threadId}");
        }));
      }
    }


  }
}
