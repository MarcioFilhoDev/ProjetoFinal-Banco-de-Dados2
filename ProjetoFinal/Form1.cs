using System.Data;
using System.Data.SqlClient;

namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=projeto_final_bd2;Data Source=DESKTOP-MCJ0K3N\SQLEXPRESS";
        private string strSql = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            strSql = "insert into viagem " +
                "(id_cliente, id_motorista, id_cavalo, id_carreta, descricao_produtos, valor_frete, km_total ) values " +
                "(@id_cliente, @id_motorista, @id_cavalo, @id_carreta, @descricao_produtos, @valor_frete, @km_total)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@id_cliente", SqlDbType.Int).Value = txtClienteId.Text;
            comando.Parameters.Add("@id_motorista", SqlDbType.Int).Value = txtMotoristaId.Text;
            comando.Parameters.Add("@id_cavalo", SqlDbType.Int).Value = txtCavaloId.Text;
            comando.Parameters.Add("@id_carreta", SqlDbType.Int).Value = txtCarretaId.Text;
            comando.Parameters.Add("@descricao_produtos", SqlDbType.VarChar).Value = txtDescProdutos.Text;
            comando.Parameters.Add("@valor_frete", SqlDbType.Decimal).Value = txtValorFrete.Text;
            comando.Parameters.Add("@km_total", SqlDbType.Int).Value = txtKmTotal.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            strSql = "UPDATE viagem SET id_cliente = @id_cliente, id_motorista = @id_motorista, id_cavalo = @id_cavalo, " +
             "id_carreta = @id_carreta, descricao_produtos = @descricao_produtos, valor_frete = @valor_frete, " +
             "km_total = @km_total WHERE id = @id";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@id", SqlDbType.Int).Value = txtIdViagem.Text;
            comando.Parameters.Add("@id_cliente", SqlDbType.VarChar).Value = txtClienteId.Text;
            comando.Parameters.Add("@id_motorista", SqlDbType.Int).Value = txtMotoristaId.Text;
            comando.Parameters.Add("@id_cavalo", SqlDbType.Int).Value = txtCavaloId.Text;
            comando.Parameters.Add("@id_carreta", SqlDbType.Int).Value = txtCarretaId.Text;
            comando.Parameters.Add("@descricao_produtos", SqlDbType.VarChar).Value = txtDescProdutos.Text;
            comando.Parameters.Add("@valor_frete", SqlDbType.Decimal).Value = txtValorFrete.Text;
            comando.Parameters.Add("@km_total", SqlDbType.Int).Value = txtKmTotal.Text;

            try
            {
                sqlCon.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                    MessageBox.Show("Dados atualizados com sucesso!");
                else
                    MessageBox.Show("Nenhum registro foi alterado. Verifique o ID informado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            strSql = @"SELECT viagem.id, viagem.id_cliente, viagem.id_motorista, 
              viagem.id_cavalo, viagem.id_carreta, clientes.nome AS nome_cliente,
              motorista.nome AS nome_motorista, veiculo_cavalo.placa AS placa_cavalo,
              veiculo_carreta.placa AS placa_carreta, viagem.descricao_produtos,
              viagem.valor_frete, viagem.km_total FROM viagem
              LEFT JOIN clientes ON viagem.id_cliente = clientes.id
              LEFT JOIN motorista ON viagem.id_motorista = motorista.id
              LEFT JOIN cavalo ON viagem.id_cavalo = cavalo.id
              LEFT JOIN carretas ON viagem.id_carreta = carretas.id
              LEFT JOIN veiculo AS veiculo_cavalo ON cavalo.id_veiculo = veiculo_cavalo.id
              LEFT JOIN veiculo AS veiculo_carreta ON carretas.id_veiculo = veiculo_carreta.id
              WHERE viagem.id = @id";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(txtIdViagem.Text);

            try
            {
                sqlCon.Open();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtClienteId.Text = reader["id_cliente"].ToString();
                    txtMotoristaId.Text = reader["id_motorista"].ToString();
                    txtCavaloId.Text = reader["id_cavalo"].ToString();
                    txtCarretaId.Text = reader["id_carreta"].ToString();

                    txtClienteNome.Text = reader["nome_cliente"].ToString();
                    txtMotoristaNome.Text = reader["nome_motorista"].ToString();
                    txtCavaloNome.Text = reader["placa_cavalo"].ToString();
                    txtCarretaNome.Text = reader["placa_carreta"].ToString();
                    txtDescProdutos.Text = reader["descricao_produtos"].ToString();
                    txtValorFrete.Text = reader["valor_frete"].ToString();
                    txtKmTotal.Text = reader["km_total"].ToString();
                }
                else
                {
                    MessageBox.Show("Viagem não encontrada.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar viagem: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }


        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            strSql = "DELETE FROM viagem WHERE id = @id";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@id", SqlDbType.Int).Value = txtIdViagem.Text;

            try
            {
                sqlCon.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Viagem excluída com sucesso!");
                    // Limpa os campos
                    txtClienteId.Clear();
                    txtMotoristaId.Clear();
                    txtCavaloId.Clear();
                    txtCarretaId.Clear();
                    txtDescProdutos.Clear();
                    txtValorFrete.Clear();
                    txtKmTotal.Clear();
                }
                else
                {
                    MessageBox.Show("Viagem não encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}