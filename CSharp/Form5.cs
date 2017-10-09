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
    public partial class Form5 : Form
    {
        private DbProviderFactory _Conexao;
        private DbConnection _conexao;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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

                comandoSql.CommandText = "INSERT INTO linha(cod_linha,des_linha)VALUES('" + campo1.Text + "','" + campo2.Text + "')";
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
