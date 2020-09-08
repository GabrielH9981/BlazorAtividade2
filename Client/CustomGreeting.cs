using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorApp.Client.Helpers
{
    public class CustomGreeting
    {
        public static string customGreeting(string value)
        {
            return value.ToUpper() + " hoje é " + DateTime.Today;
        }
    }
}