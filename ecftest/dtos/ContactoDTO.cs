using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Wcftest.dtos
{
    [Serializable]
    [DataContract]
    public class ContactoDTO
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
}