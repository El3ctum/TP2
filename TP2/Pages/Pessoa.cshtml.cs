using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using TP2.models;

namespace TP2.Pages
{
    public class PessoaModel : PageModel
    {
        public IEnumerable<Pessoa> Pessoas { get; set; }

        private readonly ILogger<PessoaModel> _logger;

        public PessoaModel(ILogger<PessoaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // Cria uma lista de pessoas hardcoded
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa("João Silva", 31, "123.456.789-00"),
                new Pessoa("Maria Silva", 25, "987.654.321-00"),
                new Pessoa("Pedro Souza", 40, "111.222.333-44")
            };

            // Atribui a lista ao Model para ser utilizada na view
            Pessoas = pessoas;
        }
    }
}
