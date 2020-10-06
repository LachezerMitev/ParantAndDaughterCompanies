using System;
using System.Collections.Generic;
using System.Text;

namespace ParentAndDaughterCompany
{
    class Company
    {
        public Company(string name)
        {
            this.name = name;
            this.Companies = new List<Company>();
        }

        public string name { get; set; }

        public List<Company> Companies { set; get; }
    }
}
