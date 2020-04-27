using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using WebApiProductService.Models;

namespace WebApiProductService.Filters
{
    public class BasicAuthFilter : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //istek yapılan verinin header bölümünde herhangi bir yetki verisi geliyor mu öncelikle bunu kontrol ediyoruz.
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
            }
            else
            {
                //kullanıcı basic olarak yetki verisi göndermişse yani kullanıcı adı ve şifre ile istek yollamışsa ulaşan isteği ilk etapta string tipe çevirmemiz gerekiyor. çünkü yetkilendirme verileri Base64 tipinde iletildikleri için içerisindeki verileri direkt okuyamayız. bu yüzden authToken isimli değişkende yakaladığımız şfireli veriyi decodeAuthToken içerisine string olarak çeviriyoruz. 
                string authToken = actionContext.Request.Headers.Authorization.Parameter;
                string decodeAuthToken = Encoding.UTF8.GetString(Convert.FromBase64String(authToken));
                //decodeAuthToken içerisinde veri
                //username:password
                //şeklinde çevrildiği için : karakterini kullanarak kullanıcı adı ve şifreyi bir dizi içerisine çıkarıyoruz.
                string[] userNamePassArray = decodeAuthToken.Split(':');
                //dizinin 0. indexinde kullanıcı ve 1. indexinde şifre olduğundan dolayı bu verileri de farklı değişkenlere aktarıyoruz.
                string userName = userNamePassArray[0];
                string password = userNamePassArray[1];

                //aktardığımız değişkenleri Login metodunu kullanarak veritabanındaki bilgiler ile doğru mu kontrol edip ardından o kullanıcıya bir izin tayin ediyoruz.
                if (AppUserSecurity.Login(userName, password))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(userName), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
                }

            }
        }
    }
}