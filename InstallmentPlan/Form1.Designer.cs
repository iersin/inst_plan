namespace InstallmentPlan
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
            this.installmentCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.installmentPeriodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costNumericTextBox = new Custom_Control.NumericTextBox();
            this.profitRateNumericTextBox = new Custom_Control.NumericTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.installmentCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installmentPeriodNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // installmentCountNumericUpDown
            // 
            this.installmentCountNumericUpDown.Location = new System.Drawing.Point(199, 51);
            this.installmentCountNumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.installmentCountNumericUpDown.Name = "installmentCountNumericUpDown";
            this.installmentCountNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.installmentCountNumericUpDown.TabIndex = 2;
            this.installmentCountNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // installmentPeriodNumericUpDown
            // 
            this.installmentPeriodNumericUpDown.Location = new System.Drawing.Point(199, 77);
            this.installmentPeriodNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.installmentPeriodNumericUpDown.Name = "installmentPeriodNumericUpDown";
            this.installmentPeriodNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.installmentPeriodNumericUpDown.TabIndex = 3;
            this.installmentPeriodNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Finansman Tutarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Taksit Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Periyot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kar Oranı";
            // 
            // costNumericTextBox
            // 
            this.costNumericTextBox.AllowSpace = false;
            this.costNumericTextBox.Location = new System.Drawing.Point(199, 25);
            this.costNumericTextBox.Name = "costNumericTextBox";
            this.costNumericTextBox.Size = new System.Drawing.Size(100, 20);
            this.costNumericTextBox.TabIndex = 8;
            this.costNumericTextBox.Text = "100000";
            // 
            // profitRateNumericTextBox
            // 
            this.profitRateNumericTextBox.AllowSpace = false;
            this.profitRateNumericTextBox.Location = new System.Drawing.Point(199, 104);
            this.profitRateNumericTextBox.Name = "profitRateNumericTextBox";
            this.profitRateNumericTextBox.Size = new System.Drawing.Size(100, 20);
            this.profitRateNumericTextBox.TabIndex = 9;
            this.profitRateNumericTextBox.Text = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 316);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 536);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.profitRateNumericTextBox);
            this.Controls.Add(this.costNumericTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.installmentPeriodNumericUpDown);
            this.Controls.Add(this.installmentCountNumericUpDown);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.installmentCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installmentPeriodNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown installmentCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown installmentPeriodNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Custom_Control.NumericTextBox costNumericTextBox;
        private Custom_Control.NumericTextBox profitRateNumericTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

