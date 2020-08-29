using App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MovieContext>>()))
            {
                
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Img = "https://th.bing.com/th/id/OIP.ZRytlTD9TMYMhxKz942WzQHaKN?pid=Api&rs=1",
                        Rating = "R",
                        Description = "In 1977, Harry Burns and Sally Albright graduate from the University of Chicago and share the drive to New York City, where Sally is beginning journalism school and Harry is starting a career. Harry is dating Sally's friend Amanda. During the drive, Harry and Sally discuss their differing ideas about relationships; Sally disagrees with Harry's assertion that men and women cannot be friends as 'the sex part gets in the way'. At a diner, Harry tells Sally she is attractive, and she angrily accuses"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Img = "https://upload.wikimedia.org/wikipedia/en/3/32/Ghostbusters_2016_film_poster.png",
                        Rating = "R",
                        Description = "Ghostbusters is a 1984 American supernatural comedy film directed by Ivan Reitman and written by Dan Aykroyd and Harold Ramis.It stars Bill Murray, Aykroyd, and Ramis as, respectively, Peter Venkman, Ray Stantz, and Egon Spengler, a trio of eccentric parapsychologists who start a ghost-catching business in New York City. The film also stars Sigourney Weaver and Rick Moranis, and features Annie"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Img = "http://1.bp.blogspot.com/-rOa6IgppMlg/VFlJNAkAtQI/AAAAAAAAAgk/ijr_COGf3jM/s1600/ghostbusters-ii-group.jpg",
                        Rating = "R",
                        Description = "Ghostbusters II is a 1989 American supernatural comedy film directed by Ivan Reitman and written by Dan Aykroyd and Harold Ramis.It stars Bill Murray, Dan Aykroyd, Sigourney Weaver, Harold Ramis, Rick Moranis, Ernie Hudson, and Annie Potts.It is the sequel to the 1984 film Ghostbusters and the second film in the Ghostbusters franchise"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Img = "http://3.bp.blogspot.com/-0SefrBxyq3k/UChcLQmTF_I/AAAAAAAAJwI/tsZmSuT6xmo/s1600/rio-bravo1-thumb-510x377-20463.jpg",
                        Rating = "R",
                        Description = "Rio Bravo is a 1959 American Western film produced and directed by Howard Hawks and starring John Wayne, Dean Martin, Ricky Nelson, Angie Dickinson, Walter Brennan, and Ward Bond. Written by Jules Furthman and Leigh Brackett, based on the short story 'Rio Bravo' by B. H. McCampbell, the film is about the sheriff of the town of Rio Bravo, Texas, who arrests the brother of a powerful local rancher for murder and then must hold the man in jail until the arrival of the United States Marshal"
                    },
                    new Movie
                    {
                        Title = "Expandables",
                        ReleaseDate = DateTime.Parse("15-11-2011"),
                        Genre = "Action",
                        Price = 465.67M,
                        Img = "https://i.ytimg.com/vi/BU4VtPgTKNU/maxresdefault.jpg",
                        Rating = "R",
                        Description = "The Expendables Official franchise logo Based onCharacters created by David Callaham StarringSee below Distributed byLionsgate Release date 2010-present Running time 332 minutes CountryUnited States LanguageEnglish Budget$270 million Box office$804 million The Expendables is an American ensemble action thriller franchise spanning a film series, written by and starring Sylvester Stallone and originally created by David Callaham, and additional media. The film series itself was created to pay homa"
                    },
                    new Movie
                    {
                        Title = "Ghost Rider",
                        ReleaseDate = DateTime.Parse("15-11-2011"),
                        Genre = "Action",
                        Price = 465.67M,
                        Img = "https://i.ytimg.com/vi/A35NFKgyHnc/maxresdefault.jpg",
                        Rating = "R",
                        Description = "Ghost Rider is the name of many antiheroes and superheroes appearing in American comic books published by Marvel Comics.Marvel had previously used the name for a Western character whose name was later changed to Phantom Rider.. The first supernatural Ghost Rider is stunt motorcyclist Johnny Blaze, who, in order to save the life of his father, agreed to give his soul to 'Satan'"
                    },
                    new Movie
                    {
                        Title = "Transporter",
                        ReleaseDate = DateTime.Parse("15-11-2011"),
                        Genre = "Action",
                        Price = 465.67M,
                        Img = "https://upload.wikimedia.org/wikipedia/en/2/2c/%22The_Transporter_Refueled%22_poster.jpg",
                        Rating = "R",
                        Description = "The Transporter Theatrical release poster Directed by Corey Yuen Louis Leterrier Produced by Luc Besson Stephen Chasman Written by Luc Besson Robert Mark Kamen Starring Jason Statham Shu Qi François Berléand Matt Schulze Music byStanley Clarke CinematographyPierre Morel Edited byNicolas Trembasiewicz Production companies EuropaCorp TF1 Films Production Current Entertainment Canal+ Distributed by20th Century Fox Release date 2 October 2002 "
                    },
                    new Movie
                    {
                        Title = "American Ninja",
                        ReleaseDate = DateTime.Parse("15-11-2011"),
                        Genre = "Action",
                        Price = 465.67M,
                        Img = "https://s-media-cache-ak0.pinimg.com/736x/f4/81/1a/f4811a5da759f6bf6637cd4246c80260.jpg",
                        Rating = "R",
                        Description = "American Ninja is a 1985 American martial arts action film produced by Menahem Golan and Yoram Globus's Cannon Films. Directed by Sam Firstenberg, who specialized in this genre in the 1980s, the film stars Michael Dudikoff in the title role, and is the first installment in the American Ninja franchise, followed by American Ninja 2: The Confrontation. It had a mixed reception but it was a financial success and since then, it was considered a cult film."
                    },
                    new Movie
                    {
                        Title = "The A team",
                        ReleaseDate = DateTime.Parse("15-11-2011"),
                        Genre = "Action",
                        Price = 895.67M,
                        Img = "https://s3.amazonaws.com/ffe-ugc/intlportal2/dev-temp/en-US/__595166aa8f7c3.jpg",
                        Rating = "R",
                        Description = "The A-Team is an American action-adventure television series that ran on NBC from 1983 to 1987 about former members of a fictitious United States Army Special Forces unit. The members, after being court-martialed 'for a crime they didn't commit', escaped from military prison and, while still on the run, worked as soldiers of fortune.The series was created by Stephen J. Cannell and Frank Lupo."
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
