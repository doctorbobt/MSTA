using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableDemo
{
    static class TableUtility
    {
        public static CloudTable AuthTable()
        {
            string accountName = "mstasa";
            string accountKey = "wG6U+c00S8eQbC+1WSVxyuyKXtFg+qkuZ9DJFNtprRYDiGo3wS89jzhV8BuV8LB0YoypQTRnTlweM1iQQJmpeg==";
            try
            {
                StorageCredentials creds = new StorageCredentials(accountName, accountKey);
                CloudStorageAccount account = new CloudStorageAccount(creds, useHttps: true);

                CloudTableClient client = account.CreateCloudTableClient();

                CloudTable table = client.GetTableReference("demoTable");

                return table;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public static bool CreateEntity(string email, string username, CloudTable table)
        {
            var newEntity = new UsernameEntity()
            {
                PartitionKey = "Username",
                RowKey = username,
                Email = email
            };

            TableOperation insert = TableOperation.Insert(newEntity);
            try
            {

                table.Execute(insert);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public static bool DoesUsernameExist(string username, CloudTable table)
        {
            TableOperation entity = TableOperation.Retrieve("Username", username);

            var result = table.Execute(entity);

            if (result.Result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
