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

namespace WindowsFormsApp1
{
    public partial class frm_AddPictures : DevExpress.XtraEditors.XtraForm
    {
        public frm_AddPictures()
        {
            InitializeComponent();
        }

        private void CheckButton1_CheckedChanged(object sender, EventArgs e)
        {

            int id = 12;
            var MyImageArray = MyClasses.FnLoadDocumentImages();
            for (int i = 0; i < MyImageArray.Length; i++)
            {
                string s = id + "_" + i;
                MyClasses.FnSaveDocumentImage(MyImageArray[i], s);
             }

            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}