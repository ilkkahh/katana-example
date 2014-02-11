using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace WebApi.Controller
{
    public class ExampleController : ApiController
    {
        private readonly Dictionary<int, string> _items;

        public ExampleController()
        {
            _items = new Dictionary<int, string>
                     {
                         {0, "Zero"}, {1, "One"}, {2, "Two"}, {3, "Three"}, {4, "Four"}
                     };
        }

        public IDictionary<int, string> Get()
        {
            return _items;
        }


        public KeyValuePair<int, string> Get(int id)
        {
            var item = _items.FirstOrDefault(i => i.Key == id);

            if (item.Value != null)
            {
                return item;
            }

            throw new HttpResponseException(HttpStatusCode.NotFound);
        }
    }
}
