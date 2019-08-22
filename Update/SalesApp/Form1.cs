using SalesApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buhlergroup.Wcs.Pm.Prd;

namespace SalesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetLists();
        }

        private void GetLists()  //create a sales context
        {
            using (var context = new SalesContext())
            {
                salesPersonBindingSource.DataSource = context.People
                    .Where(e => e.Active)
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName)
                    .ToList();


                salesRegionBindingSource.DataSource = context.Regions
                    .Where(e => e.Active)
                    .OrderBy(e => e.Name)
                    .ToList();
            }
        }

        private void RefreshSalesbutton_Click(object sender, EventArgs e)
        {

      // dll eingebunden var product = Product.CreateAndSave("Test", null);

            //int personId = Convert.ToInt32(PeoplecomboBox.SelectedValue);
          
      
      // new get string from selected item 
            string personFullName = (string) PeoplecomboBox.SelectedValue;

      // using the database context
      using (var context = new SalesContext())
      {
        // new get the personId (from context where Fullname == selected fullname form combobox
        int personId = context.People
            .Where(p => p.FullName == personFullName).First().Id;

        //int regionId = Convert.ToInt32(RegioncomboBox.SelectedValue);
        int regionId = (int)RegioncomboBox.SelectedValue;
           saleBindingSource2.DataSource = context.Sales
              .Where(s => s.PersonId == personId &&
                        s.RegionId == regionId)
              .OrderBy(s => s.Date)
              .ToList();
        }
     

    }


    
    }
}
