using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Epos
{
    public partial class CoffeHouseForm : Form
    {
        public static string[] CoffeTypeName = { "Expresso", "Latte", "Americano", "Cappuccino", "Flate White", "Lungo","affogato","Cortado","Irish","Macchiato" };
        public static string[] CoffeSizeName = { "XSmall", "Small", "Medium", "Large", "XLarge"};


        public static decimal[,] CoffePrice = { { 2.10m, 2.40m, 2.60m, 3.20m ,3.30m},
                                                { 3m,3.30m,3.50m,4.10m,4.2m},
                                                 {2.3m,2.6m,2.8m,3.4m,3.5m },
                                                  { 3.1m,3.4m,3.6m,4.2m,4.3m},
                                                   { 3.2m,3.5m,3.7m,4.3m,4.4m},
                                                   { 3m,3.30m,3.50m,4.10m,4.2m} ,
                                                    {3.5m,3.8m,4m,4.6m,4.7m },
                                                    {3.35m,3.65m,3.85m,4.45m,4.45m },
                                                     { 3.15m,3.45m,3.65m,4.25m,4.35m},
                                                     { 3.1m,3.4m,3.6m,4.2m,4.3m} };

        public static string CoffeName, SizeName;
        decimal CoffeCost;

        

        public CoffeHouseForm()
        {
            InitializeComponent();
        }

        public double Items_Cost()
        {
            double TotalSum = 0;
            int i = 0;
            for (i = 0; i < (DisplayDataGridView.Rows.Count) ;
                i++)
            {
                TotalSum = TotalSum + Convert.ToDouble(DisplayDataGridView.Rows[i].Cells[3].Value);
                
            }
            return TotalSum;
         
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Select in DisplayDataGridView.SelectedRows)
            {
      
                    DisplayDataGridView.Rows.RemoveAt(Select.Index);
                

            }
            TotalPurchasesCostLabel.Text = Items_Cost().ToString("C");


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DisplayDataGridView.Rows.Clear();
            DisplayDataGridView.Refresh();
            TotalPurchasesCostLabel.Text = "";
            CoffeSizeListBox.ClearSelected();
            CoffeTypeListBox.ClearSelected();
            QuantityNumericUpDown.Value = 1;
            CoffeTypeListBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AddOrderButton_Click(object sender, EventArgs e)
        {
            int CoffeTypeIndex, CoffeSizeIndex;
            CoffeTypeIndex = CoffeTypeListBox.SelectedIndex;
            CoffeSizeIndex = CoffeSizeListBox.SelectedIndex;
            decimal Quantity = QuantityNumericUpDown.Value;
         
            if (CoffeTypeListBox.SelectedIndex != -1)
            {
                if (CoffeSizeListBox.SelectedIndex != -1)
                {

                    CoffeName = CoffeTypeName[CoffeTypeIndex];
                    SizeName = CoffeSizeName[CoffeSizeIndex];
                    CoffeCost = CoffePrice[CoffeTypeIndex, CoffeSizeIndex];



                    DisplayDataGridView.Rows.Add(CoffeName,SizeName,Quantity,CoffeCost*Quantity);
                   TotalPurchasesCostLabel.Text= Items_Cost().ToString("C");







                }
                else
                {
                    MessageBox.Show("Please Chose Your Coffe Size  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CoffeSizeListBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Chose at less coffe type  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CoffeTypeListBox.Focus();
            }









       
        }

    }

}
