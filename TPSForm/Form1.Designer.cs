namespace TPSForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_fuelSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_fuelPerSecond = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_steamEfficiencyCoef = new System.Windows.Forms.NumericUpDown();
            this.nud_turbineEfficiencyCoef = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_workTime = new System.Windows.Forms.NumericUpDown();
            this.output = new System.Windows.Forms.ListBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_steamEfficiencyCoef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_turbineEfficiencyCoef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_workTime)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_workTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nud_turbineEfficiencyCoef);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nud_steamEfficiencyCoef);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_fuelPerSecond);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_fuelSelect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Params";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fuel type";
            // 
            // cb_fuelSelect
            // 
            this.cb_fuelSelect.FormattingEnabled = true;
            this.cb_fuelSelect.Location = new System.Drawing.Point(133, 20);
            this.cb_fuelSelect.Name = "cb_fuelSelect";
            this.cb_fuelSelect.Size = new System.Drawing.Size(121, 21);
            this.cb_fuelSelect.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mass of fuel per second";
            // 
            // tb_fuelPerSecond
            // 
            this.tb_fuelPerSecond.Location = new System.Drawing.Point(133, 47);
            this.tb_fuelPerSecond.Name = "tb_fuelPerSecond";
            this.tb_fuelPerSecond.Size = new System.Drawing.Size(120, 20);
            this.tb_fuelPerSecond.TabIndex = 3;
            this.tb_fuelPerSecond.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Steam efficiency coef";
            // 
            // nud_steamEfficiencyCoef
            // 
            this.nud_steamEfficiencyCoef.DecimalPlaces = 2;
            this.nud_steamEfficiencyCoef.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nud_steamEfficiencyCoef.Location = new System.Drawing.Point(133, 77);
            this.nud_steamEfficiencyCoef.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_steamEfficiencyCoef.Name = "nud_steamEfficiencyCoef";
            this.nud_steamEfficiencyCoef.Size = new System.Drawing.Size(120, 20);
            this.nud_steamEfficiencyCoef.TabIndex = 5;
            this.nud_steamEfficiencyCoef.Value = new decimal(new int[] {
            35,
            0,
            0,
            131072});
            // 
            // nud_turbineEfficiencyCoef
            // 
            this.nud_turbineEfficiencyCoef.DecimalPlaces = 2;
            this.nud_turbineEfficiencyCoef.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nud_turbineEfficiencyCoef.Location = new System.Drawing.Point(133, 104);
            this.nud_turbineEfficiencyCoef.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_turbineEfficiencyCoef.Name = "nud_turbineEfficiencyCoef";
            this.nud_turbineEfficiencyCoef.Size = new System.Drawing.Size(120, 20);
            this.nud_turbineEfficiencyCoef.TabIndex = 7;
            this.nud_turbineEfficiencyCoef.Value = new decimal(new int[] {
            35,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Turbine efficiency coef";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Work time";
            // 
            // nud_workTime
            // 
            this.nud_workTime.Location = new System.Drawing.Point(134, 130);
            this.nud_workTime.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nud_workTime.Name = "nud_workTime";
            this.nud_workTime.Size = new System.Drawing.Size(120, 20);
            this.nud_workTime.TabIndex = 9;
            this.nud_workTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_workTime.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged_1);
            // 
            // output
            // 
            this.output.FormattingEnabled = true;
            this.output.Location = new System.Drawing.Point(173, 189);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(136, 69);
            this.output.TabIndex = 1;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(24, 190);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(143, 68);
            this.btn_Calculate.TabIndex = 2;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 262);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.output);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_steamEfficiencyCoef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_turbineEfficiencyCoef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_workTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nud_turbineEfficiencyCoef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_steamEfficiencyCoef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_fuelPerSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_fuelSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_workTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox output;
        private System.Windows.Forms.Button btn_Calculate;
    }
}

