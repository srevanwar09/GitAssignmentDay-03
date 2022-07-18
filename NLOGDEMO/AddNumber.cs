using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo
{
    internal class AddNumber
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static int Sum(int firstNum, int secondNum)
        {

            if (firstNum == 0 || secondNum == 0)
            {
                logger.Debug("Debug successful and we are inside Sum() of AddNumber");
                logger.Error("None of the input parameters should be zero");
                logger.Warn("In order to add number, it doesn't make sense to add with zero");
            }
            int sumOfTwoNumbers = firstNum + secondNum;
            logger.Debug("Sum method executed");
            logger.Info("Sum method added numbers and executed successfully");
            return sumOfTwoNumbers;
        }
    }
}
