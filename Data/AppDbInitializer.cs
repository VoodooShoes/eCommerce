using eCommerce.Models;

namespace eCommerce.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<CinemaModel>()
                    {
                        new CinemaModel()
                        {
                            Name = "20th Century Fox",
                            Logo = "lib/Images/Cinemas/20th_Century.png",
                            Description = "20th Century Studios, Inc. is an American film production studio headquartered at the Fox Studio Lot in the Century City area of Los Angeles."
                        },
                        new CinemaModel()
                        {
                            Name = "Columbia Pictures",
                            Logo = "/lib/Images/Cinemas/Columbia_pictures.png",
                            Description = "Columbia Pictures Industries, Inc. is an American film production studio that is a member of the Sony Pictures Motion Picture Group, a division of Sony Pictures Entertainment, which is one of the Big Five studios and a subsidiary of the multinational conglomerate Sony."
                        },
                        new CinemaModel()
                        {
                            Name = "Fox Searchlight Pictures",
                            Logo = "/lib/Images/Cinemas/fox_searchlight_pictures.png",
                            Description = "Searchlight Pictures, Inc. is an American film studio that is a division of 20th Century Studios, a subsidiary of Walt Disney Studios, which is part of The Walt Disney Company."
                        },
                        new CinemaModel()
                        {
                            Name = "Lionsgate",
                            Logo = "/lib/Images/Cinemas/lionsgate.png",
                            Description = "Lions Gate Entertainment Corporation, is a Canadian-American entertainment company. It was formed by Frank Giustra on July 10, 1997, domiciled in Vancouver, British Columbia, Canada and is currently headquartered in Santa Monica, California, United States."
                        },
                        new CinemaModel()
                        {
                            Name = "Marvel Studios",
                            Logo = "/lib/Images/Cinemas/marvel_studios.png",
                            Description = "Marvel Studios, LLC is an American film and television production company that is a subsidiary of Walt Disney Studios, a division of the Walt Disney Company. Marvel Studios produces the Marvel Cinematic Universe films, based on characters that appear in Marvel Comics publications. "
                        },
                        new CinemaModel()
                        {
                            Name = "Miramax",
                            Logo = "/lib/Images/Cinemas/miramax.png",
                            Description = "Miramax, LLC is an American entertainment company known for producing and distributing films and television shows. Its headquarters are located in Los Angeles, California."
                        },
                        new CinemaModel()
                        {
                            Name = "New Line Cinema",
                            Logo = "/lib/Images/Cinemas/new_line_cinema.png",
                            Description = "New Line Cinema is an American film production studio and label of Warner Bros. It was founded in 1967 by Robert Shaye as an independent film distribution company; later becoming a film studio."
                        },
                        new CinemaModel()
                        {
                            Name = "Paramount",
                            Logo = "/lib/Images/Cinemas/paramount.png",
                            Description = "Paramount Pictures Corporation is an American film and television production and distribution company and the main namesake division of Paramount Global."
                        },
                        new CinemaModel()
                        {
                            Name = "Sony",
                            Logo = "/lib/Images/Cinemas/sony.png",
                            Description = "Sony Pictures Entertainment Inc. is an American diversified multinational mass media and entertainment studio conglomerate that produces, acquires, and distributes filmed entertainment through multiple platforms."
                        },
                        new CinemaModel()
                        {
                            Name = "Studio Ghibli",
                            Logo = "/lib/Images/Cinemas/studio_ghibli.png",
                            Description = "Studio Ghibli Inc. is a Japanese animation film studio headquartered in Koganei, Tokyo. It is best known for its animated feature films, and has also produced several short subjects, television commercials, and two television films."
                        },
                        new CinemaModel()
                        {
                            Name = "The Weinstein Company",
                            Logo = "/lib/Images/Cinemas/the_weinstein_company.png",
                            Description = "The Weinstein Company was an American independent film studio, founded in New York City by Bob and Harvey Weinstein on March 10, 2005."
                        },
                        new CinemaModel()
                        {
                            Name = "Touchstone Pictures",
                            Logo = "/lib/Images/Cinemas/touchstone_pictures.png",
                            Description = "Touchstone Pictures, Inc. is a defunct American film production label of Walt Disney Studios, founded and owned by The Walt Disney Company."
                        },
                        new CinemaModel()
                        {
                            Name = "Universal Studios",
                            Logo = "/lib/Images/Cinemas/universal_studios.png",
                            Description = "Universal Pictures is an American film production and distribution company owned by Comcast through the NBCUniversal Film and Entertainment division of NBCUniversal."
                        },
                        new CinemaModel()
                        {
                            Name = "Warner Brothers",
                            Logo = "/lib/Images/Cinemas/warner_brothers.png",
                            Description = "Warner Bros. Entertainment Inc. is an American entertainment conglomerate headquartered at the Warner Bros. Studios complex in Burbank, California, and a division of Warner Bros. Discovery."
                        }

                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<ActorModel>()
                    {
                        new ActorModel()
                        {
                            FullName = "A. J. Cook",
                            Bio = "Andrea Joy Cook is a Canadian actress. She is best known for her role as Supervisory Special Agent Jennifer Jareau on the CBS crime drama Criminal Minds. Cook has also appeared in The Virgin Suicides, Higher Ground, Ripper, Out Cold, Final Destination 2, and Tru Calling.",
                            ProfilePictureURL = "/lib/Images/Actors/a_j_cook.png"
                        },
                        new ActorModel()
                        {
                            FullName = "Aaron Eckhart",
                            Bio = "Aaron Edward Eckhart is an American actor. Born in Cupertino, California, Eckhart moved to the United Kingdom at an early age, when his father relocated the family. Several years later, he began his acting career by performing in school plays, before moving to Australia for his high school senior year. ",
                            ProfilePictureURL = "/lib/Images/Actors/aaron_eckhart.png"
                        },
                        new ActorModel()
                        {
                            FullName = "Alfie Allen",
                            Bio = "Alfie Evan Allen is an English actor. He portrayed Theon Greyjoy on all eight seasons of the HBO fantasy series Game of Thrones, for which he received a nomination for the Primetime Emmy Award for Outstanding Supporting Actor in a Drama Series.",
                            ProfilePictureURL = "/lib/Images/Actors/alfie_allen.png"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<ProducerModel>()
                    {
                        new ProducerModel()
                        {
                            FullName = "Kevin Feige",
                            Bio = "Kevin Feige is an American film and television producer who has been the president of Marvel Studios and the primary producer of the Marvel Cinematic Universe franchise since 2007.",
                            ProfilePictureURL = "/lib/Images/Producers/kevin_feige.png"
                        },
                        new ProducerModel()
                        {
                            FullName = "Lawrence Bender",
                            Bio = "Lawrence Bender is an American film producer. Throughout his career, Bender-produced films have received 36 Academy Award nominations, resulting in eight wins.",
                            ProfilePictureURL = "/lib/Images/Producers/lawrence_bender.png"
                        },
                        new ProducerModel()
                        {
                            FullName = "Martin Scorsese",
                            Bio = "Martin Charles Scorsese is an American film director, producer, screenwriter and actor. He is the recipient of many accolades, including an Academy Award, three Primetime Emmy Awards, a Grammy Award, four British Academy Film Awards, three Golden Globe Awards, and two Directors Guild of America Awards.",
                            ProfilePictureURL = "/lib/Images/Producers/martin_scorsese.png"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<MovieModel>()
                    {
                        new MovieModel()
                        {
                            Name = "Amadeus",
                            Description = "Wolfgang Amadeus Mozart (Tom Hulce) is a remarkably talented young Viennese composer who unwittingly finds a fierce rival in the disciplined and determined Antonio Salieri (F. Murray Abraham).",
                            ImageURL = "/lib/Images/Movies/amadeus.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 4,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama
                        },
                        new MovieModel()
                        {
                            Name = "Chef",
                            Description = "After a controlling owner (Dustin Hoffman) pushes him too far, chef Carl Casper (Jon Favreau) quits his position at a prestigious Los Angeles restaurant. As he tries to figure out what his next step should be, he finds himself in Miami.",
                            ImageURL = "/lib/Images/Movies/chef.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 2,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama
                        },
                        new MovieModel()
                        {
                            Name = "The Dark Knight",
                            Description ="With the help of allies Lt. Jim Gordon (Gary Oldman) and DA Harvey Dent (Aaron Eckhart), Batman (Christian Bale) has been able to keep a tight lid on crime in Gotham City. But when a vile young criminal calling himself the Joker (Heath Ledger) suddenly throws the town into chaos, the caped Crusader begins to tread a fine line between heroism and vigilantism.",
                            ImageURL = "/lib/Images/Movies/dark_knight.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 6,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Dawn of the Planet of the Apes",
                            Description ="Ten years after simian flu wiped out much of the world's homosapiens, genetically enhanced chimpanzee Caesar (Andy Serkis) and his ever-growing band of followers have established a thriving colony just outside San Francisco in Muir Woods. Meanwhile, a small band of human survivors emerges, which forces Caesar -- as leader -- to grapple with the dual challenge of protecting his people and re-establishing a relationship with the remaining human population -- the latter being Caesar's secret wish.",
                            ImageURL = "/lib/Images/Movies/dawn_of_the_planet_of_the_apes.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Django Unchained",
                            Description = "Two years before the Civil War, Django (Jamie Foxx), a slave, finds himself accompanying an unorthodox German bounty hunter named Dr. King Schultz (Christoph Waltz) on a mission to capture the vicious Brittle brothers. Their mission successful, Schultz frees Django, and together they hunt the South's most-wanted criminals. Their travels take them to the infamous plantation of shady Calvin Candie (Leonardo DiCaprio), where Django's long-lost wife (Kerry Washington) is still a slave.",
                            ImageURL = "/lib/Images/Movies/django.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Fight Club",
                            Description ="A depressed man (Edward Norton) suffering from insomnia meets a strange soap salesman named Tyler Durden (Brad Pitt) and soon finds himself living in his squalid house after his perfect apartment is destroyed. The two bored men form an underground club with strict rules and fight other men who are fed up with their mundane lives. Their perfect partnership frays when Marla (Helena Bonham Carter), a fellow support group crasher, attracts Tyler's attention.",
                            ImageURL = "/lib/Images/Movies/fight_club.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Friday",
                            Description = "In South Central Los Angeles and the exploits of perpetually unemployed Craig Jones, who along with his friends and relatives, are thrust into various situations that happen to occur on a Friday.",
                            ImageURL = "/lib/Images/Movies/friday.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Goodfellas",
                            Description ="Henry Hill (Ray Liotta) grows up in the mob and works very hard to advance himself through the ranks. He enjoys his life of money and luxury, but is oblivious to the horror that he causes. A drug addiction and a few mistakes ultimately unravel his climb to the top.",
                            ImageURL = "/lib/Images/Movies/goodfellas.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Guardians of the Galaxy Vol. 1",
                            Description = "Brash space adventurer Peter Quill (Chris Pratt) finds himself the quarry of relentless bounty hunters after he steals an orb coveted by Ronan, a powerful villain. To evade Ronan, Quill is forced into an uneasy truce with four disparate misfits: gun-toting Rocket Raccoon, treelike-humanoid Groot, enigmatic Gamora, and vengeance-driven Drax the Destroyer. But when he discovers the orb's true power and the cosmic threat it poses, Quill must rally his ragtag group to save the universe.",
                            ImageURL = "/lib/Images/Movies/guardians_galaxy_vol_1.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Guardians of the Galaxy Vol. 2",
                            Description = "Peter Quill and his fellow Guardians are hired by a powerful alien race, the Sovereign, to protect their precious batteries from invaders. When it is discovered that Rocket has stolen the items they were sent to guard, the Sovereign dispatch their armada to search for vengeance. As the Guardians try to escape, the mystery of Peter's parentage is revealed.",
                            ImageURL = "/lib/Images/Movies/guardians_galaxy_vol_2.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "The Hateful 8",
                            Description = "While racing toward the town of Red Rock in post-Civil War Wyoming, bounty hunter John \"The Hangman\" Ruth (Kurt Russell) and his fugitive prisoner (Jennifer Jason Leigh) encounter another bounty hunter (Samuel L. Jackson) and a man who claims to be a sheriff. Hoping to find shelter from a blizzard, the group travels to a stagecoach stopover located on a mountain pass. Greeted there by four strangers, the eight travelers soon learn that they may not make it to their destination after all.",
                            ImageURL = "/lib/Images/Movies/hateful_8.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Inglorious Bastards",
                            Description = "It is the first year of Germany's occupation of France. Allied officer Lt. Aldo Raine (Brad Pitt) assembles a team of Jewish soldiers to commit violent acts of retribution against the Nazis, including the taking of their scalps. He and his men join forces with Bridget von Hammersmark, a German actress and undercover agent, to bring down the leaders of the Third Reich. Their fates converge with theater owner Shosanna Dreyfus, who seeks to avenge the Nazis' execution of her family.",
                            ImageURL = "/lib/Images/Movies/inglorious_bastards.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "John Wick",
                            Description = "Assassin John Wick (Keanu Reeves) and hunts down the men who broke into his home, stole his vintage car and killed his puppy, which was a last gift to him from his recently deceased wife.",
                            ImageURL = "/lib/Images/Movies/john_wick.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Kung Pow Enter the Fist",
                            Description = "A man, called The Chosen One by the narrator, wanders from town to town to search for the man who killed his family and tried to kill him when he was a baby.",
                            ImageURL = "/lib/Images/Movies/kung_pow_enter_the_fist.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "O' Brother Where Art Thou",
                            Description = "Ulysses Everett McGill (George Clooney) is having difficulty adjusting to his hard-labor sentence in Mississippi. He scams his way off the chain gang with simple Delmar (Tim Blake Nelson) and maladjusted Pete (John Turturro), then the trio sets out to pursue freedom and the promise of a fortune in buried treasure. With nothing to lose and still in shackles, their hasty run takes them on an incredible journey of awesome experiences and colorful characters.",
                            ImageURL = "/lib/Images/Movies/o_brother_where_art_thou.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Once Upon A Time In Hollywood",
                            Description = "Actor Rick Dalton gained fame and fortune by starring in a 1950s television Western, but is now struggling to find meaningful work in a Hollywood that he doesn't recognize anymore. He spends most of his time drinking and palling around with Cliff Booth, his easygoing best friend and longtime stunt double. Rick also happens to live next door to Roman Polanski and Sharon Tate -- the filmmaker and budding actress whose futures will forever be altered by members of the Manson Family.",
                            ImageURL = "/lib/Images/Movies/once_upon_a_time_in_hollywood.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Out Cold",
                            Description = "A bunch of snowboarding employees at an Alaskan ski resort try to outsmart a leisure mogul who has major redevelopment plans for the business - plans that include getting rid of most of the party-loving staff. Matters are complicated when the mogul's two daughters show up on the scene and it transpires that one of them dumped the resort's snowboard king several years before.",
                            ImageURL = "/lib/Images/Movies/out_cold.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Princess Mononoke",
                            Description = "In the 14th century, the harmony that humans, animals and gods have enjoyed begins to crumble. The protagonist, young Ashitaka - infected by an animal attack, seeks a cure from the deer-like god Shishigami. In his travels, he sees humans ravaging the earth, bringing down the wrath of wolf god Moro and his human companion Princess Mononoke. Hiskattempts to broker peace between her and the humans brings only conflict.",
                            ImageURL = "/lib/Images/Movies/princess_mononoke.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Pulp Fiction",
                            Description = "Vincent Vega (John Travolta) and Jules Winnfield (Samuel L. Jackson) are hitmen with a penchant for philosophical discussions. In this ultra-hip, multi-strand crime movie, their storyline is interwoven with those of their boss, gangster Marsellus Wallace (Ving Rhames) ; his actress wife, Mia (Uma Thurman) ; struggling boxer Butch Coolidge (Bruce Willis) ; master fixer Winston Wolfe (Harvey Keitel) and a nervous pair of armed robbers, \"Pumpkin\" (Tim Roth) and \"Honey Bunny\" (Amanda Plummer).",
                            ImageURL = "/lib/Images/Movies/pulp_fiction.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Saving Private Ryan",
                            Description = "Captain John Miller (Tom Hanks) takes his men behind enemy lines to find Private James Ryan, whose three brothers have been killed in combat. Surrounded by the brutal realties of war, while searching for Ryan, each man embarks upon a personal journey and discovers their own strength to triumph over an uncertain future with honor, decency and courage.",
                            ImageURL = "/lib/Images/Movies/saving_private_ryan.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "Andy Dufresne (Tim Robbins) is sentenced to two consecutive life terms in prison for the murders of his wife and her lover and is sentenced to a tough prison. However, only Andy knows he didn't commit the crimes. While there, he forms a friendship with Red (Morgan Freeman), experiences brutality of prison life, adapts, helps the warden, etc., all in 19 years.",
                            ImageURL = "/lib/Images/Movies/shawshank_redemption.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Spiderman: Homecoming",
                            Description = "Thrilled by his experience with the Avengers, young Peter Parker returns home to live with his Aunt May. Under the watchful eye of mentor Tony Stark, Parker starts to embrace his newfound identity as Spider-Man. He also tries to return to his normal daily routine -- distracted by thoughts of proving himself to be more than just a friendly neighborhood superhero. Peter must soon put his powers to the test when the evil Vulture emerges to threaten everything that he holds dear.",
                            ImageURL = "/lib/Images/Movies/spiderman_homecoming.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Spiderman Into the Spiderverse",
                            Description = "Bitten by a radioactive spider in the subway, Brooklyn teenager Miles Morales suddenly develops mysterious powers that transform him into the one and only Spider-Man. When he meets Peter Parker, he soon realizes that there are many others who share his special, high-flying talents. Miles must now use his newfound skills to battle the evil Kingpin, a hulking madman who can open portals to other universes and pull different versions of Spider-Man into our world.",
                            ImageURL = "/lib/Images/Movies/spiderman_into_the_spiderverse.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Spirited Away",
                            Description = "Chihiro Ogino, a ten-year-old girl who, while moving to a new neighborhood, enters the world of Kami. After her parents are turned into pigs by the witch Yubaba, Chihiro takes a job working in Yubaba's bathhouse to find a way to free herself and her parents and return to the human world.",
                            ImageURL = "/lib/Images/Movies/spirited_away.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Super Troopers",
                            Description = "Five Vermont state troopers, avid pranksters with a knack for screwing up, try to save their jobs and out-do the local police department by solving a crime.",
                            ImageURL = "/lib/Images/Movies/super_troopers.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Superbad",
                            Description = "Two inseparable best friends navigate the last weeks of high school and are invited to a gigantic house party. Together with their nerdy friend, they spend a long day trying to score enough alcohol to supply the party and inebriate two girls in order to kick-start their sex lives before they go off to college. Their quest is complicated after one of them falls in with two inept cops who are determined to show him a good time.",
                            ImageURL = "/lib/Images/Movies/superbad.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Teenage Mutant Ninja Turtles",
                            Description = "In New York, mysterious radioactive ooze has mutated four sewer turtles into talking, upright-walking, crime-fighting ninjas. The intrepid heroes -- Michelangelo (Robbie Rist), Donatello (Corey Feldman), Raphael (Josh Pais) and Leonardo (Brian Tochi) -- are trained in the Ninjutsu arts by their rat sensei, Splinter. When a villainous rogue ninja, who is a former pupil of Splinter, arrives and spreads lawlessness throughout the city, it's up to the plucky turtles to stop him.",
                            ImageURL = "/lib/Images/Movies/teenage_mutant_ninja_turtles.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "The Suicide Squad",
                            Description = "The government sends the most dangerous supervillains in the world -- Bloodsport, Peacemaker, King Shark, Harley Quinn and others -- to the remote, enemy-infused island of Corto Maltese. Armed with high-tech weapons, they trek through the dangerous jungle on a search-and-destroy mission, with only Col. Rick Flag on the ground to make them behave.",
                            ImageURL = "/lib/Images/Movies/the_suicide_squad.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "Whiplash",
                            Description = "Andrew Neiman (Miles Teller) is an ambitious young jazz drummer, in pursuit of rising to the top of his elite music conservatory. Terence Fletcher (J.K. Simmons), an instructor known for his terrifying teaching methods, discovers Andrew and transfers the aspiring drummer into the top jazz ensemble, forever changing the young man's life. But Andrew's passion to achieve perfection quickly spirals into obsession, as his ruthless teacher pushes him to the brink of his ability and his sanity.",
                            ImageURL = "/lib/Images/Movies/whiplash.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        },
                        new MovieModel()
                        {
                            Name = "The Wolf of Wall Street",
                            Description = "In 1987, Jordan Belfort (Leonardo DiCaprio) takes an entry-level job at a Wall Street brokerage firm. By the early 1990s, while still in his 20s, Belfort founds his own firm, Stratton Oakmont. Together with his trusted lieutenant (Jonah Hill) and a merry band of brokers, Belfort makes a huge fortune by defrauding wealthy investors out of millions. However, while Belfort and his cronies partake in a hedonistic brew of sex, drugs and thrills, the SEC and the FBI close in on his empire of excess.",
                            ImageURL = "/lib/Images/Movies/wolf_of_wall_street.png",
                            Price = 14.99,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCatagory = Enums.MovieCatagory.Drama

                        }
                    });
                    context.SaveChanges();
                }
                //Actors and Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_MovieModel>()
                    {
                        new Actor_MovieModel()
                        {
                            ActorId = 1,
                            MovieId = 2,
                        },
                        new Actor_MovieModel()
                        {
                            ActorId= 3,
                            MovieId= 4,
                        },
                        new Actor_MovieModel()
                        {
                            ActorId = 1,
                            MovieId= 6,
                        },
                        new Actor_MovieModel()
                        {
                            ActorId = 1,
                            MovieId = 5
                        },
                        new Actor_MovieModel()
                        {
                            ActorId = 2,
                            MovieId = 10
                        },
                        new Actor_MovieModel()
                        {
                            ActorId = 3,
                            MovieId = 1,
                        },
                        new Actor_MovieModel()
                        {
                            ActorId =  2,
                            MovieId = 8
                        },
                        new Actor_MovieModel()
                        {
                            ActorId = 1,
                            MovieId = 11
                        }
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
