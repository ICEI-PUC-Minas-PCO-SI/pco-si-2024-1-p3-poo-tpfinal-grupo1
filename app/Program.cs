using app.Models;
using app.Repositories;
using app.Views;
namespace app
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //var pessoaFisica = new PessoaFisicaModel();
            //pessoaFisica.CPF = "86345678998";
            //pessoaFisica.Email = "vinifontes@gmail.com";
            //pessoaFisica.Nome = "Vinícius De novo";
            //pessoaFisica.Telefone = "31991424678";
            //var conec = new PessoaFisicaRepository();
            //conec.Adicionar(pessoaFisica);
            //conec.Deletar(6);
            Application.Run(new AdministradorMain());
        }
    }
}