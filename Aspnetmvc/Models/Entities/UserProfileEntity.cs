using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aspnetmvc.Models.Entities
{
    public class UserProfileEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(50)")]
        public string StreetName { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(6)")]
        public string PostalCode { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(50)")]
        public string Country { get; set; } = string.Empty;

        public string UserId { get; set; }
        public IdentityUser User { get; set; }

    }
}
