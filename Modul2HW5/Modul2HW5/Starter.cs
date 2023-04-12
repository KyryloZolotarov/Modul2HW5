using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW5
{
    internal class Starter
    {
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    var rand = new Random();
                    var methodN = rand.Next(1, 4);
                    if (methodN == 1)
                    {
                        CheckRes(new Actions().Start());
                    }

                    if (methodN == 2)
                    {
                        new Actions().SkippLogic();
                    }

                    if (methodN == 3)
                    {
                        new Actions().BrokeLogic();
                    }
                }
                catch (BusinessException ex)
                {
                    Logger.GetInstance().LogWarning("Action got this custom Exception :" + ex.Message);
                }
                catch (Exception ex)
                {
                    Logger.GetInstance().LogError("Action failed by а reason:" + ex.ToString());
                }
            }
        }

        private void CheckRes(Result result)
        {
            if (result.Status == false)
            {
                Logger.GetInstance().LogError($"Action failed by а reason:{result.Message}");
            }
        }
    }
}
