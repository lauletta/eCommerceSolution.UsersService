﻿using Dapper;
using eCommerce.Core.DTO;
using eCommerce.Core.Entities;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.DbContext;

namespace eCommerce.Infrastructure.Repositories;
internal class UsersRepository : IUsersRepository
{
    private readonly DapperDbContext _dbContext;
    public UsersRepository(DapperDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<ApplicationUser?> AddUser(ApplicationUser user)
    {
        //Generate a new unique user ID for the user
        user.UserId = Guid.NewGuid();

        //SQL query to insert user data unto the "Users" table.
        string query = "INSERT INTO public.\"Users" +
            "\"(\"UserID\", \"Email\", \"Username\", \"Gender\", \"Password\") " +
            "VALUES(@UserID, @Email, @Username, @Gender, @Password)";

       int rowCountAffectec = await _dbContext.DbConnection.ExecuteAsync(query, user);

        if (rowCountAffectec > 0)
        {
            return user;
        } else
        {
            return null;
        }
    }

    public async Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password)
    {

        //SQL query to select a user by Email and password
        string query = "SELECT * FROM public.\"Users\" WHERE \"Email\"=@Email AND \"Password\"=@Password";

        var parameters = new { Email = email, Password = password };

        ApplicationUser? user = await _dbContext.DbConnection.QueryFirstOrDefaultAsync<ApplicationUser>(query, parameters);

        return user;
    }
}
