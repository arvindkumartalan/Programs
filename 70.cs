using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Properties
    {
        private int _empNo;
        private string _empName;
        private float _empSalary;

        public int EmpNo
        {
            set
            {
                _empNo = value;
            }
            get
            {
                return _empNo;
            }
        }
        public string EmpName
        {
            set
            {
                _empName = value;
            }
            get
            {
                return _empName;
            }
        }
        public float EmpSalary
        {
            set
            {
                _empSalary = value;
            }
            get
            {
                return _empSalary;
            }
        }

    }
    class Demo
    {
        public static void Main(string[] args)
        {
            Properties properties = new Properties();
            properties.EmpNo = 1105;
            properties.EmpName = "Arvind Kumar Talan";
            properties.EmpSalary = 13980;
            Console.ReadLine();
        }
    }
}
