using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zipper.Win
{
  public partial class MainForm : Form
  {
    public MainForm()
    {

      InitializeComponent();
    }

    private async void btnOK_Click(object sender, EventArgs e)
    {
      string root = tbSource.Text;
      string moveTo = tbDest.Text;
      long maxSizeInMB = (long)nudMaxSize.Value;
      await Zipper.Core.Zipper.Run(root, moveTo, maxSizeInMB);
      MessageBox.Show("Completed!");

      Process.Start(moveTo);
    }

    private void btnSource_Click(object sender, EventArgs e)
    {
      if (fbdSource.ShowDialog() == DialogResult.OK)
        tbSource.Text = fbdSource.SelectedPath;

    }

    private void btnDest_Click(object sender, EventArgs e)
    {
      if (fbdDest.ShowDialog() == DialogResult.OK)
        tbDest.Text = fbdDest.SelectedPath;
    }

    private void nudMaxSize_ValueChanged(object sender, EventArgs e)
    {

    }
  }
}
