using System.Collections.Generic;
using EvaluationProduit.MVC.Models;
using Microsoft.AspNetCore.Http;

namespace EvaluationProduit.MVC.Services
{
    public interface IProduitService
    {
        IList<ProduitModel> ProduitModels { get; set; }
        public float RecupererlaMoyenneEvaluation(int evaluation1, int evaluation2);
        public PhotoModel ChargerFichier(IFormFile photoFile, string webRootPath);
    }
}