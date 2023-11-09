using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_GHERGHE_FLAVIUS
{
    public partial class Clienti : Form
    {
        public Clienti()
        {
            InitializeComponent();
            ArataClienti();
        }

      

        private void ArataClienti()
        {
            Con.Open();
            string Query = "select * from ClientTabel1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ClientiAfisare.DataSource = ds.Tables[0];
            Con.Close();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=stoc;Integrated Security=True");

        private void SalveazaBtn_Click(object sender, EventArgs e)
        {
            if (NumeClientTb.Text == "" || TelefonTb.Text == "" || AdresaTb.Text == "" || GenTb.SelectedIndex ==  -1)
            {
                MessageBox.Show("Date lipsa");
            }
            else
            {
                
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ClientTabel1 values(@CN, @CTelefon, @CAdresa, @CG)", Con);
                    cmd.Parameters.AddWithValue("@CN", NumeClientTb.Text);
                    cmd.Parameters.AddWithValue("@CTelefon", TelefonTb.Text);
                    cmd.Parameters.AddWithValue("@CAdresa", AdresaTb.Text);
                    cmd.Parameters.AddWithValue("@CG", GenTb.SelectedItem.ToString());
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Client salvat");
                    Con.Close();
                    ArataClienti();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
              
            }
        }
        int Key = 0;
        private void ClientiAfisare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NumeClientTb.Text = ClientiAfisare.SelectedRows[0].Cells[1].Value.ToString();
            TelefonTb.Text = ClientiAfisare.SelectedRows[0].Cells[2].Value.ToString();
            AdresaTb.Text = ClientiAfisare.SelectedRows[0].Cells[3].Value.ToString();
            GenTb.Text = ClientiAfisare.SelectedRows[0].Cells[4].Value.ToString();
            if (NumeClientTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ClientiAfisare.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditeazaBtn_Click(object sender, EventArgs e)
        {
            if (NumeClientTb.Text == "" || TelefonTb.Text == "" || AdresaTb.Text == "" || GenTb.SelectedIndex == -1)
            {
                MessageBox.Show("Date lipsa");
            }
            else
            {
                //int Profit = Convert.ToInt32(PretVanzareTb.Text) - Convert.ToInt32(PretCumparareTb.Text);
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update  ClientTabel1 set ClientNume=@CN, ClientTelefon=@CTelefon, ClientAdresa=@CAdresa, ClientGen=@CG where ClientCod=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CN", NumeClientTb.Text);
                    cmd.Parameters.AddWithValue("@CTelefon", TelefonTb.Text);
                    cmd.Parameters.AddWithValue("@CAdresa", AdresaTb.Text);
                    cmd.Parameters.AddWithValue("@CG", GenTb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Client editat!");
                    Con.Close();
                    ArataClienti();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
              
            }
        }

        private void StergeBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                System.Windows.Forms.MessageBox.Show("Selecteaza clientul");
            }
            else
            {
              
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ClientTabel1 where ClientCod = @CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show(this, "Client sters");
                    Con.Close();
                    ArataClienti();
                }
                catch (Exception Ex)
                {
                    System.Windows.Forms.MessageBox.Show(Ex.Message);
                }
              
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Clienti Obj = new Clienti();
            Obj.Show();
            this.Hide();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Furnizori Obj = new Furnizori();
            Obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Stocuri Obj = new Stocuri();
            Obj.Show();
            this.Hide();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Categorii Obj = new Categorii();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Comenzi Obj = new Comenzi();
            Obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Stocuri Obj = new Stocuri();
            Obj.Show();
            this.Hide();
        }

        private void Clienti_Load(object sender, EventArgs e)
        {

        }

       
    }
}
