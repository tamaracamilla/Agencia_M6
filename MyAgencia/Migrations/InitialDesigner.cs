using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyAgencia.Database;

#nullable disable

namespace MyAgencia.Migrations
{
    [DbContext(typeof(UsuarioDb))]
    [Migration("InitialDesigner")]
    partial class InitialDesigner
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MyAgencia.Model.Usuario", b =>
                {
                    b.Property<int>("Id_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                        
                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");
          
                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("longtext");
                
                 b.HasKey("Id_Usuario");

                    b.ToTable("id_usuario");
                });
#pragma warning restore 612, 618
        }
    }
}