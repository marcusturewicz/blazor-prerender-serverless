
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlazorHostedTest.Server
{
    public class HostModel : PageModel
    {
        private IHtmlHelper _html;

        public HostModel(IHtmlHelper html)
        {
            _html = html;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var yes = await _html.RenderStaticComponentAsync<Client.App>();
            ;
            return Page();
        }
    }
}