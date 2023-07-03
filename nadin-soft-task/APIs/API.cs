using DataAccess.Data;
using DataAccess.Models;

namespace nadin_soft_task.APIs
{
    public static class API
    {
        public static void ConfigAPI( this WebApplication app)
        {
            app.MapPost("/Users", AddUser);
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
    }
}
