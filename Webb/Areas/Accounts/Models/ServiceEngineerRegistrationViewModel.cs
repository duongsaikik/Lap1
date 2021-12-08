using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webb.Areas.Identity.Pages.Account;

namespace Webb.Areas.Accounts.Models
{
    public class ServiceEngineerRegistrationViewModel:RegisterModel.InputModel
    {
        public string UserName { get; set; }
        public bool IsEdit { get; set; }
        public bool IsActive { get; set; }
    }
}
