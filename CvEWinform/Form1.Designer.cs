namespace CvEWinform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.selectedDomains = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getText = new System.Windows.Forms.Button();
            this.finalText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericYearExp = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericDoc = new System.Windows.Forms.NumericUpDown();
            this.commaSeparated = new System.Windows.Forms.RadioButton();
            this.bulletPoints = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.random = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedDomains
            // 
            this.selectedDomains.Location = new System.Drawing.Point(12, 25);
            this.selectedDomains.Name = "selectedDomains";
            this.selectedDomains.Size = new System.Drawing.Size(305, 20);
            this.selectedDomains.TabIndex = 0;
            this.selectedDomains.TextChanged += new System.EventHandler(this.selectedDomains_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert domain(s)";
            // 
            // getText
            // 
            this.getText.Location = new System.Drawing.Point(325, 24);
            this.getText.Name = "getText";
            this.getText.Size = new System.Drawing.Size(93, 22);
            this.getText.TabIndex = 2;
            this.getText.Text = "Get Text";
            this.getText.UseVisualStyleBackColor = true;
            this.getText.Click += new System.EventHandler(this.getText_Click);
            // 
            // finalText
            // 
            this.finalText.Location = new System.Drawing.Point(12, 142);
            this.finalText.Multiline = true;
            this.finalText.Name = "finalText";
            this.finalText.Size = new System.Drawing.Size(406, 271);
            this.finalText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Years of experience";
            // 
            // numericYearExp
            // 
            this.numericYearExp.Location = new System.Drawing.Point(171, 80);
            this.numericYearExp.Name = "numericYearExp";
            this.numericYearExp.Size = new System.Drawing.Size(99, 20);
            this.numericYearExp.TabIndex = 24;
            this.numericYearExp.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericYearExp.ValueChanged += new System.EventHandler(this.numericYearExp_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Number of random documents";
            // 
            // numericDoc
            // 
            this.numericDoc.Location = new System.Drawing.Point(12, 80);
            this.numericDoc.Name = "numericDoc";
            this.numericDoc.Size = new System.Drawing.Size(98, 20);
            this.numericDoc.TabIndex = 20;
            this.numericDoc.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericDoc.ValueChanged += new System.EventHandler(this.numericDoc_ValueChanged);
            // 
            // commaSeparated
            // 
            this.commaSeparated.AutoSize = true;
            this.commaSeparated.Location = new System.Drawing.Point(12, 119);
            this.commaSeparated.Name = "commaSeparated";
            this.commaSeparated.Size = new System.Drawing.Size(110, 17);
            this.commaSeparated.TabIndex = 26;
            this.commaSeparated.TabStop = true;
            this.commaSeparated.Text = "Comma separated";
            this.commaSeparated.UseVisualStyleBackColor = true;
            this.commaSeparated.CheckedChanged += new System.EventHandler(this.commaSeparated_CheckedChanged);
            // 
            // bulletPoints
            // 
            this.bulletPoints.AutoSize = true;
            this.bulletPoints.Location = new System.Drawing.Point(133, 119);
            this.bulletPoints.Name = "bulletPoints";
            this.bulletPoints.Size = new System.Drawing.Size(82, 17);
            this.bulletPoints.TabIndex = 27;
            this.bulletPoints.TabStop = true;
            this.bulletPoints.Text = "Bullet points";
            this.bulletPoints.UseVisualStyleBackColor = true;
            this.bulletPoints.CheckedChanged += new System.EventHandler(this.bulletPoints_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Select formatting";
            // 
            // random
            // 
            this.random.AutoSize = true;
            this.random.Location = new System.Drawing.Point(221, 119);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(65, 17);
            this.random.TabIndex = 29;
            this.random.TabStop = true;
            this.random.Text = "Random";
            this.random.UseVisualStyleBackColor = true;
            this.random.CheckedChanged += new System.EventHandler(this.None_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(429, 421);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.random);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bulletPoints);
            this.Controls.Add(this.commaSeparated);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericYearExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericDoc);
            this.Controls.Add(this.finalText);
            this.Controls.Add(this.getText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedDomains);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericYearExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox selectedDomains;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getText;
        private System.Windows.Forms.TextBox finalText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericYearExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericDoc;
        private System.Windows.Forms.RadioButton commaSeparated;
        private System.Windows.Forms.RadioButton bulletPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton random;
        private System.Windows.Forms.Label label5;
    }
}

