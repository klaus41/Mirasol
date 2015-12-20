using DTOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolProxy.Login
{
    public class LoginChecker
    {
        Facade facade = new Facade();
        public bool CheckCredentials(User user)
        {
            foreach (var dbUser in facade.GetUserProxyService().ReadAll())
            {
                if (user.Email == dbUser.Email && user.Password == dbUser.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
