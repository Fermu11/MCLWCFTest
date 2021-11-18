using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MclWcfTest
{
    [DataContract]
    public class LoginResultDto
    {
        [DataMember]
        public bool LoginSuccess { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }
    }
}