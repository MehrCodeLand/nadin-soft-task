using DataAccess.Data;
using DataAccess.Models;

namespace nadin_soft_task.APIs
{
    public static class API
    {
        public static void ConfigAPI( this WebApplication app)
        {
            app.MapPost("/Users", AddUser);
            app.MapDelete("/Users", DeleteUser);
            app.MapGet("/Users", GetAllUsers);
        }


        private static async Task<IResult> GetAllUsers(IUserData data)
        {
            try
            {
                return Results.Ok(await data.GetAllUser());
            }catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> AddUser(User user , IUserData data)
        {
            try
            {
                await data.AddUser(user);
                return Results.Ok();
            }catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static IResult DeleteUser(int id , IUserData data)
        {
            try
            {
                data.DeleteUser(id);
                return Results.Ok();
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
