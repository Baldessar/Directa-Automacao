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
    public partial class Form4 : Form
    {
        private DbProviderFactory _Conexao;
        private DbConnection _conexao;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string provedor = ConfigurationManager.ConnectionStrings["dtestagio"].ProviderName;
            string urlConexao = ConfigurationManager.ConnectionStrings["dtestagio"].ConnectionString;
            _Conexao = DbProviderFactories.GetFactory(provedor);
            _conexao = _Conexao.CreateConnection();
            _conexao.ConnectionString = urlConexao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _conexao.Open();

                DbCommand comandoSql = _conexao.CreateCommand();

                comandoSql.CommandType = System.Data.CommandType.Text;

                comandoSql.CommandText = "INSERT INTO produto(nom_cor,num_serie,cod_prod,cod_familia)VALUES('" + campo1.Text + "'," + Convert.ToInt32(campo2.Text) + ",'" + campo3.Text + "','" + campo4.Text + "') ";

                comandoSql.ExecuteReader();

                _conexao.Close();

                this.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }
    }
}
