using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person.Models
{
    public record PersonRequest(string name, string gender, string document, string email = "IsNotEmail", int phone = 0, string address = "IsNotAddress", string city = "IsNotCity", string state = "IsNotState", string zipCode = "IsNotZipCode", DateTime birthDate = default);
}