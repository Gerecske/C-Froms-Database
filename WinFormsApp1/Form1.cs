using Microsoft.Data.SqlClient;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DgvReLoad()
        {
            dgv.Rows.Clear();
            using SqlConnection conn = new(Resources.ConString);
            conn.Open();
            SqlDataReader rdr = new SqlCommand(
                "SELECT * FROM emberek;",
                conn).ExecuteReader();

            while (rdr.Read())
            {
                dgv.Rows.Add(
                    rdr[0],
                    rdr[1],
                    rdr.GetBoolean(2) ? "férfi" : "nõ",
                    rdr.GetDateTime(3).ToString("yyy. MMM dd."));
            }
        }

        private void Form1_Load(object sender, EventArgs e) => DgvReLoad();

        private void Button_newPerson_Click(object sender, EventArgs e)
        {
            //TODO: "Feltételek teljesülnek-e?"
            if (string.IsNullOrEmpty(tb_Nev.Text))
            {
                _ = MessageBox.Show("A 'név' mezõ kitöltése kötelezõ!", "HIBA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string nev = tb_Nev.Text;
                string nem = rbFF.Checked ? "1" : "0";
                string szul = dtpSzul.Value.ToString("yyy-MM-dd");

                using SqlConnection conn = new(Resources.ConString);
                conn.Open();

                SqlDataAdapter sda = new()
                {
                    InsertCommand = new SqlCommand(
                        cmdText: "INSERT INTO emberek VALUES " +
                        $"('{nev}', {nem}, '{szul}');",
                        connection: conn),
                };

                sda.InsertCommand.ExecuteNonQuery();

                DgvReLoad();
            }
        }
    }
}