using System;
using CleanArchitecture.Application.Common.Interfaces.Authentication;

namespace CleanArchitecture.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Login(string username, string password)
    {
        // Check if user already exists
        
        // Create user (generate unique ID)
        
        // Create JWT Token
       return new AuthenticationResult(Guid.NewGuid(),"Devy","Priatama","devy.priatama@outlook.com","AMD12345");
    }

    public AuthenticationResult Register(string firstname, string lastname, string email, string password)
    {
        // Check if user already exists
        
        // Create user (generate unique ID)
        
        // Create JWT Token
        Guid userId = Guid.NewGuid();

        var token = _jwtTokenGenerator.GenerateToken(userId, firstname, lastname);

        return new AuthenticationResult(userId,"Devy","Priatama","devy.priatama@outlook.com",token);
    }
}
    