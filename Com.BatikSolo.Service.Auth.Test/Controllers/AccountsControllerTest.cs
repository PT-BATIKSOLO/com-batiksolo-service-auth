using Com.BatikSolo.Service.Auth.Lib.BusinessLogic.Interfaces;
using Com.BatikSolo.Service.Auth.Lib.Models;
using Com.BatikSolo.Service.Auth.Lib.ViewModels;
using Com.BatikSolo.Service.Auth.Test.Utils;
using Com.BatikSolo.Service.Auth.WebApi.Controllers.v1;

namespace Com.BatikSolo.Service.Auth.Test.Controllers
{
    public class AccountsControllerTest : BaseControllerTest<AccountsController, Account, AccountViewModel, IAccountService>
    {
    }
}
