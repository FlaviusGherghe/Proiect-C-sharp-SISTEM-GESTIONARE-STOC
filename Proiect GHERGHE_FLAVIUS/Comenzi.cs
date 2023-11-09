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
    public partial class Comenzi : Form
    {
        public Comenzi()
        {
            InitializeComponent();
            Client();
            Produs();
            ArataComenzi();
           
        }
        SqlConnection Con = new SqlConnection(@"Data Source=localhost;Initial Catalog=stoc;Integrated Security=True");

        private void Client()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from ClientTabel1", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientCod", typeof(int));
            dt.Load(Rdr);
            ClientTb.ValueMember = "ClientCod";
            ClientTb.DataSource = dt;
            Con.Close();
        }

        private void Produs()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from ProdusTabel1", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ProdusCod", typeof(int));
            dt.Load(Rdr);
            ProduseTb.ValueMember = "ProdusCod";
            ProduseTb.DataSource = dt;
            Con.Close();
        }

        private void ProdusNume()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
            Con.Open();
            string mysql = "Select * from ProdusTabel1 where ProdusCod = '" + ProduseTb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                NumeProdusTb.Text = dr["NumeProdus"].ToString();
                PretTb.Text = dr["PretVanzare"].ToString();
            }

            Con.Close();

        }


        private void ProduseTb_SelectionChangeComitted(object sender, EventArgs e)
        {
            ProdusNume();
        }
        int n = 0;
        int LBLTotal = 0;
        private void AddFacturaBtn_Click(object sender, EventArgs e)
        {
            if (NumeProdusTb.Text == "" || CantitateTb.Text == "")
            {
                MessageBox.Show("Lipsesc informatiile necesare");
            }
            else
            {
                int total = Convert.ToInt32(CantitateTb.Text) * Convert.ToInt32(PretTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(ComenziAfisare);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = NumeProdusTb.Text;
                newRow.Cells[2].Value = PretTb.Text;
                newRow.Cells[3].Value = CantitateTb.Text;
                newRow.Cells[4].Value = total;
                ComenziAfisare.Rows.Add(newRow);
                LBLTotal = LBLTotal + total;
                TotalLbl.Text = "Rezultat:" + LBLTotal;
                SumaTb.Text = "" + LBLTotal;
                n++;
                ActualizeazaStoc();
                MessageBox.Show("Produs adaugat");

            }
        }

        private void ArataComenzi()
        {
            Con.Open();
            string Query = "select * from ComandaTabel1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ComenziAfisare2.DataSource = ds.Tables[0];
            Con.Close();

        }
      

        private void ActualizeazaStoc()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProdusTabel1 set Cantitate = @Pcantitate where ProdusCod = @PrKey", Con);
                
                
                cmd.Parameters.AddWithValue("@Pcantitate", CantitateTb.Text);
               
                cmd.Parameters.AddWithValue("@PrKey", ProduseTb.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
               
                Con.Close();
               
            }
            catch (Exception Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message);
            }
         

        }
        private void ComandaBtn_Click(object sender, EventArgs e)
        {
            if (ClientTb.SelectedIndex == -1 || GenTb.SelectedIndex == -1 || SumaTb.Text == "")
            {
                MessageBox.Show("Date lipsa");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ComandaTabel1(ClientId,UserId,DataCumparare,SumaCumparare) values(@CI, @UI, @DC, @SC)", Con);
                    cmd.Parameters.AddWithValue("@CI", ClientTb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@UI", GenTb.SelectedIndex.ToString());
                    cmd.Parameters.AddWithValue("@DC", DataComandaTb.Value.Date);
                    cmd.Parameters.AddWithValue("@SC", SumaTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Comanda adaugata");
                    Con.Close();
                    ArataComenzi();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
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
