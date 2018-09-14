using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RedisTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /**/
            List<Student> list = new List<Student>();
            Student stu1 = new Student { 
                Name = "dancer",
                Age = 29,
                Sex = 1
            };
            list.Add(stu1);
            Student stu = new Student { 
                Name = "ann",
                Age = 2,
                Sex = 1
            };
            list.Add(stu);

            Redis r = new Redis();
            r.Set("stu_list", list);
            object oo = r.Get("stu_list");
            Response.Write(oo);
            
        }
    }
}