using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
  public partial class ThreadsForm : Form
  {
    public ThreadsForm()
    {
      InitializeComponent();
    }

private void RegularThreadsButton_Click(object sender, EventArgs e)
{
  RunThreads(null);
}
private void UIThreadTest_Click(object sender, EventArgs e)
{
  // SynchronizationContext.Current will return a reference to WindowsFormsSynchronizationContext
  RunThreads(SynchronizationContext.Current);
}

private void RunThreads(SynchronizationContext context)
{
  this.ResultsListBox.Items.Clear();
  this.ResultsListBox.Items.Add($"UI Thread {Thread.CurrentThread.ManagedThreadId}");


      int maxThreads = 3;
  for (int i = 0; i < maxThreads; i++)
  {
    Thread t = new Thread(UpdateListBox);
    t.IsBackground = true;
    t.Start(context); // passing context to thread proc
  }
}



private void UpdateListBox(object state)
{
  // fetching passed SynchrnozationContext
  SynchronizationContext syncContext = state as SynchronizationContext;

  // get thread ID
  var threadId = Thread.CurrentThread.ManagedThreadId;

  if (null == syncContext) // no SynchronizationContext provided
    this.ResultsListBox.Items.Add($"Hello from thread {threadId}, currently executing thread is {Thread.CurrentThread.ManagedThreadId}");
  else
    syncContext.Send((obj) => this.ResultsListBox.Items.Add($"Hello from thread {threadId}, currently executing thread is {Thread.CurrentThread.ManagedThreadId}"), null);
}
  }

}
