namespace F4calc
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
			if(disposing && (components != null))
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
			this.button_calc = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.comboBox_length_limit = new System.Windows.Forms.ComboBox();
			this.textBox_z2_max = new System.Windows.Forms.TextBox();
			this.textBox_z2_min = new System.Windows.Forms.TextBox();
			this.textBox_z1_max = new System.Windows.Forms.TextBox();
			this.textBox_z1_min = new System.Windows.Forms.TextBox();
			this.label_z1_min = new System.Windows.Forms.Label();
			this.label_z2_max = new System.Windows.Forms.Label();
			this.label_z2_min = new System.Windows.Forms.Label();
			this.label_z1_max = new System.Windows.Forms.Label();
			this.label_eps = new System.Windows.Forms.Label();
			this.textBox_eps = new System.Windows.Forms.TextBox();
			this.label_length_limit = new System.Windows.Forms.Label();
			this.label_depth_limit = new System.Windows.Forms.Label();
			this.comboBox_depth_limit = new System.Windows.Forms.ComboBox();
			this.tabControl_map = new System.Windows.Forms.TabControl();
			this.tabPage_list = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.numericUpDown_pointsCount = new System.Windows.Forms.NumericUpDown();
			this.label_pointsCount = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage_table = new System.Windows.Forms.TabPage();
			this.dataGridView_list = new System.Windows.Forms.DataGridView();
			this.Column_z1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_z2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_fd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_n = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_snn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage_text = new System.Windows.Forms.TabPage();
			this.textBox_list = new System.Windows.Forms.TextBox();
			this.tabPage_map = new System.Windows.Forms.TabPage();
			this.visualMap_draw = new F4calc.VisualMap();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabControl_map.SuspendLayout();
			this.tabPage_list.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pointsCount)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage_table.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).BeginInit();
			this.tabPage_text.SuspendLayout();
			this.tabPage_map.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_calc
			// 
			this.button_calc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.SetColumnSpan(this.button_calc, 2);
			this.button_calc.Location = new System.Drawing.Point(3, 318);
			this.button_calc.Name = "button_calc";
			this.button_calc.Size = new System.Drawing.Size(264, 42);
			this.button_calc.TabIndex = 14;
			this.button_calc.Text = "Calc";
			this.button_calc.UseVisualStyleBackColor = true;
			this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(12, 12);
			this.splitContainer1.MinimumSize = new System.Drawing.Size(360, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.AutoScroll = true;
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Panel1MinSize = 240;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl_map);
			this.splitContainer1.Panel2MinSize = 10;
			this.splitContainer1.Size = new System.Drawing.Size(760, 440);
			this.splitContainer1.SplitterDistance = 270;
			this.splitContainer1.SplitterWidth = 8;
			this.splitContainer1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.comboBox_length_limit, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.textBox_z2_max, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.textBox_z2_min, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBox_z1_max, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBox_z1_min, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label_z1_min, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label_z2_max, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label_z2_min, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label_z1_max, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label_eps, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.textBox_eps, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label_length_limit, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.label_depth_limit, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.comboBox_depth_limit, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.button_calc, 0, 7);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 363);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// comboBox_length_limit
			// 
			this.comboBox_length_limit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox_length_limit.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192",
            "16384",
            "32768"});
			this.comboBox_length_limit.FormattingEnabled = true;
			this.comboBox_length_limit.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192",
            "16384",
            "32768"});
			this.comboBox_length_limit.Location = new System.Drawing.Point(3, 277);
			this.comboBox_length_limit.Name = "comboBox_length_limit";
			this.comboBox_length_limit.Size = new System.Drawing.Size(88, 30);
			this.comboBox_length_limit.TabIndex = 12;
			this.comboBox_length_limit.Text = "256";
			// 
			// textBox_z2_max
			// 
			this.textBox_z2_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_z2_max.Location = new System.Drawing.Point(97, 143);
			this.textBox_z2_max.Name = "textBox_z2_max";
			this.textBox_z2_max.Size = new System.Drawing.Size(170, 29);
			this.textBox_z2_max.TabIndex = 7;
			this.textBox_z2_max.Text = (0.5d).ToString();
			// 
			// textBox_z2_min
			// 
			this.textBox_z2_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_z2_min.Location = new System.Drawing.Point(97, 98);
			this.textBox_z2_min.Name = "textBox_z2_min";
			this.textBox_z2_min.Size = new System.Drawing.Size(170, 29);
			this.textBox_z2_min.TabIndex = 5;
			this.textBox_z2_min.Text = (-0.5d).ToString();
			// 
			// textBox_z1_max
			// 
			this.textBox_z1_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_z1_max.Location = new System.Drawing.Point(97, 53);
			this.textBox_z1_max.Name = "textBox_z1_max";
			this.textBox_z1_max.Size = new System.Drawing.Size(170, 29);
			this.textBox_z1_max.TabIndex = 3;
			this.textBox_z1_max.Text = (0.1d).ToString();
			// 
			// textBox_z1_min
			// 
			this.textBox_z1_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_z1_min.Location = new System.Drawing.Point(97, 8);
			this.textBox_z1_min.Name = "textBox_z1_min";
			this.textBox_z1_min.Size = new System.Drawing.Size(170, 29);
			this.textBox_z1_min.TabIndex = 1;
			this.textBox_z1_min.Text = (0.1d).ToString();
			// 
			// label_z1_min
			// 
			this.label_z1_min.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label_z1_min.AutoSize = true;
			this.label_z1_min.Location = new System.Drawing.Point(3, 11);
			this.label_z1_min.Name = "label_z1_min";
			this.label_z1_min.Size = new System.Drawing.Size(88, 22);
			this.label_z1_min.TabIndex = 0;
			this.label_z1_min.Text = "Z1 min";
			// 
			// label_z2_max
			// 
			this.label_z2_max.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label_z2_max.AutoSize = true;
			this.label_z2_max.Location = new System.Drawing.Point(3, 146);
			this.label_z2_max.Name = "label_z2_max";
			this.label_z2_max.Size = new System.Drawing.Size(88, 22);
			this.label_z2_max.TabIndex = 6;
			this.label_z2_max.Text = "Z2 max";
			// 
			// label_z2_min
			// 
			this.label_z2_min.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label_z2_min.AutoSize = true;
			this.label_z2_min.Location = new System.Drawing.Point(3, 101);
			this.label_z2_min.Name = "label_z2_min";
			this.label_z2_min.Size = new System.Drawing.Size(88, 22);
			this.label_z2_min.TabIndex = 4;
			this.label_z2_min.Text = "Z2 min";
			// 
			// label_z1_max
			// 
			this.label_z1_max.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label_z1_max.AutoSize = true;
			this.label_z1_max.Location = new System.Drawing.Point(3, 56);
			this.label_z1_max.Name = "label_z1_max";
			this.label_z1_max.Size = new System.Drawing.Size(88, 22);
			this.label_z1_max.TabIndex = 2;
			this.label_z1_max.Text = "Z1 max";
			// 
			// label_eps
			// 
			this.label_eps.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label_eps.AutoSize = true;
			this.label_eps.Location = new System.Drawing.Point(22, 191);
			this.label_eps.Name = "label_eps";
			this.label_eps.Size = new System.Drawing.Size(49, 22);
			this.label_eps.TabIndex = 8;
			this.label_eps.Text = "eps";
			// 
			// textBox_eps
			// 
			this.textBox_eps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_eps.Location = new System.Drawing.Point(97, 188);
			this.textBox_eps.Name = "textBox_eps";
			this.textBox_eps.Size = new System.Drawing.Size(170, 29);
			this.textBox_eps.TabIndex = 9;
			this.textBox_eps.Text = "1E-12";
			// 
			// label_length_limit
			// 
			this.label_length_limit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label_length_limit.AutoSize = true;
			this.label_length_limit.Location = new System.Drawing.Point(99, 270);
			this.label_length_limit.Name = "label_length_limit";
			this.label_length_limit.Size = new System.Drawing.Size(166, 44);
			this.label_length_limit.TabIndex = 13;
			this.label_length_limit.Text = "Series length limit";
			// 
			// label_depth_limit
			// 
			this.label_depth_limit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label_depth_limit.AutoSize = true;
			this.label_depth_limit.Location = new System.Drawing.Point(105, 225);
			this.label_depth_limit.Name = "label_depth_limit";
			this.label_depth_limit.Size = new System.Drawing.Size(153, 44);
			this.label_depth_limit.TabIndex = 11;
			this.label_depth_limit.Text = "Fraction depth limit";
			// 
			// comboBox_depth_limit
			// 
			this.comboBox_depth_limit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox_depth_limit.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
			this.comboBox_depth_limit.FormattingEnabled = true;
			this.comboBox_depth_limit.Items.AddRange(new object[] {
            "0",
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
			this.comboBox_depth_limit.Location = new System.Drawing.Point(3, 232);
			this.comboBox_depth_limit.Name = "comboBox_depth_limit";
			this.comboBox_depth_limit.Size = new System.Drawing.Size(88, 30);
			this.comboBox_depth_limit.TabIndex = 10;
			this.comboBox_depth_limit.Text = "16";
			// 
			// tabControl_map
			// 
			this.tabControl_map.Controls.Add(this.tabPage_list);
			this.tabControl_map.Controls.Add(this.tabPage_map);
			this.tabControl_map.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl_map.Location = new System.Drawing.Point(0, 0);
			this.tabControl_map.Name = "tabControl_map";
			this.tabControl_map.SelectedIndex = 0;
			this.tabControl_map.Size = new System.Drawing.Size(482, 440);
			this.tabControl_map.TabIndex = 1;
			this.tabControl_map.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_map_Selected);
			// 
			// tabPage_list
			// 
			this.tabPage_list.AutoScroll = true;
			this.tabPage_list.Controls.Add(this.tableLayoutPanel2);
			this.tabPage_list.Location = new System.Drawing.Point(4, 32);
			this.tabPage_list.Name = "tabPage_list";
			this.tabPage_list.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_list.Size = new System.Drawing.Size(474, 404);
			this.tabPage_list.TabIndex = 1;
			this.tabPage_list.Text = "List";
			this.tabPage_list.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.numericUpDown_pointsCount, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.label_pointsCount, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(468, 398);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// numericUpDown_pointsCount
			// 
			this.numericUpDown_pointsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown_pointsCount.Location = new System.Drawing.Point(175, 3);
			this.numericUpDown_pointsCount.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDown_pointsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_pointsCount.Name = "numericUpDown_pointsCount";
			this.numericUpDown_pointsCount.Size = new System.Drawing.Size(290, 29);
			this.numericUpDown_pointsCount.TabIndex = 1;
			this.numericUpDown_pointsCount.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
			// 
			// label_pointsCount
			// 
			this.label_pointsCount.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label_pointsCount.AutoSize = true;
			this.label_pointsCount.Location = new System.Drawing.Point(3, 6);
			this.label_pointsCount.Name = "label_pointsCount";
			this.label_pointsCount.Size = new System.Drawing.Size(166, 22);
			this.label_pointsCount.TabIndex = 0;
			this.label_pointsCount.Text = "Points count";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.SetColumnSpan(this.tabControl1, 2);
			this.tabControl1.Controls.Add(this.tabPage_text);
			this.tabControl1.Controls.Add(this.tabPage_table);
			this.tabControl1.Location = new System.Drawing.Point(3, 38);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(462, 357);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage_table
			// 
			this.tabPage_table.Controls.Add(this.dataGridView_list);
			this.tabPage_table.Location = new System.Drawing.Point(4, 32);
			this.tabPage_table.Name = "tabPage_table";
			this.tabPage_table.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_table.Size = new System.Drawing.Size(454, 321);
			this.tabPage_table.TabIndex = 0;
			this.tabPage_table.Text = "Table";
			this.tabPage_table.UseVisualStyleBackColor = true;
			// 
			// dataGridView_list
			// 
			this.dataGridView_list.AllowUserToAddRows = false;
			this.dataGridView_list.AllowUserToOrderColumns = true;
			this.dataGridView_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_z1,
            this.Column_z2,
            this.Column_d,
            this.Column_fd,
            this.Column_n,
            this.Column_snn});
			this.dataGridView_list.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_list.Location = new System.Drawing.Point(3, 3);
			this.dataGridView_list.Name = "dataGridView_list";
			this.dataGridView_list.RowHeadersVisible = false;
			this.dataGridView_list.RowTemplate.Height = 24;
			this.dataGridView_list.Size = new System.Drawing.Size(448, 322);
			this.dataGridView_list.TabIndex = 2;
			// 
			// Column_z1
			// 
			this.Column_z1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_z1.HeaderText = "z1";
			this.Column_z1.Name = "Column_z1";
			// 
			// Column_z2
			// 
			this.Column_z2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_z2.HeaderText = "z2";
			this.Column_z2.Name = "Column_z2";
			// 
			// Column_d
			// 
			this.Column_d.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_d.HeaderText = "d";
			this.Column_d.Name = "Column_d";
			// 
			// Column_fd
			// 
			this.Column_fd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_fd.HeaderText = "f[d]";
			this.Column_fd.Name = "Column_fd";
			// 
			// Column_n
			// 
			this.Column_n.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_n.HeaderText = "n";
			this.Column_n.Name = "Column_n";
			// 
			// Column_snn
			// 
			this.Column_snn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column_snn.HeaderText = "s[n,n]";
			this.Column_snn.Name = "Column_snn";
			// 
			// tabPage_text
			// 
			this.tabPage_text.Controls.Add(this.textBox_list);
			this.tabPage_text.Location = new System.Drawing.Point(4, 32);
			this.tabPage_text.Name = "tabPage_text";
			this.tabPage_text.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_text.Size = new System.Drawing.Size(454, 321);
			this.tabPage_text.TabIndex = 1;
			this.tabPage_text.Text = "Text";
			this.tabPage_text.UseVisualStyleBackColor = true;
			// 
			// textBox_list
			// 
			this.textBox_list.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_list.Location = new System.Drawing.Point(3, 3);
			this.textBox_list.Multiline = true;
			this.textBox_list.Name = "textBox_list";
			this.textBox_list.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox_list.Size = new System.Drawing.Size(448, 315);
			this.textBox_list.TabIndex = 0;
			// 
			// tabPage_map
			// 
			this.tabPage_map.AutoScroll = true;
			this.tabPage_map.Controls.Add(this.visualMap_draw);
			this.tabPage_map.Location = new System.Drawing.Point(4, 32);
			this.tabPage_map.Name = "tabPage_map";
			this.tabPage_map.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_map.Size = new System.Drawing.Size(474, 404);
			this.tabPage_map.TabIndex = 0;
			this.tabPage_map.Text = "Map";
			this.tabPage_map.UseVisualStyleBackColor = true;
			// 
			// visualMap_draw
			// 
			this.visualMap_draw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.visualMap_draw.Dock = System.Windows.Forms.DockStyle.Fill;
			this.visualMap_draw.Location = new System.Drawing.Point(3, 3);
			this.visualMap_draw.Name = "visualMap_draw";
			this.visualMap_draw.Size = new System.Drawing.Size(468, 405);
			this.visualMap_draw.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AcceptButton = this.button_calc;
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(784, 465);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Lucida Console", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabControl_map.ResumeLayout(false);
			this.tabPage_list.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pointsCount)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage_table.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).EndInit();
			this.tabPage_text.ResumeLayout(false);
			this.tabPage_text.PerformLayout();
			this.tabPage_map.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label_z1_min;
		private System.Windows.Forms.TextBox textBox_z1_min;
		private System.Windows.Forms.TextBox textBox_z1_max;
		private System.Windows.Forms.Label label_z1_max;
		private System.Windows.Forms.TextBox textBox_z2_max;
		private System.Windows.Forms.Label label_z2_max;
		private System.Windows.Forms.TextBox textBox_z2_min;
		private System.Windows.Forms.Label label_z2_min;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label_eps;
		private System.Windows.Forms.TextBox textBox_eps;
		private System.Windows.Forms.Label label_depth_limit;
		private System.Windows.Forms.Label label_length_limit;
		private System.Windows.Forms.ComboBox comboBox_length_limit;
		private System.Windows.Forms.ComboBox comboBox_depth_limit;
		private VisualMap visualMap_draw;
		private System.Windows.Forms.Button button_calc;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabControl tabControl_map;
		private System.Windows.Forms.TabPage tabPage_map;
		private System.Windows.Forms.TabPage tabPage_list;
		private System.Windows.Forms.DataGridView dataGridView_list;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_z1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_z2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_d;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_fd;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_n;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_snn;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.NumericUpDown numericUpDown_pointsCount;
		private System.Windows.Forms.Label label_pointsCount;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage_table;
		private System.Windows.Forms.TabPage tabPage_text;
		private System.Windows.Forms.TextBox textBox_list;
	}
}
