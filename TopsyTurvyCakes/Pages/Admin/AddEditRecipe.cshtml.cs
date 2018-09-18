using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopsyTurvyCakes.Models;


namespace TopsyTurvyCakes.Pages.Admin
{
    [Authorize]
    public class AddEditRecipeModel : PageModel
    {
        [FromRoute]
        public long? Id { get; set; }

        private IRecipesService Rservice { get; set; }

        public bool IsNewRecipe {
            get { return Id == null;} }

        public Recipe Recipe { get; set; }//expose recipe class

        public async Task OnGetAsync()
        {
            
            Recipe = Rservice.Find(Id.GetValueOrDefault()) ?? new Recipe();
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Recipe.Id = Id.GetValueOrDefault();
            await Rservice.SaveAsync(Recipe);
            return RedirectToPage("/Recipe", new { id = Recipe.Id });
        }
        public async Task<IActionResult> OnPostDelete()
        {
           
            await Rservice.DeleteAsync(Id.Value);
            return RedirectToPage("/Index");
        }
        public AddEditRecipeModel(IRecipesService recserve)
        {
            Rservice = recserve;

        }
    }
}