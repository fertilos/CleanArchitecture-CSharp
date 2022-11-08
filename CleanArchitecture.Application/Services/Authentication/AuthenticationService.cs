namespace CleanArchitecture.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string username, string password)
    {
       return new AuthenticationResult(Guid.NewGuid(),"","","","");
    }

    public AuthenticationResult Register(string firstname, string lastname, string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(),"","","","");
    }
}
    