using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticationTokenGenerator
{
    public static class Generator
    {
        public static string StringGuidGenerator()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }

        public static string StringTokenGenerator(string guid)
        {
            string token = Convert.ToBase64String(Encoding.UTF8.GetBytes(guid));
            return token;
        }
    }
}
