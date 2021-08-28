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
  public partial class TasksForm : Form
  {
    public TasksForm()
    {
      InitializeComponent();
    }

    private void NoContextButton_Click(object sender, EventArgs e)
    {
      RunTask(null);
    }

    private void UIContextButton_Click(object sender, EventArgs e)
    {
      RunTask(SynchronizationContext.Current);
    }

    private void RunTask(SynchronizationContext context)
    {
      this.ResultsListBox.Items.Clear();
      this.ResultsListBox.Items.Add($"UI Thread {Thread.CurrentThread.ManagedThreadId}");


      Task.Run(async () =>
      {
        if (null != context)
          SynchronizationContext.SetSynchronizationContext(context);


        LogMessage($"Task started");


        if (null == SynchronizationContext.Current)
          LogMessage($"Task synchronization context is null");
        else
          LogMessage($"Task synchronization context is {SynchronizationContext.Current.GetType().Name}");

        await Task.Delay(1000);

        LogMessage($"Task thread is {Thread.CurrentThread.ManagedThreadId}");

        LogMessage($"Control.InvokeRequired = {this.ResultsListBox.InvokeRequired}");


        LogMessage($"Trying to manipulate UI...");
        try
        {
          this.ResultsListBox.Items.Add("Successfully accessed UI directly!");
        }
        catch (InvalidOperationException)
        {
          LogMessage($"Failed!");
        }

        LogMessage($"Task finished");
      });
    }

    private void LogMessage(string msg)
    {
      this.ResultsListBox.Invoke((Action)(() =>
      {
        this.ResultsListBox.Items.Add(msg);
      }));
    }


  }
}
