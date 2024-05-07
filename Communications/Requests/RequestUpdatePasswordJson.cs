namespace MyFirstApi.Communications.Requests;

public class RequestUpdatePasswordJson
{
    public string CurrentPassword { get; set; } = string.Empty;
    public string NewPassword { get; set; } = string.Empty;
}
