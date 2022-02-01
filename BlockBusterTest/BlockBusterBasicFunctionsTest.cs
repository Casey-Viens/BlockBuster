using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BlockBuster;
namespace BlockBusterTest
{
    public class BlockBusterBasicFunctionsTest
    {

        [Fact]
        public void GetMovieByIDTest()
        {
            var result = BlockBusterBasicFunctions.GetMovieByID(11);
            Assert.True(result.Title == "Vertigo");
            Assert.True(result.ReleaseYear == 1958);
        }

        [Fact]
        public void GetAllMoviesTest()
        {
            var result = BlockBusterBasicFunctions.GetAllMovies();
            Assert.True(result.Count == 49);
        }

        [Fact]
        public void GetAllCheckedOutMovies()
        {
            var result = BlockBusterBasicFunctions.GetAllCheckedOutMovies();
            Assert.True(result.Count == 3);
        }

    }
}
