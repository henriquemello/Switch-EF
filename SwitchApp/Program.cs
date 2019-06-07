using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using Switch.Infra.Data.Context;
using System;

namespace SwitchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario() { Nome = "Henrique", SobreNome = "Mello",Senha="12323" };
            var optionsBuilder = new DbContextOptionsBuilder<SwitchContext>();
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySql("Server=localhost;userid=root;password=123456;database=SwitchDB", 
                m => m.MigrationsAssembly("Switch.Infra.Data"));



            try
            {
                using (var dbContext = new SwitchContext(optionsBuilder.Options))
                {
                    dbContext.Usuarios.Add(usuario);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
