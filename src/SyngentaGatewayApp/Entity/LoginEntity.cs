using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngentaGatewayApp.Entity
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class BusinessError
    {
        public int code { get; set; }
        public string message { get; set; }
    }

    public class Menu
    {
        public int id { get; set; }
        public bool active { get; set; }
        public string descr { get; set; }
        public string iconName { get; set; }
        public int menuOrder { get; set; }
        public string name { get; set; }
        public int? parent { get; set; }
        public int level { get; set; }
        public string url { get; set; }
        public int appId { get; set; }
        public bool restricted { get; set; }
        public string appMst { get; set; }
        public bool masterclient_active { get; set; }
    }

    public class Res
    {
        public User user { get; set; }
        public Token token { get; set; }
    }

    public class Role
    {
        public int id { get; set; }
        public string name { get; set; }
        public int hierarchy { get; set; }
        public List<RoleMenuMapping> roleMenuMappings { get; set; }
        public List<object> rolePrivilegeMappings { get; set; }
        public bool active { get; set; }
        public string appMst { get; set; }
        public object createdby { get; set; }
        public object createddate { get; set; }
        public object updatedby { get; set; }
        public object updateddate { get; set; }
        public int manufId { get; set; }
        public int isActive { get; set; }
        public int plantId { get; set; }
        public int roleType { get; set; }
    }

    public class Roleid
    {
        public int id { get; set; }
        public string name { get; set; }
        public int hierarchy { get; set; }
        public List<RoleMenuMapping> roleMenuMappings { get; set; }
        public List<object> rolePrivilegeMappings { get; set; }
        public bool active { get; set; }
        public string appMst { get; set; }
        public object createdby { get; set; }
        public object createddate { get; set; }
        public object updatedby { get; set; }
        public object updateddate { get; set; }
        public int manufId { get; set; }
        public int isActive { get; set; }
        public int plantId { get; set; }
        public int roleType { get; set; }
    }

    public class RoleMenuMapping
    {
        public int id { get; set; }
        public int roleId { get; set; }
        public Menu menu { get; set; }
        public int isactive { get; set; }
        public object createdby { get; set; }
        public object createddate { get; set; }
        public object updateddate { get; set; }
        public object updatedby { get; set; }
    }

    public class Root1
    {
        public BusinessError businessError { get; set; }
        public Res res { get; set; }
    }

    public class Token
    {
        public string token { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public int type { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Role role { get; set; }
        public string title { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string passChangeDate { get; set; }
        public string password { get; set; }
        public bool active { get; set; }
        public bool firstTimeFlag { get; set; }
        public object imgName { get; set; }
        public string ipAddress { get; set; }
        public object imgData { get; set; }
        public int isAccountLock { get; set; }
        public int isLoggedIn { get; set; }
        public bool isPassSend { get; set; }
        public string lastLogin { get; set; }
        public object token { get; set; }
        public List<object> userPlantMapping { get; set; }
        public object passwordExpired { get; set; }
        public object oldPassword { get; set; }
        public object fingerPrint { get; set; }
        public object selectedLine { get; set; }
        public object selectedProduct { get; set; }
        public object signaturePassword { get; set; }
        public object signatureMeaning { get; set; }
        public object selectedProductCode { get; set; }
        public object fingerPrint1 { get; set; }
        public object fingerPrint2 { get; set; }
        public object fingerPrint3 { get; set; }
        public object plantName { get; set; }
        public object roleName { get; set; }
        public object manufName { get; set; }
        public object status { get; set; }
        public int createdby { get; set; }
        public DateTime createddate { get; set; }
        public object updatedby { get; set; }
        public object updateddate { get; set; }
        public object userMdlpDetails { get; set; }
        public string username { get; set; }
        public Roleid roleid { get; set; }
        public int isactive { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public bool passSend { get; set; }
    }
}
