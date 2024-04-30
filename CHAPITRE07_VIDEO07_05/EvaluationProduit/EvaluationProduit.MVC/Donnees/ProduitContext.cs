using Microsoft.EntityFrameworkCore;

namespace EvaluationProduit.MVC.Donnees
{
    public class ProduitContext : DbContext
    {
        public ProduitContext(DbContextOptions<ProduitContext> options) : base(options)
        {

        }
    }
}
