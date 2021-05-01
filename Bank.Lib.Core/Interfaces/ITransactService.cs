using Bank.Lib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Lib.Core.Interfaces
{
    public interface ITransactService
    {
        void AddTranHistory(List<string> details);
        List<string[]>GetTranHistory(string acctNumber);
    }
}
