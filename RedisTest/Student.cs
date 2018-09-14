using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedisTest
{
    public class Student
    {
        string name;
        int age;
        int sex;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Sex
        {
            get { return sex; }
            set { sex = value; }
        }
    }
}