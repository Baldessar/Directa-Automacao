using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;

namespace WindowsFormsApplication1
{   
    public partial class Form2 : Form
    {
        int x = 0;
        private DbProviderFactory _Conexao;
        private DbConnection _conexao;
        String sqlInsert,sqlSelect;

        public Form2()
        {
            InitializeComponent();
        }

        private void showValueGrid(DbCommand comandoSql)
        {
            DbDataReader reader = comandoSql.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.DataSource = table;
        }

        private void makeSql(int x)
        {
            switch (x)
            {
                case 1: sqlInsert = "INSERT INTO linha(cod_linha,des_linha)values('" + campo1.Text + "','" +campo2.Text+"')";
                        sqlSelect = "SELECT * FROM(SELECT * FROM linha order by seq_linha DESC) WHERE  ROWNUM  < 2";
                    break;
                case 2: sqlInsert = "INSERT INTO produto(nom_cor,num_serie,cod_prod,cod_familia)values('" + campo1.Text + "'," + campo2.Text + ",'" + campo3.Text + "','" + campo4.Text + "')";
                        sqlSelect = "SELECT * FROM(SELECT * FROM produto order by seq_produto DESC) WHERE  ROWNUM  < 2";
                    break;
                case 3: sqlInsert = "INSERT INTO producao(cod_prod,cod_linha,num_peso)values('" + campo1.Text + "','" + campo2.Text + "'," + campo3.Text + ")";
                    sqlSelect = "SELECT * FROM(SELECT * FROM producao order by seq_producao DESC) WHERE  ROWNUM  < 2";
                    break;
                case 4: sqlInsert = "INSERT INTO produto(nom_cor,num_serie,cod_prod,cod_familia)values(" + campo1.Text + "," + campo2.Text + campo3.Text + "," + campo4.Text + ")";
                        sqlSelect = "SELECT * FROM(SELECT * FROM linha order by seq_linha DESC) WHERE  ROWNUM  < 2";
                    break;
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            campo1.Hide();
            campo2.Hide();
            campo3.Hide();
            campo4.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            string provedor = ConfigurationManager.ConnectionStrings["dtestagio"].ProviderName;
            string urlConexao = ConfigurationManager.ConnectionStrings["dtestagio"].ConnectionString;
            _Conexao = DbProviderFactories.GetFactory(provedor);
            _conexao = _Conexao.CreateConnection();
            _conexao.ConnectionString = urlConexao;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            campo1.Show();
            campo2.Show();
            campo3.Hide();
            campo4.Hide();
            label3.Hide();
            label4.Hide();
            label1.Show();
            label2.Show();
            label1.Text = "Código da linha";
            label2.Text = "Descrição da linha";
            x = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            campo1.Show();
            campo2.Show();
            campo3.Show();
            campo4.Hide();
            label3.Show();
            label4.Hide();
            label1.Show();
            label2.Show();
            label1.Text = "Numero Cor";
            label2.Text = "Numero de série";
            label3.Text = "Codigo da Familia";
            label4.Hide();
            x  =  2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            campo1.Show();
            campo2.Show();
            campo3.Show();
            campo4.Hide();
            label3.Show();
            label4.Hide();
            label1.Show();
            label2.Show();
            label1.Text = "Codigo do Produto";
            label2.Text = "Codigo da linha";
            label3.Text = "Peso";
            label4.Hide();
            x = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.makeSql(x);
                _conexao.Open();
                DbCommand comandoSql = _conexao.CreateCommand();
                comandoSql.CommandType = System.Data.CommandType.Text;
                comandoSql.CommandText = sqlInsert;
                comandoSql.ExecuteReader();
                comandoSql.CommandText = sqlSelect;
                showValueGrid(comandoSql);
                _conexao.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                _conexao.Close();
            }

        }



        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formTeste = new Form1();
            formTeste.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 formTeste = new Form3();
            formTeste.Show();
        }

        
    }
}
