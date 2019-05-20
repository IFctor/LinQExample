using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class Aggregate
    {
        /// <summary>
        /// ------------------------------
        /// ----- Result of example  -----
        /// -----        MV          -----
        /// ------------------------------
        /// 1.7                           =   1.7
        /// 1.7 * 2.3                     =   3.91
        /// 1.7 * 2.3 * 1.9               =   7.429
        /// 1.7 * 2.3 * 1.9 * 4.1         =   30.4589
        /// 1.7 * 2.3 * 1.9 * 4.1 * 2.9   =   88.33081
        /// </summary>
        public void Linq1()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

            Console.WriteLine("Total product of all numbers: {0}", product);
        }
        /// <summary>
        /// ------------------------------
        /// ----- Result of example  -----
        /// -----        MV          -----
        /// ------------------------------
        ///100,(20,0)    -> 0    <=  20   -> (100-20)=80  
        ///100,(80,10)   -> 10   <=  20   -> (80-10)=70  
        ///100,(70,40)   -> 40   <=  70   -> (70-40)=30  
        ///100,(30,50)   -> 50   <=  30   -> 30  
        ///100,(30,10)   -> 10   <=  30   -> (30-10)=20 
        ///100,(20,70)   -> 70   <=  20   -> 20
        ///100,(20,30)   -> 30   <=  20   -> 20
        /// </summary>
        public void Linq2()
        {

            double startBalance = 100.0;

            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

            double endBalance =
                attemptedWithdrawals.Aggregate(startBalance,
                    (balance, nextWithdrawal) =>
                        ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));

            Console.WriteLine("Ending balance: {0}", endBalance);
        }
    }
}
