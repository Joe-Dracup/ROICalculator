namespace ROI_Calculator
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
            this.cost_lbl = new System.Windows.Forms.Label();
            this.benefit_lbl = new System.Windows.Forms.Label();
            this.startDate_lbl = new System.Windows.Forms.Label();
            this.startDate_dat = new System.Windows.Forms.DateTimePicker();
            this.start_btn = new System.Windows.Forms.Button();
            this.ROI_txt = new System.Windows.Forms.TextBox();
            this.endDate_txt = new System.Windows.Forms.TextBox();
            this.cost_num = new System.Windows.Forms.NumericUpDown();
            this.benefit_num = new System.Windows.Forms.NumericUpDown();
            this.ROI_lbl = new System.Windows.Forms.Label();
            this.endDate_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cost_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benefit_num)).BeginInit();
            this.SuspendLayout();
            // 
            // cost_lbl
            // 
            this.cost_lbl.AutoSize = true;
            this.cost_lbl.Location = new System.Drawing.Point(12, 9);
            this.cost_lbl.Name = "cost_lbl";
            this.cost_lbl.Size = new System.Drawing.Size(55, 13);
            this.cost_lbl.TabIndex = 0;
            this.cost_lbl.Text = "Total Cost";
            // 
            // benefit_lbl
            // 
            this.benefit_lbl.AutoSize = true;
            this.benefit_lbl.Location = new System.Drawing.Point(12, 62);
            this.benefit_lbl.Name = "benefit_lbl";
            this.benefit_lbl.Size = new System.Drawing.Size(72, 13);
            this.benefit_lbl.TabIndex = 2;
            this.benefit_lbl.Text = "Yearly Benefit";
            // 
            // startDate_lbl
            // 
            this.startDate_lbl.AutoSize = true;
            this.startDate_lbl.Location = new System.Drawing.Point(12, 114);
            this.startDate_lbl.Name = "startDate_lbl";
            this.startDate_lbl.Size = new System.Drawing.Size(55, 13);
            this.startDate_lbl.TabIndex = 3;
            this.startDate_lbl.Text = "Start Date";
            // 
            // startDate_dat
            // 
            this.startDate_dat.Location = new System.Drawing.Point(15, 130);
            this.startDate_dat.Name = "startDate_dat";
            this.startDate_dat.Size = new System.Drawing.Size(200, 20);
            this.startDate_dat.TabIndex = 6;
            this.startDate_dat.ValueChanged += new System.EventHandler(this.startDate_dat_ValueChanged);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(15, 175);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 7;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // ROI_txt
            // 
            this.ROI_txt.Location = new System.Drawing.Point(347, 25);
            this.ROI_txt.Name = "ROI_txt";
            this.ROI_txt.ReadOnly = true;
            this.ROI_txt.Size = new System.Drawing.Size(298, 20);
            this.ROI_txt.TabIndex = 8;
            // 
            // endDate_txt
            // 
            this.endDate_txt.Location = new System.Drawing.Point(347, 78);
            this.endDate_txt.Name = "endDate_txt";
            this.endDate_txt.ReadOnly = true;
            this.endDate_txt.Size = new System.Drawing.Size(298, 20);
            this.endDate_txt.TabIndex = 9;
            // 
            // cost_num
            // 
            this.cost_num.Location = new System.Drawing.Point(15, 26);
            this.cost_num.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.cost_num.Name = "cost_num";
            this.cost_num.Size = new System.Drawing.Size(120, 20);
            this.cost_num.TabIndex = 10;
            this.cost_num.ValueChanged += new System.EventHandler(this.cost_num_ValueChanged);
            // 
            // benefit_num
            // 
            this.benefit_num.Location = new System.Drawing.Point(15, 78);
            this.benefit_num.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.benefit_num.Name = "benefit_num";
            this.benefit_num.Size = new System.Drawing.Size(120, 20);
            this.benefit_num.TabIndex = 11;
            this.benefit_num.ValueChanged += new System.EventHandler(this.benefit_num_ValueChanged);
            // 
            // ROI_lbl
            // 
            this.ROI_lbl.AutoSize = true;
            this.ROI_lbl.Location = new System.Drawing.Point(344, 9);
            this.ROI_lbl.Name = "ROI_lbl";
            this.ROI_lbl.Size = new System.Drawing.Size(64, 13);
            this.ROI_lbl.TabIndex = 12;
            this.ROI_lbl.Text = "Your ROI is:";
            // 
            // endDate_lbl
            // 
            this.endDate_lbl.AutoSize = true;
            this.endDate_lbl.Location = new System.Drawing.Point(344, 62);
            this.endDate_lbl.Name = "endDate_lbl";
            this.endDate_lbl.Size = new System.Drawing.Size(158, 13);
            this.endDate_lbl.TabIndex = 13;
            this.endDate_lbl.Text = "The project will be payed off on:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 545);
            this.Controls.Add(this.endDate_lbl);
            this.Controls.Add(this.ROI_lbl);
            this.Controls.Add(this.benefit_num);
            this.Controls.Add(this.cost_num);
            this.Controls.Add(this.endDate_txt);
            this.Controls.Add(this.ROI_txt);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.startDate_dat);
            this.Controls.Add(this.startDate_lbl);
            this.Controls.Add(this.benefit_lbl);
            this.Controls.Add(this.cost_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cost_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benefit_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cost_lbl;
        private System.Windows.Forms.Label benefit_lbl;
        private System.Windows.Forms.Label startDate_lbl;
        private System.Windows.Forms.DateTimePicker startDate_dat;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.TextBox ROI_txt;
        private System.Windows.Forms.TextBox endDate_txt;
        private System.Windows.Forms.NumericUpDown cost_num;
        private System.Windows.Forms.NumericUpDown benefit_num;
        private System.Windows.Forms.Label ROI_lbl;
        private System.Windows.Forms.Label endDate_lbl;
    }
}

