using System;
using System.Collections.ObjectModel;
using MovieBrowser.DataModel;

namespace MovieBrowser.Data
{
    public class SampleMovieDataSource
    {
        #region Sample Data
        private static readonly ObservableCollection<Genre> _genres = new ObservableCollection<Genre>
            {
                new Genre
                {
                    Name = "Action",
                    Titles = new ObservableCollection<Title>
                    {
                        new Title
                        {
                            Name = "Action Movie 1",
                            ShortName = "AM1",
                            Synopsis = "This is the longer bit of text that represents a synopsis for the title",
                            ShortSynopsis = "short synopsis",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        },
                        new Title
                        {
                            Name = "Action Movie 2",
                            ShortName = "AM2",
                            Synopsis="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tempor scelerisque lorem in vehicula. Aliquam tincidunt, lacus ut sagittis tristique, turpis massa volutpat augue, eu rutrum ligula ante a ante",
                            ShortSynopsis="short synopsis",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        },
                        new Title
                        {
                            Name = "Action Movie 3",
                            ShortName = "AM3",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        },
                        new Title
                        {
                            Name = "Action Movie 4",
                            ShortName = "AM4",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        },
                        new Title
                        {
                            Name = "Action Movie 5",
                            ShortName = "AM5",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        },
                        new Title
                        {
                            Name = "Action Movie 6",
                            ShortName = "AM6",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        },
                        new Title
                        {
                            Name = "Action Movie 7",
                            ShortName = "AM7",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        },
                        new Title
                        {
                            Name = "Action Movie 8",
                            ShortName = "AM8",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        }
                    }
                },
                new Genre
                {
                    Name = "Comedy",
                    Titles = new ObservableCollection<Title>
                    {
                        new Title
                        {
                            Name = "Comedy Movie 1",
                            ShortName = "CM1",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        },
                        new Title
                        {
                            Name = "Comedy Movie 2",
                            ShortName = "CM2",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        },
                        new Title
                        {
                            Name = "Comedy Movie 3",
                            ShortName = "CM3",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        },
                        new Title
                        {
                            Name = "Comedy Movie 4",
                            ShortName = "CM4",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        },
                        new Title
                        {
                            Name = "Comedy Movie 5",
                            ShortName = "CM5",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        },
                        new Title
                        {
                            Name = "Comedy Movie 6",
                            ShortName = "CM6",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        },
                        new Title
                        {
                            Name = "Comedy Movie 7",
                            ShortName = "CM7",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        },
                        new Title
                        {
                            Name = "Comedy Movie 8",
                            ShortName = "CM8",
                            BoxArt = new BoxArt
                            {
                                SmallUrl = new Uri("ms-appx:Assets/SmallBoxArt.png"),
                                MediumUrl = new Uri("ms-appx:Assets/MediumBoxArt.png"),
                                LargeUrl = new Uri("ms-appx:Assets/LargeBoxArt.png")
                            }
                        }
                    }
                }
        };
        #endregion Sample Data

        public ObservableCollection<Genre> Genres
        {
            get
            {
                return _genres;
            }
        }
    }
}