namespace movie_App.Models
{
    public static class Repository
    {
        private static List<Movie> _movies = null;

        static Repository()
        {
            _movies = new List<Movie>()
            {
                new Movie(){Id = 1,Name = "shazam",Description="shazam",ImageUrl=""},
                new Movie(){Id = 2,Name = "shazam2",Description="shazam",ImageUrl=""},
                new Movie(){Id = 3,Name = "shazam3",Description="shazam3",ImageUrl=""},
                new Movie(){Id = 4,Name = "shazam4",Description="shazam4",ImageUrl=""}

            };
        }

        public static List<Movie> Movies
        {
            get { return _movies; } 
        }

        public static void AddMovie(Movie entity) { 

            _movies.Add(entity);         
        }    

        public static Movie GetById(int id) { 
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}
