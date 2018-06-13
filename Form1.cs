using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BikePartManager
{
    public partial class Form1 : Form
    {

        public BikePart partToAdd { get; set; }
        public BikePart selectedPart { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {


            if (File.Exists(BikePartList.serializeFile))
            {

                BikePartList.loadPartList();
                Console.WriteLine("LOAD");
                updatePartListBox();

            }

            else
            {

                MessageBox.Show("Please verify 'partlist.bin' is present.");

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(ebayPriceBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numbers.");
                ebayPriceBox.Text = ebayPriceBox.Text.Remove(ebayPriceBox.Text.Length - 1);
            }


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void addPartButton_Click(object sender, EventArgs e)
        {

            if (PartNameBox.Text.Length < 3)
            {

                MessageBox.Show("Please enter at least 3 characters for a name.");
                return;

            }

            if (PartTypeDropDown.Text.Length < 3)
            {

                MessageBox.Show("Please select a type.");
                return;

            }

            if (YearsDropdown.Text.Length < 3)
            {

                MessageBox.Show("Please select a manufacturing timeline.");
                return;

            }

            if (MfgDropDown.Text.Length < 4 )
            {

                MessageBox.Show("Please select a manufacturer.");
                return;

            }

            partToAdd = new BikePart(PartNameBox.Text, PartTypeDropDown.Text, MfgDropDown.Text, YearsDropdown.Text, float.Parse(ebayPriceBox.Text));

            BikePartList.AddPart(partToAdd);

            updatePartListBox();
            PartListBox.Update();

            PartListBox.SelectedIndex = PartListBox.Items.Count - 1;

            Console.WriteLine(BikePartList.PartList.Count);
            Console.WriteLine("Part LBox: " + PartListBox.Items.Count);

        }

        private void AvgSaleReturn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            selectedPart = (BikePart) PartListBox.SelectedItem;

            if (selectedPart == null)
            {

                return;

            }

            else
            {

                // Change Brk Even

                double brkEv = Math.Ceiling(Double.Parse(initInv.Text) / selectedPart.price);

                brkEvenCount.Text = brkEv.ToString();

                // Other

                PartNameBox.Text = selectedPart.name;
                PartTypeDropDown.Text = selectedPart.type;
                YearsDropdown.Text = selectedPart.years;
                MfgDropDown.Text = selectedPart.mfg;
                ebayPriceBox.Text = Math.Round(selectedPart.price, 2).ToString();

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            BikePartList.PartList.Sort((x,y) => string.Compare(x.name, y.name)) ;
            updatePartListBox();

        }

        private void updatePartButton_Click(object sender, EventArgs e)
        {

            if ( selectedPart == null )
            {

                return;

            }

            selectedPart.name = PartNameBox.Text;
            selectedPart.type = PartTypeDropDown.Text;
            selectedPart.years = YearsDropdown.Text;
            selectedPart.mfg = MfgDropDown.Text;
            selectedPart.price = float.Parse(ebayPriceBox.Text);

            selectedPart.updateDisplay();

            updatePartListBox();


        }

        private void delPartButton_Click(object sender, EventArgs e)
        {

            BikePartList.RemPart(selectedPart);

            updatePartListBox();

            Console.WriteLine(BikePartList.PartList.Count);
            Console.WriteLine("Part LBox: "+PartListBox.Items.Count);

        }

        private void updatePartListBox()
        {

            PartListBox.DataSource = null;
            PartListBox.DataSource = BikePartList.GetPartList();
            PartListBox.DisplayMember = "display";
            

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            BikePartList.PartList.Sort((x, y) => string.Compare(x.type, y.type));
            updatePartListBox();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            BikePartList.PartList.Sort((x, y) => string.Compare(x.mfg, y.mfg));
            updatePartListBox();

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            BikePartList.PartList.Sort((x, y) => string.Compare(x.years, y.years));
            updatePartListBox();

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            BikePartList.PartList.Sort((x, y) => string.Compare(x.name, y.name));
            updatePartListBox();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            string avgType = typeFetchAvg.Text;
            string avgMfg = mfgFetchAvg.Text;
            string avgYear = yearFetchAvg.Text;

            bool checkType = false;
            bool checkMfg = false;
            bool checkYear = false;

            checkType = (typeFetchAvg.Text.Length > 3) ? true : false;
            checkMfg = (mfgFetchAvg.Text.Length > 3) ? true : false;
            checkYear = (yearFetchAvg.Text.Length > 3) ? true : false;

            List<string> fieldsToCheck = new List<string>();


            if (checkType)
            {

                fieldsToCheck.Add(avgType);

            }

            if (checkMfg)
            {

                fieldsToCheck.Add(avgMfg);

            }

            if (checkYear)
            {

                fieldsToCheck.Add(avgYear);

            }


            List<dynamic> listToAvg = new List<dynamic>();

            foreach ( dynamic x in BikePartList.PartList)
            {

                int matchedFields = 0;

                for (int num = 0; num < fieldsToCheck.Count; num++)
                {

                    if( x.type == fieldsToCheck[num])
                    {

                        matchedFields += 1;

                    }

                    if (x.mfg == fieldsToCheck[num])
                    {

                        matchedFields += 1;

                    }

                    if (x.years == fieldsToCheck[num])
                    {

                        matchedFields += 1;

                    }

                    if (matchedFields == fieldsToCheck.Count)
                    {

                        listToAvg.Add(x);

                    }

                }

            }

            float totalInList = listToAvg.Count;
            float totalToAvg = 0;

            foreach (dynamic x in listToAvg)
            {

                totalToAvg += x.price;

            }

            double avgSale = Math.Round(totalToAvg / totalInList, 2);

            if (double.IsNaN(avgSale))
            {

                avgSale = 0;

            }

            avgBreakEven.Text = (Math.Ceiling(Double.Parse(initInv.Text) / avgSale)).ToString();

            AvgSaleReturn.Text = avgSale.ToString();


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            BikePartList.savePartList();

        }

        private void PartNameBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(ebayPriceBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numbers.");
                ebayPriceBox.Text = ebayPriceBox.Text.Remove(ebayPriceBox.Text.Length - 1);
            }


            try
            {

                avgBreakEven.Text = (Math.Ceiling(Double.Parse(initInv.Text) / Double.Parse(AvgSaleReturn.Text))).ToString();

            }

            catch
            {

                Console.WriteLine("ERR: 001 : Object for averaging not ready (Insignificant Error)");

            }

            try
            {

                brkEvenCount.Text = (Math.Ceiling((selectedPart.price / Double.Parse(initInv.Text)))).ToString();

            }

            catch
            {

                Console.WriteLine("ERR: 002 : Object for averaging not ready (Insignificant Error)");

            }

            
        }

        private void ebaySalePriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
