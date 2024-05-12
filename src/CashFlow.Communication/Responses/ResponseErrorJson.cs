namespace CashFlow.Communication.Responses;

public class ResponseErrorJson
{
    public string ErrorMessage { get; set; } = string.Empty;

    public ResponseErrorJson(string errorMessage)
    {//torna obrigatório passar a mensagem de erro ao usar essa classe
        ErrorMessage = errorMessage;
    }
}
