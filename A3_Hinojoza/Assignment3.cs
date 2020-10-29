using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
/*Assigment 3
 * Jose hinojoza
 * Programm keeps track of the vehicle in txt file
 * 9/22/2020
 * 
 */
namespace A3_Hinojoza
{
    public partial class Assignment3 : Form
    {

        //create a list to remember the cars in stock
        private List<vehicle> vehicleLog = new List<vehicle>();
        
        public Assignment3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//reading the file correctly and making vehicle elements
        {
            //read in file
            //the file provides strings, year, mileage, make, model
            using (StreamReader fileIn = File.OpenText("vehicles.txt"))
            {
                String line = fileIn.ReadLine(); //define line to break apart
                while (line != null)
                {
                    if (line != "")
                    {
                        String[] lineArray = line.Split(' ');
                        //parse and set parameter values
                        double year = double.Parse(lineArray[0]);
                        double mileage = double.Parse(lineArray[1]);
                        String makeAndmodel = lineArray[2] + " " + lineArray[3];
                        
                        vehicleLog.Add(new vehicle(year, mileage, makeAndmodel));                                           
                    }                     
                    line = fileIn.ReadLine();
                }               
            }   
            CreateMakeandModelLabel();
            CreateYearLabel();
            CreateMileageTxt();
        }


        private void CreateMileageTxt()
        {          
            int txtBoxTop = 97;
            foreach (vehicle item in vehicleLog)
            {
                //Console.WriteLine(item.getMakeAndModel() + " " + item.getYear() + " " + item.getMileage());
                
                TextBox txtMileage = new TextBox();
                txtMileage.Location = new System.Drawing.Point(204, txtBoxTop);
                txtMileage.Name = "textBox1";
                txtMileage.Size = new System.Drawing.Size(100, 20);
                txtMileage.TabIndex = 8;
                txtMileage.Text = item.getMileage().ToString();
                
                this.Controls.Add(txtMileage);
                item.setTxtMileage(txtMileage);
                txtBoxTop += 20;
            }
        }

        private void CreateMakeandModelLabel()
        {
            int lblTop = 100;
            foreach (vehicle item in vehicleLog)
            {
                //Console.WriteLine(item.getMakeAndModel() + " " + item.getYear() + " " + item.getMileage());
                Label lblMakeModel = new Label();
                lblMakeModel.AutoSize = true;
                lblMakeModel.Location = new System.Drawing.Point(12, lblTop);
                lblMakeModel.Name = "lblVehicle";
                lblMakeModel.Size = new System.Drawing.Size(87, 13);
                lblMakeModel.TabIndex = 2;
                lblMakeModel.Text = "";

                lblMakeModel.Text += item.getMakeAndModel();
                if (item.getMileage() > 100000)
                {
                    lblMakeModel.BackColor = System.Drawing.Color.Yellow;
                }
                this.Controls.Add(lblMakeModel);
                lblTop += 20;
            }
        }
        private void CreateYearLabel()
        {
            int lblTop = 100;
            foreach (vehicle item in vehicleLog)
            {
                Label lblYear = new Label();

                lblYear.AutoSize = true;
                lblYear.Location = new System.Drawing.Point(138, lblTop);
                lblYear.Name = "lblVehicle";
                lblYear.Size = new System.Drawing.Size(87, 13);
                lblYear.TabIndex = 2;
                lblYear.Text = "";

                lblYear.Text += item.getYear();
                if (item.getMileage() > 100000)
                {
                    lblYear.BackColor = System.Drawing.Color.Yellow;
                }
                this.Controls.Add(lblYear);
                lblTop += 20;
            }
        }

        private void btnLowestMileage_Click(object sender, EventArgs e)
        {
            double lowMileage = Double.MaxValue;
            String lowMileageCar = "";
            foreach (vehicle item in vehicleLog)
            {
                if(lowMileage > double.Parse(item.gettxtMileage().Text))
                {
                    lowMileage = double.Parse(item.gettxtMileage().Text);
                    lowMileageCar = "The car with the lowest miles is a " + item.getMakeAndModel() + " " + item.getYear() + " with " + item.gettxtMileage().Text + " miles.";
                }
            }
            MessageBox.Show(lowMileageCar);
        }

        private void btnAvgFordMileage_Click(object sender, EventArgs e)
        {
            double i = 0;
            double mileageSum = 0;
            foreach (vehicle item in vehicleLog)
            {
                if(item.getMakeAndModel().StartsWith("Ford"))
                {
                    mileageSum += double.Parse(item.gettxtMileage().Text);
                    i++;
                }
            }
            double avgFordMileage = (mileageSum / i);
            MessageBox.Show("The average Ford mileage is " + avgFordMileage + " miles (" + i + " cars total).");
            
        }
 
    }
}
