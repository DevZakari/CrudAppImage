using System;
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
    public class DetailsModel : PageModel
    {
        private readonly CrudAppImage.Data.CrudAppImageContext _context;

        public DetailsModel(CrudAppImage.Data.CrudAppImageContext context)
        {
            _context = context;
        }

        public Etudiant Etudiant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Etudiant = await _context.Etudiant.FirstOrDefaultAsync(m => m.id == id);

            if (Etudiant == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
