using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static WorkingTest.Program.StringsProgram;

namespace WorkingTest
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //StringsProgram sp = new StringsProgram();
            //sp.m1();

            //SumerizationProgram sm = new SumerizationProgram();
            //sm.m2();

            StringBulderProgram sbp = new StringBulderProgram();
            sbp.m3();
        }
    }
}
