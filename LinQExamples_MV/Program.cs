
using LinQExamples_MV.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Linq Examples - Mádi Viktor IR8C7K";

            //--- Where ---
            //new Where().Linq1();

            //--- OrderBy ---
            //new OrderBy().Linq1();
            //new OrderBy().Linq2();
            //new OrderBy().Linq3();
            //new OrderBy().Linq4();

            //--- GroupBy ---
            //new GroupBy().Linq1();
            //new GroupBy().Linq2();
            //new GroupBy().Linq3();

            //--- Count ---
            //new Count().Linq1();
            //new Count().Linq2();
            //new Count().Linq3();

            //--- Sum ---
            //new Sum().Linq1();
            //new Sum().Linq2();
            //new Sum().Linq3();

            //--- Min ---
            //new Min().Linq1();
            //new Min().Linq2();
            //new Min().Linq3();
            //new Min().Linq4();

            //--- Max ---
            //new Max().Linq1();
            //new Max().Linq2();
            //new Max().Linq3();
            //new Max().Linq4();

            //--- Avarage ---
            //new Avarage().Linq1();
            //new Avarage().Linq2();
            //new Avarage().Linq3();

            //--- Aggregate ---
            //new Aggregate().Linq1();
            //new Aggregate().Linq2();

            //--- Concat ---
            //new Concat().Linq1();
            //new Concat().Linq2();

            ////--- EqualAll ---
            //new EqualAll().Linq1();
            //new EqualAll().Linq2();


            //--- Interestings ---
            //new Interestings().Linq1();
            //new Interestings().Linq2();
            //new Interestings().Linq3();

            //--- Join ---
            //new Join().Linq1();
            //new Join().Linq2();
            //new Join().Linq3();

            //--- Any ---
            //new Any().Linq1();
            //new Any().Linq2();


            //--- All ---
            //new All().Linq1();
            //new All().Linq2();


            //--- Range ---
            //new Range().Linq1();


            //--- Repeat ---
            //new Repeat().Linq1();

            //--- Distinc ---
            //new Distinct().Linq1();
            //new Distinct().Linq2();

            //--- Union ---
            new Union().Linq1();
            new Union().Linq2();

            //---Intersect-- -
            new Intersect().Linq1();
            new Intersect().Linq2();


            //---Except-- -
            new Except().Linq1();
            new Except().Linq2();

            Console.ReadKey();
        }
    }

}
