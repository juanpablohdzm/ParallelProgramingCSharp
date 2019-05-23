namespace AsyncAwait
{
  partial class MainFrame
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
      this.BtnCalculate = new System.Windows.Forms.Button();
      this.LblResult = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // BtnCalculate
      // 
      this.BtnCalculate.Location = new System.Drawing.Point(41, 23);
      this.BtnCalculate.Name = "BtnCalculate";
      this.BtnCalculate.Size = new System.Drawing.Size(171, 72);
      this.BtnCalculate.TabIndex = 0;
      this.BtnCalculate.Text = "Calculate";
      this.BtnCalculate.UseVisualStyleBackColor = true;
      this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
      // 
      // LblResult
      // 
      this.LblResult.AutoSize = true;
      this.LblResult.Location = new System.Drawing.Point(57, 140);
      this.LblResult.Name = "LblResult";
      this.LblResult.Size = new System.Drawing.Size(93, 32);
      this.LblResult.TabIndex = 1;
      this.LblResult.Text = "label1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(806, 546);
      this.Controls.Add(this.LblResult);
      this.Controls.Add(this.BtnCalculate);
      this.Name = "MainFrame";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnCalculate;
    private System.Windows.Forms.Label LblResult;
  }
}

