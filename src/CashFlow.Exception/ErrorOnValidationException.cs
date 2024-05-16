using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Exception;
public class ErrorOnValidationException: CashFlowException
{
    public List<string> Errors { get; private set; }

    public ErrorOnValidationException(List<string> errors)
    {
        Errors = errors;
    }
}
