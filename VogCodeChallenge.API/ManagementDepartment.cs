using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API
{
    public class ManagementDepartment
    {
        int id = 122333;
        string firstName, lastName, jobTitle, Adress;

        public ManagementDepartment()
        {
            firstName = "";
            lastName = "";
            jobTitle = "";
            Adress = "";

        }

        public ManagementDepartment(string fname, string lname, string jtitle, string adress)
        {

            firstName = fname;
            lastName = lname;
            jobTitle = jtitle;
            Adress = adress;

        }



    }

}
