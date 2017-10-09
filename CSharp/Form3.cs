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
    public partial class Form3 : Form
    {
        private DbProviderFactory _Conexao;
        private DbConnection _conexao;
        List<String> sqlDelete = new List<String>();
        String delete;
        int x;

        public Form3()
        {
            InitializeComponent();
        }

        private void makeSql(int x)
        {
            switch (x)
            {
                case 1: sqlDelete.Add("DELETE producao where cod_linha ='" + delete + "'"); 
                        sqlDelete.Add("DELETE linha WHERE cod_linha = '"+delete+"'");
                        
                    break;
                case 2: sqlDelete.Add("DELETE producao WHERE seq_producao = " + Int32.Parse(delete));
                    break;
                case 3: sqlDelete.Add("DELETE producao where cod_prod ='" + delete + "'");
                        sqlDelete.Add("DELETE produto WHERE cod_prod = '" + delete + "'");
                    break;
                case 4:sqlDelete.Add("deixa ai" + delete);
                    break;
            }

        }

        private void showValueGrid(DbCommand comandoSql)
        {
            DbDataReader reader = comandoSql.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.DataSource = table;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string provedor = ConfigurationManager.ConnectionStrings["dtestagio"].ProviderName;
            string urlConexao = ConfigurationManager.ConnectionStrings["dtestagio"].ConnectionString;
            _Conexao = DbProviderFactories.GetFactory(provedor);
            _conexao = _Conexao.CreateConnection();
            _conexao.ConnectionString = urlConexao;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _conexao.Open();

            DbCommand comandoSql = _conexao.CreateCommand();

            comandoSql.CommandType = System.Data.CommandType.Text;

            comandoSql.CommandText = "SELECT cod_linha,des_linha FROM linha";

            showValueGrid(comandoSql);

            _conexao.Close();

            x = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _conexao.Open();

            DbCommand comandoSql = _conexao.CreateCommand();

            comandoSql.CommandType = System.Data.CommandType.Text;

            comandoSql.CommandText = "SELECT cod_prod AS \"Código de produto\",num_serie AS \"Numero de serie\",flg_aprovado AS \"Aprovado\",Num_resultado resultado, dat_data_inspecao AS \"Data de inspecao\" FROM inspecao";

            showValueGrid(comandoSql);

            _conexao.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _conexao.Open();

            DbCommand comandoSql = _conexao.CreateCommand();

            comandoSql.CommandType = System.Data.CommandType.Text;

            comandoSql.CommandText = "SELECT cod_prod as \"codigo de produto\",nom_cor cor,num_serie as \"Numero de serie\",cod_familia familia FROM produto";

            showValueGrid(comandoSql);

            _conexao.Close();
            x = 3; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _conexao.Open();

            DbCommand comandoSql = _conexao.CreateCommand();

            comandoSql.CommandType = System.Data.CommandType.Text;

            comandoSql.CommandText = "SELECT seq_producao AS \"Sequencia Producao\", cod_prod AS \"Código de produto\",cod_linha AS \"Código da linha\",num_peso peso,dat_data_prod AS \"Data do cadastro\" FROM producao";

            showValueGrid(comandoSql);

            _conexao.Close();

            x = 2;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           delete = grid[0, grid.CurrentRow.Index].Value.ToString();
           MessageBox.Show(delete);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                _conexao.Open();

                DbCommand comandoSql = _conexao.CreateCommand();

                comandoSql.CommandType = System.Data.CommandType.Text;

                makeSql(x);

                foreach (var item in sqlDelete)
                {
                    comandoSql.CommandText = item;
                    showValueGrid(comandoSql);
                }

                //showValueGrid(comandoSql);
                sqlDelete.Clear();
                _conexao.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                _conexao.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formTeste = new Form1();
            formTeste.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formTeste = new Form2();
            formTeste.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
