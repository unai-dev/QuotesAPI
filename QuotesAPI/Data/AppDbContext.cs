using Microsoft.EntityFrameworkCore;
using QuotesAPI.Models;

namespace QuotesAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Quote>().HasData(
                new Quote { Id = 1, Text = "El único modo de hacer un gran trabajo es amar lo que haces.", Author = "Steve Jobs", Category = "Motivación" },
                new Quote { Id = 2, Text = "En medio de la dificultad reside la oportunidad.", Author = "Albert Einstein", Category = "Motivación" },
                new Quote { Id = 3, Text = "La vida es lo que pasa mientras estás ocupado haciendo otros planes.", Author = "John Lennon", Category = "Vida" },
                new Quote { Id = 4, Text = "El código limpio siempre parece escrito por alguien a quien le importa.", Author = "Robert C. Martin", Category = "Programación" },
                new Quote { Id = 5, Text = "Primero hazlo funcionar, luego hazlo correcto.", Author = "Kent Beck", Category = "Programación" },
                new Quote { Id = 6, Text = "La simplicidad es la máxima sofisticación.", Author = "Leonardo da Vinci", Category = "Vida" },
                new Quote { Id = 7, Text = "No es que sea muy inteligente, es que paso más tiempo con los problemas.", Author = "Albert Einstein", Category = "Motivación" },
                new Quote { Id = 8, Text = "Habla bajo, habla despacio y no digas demasiado.", Author = "John Wayne", Category = "Sabiduría" },
                new Quote { Id = 9, Text = "Cualquier idiota puede escribir código que una computadora entienda. Los buenos programadores escriben código que los humanos pueden entender.", Author = "Martin Fowler", Category = "Programación" },
                new Quote { Id = 10, Text = "La mejor forma de predecir el futuro es crearlo.", Author = "Peter Drucker", Category = "Motivación" },
                new Quote { Id = 11, Text = "La experiencia es el nombre que todos damos a nuestros errores.", Author = "Oscar Wilde", Category = "Vida" },
                new Quote { Id = 12, Text = "Antes de que el software pueda ser reutilizable primero tiene que ser utilizable.", Author = "Ralph Johnson", Category = "Programación" },
                new Quote { Id = 13, Text = "No cuentes los días, haz que los días cuenten.", Author = "Muhammad Ali", Category = "Motivación" },
                new Quote { Id = 14, Text = "La vida es realmente simple, pero insistimos en hacerla complicada.", Author = "Confucio", Category = "Vida" },
                new Quote { Id = 15, Text = "Programar hoy es una carrera entre los ingenieros de software que intentan construir programas más grandes y mejores, y el universo intentando producir idiotas más grandes. Hasta ahora, el universo está ganando.", Author = "Rick Cook", Category = "Programación" }
                );
        }
    }
}
