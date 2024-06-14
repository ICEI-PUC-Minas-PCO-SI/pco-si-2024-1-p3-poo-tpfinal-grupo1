using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;

namespace CEMIG_V2
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private string configConexao = "Data Source=DESKTOP-EPSUI05\\SQLEXPRESS;Initial Catalog=DB_CEMIG;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {

            string query = "SELECT * FROM usuario";

            using (SqlConnection connection = new SqlConnection(configConexao))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Debug.WriteLine(reader[i] + "\t");
                        }
                        Console.WriteLine();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

        }
    }
}
