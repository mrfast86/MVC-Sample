using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventfulSearchWebsite;
using EventfulSearchWebsite.Controllers;
using Moq;
using Entities = EventfulSearch.Business.EntitiesImplementation;

namespace EventfulSearchWebsite.Tests.Controllers
{
    using System.Threading.Tasks;

    using EventfulSearch.Common;
    using EventfulSearch.Common.Entities;

    using EventfulSearchWebsite.Models;

    [TestClass]
    public class HomeControllerTest
    {
        private Mock<IGeoCodeDomain> geoCodeDomainMock;
        private Mock<IEventfulSearchDomain> eventfulSearchDomainMock;
        private HomeController target;

        [TestInitialize]
        public void Init()
        {
            geoCodeDomainMock = new Mock<IGeoCodeDomain>();
            eventfulSearchDomainMock = new Mock<IEventfulSearchDomain>();

            target = new HomeController(
                geoCodeDomainMock.Object, eventfulSearchDomainMock.Object);
        }

        [TestMethod]
        public async Task Products()
        {
            var expectedcoordinates = new Entities.Location();
            var expectedResults = new List<IEventfulSearch>
                                    {
                                        new Entities.EventfulSearch(),
                                        new Entities.EventfulSearch()
                                    };

            geoCodeDomainMock
                .Setup(x => x.GetLocationAsync(It.IsAny<string>()))
                .Returns(Task.FromResult<ILocation>(expectedcoordinates));
            eventfulSearchDomainMock
                .Setup(x => x.SearchAsync(It.IsAny<SearchParam>()))
                .Returns(Task.FromResult<IEnumerable<IEventfulSearch>>(expectedResults));

            //act
            var result = await target.SearchAsync(new SearchViewModel()) as ViewResult;

            //assert
            var model = result.Model as SearchViewModel;
            Assert.AreEqual(model.SearchResults, expectedResults);
        }
    }
}
