using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace oopProject2016
{
    public class Request
    {
    public  int ID;
    public  int ISBN;
     public  string Request_Date;
     
      public Request()
        {
            ID = 0;
            ISBN = 0;
            Request_Date= " ";
           
        }
      public Request(int ID, int ISBN, string Request_Date)
      {
          this.ID = ID;
          this.ISBN = ISBN;
          this.Request_Date = Request_Date;
      }
          void request ()
          {
             
          }
        }
    }

