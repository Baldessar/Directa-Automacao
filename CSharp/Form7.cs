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
    public partial class Form7 : Form
    {
        private DbProviderFactory _Conexao;
        private DbConnection _conexao;
        private String id;
        public Form7(String id)
        {
            InitializeComponent();
            this.id = id;
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

                if (campo1.Text != "")
                {
                    comandoSql.CommandText = "UPDATE produto SET nom_cor = '" + campo1.Text + "' where cod_prod = '"+id+"'";
                    comandoSql.ExecuteReader();
                }
                if (campo2.Text != "")
                {
                    comandoSql.CommandText = "UPDATE produto SET num_serie = '" + campo2.Text + "' where cod_prod = '" + id + "'";
                    comandoSql.ExecuteReader();
                }
                if (campo3.Text != "")
                {
                    comandoSql.CommandText = "UPDATE produto SET cod_prod = '" + campo3.Text + "' where cod_prod = '" + id + "'";
                    comandoSql.ExecuteReader();
                }
                if (campo4.Text != "")
                {
                    comandoSql.CommandText = "UPDATE produto SET cod_familia = '" + campo4.Text + "' where cod_prod = '" + id + "'";
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

        private void campo1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
