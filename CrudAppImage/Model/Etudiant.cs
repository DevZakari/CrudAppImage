using Microsoft.AspNetCore.Http;
using System;

namespace CrudAppImage.Model
{
    public class Etudiant
    {
        public int id { get; set; }
        public string firstN { get; set; }
        public string lastN { get; set; }
        public string email { get; set; }
        public long tel { get; set; }
        public string imageUrl { get; set; }

    }
}
