using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using trail.Models;

namespace trail.api
{
    public class NumberAddSubController : ApiController
    {
        [HttpPost]
        [Route("add")]
        public async Task<int> Add()
        {
            var modelValue = await GetModelValue();

            ModelValue.MvcValue = modelValue.value + 1;

            return ModelValue.MvcValue;
        }


        [HttpPost]
        [Route("sub")]
        public async Task<int> Sub()
        {
            var modelValue = await GetModelValue();

            ModelValue.MvcValue = modelValue.value - 1;

            return ModelValue.MvcValue;
        }

        private async Task<dynamic> GetModelValue()
        {
            var message = await Request.Content.ReadAsStringAsync();

            var modelValue = JsonConvert.DeserializeObject<dynamic>(message);
            return modelValue;
        }
    }
}
