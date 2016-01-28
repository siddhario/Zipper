namespace Zipper.Win
{
  partial class MainForm
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
      this.fbdSource = new System.Windows.Forms.FolderBrowserDialog();
      this.fbdDest = new System.Windows.Forms.FolderBrowserDialog();
      this.tbSource = new System.Windows.Forms.TextBox();
      this.tbDest = new System.Windows.Forms.TextBox();
      this.btnSource = new System.Windows.Forms.Button();
      this.btnDest = new System.Windows.Forms.Button();
      this.lblSource = new System.Windows.Forms.Label();
      this.lblDest = new System.Windows.Forms.Label();
      this.nudMaxSize = new System.Windows.Forms.NumericUpDown();
      this.lblMaxSize = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxSize)).BeginInit();
      this.SuspendLayout();
      // 
      // tbSource
      // 
      this.tbSource.Location = new System.Drawing.Point(140, 32);
      this.tbSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.tbSource.Name = "tbSource";
      this.tbSource.Size = new System.Drawing.Size(493, 22);
      this.tbSource.TabIndex = 0;
      // 
      // tbDest
      // 
      this.tbDest.Location = new System.Drawing.Point(140, 76);
      this.tbDest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.tbDest.Name = "tbDest";
      this.tbDest.Size = new System.Drawing.Size(493, 22);
      this.tbDest.TabIndex = 1;
      // 
      // btnSource
      // 
      this.btnSource.Location = new System.Drawing.Point(641, 32);
      this.btnSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnSource.Name = "btnSource";
      this.btnSource.Size = new System.Drawing.Size(39, 22);
      this.btnSource.TabIndex = 2;
      this.btnSource.Text = "...";
      this.btnSource.UseVisualStyleBackColor = true;
      this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
      // 
      // btnDest
      // 
      this.btnDest.Location = new System.Drawing.Point(641, 76);
      this.btnDest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnDest.Name = "btnDest";
      this.btnDest.Size = new System.Drawing.Size(39, 22);
      this.btnDest.TabIndex = 3;
      this.btnDest.Text = "...";
      this.btnDest.UseVisualStyleBackColor = true;
      this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
      // 
      // lblSource
      // 
      this.lblSource.AutoSize = true;
      this.lblSource.Location = new System.Drawing.Point(29, 36);
      this.lblSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblSource.Name = "lblSource";
      this.lblSource.Size = new System.Drawing.Size(54, 16);
      this.lblSource.TabIndex = 4;
      this.lblSource.Text = "Source:";
      // 
      // lblDest
      // 
      this.lblDest.AutoSize = true;
      this.lblDest.Location = new System.Drawing.Point(29, 80);
      this.lblDest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblDest.Name = "lblDest";
      this.lblDest.Size = new System.Drawing.Size(78, 16);
      this.lblDest.TabIndex = 5;
      this.lblDest.Text = "Destination:";
      // 
      // nudMaxSize
      // 
      this.nudMaxSize.Location = new System.Drawing.Point(140, 121);
      this.nudMaxSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.nudMaxSize.Name = "nudMaxSize";
      this.nudMaxSize.Size = new System.Drawing.Size(81, 22);
      this.nudMaxSize.TabIndex = 6;
      this.nudMaxSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.nudMaxSize.ValueChanged += new System.EventHandler(this.nudMaxSize_ValueChanged);
      // 
      // lblMaxSize
      // 
      this.lblMaxSize.AutoSize = true;
      this.lblMaxSize.Location = new System.Drawing.Point(29, 121);
      this.lblMaxSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblMaxSize.Name = "lblMaxSize";
      this.lblMaxSize.Size = new System.Drawing.Size(94, 16);
      this.lblMaxSize.TabIndex = 7;
      this.lblMaxSize.Text = "Max size (MB):";
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point(140, 164);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(276, 47);
      this.btnOK.TabIndex = 8;
      this.btnOK.Text = "Start";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(722, 223);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.lblMaxSize);
      this.Controls.Add(this.nudMaxSize);
      this.Controls.Add(this.lblDest);
      this.Controls.Add(this.lblSource);
      this.Controls.Add(this.btnDest);
      this.Controls.Add(this.btnSource);
      this.Controls.Add(this.tbDest);
      this.Controls.Add(this.tbSource);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "MainForm";
      this.Text = "ZipperWin";
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxSize)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.FolderBrowserDialog fbdSource;
    private System.Windows.Forms.FolderBrowserDialog fbdDest;
    private System.Windows.Forms.TextBox tbSource;
    private System.Windows.Forms.TextBox tbDest;
    private System.Windows.Forms.Button btnSource;
    private System.Windows.Forms.Button btnDest;
    private System.Windows.Forms.Label lblSource;
    private System.Windows.Forms.Label lblDest;
    private System.Windows.Forms.NumericUpDown nudMaxSize;
    private System.Windows.Forms.Label lblMaxSize;
    private System.Windows.Forms.Button btnOK;
  }
}

