using System.Collections.Generic;

namespace PrometheusAPI.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual List<SavedBuild> SavedBuilds { get; set;} = default!;
        public Login() { }
    }
}