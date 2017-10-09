namespace WindowsFormsApplication1
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspeçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campo3 = new System.Windows.Forms.TextBox();
            this.campo1 = new System.Windows.Forms.TextBox();
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.campo2 = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.calendar2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inspeçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 201);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(733, 166);
            this.grid.TabIndex = 3;
            this.grid.Visible = false;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.inserirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linhaToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // linhaToolStripMenuItem
            // 
            this.linhaToolStripMenuItem.Name = "linhaToolStripMenuItem";
            this.linhaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.linhaToolStripMenuItem.Text = "Linha";
            this.linhaToolStripMenuItem.Click += new System.EventHandler(this.linhaToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.produtoToolStripMenuItem.Text = "produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produçãoToolStripMenuItem,
            this.inspeçãoToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // produçãoToolStripMenuItem
            // 
            this.produçãoToolStripMenuItem.Name = "produçãoToolStripMenuItem";
            this.produçãoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.produçãoToolStripMenuItem.Text = "Produção";
            this.produçãoToolStripMenuItem.Click += new System.EventHandler(this.produçãoToolStripMenuItem_Click);
            // 
            // inspeçãoToolStripMenuItem
            // 
            this.inspeçãoToolStripMenuItem.Name = "inspeçãoToolStripMenuItem";
            this.inspeçãoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.inspeçãoToolStripMenuItem.Text = "Inspeção";
            this.inspeçãoToolStripMenuItem.Click += new System.EventHandler(this.inspeçãoToolStripMenuItem_Click);
            // 
            // campo3
            // 
            this.campo3.Location = new System.Drawing.Point(228, 51);
            this.campo3.Name = "campo3";
            this.campo3.Size = new System.Drawing.Size(102, 20);
            this.campo3.TabIndex = 14;
            this.campo3.Visible = false;
            // 
            // campo1
            // 
            this.campo1.Location = new System.Drawing.Point(12, 51);
            this.campo1.Name = "campo1";
            this.campo1.Size = new System.Drawing.Size(102, 20);
            this.campo1.TabIndex = 13;
            this.campo1.Visible = false;
            // 
            // calendar
            // 
            this.calendar.Enabled = false;
            this.calendar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendar.Location = new System.Drawing.Point(12, 80);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(102, 20);
            this.calendar.TabIndex = 11;
            this.calendar.Visible = false;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(397, 50);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(61, 20);
            this.btnPesquisa.TabIndex = 10;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Visible = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // campo2
            // 
            this.campo2.Location = new System.Drawing.Point(120, 51);
            this.campo2.Name = "campo2";
            this.campo2.Size = new System.Drawing.Size(102, 20);
            this.campo2.TabIndex = 9;
            this.campo2.Visible = false;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(12, 391);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(255, 23);
            this.btnCadastro.TabIndex = 16;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Visible = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(287, 391);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(220, 23);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(525, 391);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(220, 23);
            this.btnDeletar.TabIndex = 18;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Visible = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(228, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Habilitar consulta por data";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // calendar2
            // 
            this.calendar2.Enabled = false;
            this.calendar2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendar2.Location = new System.Drawing.Point(120, 80);
            this.calendar2.Name = "calendar2";
            this.calendar2.Size = new System.Drawing.Size(102, 20);
            this.calendar2.TabIndex = 20;
            this.calendar2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "S",
            "N"});
            this.comboBox1.Location = new System.Drawing.Point(336, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(55, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Visible = false;
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Aprovado";
            this.label4.Visible = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(613, 172);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(132, 23);
            this.btnExcel.TabIndex = 26;
            this.btnExcel.Text = "Exportar dados";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Visible = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produçãoToolStripMenuItem1,
            this.inspeçãoToolStripMenuItem1});
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.inserirToolStripMenuItem.Text = "Inserir";
            // 
            // produçãoToolStripMenuItem1
            // 
            this.produçãoToolStripMenuItem1.Name = "produçãoToolStripMenuItem1";
            this.produçãoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.produçãoToolStripMenuItem1.Text = "Produção";
            this.produçãoToolStripMenuItem1.Click += new System.EventHandler(this.produçãoToolStripMenuItem1_Click);
            // 
            // inspeçãoToolStripMenuItem1
            // 
            this.inspeçãoToolStripMenuItem1.Name = "inspeçãoToolStripMenuItem1";
            this.inspeçãoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.inspeçãoToolStripMenuItem1.Text = "Inspeção";
            this.inspeçãoToolStripMenuItem1.Click += new System.EventHandler(this.inspeçãoToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 430);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendar2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.campo3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.campo1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.campo2);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.btnPesquisa);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox campo2;
        private System.Windows.Forms.TextBox campo1;
        private System.Windows.Forms.DateTimePicker calendar;
        private System.Windows.Forms.TextBox campo3;
        private System.Windows.Forms.ToolStripMenuItem linhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.ToolStripMenuItem produçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inspeçãoToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker calendar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inspeçãoToolStripMenuItem1;
    }
}

