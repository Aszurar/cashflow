using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Exception;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseUseCase
{
    public ResponseRegisteredExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        Validate(request);

        var response = new ResponseRegisteredExpenseJson();
        return response;
    }

    private void Validate(RequestRegisterExpenseJson request)
    {
        var validator = new RegisterExpenseValidator();

        var validationResult = validator.Validate(request);

        if(validationResult.IsValid == false)
        {
            var errorsMessage = validationResult.Errors.Select(error => error.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errorsMessage);
        }

   
    }
}
