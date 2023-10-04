using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudAppImage.Data;
using CrudAppImage.Model;

namespace CrudAppImage.Pages.Etudiants
{
    public class IndexModel : PageModel
    {
        private readonly CrudAppImage.Data.CrudAppImageContext _context;

        public IndexModel(CrudAppImage.Data.CrudAppImageContext context)
        {
            _context = context;
        }

        public IList<Etudiant> Etudiant { get; set; }

        [BindProperty(SupportsGet = true)]
        public string prenom { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<Etudiant> etudiantsQuery = _context.Etudiant;

            if (!string.IsNullOrEmpty(prenom))
            {
                // Filter based on the search term
                etudiantsQuery = etudiantsQuery
                    .Where(e => e.firstN.Contains(prenom));
            }

            Etudiant = await etudiantsQuery.ToListAsync();
        }
    }
}
