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

    public NatureDBContext(DbContextOptions<NatureDBContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // =========================
        // Relaciones
        // =========================

        // M:N Place <-> Amenity (tabla puente PlaceAmenity) SIN cascada para evitar rutas múltiples
        modelBuilder.Entity<PlaceAmenity>()
            .HasKey(pa => new { pa.PlaceId, pa.AmenityId });

        modelBuilder.Entity<PlaceAmenity>()
            .HasOne(pa => pa.Place)
            .WithMany(p => p.PlaceAmenities)
            .HasForeignKey(pa => pa.PlaceId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PlaceAmenity>()
            .HasOne(pa => pa.Amenity)
            .WithMany(a => a.PlaceAmenities)
            .HasForeignKey(pa => pa.AmenityId)
            .OnDelete(DeleteBehavior.Restrict);

        // 1:N Place -> Photo/Trail/Review (también SIN cascada)
        modelBuilder.Entity<Photo>()
            .HasOne(ph => ph.Place)
            .WithMany(p => p.Photos)
            .HasForeignKey(ph => ph.PlaceId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Trail>()
            .HasOne(t => t.Place)
            .WithMany(p => p.Trails)
            .HasForeignKey(t => t.PlaceId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Review>()
            .HasOne(r => r.Place)
            .WithMany(p => p.Reviews)
            .HasForeignKey(r => r.PlaceId)
            .OnDelete(DeleteBehavior.Restrict);

        // =========================
        // Seeds
        // =========================

        // Places (6..10)
        modelBuilder.Entity<Place>().HasData(
            new Place
            {
                Id = 6,
                Name = "Cascadas de Agua Azul",
                Description = "Conjunto de cascadas de color turquesa formadas por sales calcáreas en la selva chiapaneca; senderos, miradores y áreas de baño señalizadas.",
                Category = "Cascada",
                Latitude = 17.2680,
                Longitude = -92.1090,
                ElevationMeters = 150,
                Accessible = true,
                EntryFee = 50.00,
                OpeningHours = "08:00 - 18:00",
                CreatedAt = new DateTime(2025, 9, 15, 0, 0, 0, DateTimeKind.Utc)
            },
            new Place
            {
                Id = 7,
                Name = "Barrancas del Cobre (Divisadero)",
                Description = "Sistema de cañones más extenso que el Gran Cañón; miradores espectaculares, teleférico y rutas de senderismo en la Sierra Tarahumara.",
                Category = "Cañón",
                Latitude = 27.5350,
                Longitude = -107.8100,
                ElevationMeters = 2400,
                Accessible = true,
                EntryFee = 0.00,
                OpeningHours = "08:00 - 18:00",
                CreatedAt = new DateTime(2025, 9, 15, 0, 0, 0, DateTimeKind.Utc)
            },
            new Place
            {
                Id = 8,
                Name = "Nevado de Toluca (Xinantécatl)",
                Description = "Volcán con lagunas crátericas (Sol y Luna) y paisajes de alta montaña; rutas de senderismo con control de acceso en temporada.",
                Category = "Volcán",
                Latitude = 19.1080,
                Longitude = -99.7580,
                ElevationMeters = 4680,
                Accessible = true,
                EntryFee = 54.00,
                OpeningHours = "07:00 - 16:00",
                CreatedAt = new DateTime(2025, 9, 15, 0, 0, 0, DateTimeKind.Utc)
            },
            new Place
            {
                Id = 9,
                Name = "Laguna de Bacalar (Laguna de los Siete Colores)",
                Description = "Laguna cristalina de tonos azul-turquesa con estromatolitos, cenotes y balnearios; ideal para kayak, paddle y paseos en lancha.",
                Category = "Laguna",
                Latitude = 18.6690,
                Longitude = -88.3910,
                ElevationMeters = 10,
                Accessible = true,
                EntryFee = 50.00,
                OpeningHours = "08:00 - 18:00",
                CreatedAt = new DateTime(2025, 9, 15, 0, 0, 0, DateTimeKind.Utc)
            },
            new Place
            {
                Id = 10,
                Name = "Cañón del Sumidero",
                Description = "Imponente cañón con paredes de más de 1000 m de altura, recorridos en lancha por el río Grijalva y miradores panorámicos.",
                Category = "Cañón",
                Latitude = 16.8330,
                Longitude = -93.1020,
                ElevationMeters = 450,
                Accessible = true,
                EntryFee = 250.00,
                OpeningHours = "08:00 - 17:00",
                CreatedAt = new DateTime(2025, 9, 15, 0, 0, 0, DateTimeKind.Utc)
            }
        );

        // Photos (6..10)
        modelBuilder.Entity<Photo>().HasData(
            new Photo
            {
                Id = 6,
                PlaceId = 6,
                URL = "https://visitachiapas.com/wp-content/uploads/32080021_2001255793535615_8694945979746484224_n-845x684.jpg"
            },
            new Photo
            {
                Id = 7,
                PlaceId = 7,
                URL = "https://static.wixstatic.com/media/cf3297_1207992ee7504d6b89bef1ad615630e4~mv2.jpg/v1/fill/w_568,h_378,al_c,q_80,usm_0.66_1.00_0.01,enc_avif,quality_auto/cf3297_1207992ee7504d6b89bef1ad615630e4~mv2.jpg"
            },
            new Photo
            {
                Id = 8,
                PlaceId = 8,
                URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/28/Vista_del_Nevado_de_Toluca.jpg/1280px-Vista_del_Nevado_de_Toluca.jpg"
            },
            new Photo
            {
                Id = 9,
                PlaceId = 9,
                URL = "https://www.gob.mx/cms/uploads/article/main_image/83508/BACALAR-web.jpg"
            },
            new Photo
            {
                Id = 10,
                PlaceId = 10,
                URL = "https://www.shutterstock.com/image-photo/sumidero-canyon-chiapas-mexico-600nw-2292202987.jpg"
            }
        );

        // Amenities nuevos (5..9)
        modelBuilder.Entity<Amenity>().HasData(
            new Amenity { Id = 5, Name = "Miradores y pasarelas (Agua Azul)" },
            new Amenity { Id = 6, Name = "Mirador panorámico (Divisadero)" },
            new Amenity { Id = 7, Name = "Refugio de alta montaña (Nevado)" },
            new Amenity { Id = 8, Name = "Muelle público y zona de nado (Bacalar)" },
            new Amenity { Id = 9, Name = "Embarcadero turístico (Sumidero)" }
        );

        // Vinculaciones M:N (6..10 -> 5..9)
        modelBuilder.Entity<PlaceAmenity>().HasData(
            new PlaceAmenity { PlaceId = 6, AmenityId = 5 },
            new PlaceAmenity { PlaceId = 7, AmenityId = 6 },
            new PlaceAmenity { PlaceId = 8, AmenityId = 7 },
            new PlaceAmenity { PlaceId = 9, AmenityId = 8 },
            new PlaceAmenity { PlaceId = 10, AmenityId = 9 }
        );


        // Trails (101..105)
        modelBuilder.Entity<Trail>().HasData(
            new Trail
            {
                Id = 101,
                PlaceId = 6,
                Name = "Sendero Pozas Turquesa",
                DistanceKm = 2.4,
                EstimatedTimeMinutes = 75,
                Difficulty = "Moderado",
                Path = "Tramo sombreado que sigue el cauce del rio con miradores a varias caidas; se avanza sobre pasarelas y roca humeda, con tramos resbalosos tras lluvia.",
                IsLoop = false
            },
            new Trail
            {
                Id = 102,
                PlaceId = 7,
                Name = "Miradores del Divisadero",
                DistanceKm = 7.0,
                EstimatedTimeMinutes = 210,
                Difficulty = "Dificil",
                Path = "Recorrido por la cresta con sube y baja constante; bordea varios miradores naturales con secciones expuestas y terreno pedregoso.",
                IsLoop = false
            },
            new Trail
            {
                Id = 103,
                PlaceId = 8,
                Name = "Lagunas del Sol y la Luna",
                DistanceKm = 5.5,
                EstimatedTimeMinutes = 180,
                Difficulty = "Dificil",
                Path = "Circuito a gran altitud que desciende al crater y rodea ambas lagunas; piso de arena volcanica y piedra suelta con pendientes pronunciadas.",
                IsLoop = true
            },
            new Trail
            {
                Id = 104,
                PlaceId = 9,
                Name = "Costera de los Siete Colores",
                DistanceKm = 3.2,
                EstimatedTimeMinutes = 80,
                Difficulty = "Facil",
                Path = "Camino llano junto a la laguna con accesos a muelles y miradores; ideal para paseo suave con paradas para fotografias.",
                IsLoop = true
            },
            new Trail
            {
                Id = 105,
                PlaceId = 10,
                Name = "Ribera del Grijalva",
                DistanceKm = 4.0,
                EstimatedTimeMinutes = 120,
                Difficulty = "Moderado",
                Path = "Senda riberenia entre selva baja y paredones del cañon; zonas con lodazales en temporada y tramos estrechos junto al rio.",
                IsLoop = false
            }
        );

        // Llamada única al final
        base.OnModelCreating(modelBuilder);
    }
}
