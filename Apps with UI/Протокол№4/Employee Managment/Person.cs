using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Windows.Forms.AxHost;

namespace Employee_Managment
{
    internal class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Zip{ get; set; }

        public string Email{ get; set; }

        public string Phone{ get; set; }
    }
   public string GetAddress()
    {
        this.GetAddress =
        return FirstName + ""+LastName +" "+Environment.NewLine+Street + Environment.NewLine + City +" "
        +State +" "+Zip;
    }
   
}
