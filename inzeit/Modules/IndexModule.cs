using Nancy;

namespace inzeit.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                return View["gert"];
            };
        }
    }
}