namespace Hardware_Monitor_Display_PC
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Connect = new System.Windows.Forms.ToolStripButton();
            this.Start = new System.Windows.Forms.ToolStripButton();
            this.Disconnect = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.Gauge_8_dropdown = new System.Windows.Forms.ComboBox();
            this.Gauge_7_dropdown = new System.Windows.Forms.ComboBox();
            this.Gauge_6_dropdown = new System.Windows.Forms.ComboBox();
            this.Gauge_5_dropdown = new System.Windows.Forms.ComboBox();
            this.Gauge_1_dropdown = new System.Windows.Forms.ComboBox();
            this.Gauge_2_dropdown = new System.Windows.Forms.ComboBox();
            this.Gauge_3_dropdown = new System.Windows.Forms.ComboBox();
            this.Gauge_4_dropdown = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Connect,
            this.Start,
            this.Disconnect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 63);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Connect
            // 
            this.Connect.AutoSize = false;
            this.Connect.Image = ((System.Drawing.Image)(resources.GetObject("Connect.Image")));
            this.Connect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(60, 60);
            this.Connect.Text = "Connect";
            this.Connect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Connect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Connect.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Start
            // 
            this.Start.AutoSize = false;
            this.Start.Image = ((System.Drawing.Image)(resources.GetObject("Start.Image")));
            this.Start.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(50, 60);
            this.Start.Text = "Start";
            this.Start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Start.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.AutoSize = false;
            this.Disconnect.Image = ((System.Drawing.Image)(resources.GetObject("Disconnect.Image")));
            this.Disconnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Disconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(70, 60);
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Disconnect.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(645, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "8000";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(263, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "190.160.1.5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP/Hostname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gauge 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gauge 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gauge 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gauge 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gauge 5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Gauge 6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Gauge 7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(613, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Gauge 8";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.tick_object);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(12, 226);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.logBox.Size = new System.Drawing.Size(741, 212);
            this.logBox.TabIndex = 23;
            this.logBox.Text = "";
            // 
            // Gauge_8_dropdown
            // 
            this.Gauge_8_dropdown.FormattingEnabled = true;
            this.Gauge_8_dropdown.Items.AddRange(new object[] {
            "CPU Load",
            "CPU Temperature",
            "GPU Load",
            "GPU Temperature",
            "RAM Load",
            "Front Fan",
            "CPU Fan",
            "Rear Fan"});
            this.Gauge_8_dropdown.Location = new System.Drawing.Point(667, 177);
            this.Gauge_8_dropdown.Name = "Gauge_8_dropdown";
            this.Gauge_8_dropdown.Size = new System.Drawing.Size(121, 21);
            this.Gauge_8_dropdown.TabIndex = 24;
            this.Gauge_8_dropdown.Text = "Rear Fan";
            this.Gauge_8_dropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Gauge_7_dropdown
            // 
            this.Gauge_7_dropdown.FormattingEnabled = true;
            this.Gauge_7_dropdown.Items.AddRange(new object[] {
            "CPU Load",
            "CPU Temperature",
            "GPU Load",
            "GPU Temperature",
            "RAM Load",
            "Front Fan",
            "CPU Fan",
            "Rear Fan"});
            this.Gauge_7_dropdown.Location = new System.Drawing.Point(467, 174);
            this.Gauge_7_dropdown.Name = "Gauge_7_dropdown";
            this.Gauge_7_dropdown.Size = new System.Drawing.Size(121, 21);
            this.Gauge_7_dropdown.TabIndex = 26;
            this.Gauge_7_dropdown.Text = "CPU Fan";
            // 
            // Gauge_6_dropdown
            // 
            this.Gauge_6_dropdown.FormattingEnabled = true;
            this.Gauge_6_dropdown.Items.AddRange(new object[] {
            "CPU Load",
            "CPU Temperature",
            "GPU Load",
            "GPU Temperature",
            "RAM Load",
            "Front Fan",
            "CPU Fan",
            "Rear Fan"});
            this.Gauge_6_dropdown.Location = new System.Drawing.Point(264, 172);
            this.Gauge_6_dropdown.Name = "Gauge_6_dropdown";
            this.Gauge_6_dropdown.Size = new System.Drawing.Size(121, 21);
            this.Gauge_6_dropdown.TabIndex = 27;
            this.Gauge_6_dropdown.Text = "Front Fan";
            // 
            // Gauge_5_dropdown
            // 
            this.Gauge_5_dropdown.FormattingEnabled = true;
            this.Gauge_5_dropdown.Items.AddRange(new object[] {
            "CPU Load",
            "CPU Temperature",
            "GPU Load",
            "GPU Temperature",
            "RAM Load",
            "Front Fan",
            "CPU Fan",
            "Rear Fan"});
            this.Gauge_5_dropdown.Location = new System.Drawing.Point(68, 169);
            this.Gauge_5_dropdown.Name = "Gauge_5_dropdown";
            this.Gauge_5_dropdown.Size = new System.Drawing.Size(121, 21);
            this.Gauge_5_dropdown.TabIndex = 28;
            this.Gauge_5_dropdown.Text = "RAM Load";
            // 
            // Gauge_1_dropdown
            // 
            this.Gauge_1_dropdown.FormattingEnabled = true;
            this.Gauge_1_dropdown.Items.AddRange(new object[] {
            "CPU Load",
            "CPU Temperature",
            "GPU Load",
            "GPU Temperature",
            "RAM Load",
            "Front Fan",
            "CPU Fan",
            "Rear Fan"});
            this.Gauge_1_dropdown.Location = new System.Drawing.Point(68, 130);
            this.Gauge_1_dropdown.Name = "Gauge_1_dropdown";
            this.Gauge_1_dropdown.Size = new System.Drawing.Size(121, 21);
            this.Gauge_1_dropdown.TabIndex = 29;
            this.Gauge_1_dropdown.Text = "CPU Load";
            // 
            // Gauge_2_dropdown
            // 
            this.Gauge_2_dropdown.FormattingEnabled = true;
            this.Gauge_2_dropdown.Items.AddRange(new object[] {
            "CPU Load",
            "CPU Temperature",
            "GPU Load",
            "GPU Temperature",
            "RAM Load",
            "Front Fan",
            "CPU Fan",
            "Rear Fan"});
            this.Gauge_2_dropdown.Location = new System.Drawing.Point(264, 130);
            this.Gauge_2_dropdown.Name = "Gauge_2_dropdown";
            this.Gauge_2_dropdown.Size = new System.Drawing.Size(121, 21);
            this.Gauge_2_dropdown.TabIndex = 30;
            this.Gauge_2_dropdown.Text = "CPU Temperature";
            // 
            // Gauge_3_dropdown
            // 
            this.Gauge_3_dropdown.FormattingEnabled = true;
            this.Gauge_3_dropdown.Items.AddRange(new object[] {
            "CPU Load",
            "CPU Temperature",
            "GPU Load",
            "GPU Temperature",
            "RAM Load",
            "Front Fan",
            "CPU Fan",
            "Rear Fan"});
            this.Gauge_3_dropdown.Location = new System.Drawing.Point(467, 130);
            this.Gauge_3_dropdown.Name = "Gauge_3_dropdown";
            this.Gauge_3_dropdown.Size = new System.Drawing.Size(121, 21);
            this.Gauge_3_dropdown.TabIndex = 31;
            this.Gauge_3_dropdown.Text = "GPU Load";
            // 
            // Gauge_4_dropdown
            // 
            this.Gauge_4_dropdown.FormattingEnabled = true;
            this.Gauge_4_dropdown.Items.AddRange(new object[] {
            "CPU Load",
            "CPU Temperature",
            "GPU Load",
            "GPU Temperature",
            "RAM Load",
            "Front Fan",
            "CPU Fan",
            "Rear Fan"});
            this.Gauge_4_dropdown.Location = new System.Drawing.Point(667, 130);
            this.Gauge_4_dropdown.Name = "Gauge_4_dropdown";
            this.Gauge_4_dropdown.Size = new System.Drawing.Size(121, 21);
            this.Gauge_4_dropdown.TabIndex = 32;
            this.Gauge_4_dropdown.Text = "GPU Temperature";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gauge_4_dropdown);
            this.Controls.Add(this.Gauge_3_dropdown);
            this.Controls.Add(this.Gauge_2_dropdown);
            this.Controls.Add(this.Gauge_1_dropdown);
            this.Controls.Add(this.Gauge_5_dropdown);
            this.Controls.Add(this.Gauge_6_dropdown);
            this.Controls.Add(this.Gauge_7_dropdown);
            this.Controls.Add(this.Gauge_8_dropdown);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hardware Monitor Display Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Connect;
        private System.Windows.Forms.ToolStripButton Start;
        private System.Windows.Forms.ToolStripButton Disconnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.ComboBox Gauge_8_dropdown;
        private System.Windows.Forms.ComboBox Gauge_7_dropdown;
        private System.Windows.Forms.ComboBox Gauge_6_dropdown;
        private System.Windows.Forms.ComboBox Gauge_5_dropdown;
        private System.Windows.Forms.ComboBox Gauge_1_dropdown;
        private System.Windows.Forms.ComboBox Gauge_2_dropdown;
        private System.Windows.Forms.ComboBox Gauge_3_dropdown;
        private System.Windows.Forms.ComboBox Gauge_4_dropdown;
    }
}
