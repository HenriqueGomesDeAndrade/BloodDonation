using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Domain.Result
{
    public class Result<T>
    {
        private Result(T value)
        {
            IsSuccessful = true;
            Value = value;
            StatusCode = ResultStatusCodeEnum.Ok;
        }

        private Result(ResultError error, ResultStatusCodeEnum statusCode)
        {
            IsSuccessful = false;
            Error = error;
        }

        public bool IsSuccessful { get; private set; }
        public T Value { get; set; }
        public ResultError Error { get; private set; }
        public ResultStatusCodeEnum StatusCode { get; set; }

        public Result<T> Success(T value) => new Result<T>(value);
        public Result<T> Failure(ResultError error, ResultStatusCodeEnum statusCode = ResultStatusCodeEnum.BadRequest) => new Result<T>(error, statusCode);
        public object GetFinalObject() => IsSuccessful ? Value : Error;
    }
}
