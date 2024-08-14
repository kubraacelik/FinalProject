using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    //kullanıcı sisteme istekte bulunduğunda yetki gerektiren bir şeyse token'ı da yollar ve buna AccessToken denir
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
