﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Biblio_test
{
    public class Admin :Person
    {
       private string rolle;

       public Admin(string name, string vorname, string email, string foto, string rolle):
       base(name, vorname, email, foto)
       {
            Rolle = rolle;
       }


        public String Rolle
        {
            get
            {
                return rolle;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Rolle darf nicht leer sein");
                }
                else
                {
                    this.rolle = value;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + Rolle;
        }

    }
 
}
