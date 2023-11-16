namespace Modern.Crown.Domain.Tests;
using Modern.Crown.Domain.Tests;
using Modern.Crown.Domain;
using Modern.Crown.Domain.Catalog;

[TestClass]
public class ItemTests
{
    [TestMethod]
        public void Can_Create_New_Items()
        {
            var item = new Item("Name", "Description", "Brand", 10.00m);
            Assert.AreEqual("Name", item.Name);
            Assert.AreEqual("Description", item.Description);
            Assert.AreEqual("Brand", item.Brand);
            Assert.AreEqual(10.00m, item.Price);
        }
    [TestMethod]
    public void Can_Create_Add_Rating()
    {
        //Arrange
        var item = new Item("Name", "Description", "Brand", 10.00m);
        var rating = new Rating(5,"Name","Review");
        //Act
        item.AddRating(rating);
        //Assert
        Assert.AreEqual(rating,item.Ratings[0]);
    }
}