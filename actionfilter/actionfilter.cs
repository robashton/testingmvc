namespace MyLittlePonyCrm {

  public class LogMyFavouritePony : ActionFilterAttribute {
    FavouritePonyLogger logging;

    public LogMyFavouritePony(FavouritePonyLogger logging) {
      this.logging = logging;
    }

    public override void OnActionExecuting(ActionExecutingContext filterContext) {
      var user = ((CustomControllerBase)filterContext.Controller).User;

      if(!user.IsAuthenticated)
        return;

      if(!user.AllowsPonyTracking())
        return;

      logging.LogFavouritePony(user.FavouritePony, filterContext.HttpContext.Request.Path);
    }
  }
}
