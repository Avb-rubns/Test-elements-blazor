using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Mud.Client.Models;
using Mud.Client.Utilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mud.Client.Pages
{
    public partial class RegistedUser
    {
        [Inject]
        public GenerarInfo Utilitis { get; set; }
        public List<User> info { get; set; }
        public User userModel = new User();

        bool[] status;
        public EditContext Context;

        protected override void OnInitialized()
        {
            info = Utilitis.FakeInfo();
            status = new bool[info.Count];
            Console.WriteLine($"tam:{info.Count}");
            int i = 0;
            while(i < info.Count)
            {
                status[i] = true;
                i++;
            }

        } 

        private void OnValidSubmit( User user)
        {
            Console.WriteLine("save");
            Console.WriteLine(user.Name);
            
        }

        void ChangeInfoUser(int index)
        {
            Console.WriteLine($"index:{index}");
            status[index] = !status[index];
            StateHasChanged();
        }
    }
}
