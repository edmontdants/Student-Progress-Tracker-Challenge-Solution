using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net;

namespace StudentProgress.Tests.Controllers
{
    public class StudentsControllerTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public StudentsControllerTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetAll_ReturnsOk()
        {
            var response = await _client.GetAsync("/api/students");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetById_ReturnsNotFound_ForUnknownId()
        {
            var id = Guid.NewGuid();
            var response = await _client.GetAsync($"/api/students/{id}");
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
