using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var result in logics)
            {
                if (!result.IsSuccess)
                {
                    return result;
                }
            }
            return new SuccessResult();
        }
    }
}