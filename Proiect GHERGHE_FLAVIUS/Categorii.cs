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
    public partial class Categorii : Form
    {
        public Categorii()
        {
            InitializeComponent();
            ArataCategorii();
            CountCat();
        }

        private void ArataCategorii()
        {

            Con.Open();
            string Query = "select * from CategoriiTabel1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CategoriiAfisare.DataSource = ds.Tables[0];
            Con.Close();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=stoc;Integrated Security=True");

        private void SalveazaBtn_Click(object sender, EventArgs e)
        {
            if (CategorieTb.Text == "" )
            {
                MessageBox.Show("Date lipsa");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CategoriiTabel1 values(@CAN)", Con);
                    cmd.Parameters.AddWithValue("@CAN", CategorieTb.Text);
                  

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Categorie salvata");
                    Con.Close();
                    ArataCategorii();
                    CountCat();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
              
            }
        }
        int Key = 0;
        private void CategoriiAfisare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategorieTb.Text = CategoriiAfisare.SelectedRows[0].Cells[1].Value.ToString();
            
            if (CategorieTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CategoriiAfisare.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void EditeazaBtn_Click(object sender, EventArgs e)
        {
            if (CategorieTb.Text == "" )
            {
                MessageBox.Show("Date lipsa");
            }
            else
            {
                //int Profit = Convert.ToInt32(PretVanzareTb.Text) - Convert.ToInt32(PretCumparareTb.Text);
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update  CategoriiTabel1 set NumeCategorie=@CAN where CatCod=@CatKey", Con);
                    cmd.Parameters.AddWithValue("@CAN", CategorieTb.Text);
                    cmd.Parameters.AddWithValue("@CatKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Categorie editata!");
                    Con.Close();
                    ArataCategorii();
                    CountCat();
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
                System.Windows.Forms.MessageBox.Show("Selecteaza categoria");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CategoriiTabel1 where CatCod = @CATKey", Con);
                    cmd.Parameters.AddWithValue("@CATKey", Key);
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show(this, "Categorie stearsa");
                    Con.Close();
                    ArataCategorii();
                }
                catch (Exception Ex)
                {
                    System.Windows.Forms.MessageBox.Show(Ex.Message);
                }

            }
        }
        private void CountCat()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CategoriiTabel1", Con);  
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CategorieNumar.Text = dt.Rows[0][0].ToString(); 
            Con.Close();



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

