namespace MyLittlePonyCrm {
  public class PonyController : Controller {

    public PonyController() {

    }

    public ActionResult Create(NewPonyInput input) {
      if(!ModelState.IsValid) 
        return View("Create", input);
      return RedirectToAction("List");
    }
  }

}


