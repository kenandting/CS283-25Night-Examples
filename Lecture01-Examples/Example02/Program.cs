using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementLibrary;

namespace Example02
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Student aStudent = new Student()
            {
                name = "侯建德",
                phone = "0958839890",
                address = "龍華資管"
            };
            Console.WriteLine(
                "學生姓名:{0},電話:{1},地址:{2}"
                , aStudent.name
                , aStudent.phone
                , aStudent.address
               );
        }
    }
}