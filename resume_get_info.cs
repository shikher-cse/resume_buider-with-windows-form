using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monday_resumebuilder
{
    class resume_get_info



    {       
        public  string surname { get; set; }

        public string firstname { get; set; }
        public string  permanent_address { get; set; }
        public int  phone_number { get; set; }
        //public int  dob { get; set; }
        //public  DateTime? dob { get; set; }
        //public DateTime? uni_from { get; set; }
        //public  DateTime? uni_to { get; set; }
        public string high_school { get; set; }
        public string sec_school{ get; set; }

        public string uni         { get; set; }
        public  string gender      { get; set; }
        public  string  martial_status { get; set; } 
        

        public  string status_of_uni { get; set; }       
        public  string pincode_permanent { get; set; }
        public  string pincode_highschool { get; set; }
        public  string pincode_secschool { get; set; }
        public  string pincode_university { get; set; }

        public  string  industrial_training { get; set; }
        public  string  certifications { get; set; }
        public  string linkedin         { get; set; }
        public  string  current_ogpa { get; set; }
        public  string extra_information { get; set; }
        public  byte image { get; set; }




    }
}
