namespace Lab1
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
            this.textResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textResult
            // 
            this.textResult.AutoSize = true;
            this.textResult.Location = new System.Drawing.Point(156, 181);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(24, 16);
            this.textResult.TabIndex = 17;
            this.textResult.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Роезультат:";
            // 
            // textC
            // 
            this.textC.Location = new System.Drawing.Point(97, 91);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(100, 22);
            this.textC.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "C:";
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(97, 63);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(100, 22);
            this.textB.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "B:";
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(97, 35);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(100, 22);
            this.textA.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "A:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Розрахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 271);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

