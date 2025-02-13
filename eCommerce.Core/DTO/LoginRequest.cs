namespace eCommerce.Core.DTO;
/// <summary>
/// Create the DTO LoginRequest class which contains all the details of the user login
/// To see what reocords and DTO are see the Documentation document
/// </summary>
/// <param name="Email"></param>
/// <param name="Password"></param>
public record LoginRequest (
    string? Email,
    string? Password
    );

