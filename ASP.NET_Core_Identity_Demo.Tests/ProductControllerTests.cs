using ASP.NET_Core_Identity_Demo.Controllers;
using ASP.NET_Core_Identity_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ASP.NET_Core_Identity_Demo.Tests
{
    public class ProductControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        // Refer to the docs (applies even though it's for Version 6.0): https://docs.microsoft.com/en-us/aspnet/core/test/integration-tests?view=aspnetcore-6.0
        private readonly WebApplicationFactory<Startup> _factory;

        public ProductControllerTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/Product")]
        [InlineData("/Product/")]
        [InlineData("/Product/Index")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }

        [Theory]
        [InlineData("/ViewProduct/1")]
        public async Task Get_EndpointsReturnFailAndCorrectContentType(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            var didNotFail = response.IsSuccessStatusCode;
            Assert.Equal("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
            Assert.False(didNotFail);
        }










        //private readonly IProductRepository _productRepository;

        //public ProductControllerTests(IProductRepository productRepository)
        //{
        //    _productRepository = productRepository;
        //}

        //[Fact]
        //public void ShouldGetProducts()
        //{
        //    var controller = new ProductController(_productRepository);
        //    var result = controller.Index(null, null) as ViewResult;
        //    var products = (IEnumerable<Product>) result.ViewData.Model;
        //    Assert.NotNull(products);
        //    Assert.True(products.Any());
        //}
    }
}
