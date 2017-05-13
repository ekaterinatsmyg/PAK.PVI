using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bsuir.PAK.PVI.DataAccessLayer.Entities.Enums;

namespace Bsuir.PAK.PVI.DataAccessLayer.Models.Models
{
    [Serializable]
    public class UserModel : IModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public UserRoles Role { get; set; }
        public string Group { get; set; }
        public string Password { get; set; }
        

    }
}
