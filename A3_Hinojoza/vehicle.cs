using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_Hinojoza
{
    class vehicle
    {
        private String makeAndmodel;
        private double mileage, year;
        private TextBox txtMileage;
        
        //create constructor based on parameters
        public vehicle(double year, double mileage, String makeAndmodel)
        {  
            this.year = year;
            this.mileage = mileage;
            this.makeAndmodel = makeAndmodel;
        }

        //set getters
        public double getMileage()
        {
            return mileage;
        }
        public double getYear()
        {
            return year;
        }
        public String getMakeAndModel()
        {
            return makeAndmodel;
        }
        public TextBox gettxtMileage()
        {
            return txtMileage;
        }

        //set setters
        public void setMileage(double newMileage)
        {
            mileage = newMileage;
        }
        public void setYear(double newYear)
        {
            year = newYear;
        }
        public void setMake(string newMakeAndModel)
        {
            makeAndmodel = newMakeAndModel;
        }
        public void setTxtMileage(TextBox newtxtMileage)
        {
            txtMileage = newtxtMileage;
        }
        
    }
}
