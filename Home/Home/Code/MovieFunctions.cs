using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using DM.MovieApi.ApiRequest;
using DM.MovieApi.ApiResponse;
using DM.MovieApi.MovieDb;
using DM.MovieApi;
using DM.MovieApi.Shims;
using DM.MovieApi.MovieDb.Movies;
using DM.MovieApi.MovieDb.TV;


namespace Home
{
    public class MovieFunctions : IMovieDbSettings
    {
        

        string IMovieDbSettings.ApiKey => "a6c9dbdff726acde2637d95c9fadf778";
        string IMovieDbSettings.ApiUrl => "http://api.themoviedb.org/3/";


        public MovieFunctions()
        {
           MovieDbFactory.RegisterSettings("a6c9dbdff726acde2637d95c9fadf778");
        }

        public MovieFunctions(string apiKey)
        {
            MovieDbFactory.RegisterSettings(apiKey);
        }

       /* public async SearchByTitleAsync(string title)
        {
            title = "Star Trek";
            var movieApi = MovieDbFactory.Create<IApiMovieRequest>().Value;
            ApiSearchResponse<MovieInfo> response = await movieApi.SearchByTitleAsync(title);

            Debug.Flush();
            Debug.WriteLine("Beginning");
            foreach (var info in response.Results)
            {
                Debug.WriteLine("{0} ({1}): {2}", info.Title, info.ReleaseDate, info.Overview);
            }
            Debug.WriteLine("End");
            
        }
        */

    }
}