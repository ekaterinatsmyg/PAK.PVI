using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bsuir.PAK.PVI.DataAccessLayer.Entities.Enums;

namespace Bsuir.PAK.PVI.DataAccessLayer.Entities.Entities
{
    [Table("User")]
    public class UserEntity : BaseEntity
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public UserRoles Role { get; set; }
        public string Group { get; set; }
        public string Password { get; set; }

        public ICollection<ResultsEntity> UserResults { get; set; }
        
    }
}
