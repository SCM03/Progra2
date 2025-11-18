using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WeBcalculadora
{
    public class ClsCheckbox
    {
        private float num1 { get; set; }
        private float num2 { get; set; }

        public ClsCheckbox(float n1, float n2)
        {
            num1 = n1;
            num2 = n2;
        }

        // getter y setter

        public float Num1
        {
            get { return num1; }  // getter 
            set { num1 = value; }  //Setter
        }
        public float Num2
        {
            get { return num2; }  // getter 
            set { num2 = value; }  //Setter
        }


        public float sumar()
        {
            return num1 + num2;
        }
        public float restar()
        {
            return num1 - num2;
        }
    }
}