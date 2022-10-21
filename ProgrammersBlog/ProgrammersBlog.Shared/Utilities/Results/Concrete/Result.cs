using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;

namespace ProgrammersBlog.Shared.Utilities.Results.Concrete
{
    public class Result:IResult
    {
        public Result(ResultStatus resultStatus)
        {
            Resultstatus = resultStatus;
        }
        public Result(ResultStatus resultStatus,string message)
        {
            Resultstatus = resultStatus;
            Message = message;
        }
        public Result(ResultStatus resultStatus, string message,Exception exception)
        {
            Resultstatus = resultStatus;
            Message = message;
            Exception = exception;
        }
        public ResultStatus Resultstatus { get; }
        public string Message { get; }
        public Exception Exception { get; }
    }
}
