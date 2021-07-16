using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Handler
{
    public class OpManHandler:AbstractHandler
    {

        public override string Handle(double request)
        {
            if (request > 400 || request<1001)
            {
                return $"{request} approved for Operation Manager";
            }
            else
            {
                return base.Handle(request);
            }
        }

    }
}
