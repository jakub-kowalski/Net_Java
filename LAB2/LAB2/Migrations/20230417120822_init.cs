using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB2.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    height = table.Column<int>(type: "INTEGER", nullable: false),
                    weight = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTypeInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTypeInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    typeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Pokemonid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonType_PokemonTypeInfo_typeId",
                        column: x => x.typeId,
                        principalTable: "PokemonTypeInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonType_Pokemons_Pokemonid",
                        column: x => x.Pokemonid,
                        principalTable: "Pokemons",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonType_Pokemonid",
                table: "PokemonType",
                column: "Pokemonid");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonType_typeId",
                table: "PokemonType",
                column: "typeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonType");

            migrationBuilder.DropTable(
                name: "PokemonTypeInfo");

            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
