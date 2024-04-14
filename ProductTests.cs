using Xunit;
using LabWebApp.Models; 
namespace TestProject1
{
    public class ProductTests
    {
        [Fact]
        public void Product_PropertiesSetCorrectly()
        {
            // Arrange
            var product = new Product
            {
                Id = 1,
                Name = "Test Product",
                Price = 9.99m,
                Description = "Test product description"
            };

            // Act
            // (No action needed for this test.)

            // Assert
            Assert.Equal(1, product.Id);
            Assert.Equal("Test Product", product.Name);
            Assert.Equal(9.99m, product.Price);
            Assert.Equal("Test product description", product.Description);
        }
    }
}
