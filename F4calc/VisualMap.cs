using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace F4calc
{
	public partial class VisualMap : UserControl
	{
		private const int a = 1, b = 2, c1 = 2, c2 = 2;
		private int depthLimit = 16, nLimit = 256;
		private double eps = 1e-12d;
		private double z1min = -0.5d, z1max = 0.5d;
		private double z2min = -0.5d, z2max = 0.5d;
		private Image _bitmap;
		public VisualMap()
		{
			AutoScaleMode = AutoScaleMode.Font;
		}
		public void SetParams(
			double z1min, double z1max, double z2min, double z2max,
			double eps, int depthLimit, int nLimit)
		{
			this.z1min = z1min;
			this.z1max = z1max;
			this.z2min = z2min;
			this.z2max = z2max;
			this.eps = eps;
			this.depthLimit = depthLimit;
			this.nLimit = nLimit;
		}
		public void RePaint()
		{
			_bitmap = null;
			Invalidate();
		}
	}
}
