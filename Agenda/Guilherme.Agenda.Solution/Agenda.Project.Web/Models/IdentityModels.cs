using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Agenda.Project.Web.Models
{
    // É possível adicionar dados do perfil do usuário adicionando mais propriedades na sua classe ApplicationUser, visite https://go.microsoft.com/fwlink/?LinkID=317594 para obter mais informações.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Observe que o authenticationType deve corresponder àquele definido em CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Adicionar declarações de usuário personalizado aqui
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        //Ligação entre o seu Modelo de Dados e o Bando de Dados (ContatoModel >>> Tabela Contatos)
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }



        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}