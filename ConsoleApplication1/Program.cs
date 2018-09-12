using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string siteUrl = "https://kartooz2000hotmail.sharepoint.com";
            string userName = "azureadmin@kartooz2000hotmail.onmicrosoft.com";
            string passWord = "IndMv123$";
            ClientContext clientContext = null;
            clientContext = new ClientContext(siteUrl);
            var pwd = new SecureString();
            foreach (char c in passWord.ToCharArray()) pwd.AppendChar(c);
            clientContext.Credentials = new SharePointOnlineCredentials(userName, pwd);
            Web web=clientContext.Web;
            clientContext.Load(web.RoleDefinitions, roledefinitions => roledefinitions.Include(thisRole => thisRole.Name, thisRole => thisRole.Id));
            clientContext.ExecuteQuery();
        }
    }
}


//testing
