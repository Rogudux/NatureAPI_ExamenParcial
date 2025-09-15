using Microsoft.EntityFrameworkCore;
using LibraryAPI.models.entities;

namespace NatureAPi;

public class NatureDBContext : DbContext
{
    public DbSet<Amenity> Amenity { get; set; }
    public DbSet<Photo> Photo { get; set; }
    public DbSet<Place> Place { get; set; }
    public DbSet<Review> Review { get; set; }
    public DbSet<Trail> Trail { get; set; }
    public DbSet<PlaceAmenity> PlaceAmenity { get; set; }
    
    public NatureDBContext(DbContextOptions<NatureDBContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<PlaceAmenity>()
            .HasKey(p => new { p.PlaceId, p.AmenityId });

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Place>().HasData(
            new Place
            {
                Id = 1,
                Name = "Playa Isla Mujeres",
                Description =
                    "Reconocida mundialmente por su arena blanca y fina, y sus aguas cristalinas de poca profundidad y oleaje suave, ideal para nadar y relajarse.",
                Category = "Playa",
                Latitude = 21.2577,
                Longitude = -86.7517,
                ElevationMeters = 1,
                Accessible = true,
                EntryFee = 0.00,
                OpeningHours = "Abierto 24 horas",
                CreatedAt = new DateTime(2025, 9, 15, 0, 0, 0, DateTimeKind.Utc)
            },
            new Place
            {
                Id = 2,
                Name = "Selva Lacandona",
                Description =
                    "Una de las regiones de mayor diversidad biológica de México y el mundo. Es el corazón de la selva tropical más grande del país y hogar de especies como el jaguar y la guacamaya roja.",
                Category = "Selva",
                Latitude = 16.6333,
                Longitude = -91.0000,
                ElevationMeters = 200,
                Accessible = true,
                EntryFee = 300.00,
                OpeningHours = "Varía según el tour; generalmente 7:00 AM - 6:00 PM",
                CreatedAt = new DateTime(2025, 9, 15, 0, 0, 0, DateTimeKind.Utc)
            }

        );

        modelBuilder.Entity<Photo>().HasData(
            new Photo
            {
                Id = 1,
                PlaceId = 1,
                URL = "https://images.odigoo.com/cb6a1e9c-21c6-4165-9ba7-db9263d832a1/images/media/isla-mujeres-beaches/webp/playa-norte-htfw.webp"
            },
            new Photo
            {
                Id = 2,
                PlaceId = 1,
                URL = "https://cdn.sanity.io/images/atvntylo/production/52a6fcd9855b358bda42ad22de46ad0dfdbd7673-1200x630.png"
            },
            new Photo
            {
                Id = 3,
                PlaceId = 2,
                URL="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQNIIv3OeZuYBcyk2F1mR6e-19hILJZ5BpiVA&s"
            },
            new Photo
            {
                Id = 4,
                PlaceId = 2,
                URL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR9BeIi7ay8rQgZG4HEnLqGsjwmdFgKo_81xg&s"
            }
            
        );

        modelBuilder.Entity<Amenity>().HasData(
            new  Amenity
            {
                Id = 1,
                Name = "Departamento frente a playa isla mujeres"
            },
            new  Amenity
            {
                Id = 2,
                Name = "Cabaña a un lado de monumentos en playa isla mujeres"
            },
            new  Amenity
            {
                Id = 3,
                Name = "Zona de campamento en selva lacandona"
            },
            new  Amenity
            {
                Id = 4,
                Name = "Bote equipado en medio del rio en selva lacandona"
            }
            );
        modelBuilder.Entity<Trail>().HasData(
            new Trail
            {
                Id = 1,
                PlaceId = 1, 
                Name = "Sendero Escultórico de Punta Sur",
                DistanceKm = 1.2,
                EstimatedTimeMinutes = 25,
                Difficulty = "Facil",
                Path = "Un camino costero que rodea el acantilado sur de la isla, pasando por un jardín de esculturas y con vistas espectaculares al mar Caribe.",
                IsLoop = true
            },
            new Trail
            {
                Id = 2,
                PlaceId = 1, 
                Name = "Circuito de la Salina Grande",
                DistanceKm = 2.5,
                EstimatedTimeMinutes = 45,
                Difficulty = "Dificil",
                Path = "Ruta plana que bordea la laguna salada en el centro de la isla, ideal para observar aves y disfrutar de un paisaje diferente al de la playa.",
                IsLoop = true
            },
            new Trail
            {
                Id = 3,
                PlaceId = 2,
                Name = "Sendero del Río Lacanjá",
                DistanceKm = 4.5,
                EstimatedTimeMinutes = 120,
                Difficulty = "Intermedio",
                Path = "Una caminata inmersiva a lo largo de la ribera del río Lacanjá, atravesando vegetación densa y puentes colgantes, terminando en una serie de cascadas.",
                IsLoop = false
            },
            new Trail
            {
                Id = 4,
                PlaceId = 2, 
                Name = "Exploración de la Zona Arqueológica de Yaxchilán",
                DistanceKm = 3.0,
                EstimatedTimeMinutes = 90,
                Difficulty = "Facil",
                Path = "Circuito que conecta las principales estructuras y estelas mayas de Yaxchilán, un sitio accesible solo por río. El sendero está rodeado por el sonido de monos aulladores.",
                IsLoop = true
            }
            
        );

        modelBuilder.Entity<PlaceAmenity>().HasData(
            new  PlaceAmenity
            {
                PlaceId = 1,
                AmenityId = 1,
            },
            new  PlaceAmenity
            {
                PlaceId = 1,
                AmenityId = 2,
            },
            new  PlaceAmenity
            {
                PlaceId = 2,
                AmenityId = 3,
            },
            new  PlaceAmenity
            {
                PlaceId = 2,
                AmenityId = 4,
            }
            
            );





    }



}