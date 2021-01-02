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
    public partial class Frm_Relateds : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Relateds()
        {
            InitializeComponent();
        }

        private void Txt_NationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyClasses.FnAcceptDigit(e);
        }
    }
}