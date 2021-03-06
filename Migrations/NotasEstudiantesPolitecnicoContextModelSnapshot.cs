// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotasEstudiantesPolitecnico.Models;

namespace NotasEstudiantesPolitecnico.Migrations
{
    [DbContext(typeof(NotasEstudiantesPolitecnicoContext))]
    partial class NotasEstudiantesPolitecnicoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NotasEstudiantesPolitecnico.Models.Datos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estudiante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Nota1")
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("Nota2")
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("Nota3")
                        .HasColumnType("decimal(2,2)");

                    b.Property<decimal>("NotaFinal")
                        .HasColumnType("decimal(2,2)");

                    b.HasKey("Id");

                    b.ToTable("Datos");
                });
#pragma warning restore 612, 618
        }
    }
}
