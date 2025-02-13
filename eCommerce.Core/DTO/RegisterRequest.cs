namespace eCommerce.Core.DTO;
/// <summary>
/// Create the DTO RegisterRequest class which contains all the registration details
/// </summary>
public record RegisterRequest(
    string? Email,
    string? Password,
    string? UserName,
    GenderOptions Gender
    );

