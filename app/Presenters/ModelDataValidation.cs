using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Presenters
{
    internal class ModelDataValidation
    {
        public static List<ValidationResult> ObterValidacao (Object model)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, contexto, resultadoValidacao, true);
            return resultadoValidacao;
        }
    }
}
