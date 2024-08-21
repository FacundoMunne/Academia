using BibliotecaDeClases;
using System.Data.Entity;

public class MyDbContext : DbContext
{
    public MyDbContext() : base("name=MyDbContext")
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<DocenteCurso> DocentesCursos { get; set; }
    public DbSet<AlumnosInscripcion> AlumnosInscripciones { get; set; }
    public DbSet<Plan> Planes { get; set; }
    public DbSet<Especialidad> Especialidades { get; set; }
    public DbSet<Comision> Comisiones { get; set; }
    public DbSet<Materia> Materias { get; set; }

   /*/ protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        // Configuración de relaciones y restricciones adicionales si es necesario
        modelBuilder.Entity<Usuario>()
            .HasRequired(u => u.Persona)
            .WithMany(p => p.Usuarios)
            .HasForeignKey(u => u.IdPersona);

        modelBuilder.Entity<DocenteCurso>()
            .HasRequired(dc => dc.Curso)
            .WithMany(c => c.DocentesCursos)
            .HasForeignKey(dc => dc.IdCurso);

        modelBuilder.Entity<DocenteCurso>()
            .HasRequired(dc => dc.Docente)
            .WithMany(p => p.DocentesCursos)
            .HasForeignKey(dc => dc.IdDocente);

        modelBuilder.Entity<AlumnosInscripcion>()
            .HasRequired(ai => ai.Alumno)
            .WithMany(p => p.AlumnosInscripciones)
            .HasForeignKey(ai => ai.IdAlumno);

        modelBuilder.Entity<AlumnosInscripcion>()
            .HasRequired(ai => ai.Curso)
            .WithMany(c => c.AlumnosInscripciones)
            .HasForeignKey(ai => ai.IdCurso);

        modelBuilder.Entity<Curso>()
            .HasRequired(c => c.Materia)
            .WithMany(m => m.Cursos)
            .HasForeignKey(c => c.IdMateria);

        modelBuilder.Entity<Curso>()
            .HasRequired(c => c.Comision)
            .WithMany(co => co.Cursos)
            .HasForeignKey(c => c.IdComision);

        modelBuilder.Entity<Plan>()
            .HasOptional(p => p.Especialidad)
            .WithMany(e => e.Planes)
            .HasForeignKey(p => p.IdEspecialidad);

        modelBuilder.Entity<Materia>()
            .HasRequired(m => m.Plan)
            .WithMany(p => p.Materias)
            .HasForeignKey(m => m.IdPlan);

        modelBuilder.Entity<Comision>()
            .HasRequired(c => c.Plan)
            .WithMany(p => p.Comisiones)
            .HasForeignKey(c => c.IdPlan);
    }/*/
}
