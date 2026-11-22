using System.ComponentModel;

namespace MVCProject849.Model_Views
{
    public class senddata
    {
        //string name, string email,string age, string address,string phone4


        [DisplayName("Student Name")]
        public string name { get; set; }

        [DisplayName("Student Email")]
        public string email { get; set; }

        [DisplayName("Student Age")]
        public int age { get; set; }
        
        [DisplayName("Student Address")]
        public string address { get; set; }

        [DisplayName("Student Phone")]
        public string phone { get; set; }

        [DisplayName("Student Code")]
        public Boolean code { get; set; }

        //



    }
}
