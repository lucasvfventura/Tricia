using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
namespace Trivia.Models
{
    public class User : IdentityUser
    {
        public ICollection<Answer> Answers { get; set; }
    }
}