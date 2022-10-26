using System.Collections.Generic;

namespace Azbil.Billing.Entities.UserManagement
{
    public partial class User
    {
        public List<VwFeature> featureList = new List<VwFeature>();

        public bool authenticated;

        public List<MainMenu> mainMenuList = new List<MainMenu>();

        public List<SubMenu> subMenuList = new List<SubMenu>();

        public string profileName;

      //  public string confirmPassword { get; set; }
    }
}
