namespace CashFlow.Communication.Responses;

public class ResponseErrorJson
{
    public List<string> ErrorMessages { get; set; }

    public ResponseErrorJson(string errorMessage)
    {//torna obrigatório passar a mensagem de erro ao usar essa classe
        ErrorMessages = [errorMessage];
    }

    public ResponseErrorJson(List<string> errors)
    { //torna obrigatório passar a lista de mensagens de erro ao usar essa classe
        ErrorMessages = errors;
    }
}
