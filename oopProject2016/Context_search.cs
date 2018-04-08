using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace oopProject2016
{
    class Context_search
    {
        search s;
        public Context_search(search s)
        {
            this.s = s;
        }
        public DataTable do_search(string x)
        {
            return s.search(x);
        }
    }
}
