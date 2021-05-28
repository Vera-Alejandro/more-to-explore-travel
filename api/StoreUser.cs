using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace api
{
    public static class StoreUser
    {
        [FunctionName("AddToNotificationList")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]
            HttpRequest req, ILogger log, ExecutionContext context)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(context.FunctionAppDirectory)
                .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            string conn_str = config["SQLConnectionString"];

            if (string.IsNullOrEmpty(conn_str))
            {
                log.LogError("-!!!!-----There was an issue with getting the connection string.");
            }

            using (SqlConnection conn = new SqlConnection(conn_str))
            {
                conn.Open();

                var text_cmd = $"INSERT INTO EmailList VALUES ('Ale at {DateTime.Now}', 'alejandro@google.com');";

                using (SqlCommand cmd = new SqlCommand(text_cmd, conn))
                {
                    var rows = await cmd.ExecuteNonQueryAsync();

                    log.LogInformation($"{rows} rows were inserted!");

                    return new OkObjectResult($"Hello, Alejandro, \ndata has been inserted.");
                }
            }
        }
    }
}