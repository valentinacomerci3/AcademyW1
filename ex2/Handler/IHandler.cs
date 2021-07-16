using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Handler
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler); //set next anello 
        string Handle(double request); //request handler
    }
}
