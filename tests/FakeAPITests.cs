using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework.Internal;
using RestSharp;

namespace fakeapi.tests
{
    public class FakeAPITests
    {
        public string BaseURL = "https://fakerestapi.azurewebsites.net/";
        [Test]
        public void SearchBooks()
        {
            var url = BaseURL + "/api/v1/Books";
            RestClient client = new(url);
            RestRequest restRequest = new(url, Method.Get);
            RestResponse restResponse = client.Execute<RestRequest>(restRequest);
            restResponse.Should().NotBeNull();
            restResponse.StatusCode.Should().Be(HttpStatusCode.OK);

        }
    }
}