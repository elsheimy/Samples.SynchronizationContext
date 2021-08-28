
namespace WinFormsApp
{
  partial class ConfigureAwaitForm
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

#region Windows Form Designer generated code

/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent()
{
      this.ResultsListBox = new System.Windows.Forms.ListBox();
      this.ConfigureTrueButton = new System.Windows.Forms.Button();
      this.ConfigureFalseButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // ResultsListBox
      // 
      this.ResultsListBox.FormattingEnabled = true;
      this.ResultsListBox.Location = new System.Drawing.Point(12, 12);
      this.ResultsListBox.Name = "ResultsListBox";
      this.ResultsListBox.Size = new System.Drawing.Size(517, 342);
      this.ResultsListBox.TabIndex = 0;
      // 
      // ConfigureTrueButton
      // 
      this.ConfigureTrueButton.Location = new System.Drawing.Point(12, 357);
      this.ConfigureTrueButton.Name = "ConfigureTrueButton";
      this.ConfigureTrueButton.Size = new System.Drawing.Size(516, 23);
      this.ConfigureTrueButton.TabIndex = 1;
      this.ConfigureTrueButton.Text = "Task.ConfigureAwait(true) Test";
      this.ConfigureTrueButton.UseVisualStyleBackColor = true;
      this.ConfigureTrueButton.Click += new System.EventHandler(this.ConfigureTrueButton_Click);
      // 
      // ConfigureFalseButton
      // 
      this.ConfigureFalseButton.Location = new System.Drawing.Point(12, 386);
      this.ConfigureFalseButton.Name = "ConfigureFalseButton";
      this.ConfigureFalseButton.Size = new System.Drawing.Size(516, 23);
      this.ConfigureFalseButton.TabIndex = 2;
      this.ConfigureFalseButton.Text = "Task.ConfigureAwait(false) Test";
      this.ConfigureFalseButton.UseVisualStyleBackColor = true;
      this.ConfigureFalseButton.Click += new System.EventHandler(this.ConfigureFalseButton_Click);
      // 
      // ConfigureAwaitForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(541, 421);
      this.Controls.Add(this.ConfigureFalseButton);
      this.Controls.Add(this.ConfigureTrueButton);
      this.Controls.Add(this.ResultsListBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "ConfigureAwaitForm";
      this.Text = "Task.ConfigureAwait Sample";
      this.ResumeLayout(false);

}

#endregion

private System.Windows.Forms.ListBox ResultsListBox;
private System.Windows.Forms.Button ConfigureTrueButton;
private System.Windows.Forms.Button ConfigureFalseButton;
  }
}

