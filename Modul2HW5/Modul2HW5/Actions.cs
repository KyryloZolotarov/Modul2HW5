using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW5
{
    internal class Actions
    {
        public Result Start()
        {
            Logger.GetInstance().LogInfo($"Start method: Start");
            var res = new Result();
            res.Status = true;
            return res;
        }

        public void SkippLogic()
        {
            throw new BusinessException("Skipped logic in method: SkippLogic");
        }

        public void BrokeLogic()
        {
            throw new Exception("I broke a logic");
        }
    }
}
