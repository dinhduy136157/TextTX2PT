using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TextTX2PT
{
    public class Nhanvien
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }

        public string address { get; set; }

        public string email { get; set; }

        public int title { get; set; }

        public Nhanvien()
        {

        }

        public Nhanvien(int id, string name, string gender, string address, string email, int title)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.address = address;
            this.email = email;
            this.title = title;
        }
    }
}