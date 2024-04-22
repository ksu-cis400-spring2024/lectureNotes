using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebDataExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet =true)]
        public string UserInput { get; set; }

        public List<string> AllWords => Info.AllWords;

        public void OnGet()
        {
            //happens when the form is submitted (and when the page loads)
            if (UserInput != null)
            {
                Info.AddWord(UserInput);
                UserInput = "";
            }
        }
    }
}