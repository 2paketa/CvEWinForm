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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.domains = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getText = new System.Windows.Forms.Button();
            this.finalText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericYearExp = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericDoc = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // domains
            // 
            this.domains.Location = new System.Drawing.Point(14, 25);
            this.domains.Name = "domains";
            this.domains.Size = new System.Drawing.Size(305, 20);
            this.domains.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 8);
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
            this.finalText.Location = new System.Drawing.Point(12, 96);
            this.finalText.Multiline = true;
            this.finalText.Name = "finalText";
            this.finalText.Size = new System.Drawing.Size(406, 317);
            this.finalText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Years of experience";
            // 
            // numericYearExp
            // 
            this.numericYearExp.Location = new System.Drawing.Point(168, 70);
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
            this.label4.Location = new System.Drawing.Point(10, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Number of random documents";
            // 
            // numericDoc
            // 
            this.numericDoc.Location = new System.Drawing.Point(14, 70);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 421);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericYearExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericDoc);
            this.Controls.Add(this.finalText);
            this.Controls.Add(this.getText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domains);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericYearExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox domains;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getText;
        private System.Windows.Forms.TextBox finalText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericYearExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericDoc;
    }
}

