using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace DatingApp.API.Models
{
    public class User: IdentityUser<int>
    {
        [Required]
        [MaxLength(10)]
        public string Gender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [MaxLength(100)]
        public string KnownAs { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        [MaxLength(500)]
        public string Introduction { get; set; }
        [MaxLength(250)]
        public string LookingFor { get; set; }
        [MaxLength(500)]
        public string Interests { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [MaxLength(100)]
        public string Country { get; set; }
        public virtual ICollection<Photo> Photos { get; set; } = new HashSet<Photo>();
        public virtual ICollection<Like> Likers { get; set; }  = new HashSet<Like>();
        public virtual ICollection<Like> Likees { get; set; } = new HashSet<Like>();
        public virtual ICollection<Message> MessagesSent { get; set; } = new HashSet<Message>();
        public virtual ICollection<Message> MessagesReceived { get; set; } = new HashSet<Message>();
        public virtual ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    }
}