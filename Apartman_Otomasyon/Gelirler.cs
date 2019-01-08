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

namespace Apartman_Otomasyon
{
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }
        SqlHelper can = new SqlHelper();

        private void Gelirler_Load(object sender, EventArgs e)
        {

            

            DataTable dt = can.GetTable("Select * from AidatOdemesi");
            
            
            foreach (DataRow item in dt.Rows)
            {

                listBox1.Items.Add(item["daireno"]).ToString();
                listBox2.Items.Add(item["para"]).ToString();
                listBox3.Items.Add(item["Tarih"]).ToString();

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int daireno = Convert.ToInt32(cmb_daire_no.Text);
            int para = (int)numericUpDown_tutar.Value;
            DateTime yeni = dateTimePicker1.Value;



            SqlParameter p1 = new SqlParameter("Daireno", daireno);

            SqlParameter p2 = new SqlParameter("Para", para);

            SqlParameter p3 = new SqlParameter("Tarih", yeni);



            can.ExecuteProc("ODEME_AL", p1, p2, p3);

        }
    }
}
