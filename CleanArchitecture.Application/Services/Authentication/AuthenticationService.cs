using System;

namespace CleanArchitecture.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string username, string password)
    {
       return new AuthenticationResult(Guid.NewGuid(),"Devy","Priatama","devy.priatama@outlook.com","AMD12345");
    }

    public AuthenticationResult Register(string firstname, string lastname, string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(),"Devy","Priatama","devy.priatama@outlook.com","AMD12345");
    }
}
    