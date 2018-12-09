using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Armalo.Models;

namespace Armalo.Models
{
    public partial class ArmaloContext : DbContext
    {
        

        public ArmaloContext(DbContextOptions<ArmaloContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
        
        public virtual DbSet<HistoriaDeEventosOrg> HistoriaDeEventosOrg { get; set; }
        public virtual DbSet<HistoriaDeEventosUsr> HistoriaDeEventosUsr { get; set; }
        public virtual DbSet<ListaDeAsistentes> ListaDeAsistentes { get; set; }
        public virtual DbSet<Publicidad> Publicidad { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Interaccion> Interaccion { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(DotNetEnv.Env.GetString("CONECTION_STRING"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.IdItem);

                entity.ToTable("items");

                entity.Property(e => e.IdAgenda)
                    .HasColumnName("id_agenda")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdItem)
                    .HasColumnName("ID_ITEM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Actividad)
                    .IsRequired()
                    .HasColumnType("varchar(45)");
            });
            modelBuilder.Entity<Agenda>(entity =>
            {
                entity.HasKey(e => e.IdAgenda);

                entity.ToTable("agenda");

                entity.Property(e => e.IdAgenda)
                    .HasColumnName("id_agenda")
                    .HasColumnType("int(11)");

                entity.HasMany(e => e.Item)
                       .WithOne();

                entity.Property(e => e.Eventos)
                    .IsRequired()
                    .HasColumnType("varchar(5000)");
            });

            modelBuilder.Entity<Evento>(entity =>
            {
                entity.HasKey(e => e.IdEvent);

                entity.ToTable("evento");

                entity.HasIndex(e => e.Agenda)
                    .HasName("Agenda_idx");

                entity.HasIndex(e => e.IdLista)
                    .HasName("Invitados_idx");

                entity.HasIndex(e => e.IdOrg)
                    .HasName("Organizador_idx");

                entity.HasIndex(e => e.Staff)
                    .HasName("staff_idx");

                entity.Property(e => e.IdEvent)
                    .HasColumnName("ID_EVENT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Agenda).HasColumnType("int(11)");

                entity.Property(e => e.fin).HasColumnType("time");

                entity.Property(e => e.inicio).HasColumnType("time");


                entity.Property(e => e.CupoMax)
                    .HasColumnName("CUPO_MAX")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CupoOcu)
                    .HasColumnName("CUPO_OCU")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("date");

                entity.Property(e => e.IdLista)
                    .HasColumnName("ID_LISTA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrg)
                    .HasColumnName("ID_ORG")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Staff).HasColumnType("int(11)");

                entity.Property(e => e.Tipo).HasColumnType("int(11)");

                entity.Property(e => e.Precio).HasColumnType("int(11)");

                entity.Property(e => e.Nombre).HasColumnType("varchar(45)");


                entity.Property(e => e.location).HasColumnType("varchar(45)");

                entity.HasOne(d => d.AgendaNavigation)
                    .WithMany(p => p.Evento)
                    .HasForeignKey(d => d.Agenda)
                    .HasConstraintName("Agenda");

                entity.HasOne(d => d.IdListaNavigation)
                    .WithMany(p => p.Evento)
                    .HasForeignKey(d => d.IdLista)
                    .HasConstraintName("Invitados");

                entity.HasOne(d => d.IdOrgNavigation)
                    .WithMany(p => p.Evento)
                    .HasForeignKey(d => d.IdOrg)
                    .HasConstraintName("Organizador");

                entity.HasOne(d => d.StaffNavigation)
                    .WithMany(p => p.Evento)
                    .HasForeignKey(d => d.Staff)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("staff");
            });

            modelBuilder.Entity<HistoriaDeEventosOrg>(entity =>
            {
                entity.HasKey(e => e.IdOrg);

                entity.ToTable("historia_de_eventos_org");

                entity.HasIndex(e => e.IdEvent)
                    .HasName("ID_EVENTO_idx");

                entity.Property(e => e.IdOrg)
                    .HasColumnName("ID_ORG")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEvent)
                    .HasColumnName("ID_EVENT")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdEventNavigation)
                    .WithMany(p => p.HistoriaDeEventosOrg)
                    .HasForeignKey(d => d.IdEvent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_EVENTO");
            });

            modelBuilder.Entity<HistoriaDeEventosUsr>(entity =>
            {
                entity.ToTable("historia_de_eventos_usr");

                entity.HasIndex(e => e.IdEvent)
                    .HasName("ID_EVENTO_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEvent)
                    .HasColumnName("ID_EVENT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsr)
                    .HasColumnName("ID_USR")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdEventNavigation)
                    .WithMany(p => p.HistoriaDeEventosUsr)
                    .HasForeignKey(d => d.IdEvent)
                    .HasConstraintName("Event");
            });

            modelBuilder.Entity<ListaDeAsistentes>(entity =>
            {
                entity.HasKey(e => e.IdLista);

                entity.ToTable("lista_de_asistentes");

                entity.Property(e => e.IdLista)
                    .HasColumnName("ID_LISTA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEvent)
                    .HasColumnName("ID_EVENT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsr)
                    .HasColumnName("ID_USR")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Publicidad>(entity =>
            {
                entity.ToTable("publicidad");

                entity.HasIndex(e => e.IdAdmin)
                    .HasName("Administrador_idx");

                entity.HasIndex(e => e.IdEvent)
                    .HasName("Evento_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Duracion).HasColumnType("int(11)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdAdmin)
                    .HasColumnName("ID_ADMIN")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEvent)
                    .HasColumnName("ID_EVENT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Monto).HasColumnType("int(11)");

                entity.HasOne(d => d.IdAdminNavigation)
                    .WithMany(p => p.Publicidad)
                    .HasForeignKey(d => d.IdAdmin)
                    .HasConstraintName("Administrador");

                entity.HasOne(d => d.IdEventNavigation)
                    .WithMany(p => p.Publicidad)
                    .HasForeignKey(d => d.IdEvent)
                    .HasConstraintName("Evento");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.HasKey(e => e.IdStaff);

                entity.ToTable("staff");

                entity.HasIndex(e => e.IdUsr)
                    .HasName("Integrantes_idx");

                entity.Property(e => e.IdStaff)
                    .HasColumnName("ID_STAFF")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsr)
                    .HasColumnName("ID_USR")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdUsrNavigation)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.IdUsr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Integrantes");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsr);

                entity.ToTable("usuarios");

                entity.Property(e => e.IdUsr)
                    .HasColumnName("ID_USR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.NombreUsr)
                    .IsRequired()
                    .HasColumnName("Nombre_USR")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Resume).HasColumnType("varchar(300)");

                entity.Property(e => e.TipoUsr)
                    .HasColumnName("TipoUSR")
                    .HasColumnType("int(11)");
            });
          
           modelBuilder.Entity<Interaccion>(entity =>
            {
                entity.HasKey(e => e.idinteraccion);
                
                entity.ToTable("interaccion");

                entity.Property(e => e.idinteraccion)
                    .HasColumnName("interaccionid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.id_event)
                    .HasColumnName("id_event")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.interaccion)
                    .HasColumnName("interaccion")
                    .HasColumnType("varchar(2000)");
            });
       
        }

        
    }
}
