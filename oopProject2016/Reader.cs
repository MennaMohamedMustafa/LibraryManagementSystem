using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProject2016
{
    class Reader : person
    {
            public List<string> BookList;

            public Reader()
                : base()
            {
               
            }
            public Reader(List<string> BookList, string Name, string PhoneNumber, string Email, string passWord, int ID)
                : base(Name, PhoneNumber, Email, passWord, ID)
            {
                this.BookList = BookList;
            }
       
    }
}
