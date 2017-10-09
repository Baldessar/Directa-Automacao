namespace WindowsFormsApplication1
{
    partial class Form7
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
            this.campo1 = new System.Windows.Forms.TextBox();
            this.campo2 = new System.Windows.Forms.TextBox();
            this.campo3 = new System.Windows.Forms.TextBox();
            this.campo4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campo1
            // 
            this.campo1.Location = new System.Drawing.Point(122, 44);
            this.campo1.Name = "campo1";
            this.campo1.Size = new System.Drawing.Size(100, 20);
            this.campo1.TabIndex = 0;
            this.campo1.TextChanged += new System.EventHandler(this.campo1_TextChanged);
            // 
            // campo2
            // 
            this.campo2.Location = new System.Drawing.Point(122, 85);
            this.campo2.Name = "campo2";
            this.campo2.Size = new System.Drawing.Size(100, 20);
            this.campo2.TabIndex = 1;
            // 
            // campo3
            // 
            this.campo3.Location = new System.Drawing.Point(122, 130);
            this.campo3.Name = "campo3";
            this.campo3.Size = new System.Drawing.Size(100, 20);
            this.campo3.TabIndex = 2;
            // 
            // campo4
            // 
            this.campo4.Location = new System.Drawing.Point(122, 175);
            this.campo4.Name = "campo4";
            this.campo4.Size = new System.Drawing.Size(100, 20);
            this.campo4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero de serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo de Producão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Familia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campo4);
            this.Controls.Add(this.campo3);
            this.Controls.Add(this.campo2);
            this.Controls.Add(this.campo1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campo1;
        private System.Windows.Forms.TextBox campo2;
        private System.Windows.Forms.TextBox campo3;
        private System.Windows.Forms.TextBox campo4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}