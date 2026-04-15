using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuotesAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "Category", "CreatedAt", "Text" },
                values: new object[,]
                {
                    { 1, "Steve Jobs", "Motivación", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "El único modo de hacer un gran trabajo es amar lo que haces." },
                    { 2, "Albert Einstein", "Motivación", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "En medio de la dificultad reside la oportunidad." },
                    { 3, "John Lennon", "Vida", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "La vida es lo que pasa mientras estás ocupado haciendo otros planes." },
                    { 4, "Robert C. Martin", "Programación", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "El código limpio siempre parece escrito por alguien a quien le importa." },
                    { 5, "Kent Beck", "Programación", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primero hazlo funcionar, luego hazlo correcto." },
                    { 6, "Leonardo da Vinci", "Vida", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "La simplicidad es la máxima sofisticación." },
                    { 7, "Albert Einstein", "Motivación", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "No es que sea muy inteligente, es que paso más tiempo con los problemas." },
                    { 8, "John Wayne", "Sabiduría", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Habla bajo, habla despacio y no digas demasiado." },
                    { 9, "Martin Fowler", "Programación", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cualquier idiota puede escribir código que una computadora entienda. Los buenos programadores escriben código que los humanos pueden entender." },
                    { 10, "Peter Drucker", "Motivación", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "La mejor forma de predecir el futuro es crearlo." },
                    { 11, "Oscar Wilde", "Vida", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "La experiencia es el nombre que todos damos a nuestros errores." },
                    { 12, "Ralph Johnson", "Programación", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antes de que el software pueda ser reutilizable primero tiene que ser utilizable." },
                    { 13, "Muhammad Ali", "Motivación", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "No cuentes los días, haz que los días cuenten." },
                    { 14, "Confucio", "Vida", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "La vida es realmente simple, pero insistimos en hacerla complicada." },
                    { 15, "Rick Cook", "Programación", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Programar hoy es una carrera entre los ingenieros de software que intentan construir programas más grandes y mejores, y el universo intentando producir idiotas más grandes. Hasta ahora, el universo está ganando." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
