using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebUI.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName = "nvarchar(50)")]
    public string FirstName { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(50)")]
    public string LastName { get; set; }
}

