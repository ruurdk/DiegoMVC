using System;
using System.Collections.Generic;
using System.Linq;

namespace DiegoMVC.Web.Models
{
    public class EnvironmentModel
    {
        public Guid ApplicationId { get; set; }
        public IEnumerable<KeyValuePair<string, string>> Variables { get; set; }       
    }
}