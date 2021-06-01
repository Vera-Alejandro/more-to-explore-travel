using System;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace api
{
    public static class StoreUser
    {
        [FunctionName("AddToNotificationList")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "GET", "POST", Route = null)]
            HttpRequest req, ILogger log, ExecutionContext context)
        {

            string conn_str = "Server=tcp:skynet-wopr.database.windows.net,1433;Initial Catalog=santa;Persist Security Info=False;User ID=heheman;Password=kE19w&nK7i4p0OP7ERtA;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            if (string.IsNullOrEmpty(conn_str))
            {
                log.LogError("-!!!!-----There was an issue with getting the connection string.");
                return new BadRequestErrorMessageResult("Connection String Error");
            }

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            UserToNotify user = JsonConvert.DeserializeObject<UserToNotify>(requestBody);


            try
            {
                using (SqlConnection conn = new SqlConnection(conn_str))
                {
                    conn.Open();

                    var query = "INSERT INTO EmailList VALUES (@fullName, @emailAddress, @insertDate);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fullName", user.FullName);
                        cmd.Parameters.AddWithValue("@emailAddress", user.EmailAddress);
                        cmd.Parameters.AddWithValue("@insertDate", DateTime.Now.ToLocalTime());

                        var rows = await cmd.ExecuteNonQueryAsync();
                        
                        log.LogInformation($"{rows} rows were inserted!");

                        return new OkObjectResult($"Hello, Alejandro, \ndata has been inserted.");
                    }
                }
            }
            catch (Exception e)
            {
                log.LogError($"There was an error when writing to the db: {e}-");
                return new InternalServerErrorResult();
            }
        }
    }

    public class UserToNotify
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
    }
}