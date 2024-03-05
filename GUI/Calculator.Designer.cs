namespace GUI
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbResult);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSecond);
            this.groupBox1.Controls.Add(this.tbFirst);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "| Data Bilangan |";
            // 
            // tbResult
            // 
            this.tbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResult.Enabled = false;
            this.tbResult.Location = new System.Drawing.Point(299, 165);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(211, 22);
            this.tbResult.TabIndex = 5;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasil";
            // 
            // tbSecond
            // 
            this.tbSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSecond.Location = new System.Drawing.Point(299, 67);
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(211, 22);
            this.tbSecond.TabIndex = 3;
            this.tbSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbFirst
            // 
            this.tbFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFirst.Location = new System.Drawing.Point(299, 39);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(211, 22);
            this.tbFirst.TabIndex = 2;
            this.tbFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilangan Kedua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilangan Pertama";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.btnBagi);
            this.groupBox2.Controls.Add(this.btnKali);
            this.groupBox2.Controls.Add(this.btnKurang);
            this.groupBox2.Controls.Add(this.btnSum);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "| Operator |";
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(438, 18);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10);
            this.button5.Size = new System.Drawing.Size(72, 70);
            this.button5.TabIndex = 5;
            this.button5.Text = "Close";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(368, 18);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10);
            this.button6.Size = new System.Drawing.Size(64, 70);
            this.button6.TabIndex = 4;
            this.button6.Text = "New";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.AutoSize = true;
            this.btnBagi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBagi.Location = new System.Drawing.Point(156, 42);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Padding = new System.Windows.Forms.Padding(10);
            this.btnBagi.Size = new System.Drawing.Size(41, 46);
            this.btnBagi.TabIndex = 3;
            this.btnBagi.Text = "/";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.btnBagi_Click);
            // 
            // btnKali
            // 
            this.btnKali.AutoSize = true;
            this.btnKali.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKali.Location = new System.Drawing.Point(106, 42);
            this.btnKali.Name = "btnKali";
            this.btnKali.Padding = new System.Windows.Forms.Padding(10);
            this.btnKali.Size = new System.Drawing.Size(42, 46);
            this.btnKali.TabIndex = 2;
            this.btnKali.Text = "*";
            this.btnKali.UseVisualStyleBackColor = true;
            this.btnKali.Click += new System.EventHandler(this.btnKali_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.AutoSize = true;
            this.btnKurang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKurang.Location = new System.Drawing.Point(56, 42);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Padding = new System.Windows.Forms.Padding(10);
            this.btnKurang.Size = new System.Drawing.Size(41, 46);
            this.btnKurang.TabIndex = 1;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // btnSum
            // 
            this.btnSum.AutoSize = true;
            this.btnSum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSum.Location = new System.Drawing.Point(6, 42);
            this.btnSum.Name = "btnSum";
            this.btnSum.Padding = new System.Windows.Forms.Padding(10);
            this.btnSum.Size = new System.Drawing.Size(44, 46);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSecond;
        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnSum;
    }
}