namespace CleanArchitecture.Contracts.Authentication.Request;

public record LoginRequest(
    string Email,
    string Password
);
