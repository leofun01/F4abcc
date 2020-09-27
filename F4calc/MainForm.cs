using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace F4calc
{
	public partial class MainForm : Form
	{
		private const int a = 1, b = 2, c1 = 2, c2 = 2;
		private int depthLimit = 16, nLimit = 256;
		private double eps = 1e-12d;
		private double z1min = -0.5d, z1max = 0.5d;
		private double z2min = -0.5d, z2max = 0.5d;
		private Color DefaultComboBox_BackColor;
		private Color DefaultTextBox_BackColor;
		public MainForm()
		{
			InitializeComponent();
			textBox_z1_min.Text = z1min.ToString();
			textBox_z1_max.Text = z1max.ToString();
			textBox_z2_min.Text = z2min.ToString();
			textBox_z2_max.Text = z2max.ToString();
			textBox_eps.Text = eps.ToString();
			comboBox_depth_limit.Text = depthLimit.ToString();
			comboBox_length_limit.Text = nLimit.ToString();
			for(int depth = 0; depth <= 30; depth += 2)
			{
				comboBox_depth_limit.AutoCompleteCustomSource.Add(depth.ToString());
				comboBox_depth_limit.Items.Add(depth);
				int n = 1 << (depth >> 1);
				comboBox_length_limit.AutoCompleteCustomSource.Add(n.ToString());
				comboBox_length_limit.Items.Add(n);
			}
			DefaultComboBox_BackColor = comboBox_depth_limit.BackColor;
			DefaultTextBox_BackColor = textBox_eps.BackColor;
		}
		private void tabControl_map_Selected(object sender, TabControlEventArgs e)
		{
			if(e.TabPage == tabPage_map) button_calc.Text = "Draw";
			if(e.TabPage == tabPage_list) button_calc.Text = "Calc";
		}
		private void button_calc_Click(object sender, EventArgs e)
		{
			if(!InitValues()) return;
			if(tabControl_map.SelectedTab.Text == "Map") DrawMap(visualMap_draw);
			if(tabControl_map.SelectedTab.Text == "List") DataGridInit(dataGridView_list);
		}
		private bool InitValues()
		{
			bool success = true;
			if(double.TryParse(textBox_z1_min.Text, out z1min))
				textBox_z1_min.BackColor = DefaultTextBox_BackColor;
			else {
				textBox_z1_min.BackColor = Color.LightPink;
				success = false;
			}
			if(double.TryParse(textBox_z1_max.Text, out z1max))
				textBox_z1_max.BackColor = DefaultTextBox_BackColor;
			else {
				textBox_z1_max.BackColor = Color.LightPink;
				success = false;
			}
			if(double.TryParse(textBox_z2_min.Text, out z2min))
				textBox_z2_min.BackColor = DefaultTextBox_BackColor;
			else {
				textBox_z2_min.BackColor = Color.LightPink;
				success = false;
			}
			if(double.TryParse(textBox_z2_max.Text, out z2max))
				textBox_z2_max.BackColor = DefaultTextBox_BackColor;
			else {
				textBox_z2_max.BackColor = Color.LightPink;
				success = false;
			}
			if(double.TryParse(textBox_eps.Text, out eps))
				textBox_eps.BackColor = DefaultTextBox_BackColor;
			else {
				textBox_eps.BackColor = Color.LightPink;
				success = false;
			}
			if(int.TryParse(comboBox_depth_limit.Text, out depthLimit))
				comboBox_depth_limit.BackColor = DefaultComboBox_BackColor;
			else {
				comboBox_depth_limit.BackColor = Color.LightPink;
				success = false;
			}
			if(int.TryParse(comboBox_length_limit.Text, out nLimit))
				comboBox_length_limit.BackColor = DefaultComboBox_BackColor;
			else {
				comboBox_length_limit.BackColor = Color.LightPink;
				success = false;
			}
			return success;
		}
		private void DrawMap(VisualMap map)
		{
			visualMap_draw.SetParams(
				z1min, z1max, z2min, z2max,
				eps, depthLimit, nLimit
			);
			visualMap_draw.RePaint();
		}
		private void DataGridInit(DataGridView grid)
		{
			grid.SuspendLayout();
			textBox_list.SuspendLayout();
			grid.Rows.Clear();
			textBox_list.Clear();
			int pointsCount = (int)numericUpDown_pointsCount.Value;
			grid.Rows.Add(pointsCount);
			int depth = 0, n = 0;
			double z1 = 0d, z2 = 0d;
			for(int i = 0; i < pointsCount; ++i) {
				if(pointsCount > 1) {
					z1 = (z1max - z1min) * i / (pointsCount - 1) + z1min;
					z2 = (z2max - z2min) * i / (pointsCount - 1) + z2min;
				}
				else {
					z1 = (z1min + z1max) / 2;
					z2 = (z2min + z2max) / 2;
				}
				z1 = Math.Floor(z1 * 1e+12d + 0.5d) / 1e+12d;
				z2 = Math.Floor(z2 * 1e+12d + 0.5d) / 1e+12d;
				double frac = Fraction.F4Frac_a_c1(a, b, c1, c2, z1, z2, eps, depthLimit, out depth);
				double series = Series.F4Series(a, b, c1, c2, z1, z2, eps, nLimit, out n);
				DataGridViewRow row = grid.Rows[i];
				row.Cells[0].Value = z1;
				row.Cells[1].Value = z2;
				row.Cells[2].Value = depth;
				row.Cells[3].Value = 1d / frac;
				row.Cells[4].Value = n;
				row.Cells[5].Value = series;
				textBox_list.AppendText(
					string.Format(
						"( {0,-5}, {1,-5} ) => {2,3} : {3,-22},  {4,3} : {5,-22}\r\n",
						z1, z2, depth, 1d / frac, n, series
					)
				);
			}
			grid.ResumeLayout(false);
			textBox_list.ResumeLayout(false);
		}
	}
}
