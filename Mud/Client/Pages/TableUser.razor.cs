using Microsoft.AspNetCore.Components;
using Mud.Client.Models;
using Mud.Client.Utilitis;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mud.Client.Pages
{
    public partial class TableUser
    {
        /*[Inject]
        public GenerarInfo Utilitis { get; set; }

        public ISnackbar Snackbar;

        public User User = new User();
        private List<string> editEvents = new();
        private bool dense = false; //espacio vertical
        private bool hover = true; // selecion sobre fila
        private bool ronly = false; //permitir edicion
        private bool canCancelEdit = false;  //Edicion
        private string searchString = ""; //input de busqueda
        private User selectedItem1 = null;
        private User selectedItem2 = null;
        private User elementBeforeEdit;
        private HashSet<User> selectedItems1 = new HashSet<User>();
        private HashSet<User> selectedItems2 = new HashSet<User>();

        private IEnumerable<User> Users = new List<User>();

        protected override void OnInitialized()
        {
             Users = Utilitis.FakeInfo();
        }

        private void ClearEventLog()
        {
            editEvents.Clear();
        }

        private void AddEditionEvent(string message)
        {
            editEvents.Add(message);
            StateHasChanged();
        }

        private void BackupItem(object element)
        {
            elementBeforeEdit = new()
            {
                Username = ((User)element).Username,
                Name = ((User)element).Name,
                Email = ((User)element).Email

            };
            AddEditionEvent($"RowEditPreview event: made a backup of User {((User)element).Name}");
        }

        private void ItemHasBeenCommitted(object element)
        {
            AddEditionEvent($"RowEditCommit event: Changes to  {((User)element).Name} committed");
        }

        private void ResetItemToOriginalValues(object element)
        {
            ((User)element).Name = elementBeforeEdit.Name;
            ((User)element).Username = elementBeforeEdit.Username;
            ((User)element).Email = elementBeforeEdit.Email;
            AddEditionEvent($"RowEditCancel event: Editing of Element {((User)element).Name} cancelled");
        }

        private bool FilterFunc(User user)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (user.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{user.Email} {user.Username} {user.Email}".Contains(searchString))
                return true;
            return false;
        }*/
    }
}
