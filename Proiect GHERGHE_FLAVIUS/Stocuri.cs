using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proiect_GHERGHE_FLAVIUS
{
    public partial class Stocuri : Form
    {
        public Stocuri()
        {
            InitializeComponent();
            ArataProduse();
            Categorie();
            Furnizori();
        }
        private void ArataProduse()
        {
            Con.Open();
            string Query = "select * from ProdusTabel1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProduseAfisare.DataSource = ds.Tables[0];
            Con.Close();
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Stocuri_Load(object sender, EventArgs e)
        {
        }


        SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=stoc;Integrated Security=True");
        private void SalveazaBtn_Click(object sender, EventArgs e)
        {
            if (NumeProdusTb.Text == "" || CantitateTb.Text == "" || PretVanzareTb.Text == "" || PretCumparareTb.Text == "" || FurnizoriTb.SelectedIndex == -1 || CategorieTb.SelectedIndex == -1)
            {
                MessageBox.Show("Date lipsa");
            }
            else
            {
                int Profit = Convert.ToInt32(PretVanzareTb.Text) - Convert.ToInt32(PretCumparareTb.Text);
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ProdusTabel1 values(@PN, @Pcategorie, @Pcantitate, @Pcumparare, @Pvanzare, @Pdata, @Pfurnizori, @P)", Con);
                    cmd.Parameters.AddWithValue("@PN", NumeProdusTb.Text);
                    cmd.Parameters.AddWithValue("@Pcategorie", CategorieTb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Pcantitate", CantitateTb.Text);
                    cmd.Parameters.AddWithValue("@Pcumparare", PretCumparareTb.Text);
                    cmd.Parameters.AddWithValue("@Pvanzare", PretVanzareTb.Text);
                    cmd.Parameters.AddWithValue("@Pdata", DataTb.Value.Date);
                    cmd.Parameters.AddWithValue("@Pfurnizori", FurnizoriTb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@P", Profit);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Produs salvat");
                    Con.Close();
                    ArataProduse();
                    Categorie();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
             

            }
        }
                int Key = 0;
            private void ProduseAfisare_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
                    NumeProdusTb.Text = ProduseAfisare.SelectedRows[0].Cells[1].Value.ToString();
                    CategorieTb.Text = ProduseAfisare.SelectedRows[0].Cells[2].Value.ToString();
                    CantitateTb.Text = ProduseAfisare.SelectedRows[0].Cells[3].Value.ToString();
                    PretCumparareTb.Text = ProduseAfisare.SelectedRows[0].Cells[4].Value.ToString();
                    PretVanzareTb.Text = ProduseAfisare.SelectedRows[0].Cells[5].Value.ToString();
                    DataTb.Text = ProduseAfisare.SelectedRows[0].Cells[6].Value.ToString();
                    FurnizoriTb.Text = ProduseAfisare.SelectedRows[0].Cells[7].Value.ToString();
                    if (NumeProdusTb.Text == "")
                    {
                        Key = 0;
                    }
                    else
                    {
                        Key = Convert.ToInt32(ProduseAfisare.SelectedRows[0].Cells[0].Value.ToString());
                    }
                }
        private void EditeazaBtn_Click(object sender, EventArgs e)
        {
            if (NumeProdusTb.Text == "" || CantitateTb.Text == "" || PretVanzareTb.Text == "" ||
            PretCumparareTb.Text == "" || FurnizoriTb.SelectedIndex == -1 || CategorieTb.SelectedIndex == -1)
            {
                System.Windows.Forms.MessageBox.Show("Date lipsa");
            }
            else
            {
                int Profit = Convert.ToInt32(PretVanzareTb.Text) - Convert.ToInt32(PretCumparareTb.Text);
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ProdusTabel1 set NumeProdus = @PN, Categorie = @Pcategorie, Cantitate = @Pcantitate, PretCumparare = @Pcumparare, PretVanzare = @Pvanzare, Data = @Pdata, Furnizori = @Pfurnizori, Profit = @P where ProdusCod = @PrKey", Con);
                    cmd.Parameters.AddWithValue("@PN", NumeProdusTb.Text);
                    cmd.Parameters.AddWithValue("@Pcategorie", CategorieTb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Pcantitate", CantitateTb.Text);
                    cmd.Parameters.AddWithValue("@Pcumparare", PretCumparareTb.Text);
                    cmd.Parameters.AddWithValue("@Pvanzare", PretVanzareTb.Text);
                    cmd.Parameters.AddWithValue("@Pdata", DataTb.Value.Date);
                    cmd.Parameters.AddWithValue("@Pfurnizori", FurnizoriTb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@P", Profit);
                    cmd.Parameters.AddWithValue("@PrKey", Key);
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show(this, "Produs editat");
                    Con.Close();
                    ArataProduse();
                    Categorie();
                    Furnizori();
                }
                catch (Exception Ex)
                {
                    System.Windows.Forms.MessageBox.Show(Ex.Message);
                }
              

            }
        }
        private void StergeBtn_Click(object sender, EventArgs e)
            {
                if (Key == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Selecteaza produsul");
                }
                else
                {
                    int Profit = Convert.ToInt32(PretVanzareTb.Text) -
                    Convert.ToInt32(PretCumparareTb.Text);
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("delete from ProdusTabel1 where ProdusCod = @PrKey", Con);
                        cmd.Parameters.AddWithValue("@PrKey", Key);
                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show(this, "Produs sters");
                        Con.Close();
                        ArataProduse();
                    Furnizori();
                }
                    catch (Exception Ex)
                    {
                        System.Windows.Forms.MessageBox.Show(Ex.Message);
                    }
           

            }
            }
        private void Categorie()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from CategoriiTabel1", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt= new DataTable();
            dt.Columns.Add("CatCod", typeof(int));
            dt.Load(Rdr);
            CategorieTb.ValueMember = "CatCod";
            CategorieTb.DataSource = dt;
            Con.Close();
        }

        private void Furnizori()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from FurnizorTabel1", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("FurnizorCod", typeof(int));
            dt.Load(Rdr);
            FurnizoriTb.ValueMember = "FurnizorCod";
            FurnizoriTb.DataSource = dt;
            Con.Close();
        }
        private void CategorieTb_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        private void CautareFiltruTextBox()
        {
            Con.Open();
            string Query = "select * from ProdusTabel1 where NumeProdus = '" + CautareTb.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProduseAfisare.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void CautareBtn_Click(object sender, EventArgs e)
        {
            CautareFiltruTextBox();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ArataProduse();
            CautareTb.Text = "";
        }

        private void ProfitFiltruTextBox()
        {
            Con.Open();
            string Query = "select * from ProdusTabel1 where Profit = '" + CautareCb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProduseAfisare.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void CautareCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProfitFiltruTextBox();
        }

     
    }
    }
