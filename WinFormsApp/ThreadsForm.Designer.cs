
namespace WinFormsApp
{
  partial class ThreadsForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }


/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent()
{
  this.ResultsListBox = new System.Windows.Forms.ListBox();
  this.RegularThreadsButton = new System.Windows.Forms.Button();
  this.UIThreadTest = new System.Windows.Forms.Button();
  this.SuspendLayout();
  // 
  // ResultsListBox
  // 
  this.ResultsListBox.FormattingEnabled = true;
  this.ResultsListBox.Location = new System.Drawing.Point(12, 12);
  this.ResultsListBox.Name = "ResultsListBox";
  this.ResultsListBox.Size = new System.Drawing.Size(516, 212);
  this.ResultsListBox.TabIndex = 1;
  // 
  // RegularThreadsButton
  // 
  this.RegularThreadsButton.Location = new System.Drawing.Point(12, 232);
  this.RegularThreadsButton.Name = "RegularThreadsButton";
  this.RegularThreadsButton.Size = new System.Drawing.Size(516, 23);
  this.RegularThreadsButton.TabIndex = 2;
  this.RegularThreadsButton.Text = "Regular Thread Test";
  this.RegularThreadsButton.UseVisualStyleBackColor = true;
  this.RegularThreadsButton.Click += new System.EventHandler(this.RegularThreadsButton_Click);
  // 
  // UIThreadTest
  // 
  this.UIThreadTest.Location = new System.Drawing.Point(12, 261);
  this.UIThreadTest.Name = "UIThreadTest";
  this.UIThreadTest.Size = new System.Drawing.Size(516, 23);
  this.UIThreadTest.TabIndex = 3;
  this.UIThreadTest.Text = "UI-Context Thread Test";
  this.UIThreadTest.UseVisualStyleBackColor = true;
  this.UIThreadTest.Click += new System.EventHandler(this.UIThreadTest_Click);
  // 
  // ThreadsForm
  // 
  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
  this.ClientSize = new System.Drawing.Size(540, 294);
  this.Controls.Add(this.UIThreadTest);
  this.Controls.Add(this.RegularThreadsButton);
  this.Controls.Add(this.ResultsListBox);
  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
  this.MaximizeBox = false;
  this.Name = "ThreadsForm";
  this.Text = "SynchronizationContext Sample";
  this.ResumeLayout(false);

}

private System.Windows.Forms.ListBox ResultsListBox;
private System.Windows.Forms.Button RegularThreadsButton;
private System.Windows.Forms.Button UIThreadTest;
  }
}