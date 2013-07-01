namespace MyLittlePonyCrm {

  [TestFixture]
  public class PonyLogger {

    [Test]
    public void SomeTest() {

      // Arrange
      var context = new ActionExecutingContext();
      var fakeHttpContext = new Mock<HttpContextBase>();
      var fakeRequest = new Mock<HttpRequestBase>();
      var user = new Mock<Brony>();

      context.HttpContext = fakeHttpContext.Object;
      fakeHttpContext.Get(x=>x.Request, fakeRequest.Object);
      fakeRequest.Get(x => x.User, fakeUser.Object);
      user.Get(x=> x.FavouritePony, "Rainbow Dash");

      var loggerMock = new Mock<FavouritePonyLogger>();
      var attribute = new LogMyFavouritePony(logger.Object);

      // Act
      attribute.OnActionExecuting(context.Object);

      // Assert
      loggerMock.WasCalled(x=>x.LogFavouritePony(y=> Is.EqualTo(y, "Rainbow Dash")));
      
    }
  }
}
