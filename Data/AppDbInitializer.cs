using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ticketsonline.Models;

namespace ticketsonline.Data
{
    public class AppDbInitializer
    {
        //khởi tạo database trường hợp database chưa có dữ liệu
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinemas
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="CGV",
                            Logo="CGV.jpg",
                            Description="This is the description of CGV Cinema"
                        },
                        new Cinema()
                        {
                            Name="BHD",
                            Logo="BHD.jpg",
                            Description="This is the description of BHD Cinema"
                        },
                        new Cinema()
                        {
                            Name="Galaxy",
                            Logo="Galaxy.jpg",
                            Description="This is description of Galaxy Cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName="Actor1",
                            Bio="This is the Bio of the Actor1",
                            ProfilePictureURL="Actor1.jpg"
                        },
                        new Actor()
                        {
                            FullName="Actor2",
                            Bio="This is the Bio of the Actor",
                            ProfilePictureURL="Actor2.jpg"
                        },
                        new Actor()
                        {
                            FullName="Actor3",
                            Bio="This is the Bio of the Actor",
                            ProfilePictureURL="Actor3.jpg"
                        },
                        new Actor()
                        {
                            FullName="Actor4",
                            Bio="This is the Bio of the Actor",
                            ProfilePictureURL="Actor4.jpg"
                        },
                        new Actor()
                        {
                            FullName="Actor5",
                            Bio="This is the Bio of the Actor",
                            ProfilePictureURL="Actor5.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName="Producer 1",
                            Bio = "This is the Bio of the Producer 1",
                            ProfilePictureURL="producer1.jpg"
                        },
                        new Producer()
                        {
                            FullName="Producer2",
                            Bio = "This is the Bio of the producer 2",
                            ProfilePictureURL="producer2.jpg"
                        },
                        new Producer()
                        {
                            FullName="Producer3",
                            Bio = "This is the Bio of the producer 3",
                            ProfilePictureURL="producer3.jpg"
                        },
                        new Producer()
                        {
                            FullName="Producer4",
                            Bio = "This is the Bio of the producer 4",
                            ProfilePictureURL="producer4.jpg"
                        },
                        new Producer()
                        {
                            FullName="Producer5",
                            Bio = "This is the Bio of the producer 5",
                            ProfilePictureURL="producer5.jpg"
                        },
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name="Ván bài lật ngửa",
                            Description="this is description of movie",
                            Price=100000,
                            ImageURL="vanbailatngua.jpg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(10),
                            CinemaId=3,
                            ProducerId=3,
                            MovieCategory=MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name="fghsf",
                            Description="this is description of movie",
                            Price=120000,
                            ImageURL="fghsf.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId=1,
                            ProducerId=1,
                            MovieCategory=MovieCategory.Documentary
                        },
                         new Movie()
                        {
                            Name="Ván bài lật ngửa",
                            Description="this is description of movie",
                            Price=100000,
                            ImageURL="vanbailatngua.jpg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(10),
                            CinemaId=3,
                            ProducerId=3,
                            MovieCategory=MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name="fghsf",
                            Description="this is description of movie",
                            Price=120000,
                            ImageURL="fghsf.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId=1,
                            ProducerId=1,
                            MovieCategory=MovieCategory.Documentary
                        },
                         new Movie()
                        {
                            Name="Ván bài lật ngửa",
                            Description="this is description of movie",
                            Price=100000,
                            ImageURL="vanbailatngua.jpg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(10),
                            CinemaId=3,
                            ProducerId=3,
                            MovieCategory=MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name="fghsf",
                            Description="this is description of movie",
                            Price=120000,
                            ImageURL="fghsf.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId=1,
                            ProducerId=1,
                            MovieCategory=MovieCategory.Documentary
                        },
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=1
                        },
                        new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=1
                        },
                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
