using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        enum pictureType
        {
            BillOfDivorceImageDIR
      , HelpSeekerImageDIR
      , NationalCardImageDIR
      , CaretakerImageDIR
      , BirthCertificateImageDIR
      , LeaseImageDIR
      , DeathCertificateImageDIR
      , EtcImageDIR
        }
        public Frm_Main()
        {
            InitializeComponent();

     

        }

        private void BarButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Service myForm = new frm_Service();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panelControl1.Controls.Add(myForm);
            myForm.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Frm_LoginPage myForm = new Frm_LoginPage();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panelControl1.Controls.Add(myForm);
            myForm.Show();
        }

        private void BarButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Save myForm = new frm_Save();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panelControl1.Controls.Add(myForm);
            myForm.Show();
        }

        private void BarButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Relateds myForm = new Frm_Relateds();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panelControl1.Controls.Add(myForm);
            myForm.Show();
        }

        private void BarButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_accountant myForm = new frm_accountant();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panelControl1.Controls.Add(myForm);
            myForm.Show();
        }

        private void BarButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_AddPictures myForm = new frm_AddPictures();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panelControl1.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
