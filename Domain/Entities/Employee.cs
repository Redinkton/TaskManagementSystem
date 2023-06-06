using Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Employee : IdentityUser
    {
        public Guid Id { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }
        //public Role Role { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
