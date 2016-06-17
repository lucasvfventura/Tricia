using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
namespace Trivia.Models
{
    public class User : IdentityUser
    {
        public ICollection<UserAnswer> Answers { get; set; }
    }
}