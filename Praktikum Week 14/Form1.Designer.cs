
namespace Praktikum_Week_14
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
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reverse = new System.Windows.Forms.Button();
            this.urut = new System.Windows.Forms.Button();
            this.hasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(122, 161);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(218, 22);
            this.input.TabIndex = 0;
            this.input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // reverse
            // 
            this.reverse.Location = new System.Drawing.Point(122, 206);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(95, 23);
            this.reverse.TabIndex = 2;
            this.reverse.Text = "REVERSE";
            this.reverse.UseVisualStyleBackColor = true;
            this.reverse.Click += new System.EventHandler(this.reverse_Click);
            // 
            // urut
            // 
            this.urut.Location = new System.Drawing.Point(241, 206);
            this.urut.Name = "urut";
            this.urut.Size = new System.Drawing.Size(99, 23);
            this.urut.TabIndex = 3;
            this.urut.Text = "URUTKAN";
            this.urut.UseVisualStyleBackColor = true;
            this.urut.Click += new System.EventHandler(this.button1_Click);
            // 
            // hasil
            // 
            this.hasil.AutoSize = true;
            this.hasil.Location = new System.Drawing.Point(122, 267);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(51, 17);
            this.hasil.TabIndex = 4;
            this.hasil.Text = "Output\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 484);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.urut);
            this.Controls.Add(this.reverse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reverse;
        private System.Windows.Forms.Button urut;
        private System.Windows.Forms.Label hasil;
    }
}

