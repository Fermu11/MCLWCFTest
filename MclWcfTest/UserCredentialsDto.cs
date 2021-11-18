using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MclWcfTest
{
    [DataContract]
    public class UserCredentialsDto
    {
        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}