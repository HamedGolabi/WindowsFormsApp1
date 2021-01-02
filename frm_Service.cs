using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsApp1.Forms
{
    public partial class frm_Service : DevExpress.XtraEditors.XtraForm
    {
        CharityEntities4 db = new CharityEntities4();
        public frm_Service()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tbl_HealthStatus hs = new tbl_HealthStatus();
            hs.name = textBox1.Text;
           db.tbl_HealthStatus.Add(hs);
            db.SaveChanges(); 
            fn_LoadAllHealthStatus();
        }

        void fn_LoadAllRelativeName()
        {
            var data = (from d in db.tbl_RelativeName select d);
            comboBox1.Items.Clear();
            foreach (var item in data.ToList())
                comboBox1.Items.Add(item.name);
        }

        void fn_LoadAllHealthStatus()
        {
            var data = (from d in db.tbl_HealthStatus select d);
            dataGridView1.DataSource = data.ToList();
            dataGridView1.Refresh();
        }

        private void Frm_Service_Load(object sender, EventArgs e)
        {
            fn_LoadAllRelativeName();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tbl_HealthStatus hs = new tbl_HealthStatus();
            hs = db.tbl_HealthStatus.Find(6);
            hs.name = hs.name;
            hs.name = hs.name.Remove('*');
            db.tbl_HealthStatus.Remove(hs);
            db.SaveChanges(); 
            fn_LoadAllHealthStatus();
        }

        void fn_Update_HealthStatus(int id,string name)
        {
            tbl_HealthStatus hs = new tbl_HealthStatus();
            hs = db.tbl_HealthStatus.Find(7);
            hs.name = name;
            db.Entry(hs).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            fn_LoadAllHealthStatus();
        }

        void fn_Remove_HealthStatus(int id )
        {
            tbl_HealthStatus hs = new tbl_HealthStatus();
            hs = db.tbl_HealthStatus.Find(id); 
             db.tbl_HealthStatus.Remove(hs);
            db.SaveChanges(); 
            fn_LoadAllHealthStatus();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tbl_HealthStatus hs = new tbl_HealthStatus();
            hs = db.tbl_HealthStatus.Find(7);
            hs.name = hs.name + "*";
            db.Entry(hs).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            fn_LoadAllHealthStatus();
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);



        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            fn_Remove_HealthStatus(id);
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            fn_Update_HealthStatus(id, textBox1.Text);
            
        }
    }
}