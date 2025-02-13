using eCommerce.Core.DTO;
namespace eCommerce.Core.ServiceContracts;
/// <summary>
/// Contract for users service that contains use cases for users
/// </summary>
public interface IUsersService
{
    /// <summary>
    /// Method to handle user login use case and reutrns an AuthenticationResponse (DTO) object that contains status of login
    /// </summary>
    /// <param name="loginRequest"></param>
    /// <returns></returns>
    Task<AuthenticationResponse> Login(LoginRequest loginRequest);

    /// <summary>
    /// Method handle user registrations and returns an object of AuthenticatonResponse (DTO) type that represents statu of user registration
    /// </summary>
    /// <param name="registerRequest"></param>
    /// <returns></returns>
    Task<AuthenticationResponse> Register(RegisterRequest registerRequest);

}
