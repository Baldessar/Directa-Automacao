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
using System.IO;

namespace WindowsFormsApplication1 {

    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private DbProviderFactory _Conexao;
        private DbConnection _conexao;
        String sql;
        String deledit;
        int table;
        bool checkbox = false;
        
        
        private void showValueGrid(DbCommand comandoSql) {
            try
            {
                DbDataReader reader = comandoSql.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grid.DataSource = table;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void showGrid()
        {
            grid.Show();
            btnCadastro.Show();
            //btnDeletar.Show();
            //btnEditar.Show();
        }

        private void makeSql(int table)
        {
          switch (table) {
              case 0: sql = "SELECT cod_linha,des_linha FROM linha where cod_linha LIKE '" + campo1.Text + "%' AND des_linha LIKE '" + campo2.Text + "%'";
                  break;
              case 1: sql = "SELECT cod_prod as \"codigo de produto\", nom_cor cor,num_serie as \"Numero de serie\",cod_familia familia FROM produto WHERE nom_cor LIKE '" + campo1.Text + "%' AND num_serie LIKE '" + campo2.Text + "%' AND cod_familia LIKE '" + campo3.Text + "%'" ;
                  break;
              case 2:
                  if (checkbox)
                  {
                      sql = "SELECT cod_prod,cod_linha,num_peso,dat_data_prod FROM producao WHERE cod_linha LIKE '" + campo1.Text + "%'AND cod_prod LIKE '" + campo2.Text + "%'AND num_peso LIKE '" + campo3.Text + "%' AND dat_data_prod BETWEEN TO_DATE('" + calendar.Value + "','dd.MM.yyyy hh24:mi:ss') and TO_DATE('" + calendar2.Value + "','dd.MM.yyyy hh24:mi:ss')";
                  }
                  else
                  {
                    sql = "SELECT cod_prod,cod_linha,num_peso,dat_data_prod FROM producao WHERE cod_linha LIKE '" + campo1.Text + "%'AND cod_prod LIKE '" + campo2.Text + "%'AND num_peso LIKE '" + campo3.Text + "%'";
                  }
                  break;
              case 3:
                  if (checkbox)
                  {
                      sql = "SELECT cod_prod,num_serie,flg_aprovado,num_resultado,dat_data_inspecao FROM inspecao WHERE cod_prod LIKE '" + campo1.Text + "%' AND num_serie LIKE '" + campo2.Text + "%' AND num_resultado LIKE '" + campo3.Text + "%' AND flg_aprovado LIKE '" + comboBox1.SelectedItem.ToString() + "%' AND dat_data_inspecao BETWEEN TO_DATE('" + calendar.Value + "','dd.MM.yyyy hh24:mi:ss') and TO_DATE('" + calendar2.Value + "','dd.MM.yyyy hh24:mi:ss')";
                  }
                  else
                  {
                      sql = "SELECT cod_prod,num_serie,flg_aprovado,num_resultado,dat_data_inspecao FROM inspecao WHERE cod_prod LIKE '" + campo1.Text + "%' AND num_serie LIKE '" + campo2.Text + "%' AND num_resultado LIKE '" + campo3.Text + "%' AND flg_aprovado LIKE '" + comboBox1.SelectedItem.ToString() + "%'"; 
                  }
                  break;
          }
              
        }
        
        private void button1_Click(object sender, EventArgs e) {
            
            _conexao.Open();

            DbCommand comandoSql = _conexao.CreateCommand();

            comandoSql.CommandType = System.Data.CommandType.Text;

            comandoSql.CommandText = "SELECT cod_linha,des_linha FROM linha";

            showValueGrid(comandoSql);
            
            _conexao.Close();

            campo2.Show();
            campo2.Text = "Descricao da linha";
            campo1.Show();
            campo1.Text = "Codigo da linha";
            btnPesquisa.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            try
            {
                string provedor = ConfigurationManager.ConnectionStrings["dtestagio"].ProviderName;
                string urlConexao = ConfigurationManager.ConnectionStrings["dtestagio"].ConnectionString;
                //string provedor = "System.Data.OracleClient";
                //string urlConexao = "Data Source=dtestagio;Persist Security Info=True;User ID=treinamento;Password=treinamento;Unicode=True;Pooling=true;Min Pool Size=5;Max Pool Size=100;";
                _Conexao = DbProviderFactories.GetFactory(provedor);
                _conexao = _Conexao.CreateConnection();
                _conexao.ConnectionString = urlConexao;
                comboBox1.SelectedIndex = 0 ;
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) {

            this.Hide();
            Form2 formTeste = new Form2();
            formTeste.Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            _conexao.Open();

            DbCommand comandoSql = _conexao.CreateCommand();

            comandoSql.CommandType = System.Data.CommandType.Text;

            comandoSql.CommandText = "SELECT nom_cor cor,num_serie as \"Numero de serie\",cod_familia familia FROM produto";

            showValueGrid(comandoSql);

            _conexao.Close();
        }

        private void button4_Click(object sender, EventArgs e) {
            _conexao.Open();

            DbCommand comandoSql = _conexao.CreateCommand();

            comandoSql.CommandType = System.Data.CommandType.Text;

            comandoSql.CommandText = "SELECT cod_prod AS \"Código de producao\",cod_linha AS \"Código da linha\",num_peso peso,dat_data_prod AS \"Data do cadastro\" FROM producao";

            showValueGrid(comandoSql);

            _conexao.Close();
        }

        private void button5_Click(object sender, EventArgs e) {
            _conexao.Open();

            DbCommand comandoSql = _conexao.CreateCommand();

            comandoSql.CommandType = System.Data.CommandType.Text;

            comandoSql.CommandText = "SELECT cod_prod AS \"Código de producao\",num_serie AS \"Numero de serie\",flg_aprovado AS \"Aprovado\",Num_resultado resultado, dat_data_inspecao AS \"Data de inspecao\" FROM inspecao";

            showValueGrid(comandoSql);

            _conexao.Close();
        }

        private void button6_Click(object sender, EventArgs e) {
            _conexao.Open();

            DbCommand comandoSql = _conexao.CreateCommand();

            comandoSql.CommandType = System.Data.CommandType.Text;

            comandoSql.CommandText = "SELECT * FROM producao p INNER JOIN produto pr on p.cod_prod = pr.cod_prod";

            showValueGrid(comandoSql);

            _conexao.Close();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeletar.Show();
            btnEditar.Show();
            deledit = grid[0,grid.CurrentRow.Index].Value.ToString();
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 formTeste = new Form3();
            formTeste.Show();
        }


        private void linhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _conexao.Open();

            DbCommand comandoSql = _conexao.CreateCommand();

            comandoSql.CommandType = System.Data.CommandType.Text;

            comandoSql.CommandText = "SELECT cod_linha,des_linha FROM linha";

            showValueGrid(comandoSql);

            _conexao.Close();

            campo2.Show();
            label2.Text = "Descricao da linha";
            label2.Show();
            campo1.Show();
            label1.Text = "Codigo da linha";
            label1.Show();
            campo3.Hide();
            label3.Hide();
            label4.Hide();
            comboBox1.Hide();
            calendar.Hide();
            calendar2.Hide();
            checkBox1.Hide();
            btnPesquisa.Show();
            btnExcel.Show();
            

            showGrid();
            table = 0;
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _conexao.Open();

            DbCommand comandoSql = _conexao.CreateCommand();

            comandoSql.CommandType = System.Data.CommandType.Text;

            comandoSql.CommandText = "SELECT cod_prod as \"codigo do produto\",nom_cor cor,num_serie as \"Numero de serie\",cod_familia familia FROM produto";

            showValueGrid(comandoSql);

            _conexao.Close();

            campo1.Show();
            label1.Text = "Cor";
            label1.Show();
            campo2.Show();
            label2.Text = "Numero de serie";
            label2.Show();
            campo3.Show();
            label3.Text = "Familia";
            label3.Show();
            label4.Hide();
            comboBox1.Hide();
            calendar.Hide();
            calendar2.Hide();
            checkBox1.Hide();
            btnPesquisa.Show();
            btnExcel.Show();
            
            showGrid();
            table = 1;
       
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            
            _conexao.Open();

            DbCommand comandoSql = _conexao.CreateCommand();

            comandoSql.CommandType = System.Data.CommandType.Text;
            
            makeSql(table);

            comandoSql.CommandText = sql;

            showValueGrid(comandoSql);

            _conexao.Close();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (table == 0)
            {
                Form5 formChild = new Form5();
                formChild.Show();
            }
            else
            {
                Form4 formChild = new Form4();
                formChild.Show();
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (table == 0)
            {
                Form6 formChild = new Form6(deledit);
                formChild.Show();
            }
            else
            {
                Form7 formChild = new Form7(deledit);
                formChild.Show();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            _conexao.Open();
            DbCommand comandoSql = _conexao.CreateCommand();
            if (table == 0)
            {
                sql = "DELETE FROM linha WHERE cod_linha = '" + deledit + "'";
                comandoSql.CommandType = System.Data.CommandType.Text;
            }
            else
            {
                sql = "p_delete_produto('" + deledit + "')";
                comandoSql.CommandType = System.Data.CommandType.StoredProcedure;

            }


            comandoSql.CommandText = sql;

            showValueGrid(comandoSql);

            _conexao.Close();
        }

        private void produçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _conexao.Open();

            DbCommand comandoSql = _conexao.CreateCommand();

            comandoSql.CommandType = System.Data.CommandType.Text;

            comandoSql.CommandText = "SELECT cod_prod,cod_linha,num_peso,dat_data_prod FROM producao";

            showValueGrid(comandoSql);

            _conexao.Close();

            campo2.Show();
            label2.Text = "codigo de produto";
            label2.Show();
            campo1.Show();
            label1.Text = "Codigo da linha";
            label1.Show();
            campo3.Show();
            label3.Text = "Peso";
            label3.Show();
            label4.Hide();
            comboBox1.Hide();
            calendar.Show();
            calendar2.Show();
            checkBox1.Show();
            btnPesquisa.Show();
            btnExcel.Show();

            sql = "SELECT cod_prod,cod_linha,num_peso,dat_data_prod FROM producao WHERE cod_linha LIKE '" + campo1.Text + "%'AND cod_prod LIKE '"+campo2.Text +"%'AND num_peso LIKE '" + campo3.Text + " AND dat_data_prod =" + calendar.Value;

            showGrid();
            table = 2;
        }

        private void inspeçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _conexao.Open();

            DbCommand comandoSql = _conexao.CreateCommand();

            comandoSql.CommandType = System.Data.CommandType.Text;

            comandoSql.CommandText = "SELECT cod_prod,num_serie,flg_aprovado,num_resultado,dat_data_inspecao FROM inspecao";

            showValueGrid(comandoSql);

            _conexao.Close();

            campo2.Show();
            label2.Text = "Codigo de produto";
            label2.Show();
            campo1.Show();
            label1.Text = "numero de série";
            label1.Show();
            campo3.Show();
            label3.Text = "Resultado";
            label3.Show();
            label4.Show();
            comboBox1.Show();
            calendar.Show();
            calendar2.Show();
            checkBox1.Show();
            btnPesquisa.Show();
            btnExcel.Show();

            showGrid();
            table = 3;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   

            calendar.Enabled = !(calendar.Enabled);
            calendar2.Enabled = !(calendar2.Enabled);
            checkbox = !(checkbox);
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(comboBox1.SelectedItem.ToString());
            } catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string CsvFpath = @"C:\Documents and Settings\Dell\Desktop\teste.csv";
            try
            {
                System.IO.StreamWriter csvFileWriter = new StreamWriter(CsvFpath, false);

                string columnHeaderText = "";

                int countColumn = grid.ColumnCount - 1;

                if (countColumn >= 0)
                {
                    columnHeaderText = grid.Columns[0].HeaderText;
                }

                for (int i = 1; i <= countColumn; i++)
                {
                    columnHeaderText = columnHeaderText + ',' + grid.Columns[i].HeaderText;
                }


                csvFileWriter.WriteLine(columnHeaderText);

                foreach (DataGridViewRow dataRowObject in grid.Rows)
                {
                    if (!dataRowObject.IsNewRow)
                    {
                        string dataFromGrid = "";

                        dataFromGrid = dataRowObject.Cells[0].Value.ToString();

                        for (int i = 1; i <= countColumn; i++)
                        {
                            dataFromGrid = dataFromGrid + ',' + dataRowObject.Cells[i].Value.ToString();

                            csvFileWriter.WriteLine(dataFromGrid);
                        }
                    }
                }


                csvFileWriter.Flush();
                csvFileWriter.Close();
            }
            catch (Exception exceptionObject)
            {
                MessageBox.Show(exceptionObject.ToString());
            }


        }

        private void produçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                _conexao.Open();

                DbCommand comandoSql = _conexao.CreateCommand();

                sql = "p_delete_produto('" + deledit + "')";
                comandoSql.CommandType = System.Data.CommandType.StoredProcedure;
                comandoSql.CommandText = "p_add_row_producao(100)";
                comandoSql.ExecuteReader();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
               _conexao.Close();
            }
        }

        private void inspeçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                _conexao.Open();

                DbCommand comandoSql = _conexao.CreateCommand();

                sql = "p_delete_produto('" + deledit + "')";
                comandoSql.CommandType = System.Data.CommandType.StoredProcedure;
                comandoSql.CommandText = "p_add_row_inspecao(100)";
                comandoSql.ExecuteReader();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                _conexao.Close();
            }
        }
     }
  }

