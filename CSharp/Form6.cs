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
    public partial class Form6 : Form
    {
        private DbProviderFactory _Conexao;
        private DbConnection _conexao;
        String id;

        public Form6(String id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Form6_Load(object sender, EventArgs e)
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

                if (campo1.Text != "")
                {
                    comandoSql.CommandText = "UPDATE producao SET cod_linha = '" + campo1.Text + "' where cod_linha = '" + id + "'";
                    comandoSql.ExecuteReader();
                    comandoSql.CommandText = "UPDATE linha SET cod_linha = '" + campo1.Text + "' where cod_linha = '" + id + "'";
                    comandoSql.ExecuteReader();
                }
                if (campo2.Text != "")
                {
                    comandoSql.CommandText = "UPDATE linha SET des_linha = '" + campo2.Text + "' where cod_linha = '" + id + "'";
                    comandoSql.ExecuteReader();
                }

                _conexao.Close();

                this.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                _conexao.Close();
            }
            
        }
    }
}
