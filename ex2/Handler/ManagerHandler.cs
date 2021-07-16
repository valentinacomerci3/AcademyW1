using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Handler
{
    public class ManagerHandler :AbstractHandler
    {

        public override string Handle(double request)
        {
            if (request <= 400)
            {
                return $"{request} approved for manager";
            }
            else
            {
                return base.Handle(request);
            }
        }

    }
}
