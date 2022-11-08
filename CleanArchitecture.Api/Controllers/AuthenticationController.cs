using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Contracts.Authentication.Request;
using CleanArchitecture.Application.Services.Authentication;
using CleanArchitecture.Contracts.Authentication.Response;

namespace CleanArchitecture.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticatedController: ControllerBase
{
    private readonly IAuthenticationService _authService;

    public AuthenticatedController(IAuthenticationService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResult = _authService.Register(request.FirstName, request.LastName, request.Email, request.Password);
        var response = new AuthenticationResponse(
                authResult.Id,
                authResult.FirstName,
                authResult.LastName,
                authResult.Email,
                authResult.Token
        );
       return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _authService.Login(request.Email, request.Password);
        var response = new AuthenticationResponse(
                authResult.Id,
                authResult.FirstName,
                authResult.LastName,
                authResult.Email,
                authResult.Token
        );
       return Ok(response);
    }
}