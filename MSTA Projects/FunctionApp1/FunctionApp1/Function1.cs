using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using FunctionApp1;

namespace FunctionApp4
{
    public static class HrLeaveRequest2
    {
        [FunctionName("LeaveRequestList2")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req)
        {
            List<LeaveRequest> lst = null;
            string EmployeeId = string.Empty;
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            EmployeeId = data?.employeeId;
            if (EmployeeId != null)
            {
                lst = new List<LeaveRequest>();
                for (int i = 1; i < 4; i++)
                {
                    lst.Add(new LeaveRequest() { 
                        EmployeeId = "10", 
                        Name = $"Employee {i}",
                        From = DateTime.Now.AddDays(-i - 1), 
                        To = DateTime.Now.AddDays(-i) 
                    });
                }
                return (ActionResult)new OkObjectResult(lst);
            }
            return new BadRequestObjectResult("Please pass a employee Id in the request body");
        }
    }
}
