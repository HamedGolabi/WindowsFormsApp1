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
using System.Data.Entity;

namespace WindowsFormsApp1
{
    public partial class frm_accountant : DevExpress.XtraEditors.XtraForm
    {
        CharityEntities4 db = new CharityEntities4();
        public frm_accountant()
        {
            InitializeComponent();

        }

        void fn_FillPerson()
        {

            WindowsFormsApp1.CharityEntities4 dbContext = new WindowsFormsApp1.CharityEntities4();
            dbContext.tbl_Accountant.LoadAsync().ContinueWith(loadTask =>
            {//.OrderByDescending(x=>x.id)
                gridControl1.DataSource = dbContext.tbl_Accountant.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            //this.tbl_AccountantTableAdapter.Fill(this.charityDataSet.tbl_Accountant);
        }
        private void DateTimeSelector9_Click(object sender, EventArgs e)
        {

        }

        private void GridControl1_Click(object sender, EventArgs e)
        {



        }

        private void frm_accountant_Load(object sender, EventArgs e)
        {

        }

        tbl_Accountant My_Accountant = new tbl_Accountant();

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (
                txt_NationalCode.Text.Length > 0 //&&
                                             //txt_AbsentNo.Text.Length > 0  
                )
            {
                tbl_Accountant My_Accountant = new tbl_Accountant()
                {
                    FoodBasketCosts = int.Parse(txt_FoodBasket.Text),
                    StationaryCosts = int.Parse(txt_Stationary.Text),
                    ClothCosts = int.Parse(txt_Cloth.Text),
                    ShoeCosts = int.Parse(txt_Shoe.Text),
                    BagCosts = int.Parse(txt_Bag.Text),
                    ScholarshipCosts = int.Parse(txt_Scholarship.Text),
                    TrainingClassesCosts = int.Parse(txt_TrainingClasses.Text),
                    PicnicAndOccasionsCosts = int.Parse(txt_PicnicAndOccasions.Text),
                    GiftsCosts = int.Parse(txt_Gifts.Text),
                    InspectionsCosts = int.Parse(txt_Inspections.Text),
                    GrantsCosts = int.Parse(txt_Grants.Text),
                    LoanCosts = int.Parse(txt_Loan.Text),
                    TreatmentAndMedicineCosts = int.Parse(txt_TreatmentAndMedicine.Text),
                    DowryAllowanceCosts = int.Parse(txt_DowryAllowance.Text),
                    QuitAddictionCosts = int.Parse(txt_QuitAddiction.Text),
                    OfficialAndPersonnelCosts = int.Parse(txt_OfficialAndPersonnel.Text),
                    EtcCosts = int.Parse(txt_Etc.Text),
                    Descriptions = rtx_Des.Text,

                   

                };






                db.tbl_Accountant.Add(My_Accountant);
                db.SaveChanges();
                fn_FillPerson();
            }
            else
            {
                MessageBox.Show("مقادیر کامل نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
    
}