using Mud.Client.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace Mud.Client.Utilitis
{
    public class GenerarInfo
    {

        public List<User> FakeInfo()
        {
            string jsonString = @"[{""Name"": ""Luis Arturo Perez "",""Username"": ""Luisillo"",""Email"": ""prueba1 @mail.com"",""RolId"": null },{""Name"": ""Pedro pica piedra"",""Username"": ""picapiera"",""Email"": ""prueba2 @mail.com"",""RolId"": null},{""Email"": ""prueba3 @mail.com"",""Name"": ""Ruben Sanchez Rugerio"",""RolId"": null ,""Username"": ""_rubns_""}]";
            var response = JsonSerializer.Deserialize<List<User>>(jsonString);

            return response;
        }
    }

    
}
