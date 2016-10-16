using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using MovieBrowser.Common;
using MovieBrowser.Data;

namespace MovieBrowser.DataModel
{
    public class MovieBrowserViewModel : BindableBase
    {
        public event EventHandler<ViewTitleEventArgs> ViewTitle;
        public event EventHandler<ViewGenreEventArgs> ViewGenre;

        private SampleMovieDataSource _catalog = new SampleMovieDataSource();

        public MovieBrowserViewModel()
        {
            SelectGenreCommand = new DelegateCommand(
                arg =>
                {
                    var genre = (Genre)arg;
                    SelectedGenre = genre;
                    RaiseViewGenre(genre);
                },
                arg =>
                {
                    return arg is Genre;
                });

            SelectTitleCommand = new DelegateCommand(
                arg =>
                {
                    var title = (Title)arg;
                    SelectedTitle = title;
                    SelectedGenre = Genres.Where(g => g.Titles.Contains(title)).FirstOrDefault();
                    RaiseViewTitle(title);
                },
                arg =>
                {
                    return arg is Title;
                });
        }

        public ObservableCollection<Genre> Genres
        {
            get { return _catalog.Genres; }
        }

        private Genre _selectedGenre;
        public Genre SelectedGenre
        {
            get
            {
                return _selectedGenre;
            }
            set
            {
                SetProperty(ref _selectedGenre, value);
            }
        }

        private Title _selectedTitle;
        public Title SelectedTitle
        {
            get
            {
                return _selectedTitle;
            }
            set
            {
                SetProperty(ref _selectedTitle, value);
            }
        }

        public ICommand SelectTitleCommand
        {
            get;
            private set;
        }

        public ICommand SelectGenreCommand
        {
            get;
            private set;
        }

        private void RaiseViewTitle(Title title)
        {
            if (ViewTitle != null)
            {
                ViewTitle(this, new ViewTitleEventArgs(title));
            }
        }

        private void RaiseViewGenre(Genre genre)
        {
            if(ViewGenre != null)
            {
                ViewGenre(this, new ViewGenreEventArgs(genre));
            }
        }
    }
}
