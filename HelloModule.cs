using Nancy;
using System.Collections.Generic;
namespace HelloNancy
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get("/", args =>
                        {
                            ViewBag.greeting = "HELLOOOOOOOO";
                            ViewBag.show = true;
                            List<string> listOfUsers = new List<string>
                                { "Cindy", "An", "Wendy", "Josey"};
                            return View["Hello.sshtml", listOfUsers];
                        });

            Post("/formsubmitted", args =>
            {
                string User = Request.Form["name"];
                Session["User"] = User;
                return Response.AsRedirect("/");
            });
        }
    }
}