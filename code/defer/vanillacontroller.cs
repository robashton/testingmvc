namespace MyLittlePonyCrm {
  public class PonyController : Controller {
    IHousePonies stable;

    public PonyController(IHousePonies stable) {
      this.stable = stable;
    }

    public ActionResult Create(NewPonyInput input) {
      if(!ModelState.IsValid) 
        return View("Create", input);

      stable.House(input.ToPony());

      //TODO: Persist pretty ponies
      return RedirectToAction("List");
    }
  }

}


