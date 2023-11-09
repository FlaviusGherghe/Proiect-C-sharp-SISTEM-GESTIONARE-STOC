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
    public partial class Furnizori : Form
    {
        public Furnizori()
        {
            InitializeComponent();
            ArataFurnizori();
        }

        private void ArataFurnizori()
        {
            Con.Open();
            string Query = "select * from FurnizorTabel1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FurnizoriAfisare.DataSource = ds.Tables[0];
            Con.Close();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=stoc;Integrated Security=True");

        private void SalveazaBtn_Click(object sender, EventArgs e)
        {
            if (NumeFurnizorTb.Text == "" || TelefonFurnizorTb.Text == "" || AdresaFurnizorTb.Text == "")
            {
                MessageBox.Show("Date lipsa");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into FurnizorTabel1 values(@FN, @FTelefon, @FAdresa)", Con);
                    cmd.Parameters.AddWithValue("@FN", NumeFurnizorTb.Text);
                    cmd.Parameters.AddWithValue("@FTelefon", TelefonFurnizorTb.Text);
                    cmd.Parameters.AddWithValue("@FAdresa", AdresaFurnizorTb.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Furnizor salvat");
                    Con.Close();
                    ArataFurnizori();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
               
            }
        }
        int Key = 0;
        private void FurnizoriAfisare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NumeFurnizorTb.Text = FurnizoriAfisare.SelectedRows[0].Cells[1].Value.ToString();
            TelefonFurnizorTb.Text = FurnizoriAfisare.SelectedRows[0].Cells[2].Value.ToString();
            AdresaFurnizorTb.Text = FurnizoriAfisare.SelectedRows[0].Cells[3].Value.ToString();

            if (NumeFurnizorTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(FurnizoriAfisare.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditeazaBtn_Click(object sender, EventArgs e)
        {
            if (NumeFurnizorTb.Text == "" || TelefonFurnizorTb.Text == "" || AdresaFurnizorTb.Text == "")
            {
                MessageBox.Show("Date lipsa");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update FurnizorTabel1 set FurnizorNume=@FN, FurnizorTelefon=@FTelefon, FurnizorAdresa=@FAdresa where FurnizorCod=@FKey ", Con);
                    cmd.Parameters.AddWithValue("@FN", NumeFurnizorTb.Text);
                    cmd.Parameters.AddWithValue("@FTelefon", TelefonFurnizorTb.Text);
                    cmd.Parameters.AddWithValue("@FAdresa", AdresaFurnizorTb.Text);
                    cmd.Parameters.AddWithValue("@FKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Furnizor editat");
                    Con.Close();
                    ArataFurnizori();
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
                System.Windows.Forms.MessageBox.Show("Selecteaza furnizorul");
            }
            else
            {
                
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from FurnizorTabel1 where FurnizorCod = @FKey", Con);
                    cmd.Parameters.AddWithValue("@FKey", Key);
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show(this, "Furnizor sters");
                    Con.Close();
                    ArataFurnizori();
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

     
    }
}