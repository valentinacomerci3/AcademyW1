using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Handler
{
    public class CeoHandler:AbstractHandler
    {
        public override string Handle(double request)
        {
            if (request > 1000 && request <2500)
            {
                return $"{request} approved for ceo";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
