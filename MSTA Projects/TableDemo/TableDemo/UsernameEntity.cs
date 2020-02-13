using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableDemo
{
    public class UsernameEntity : TableEntity
    {
        public UsernameEntity() { }

        public string Email { get; set; }
    }
}
