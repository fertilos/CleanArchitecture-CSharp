namespace CleanArchitecture.Application.Services.Authentication;


public interface IAuthenticationService
{
    AuthenticationResult Login(string username, string password);
    AuthenticationResult Register(string firstname, string lastname, string email, string password);
}