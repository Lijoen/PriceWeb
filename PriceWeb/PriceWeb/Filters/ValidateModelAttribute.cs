using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace PriceWeb.Filters
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ModelState.IsValid)
                return;

            IEnumerable<String> allErrors = context.ModelState.Values.SelectMany(v => v.Errors).Select(o => o.ErrorMessage);

            if (!string.IsNullOrEmpty(allErrors?.First()))
                context.Result = new Microsoft.AspNetCore.Mvc.BadRequestObjectResult(new { message = allErrors });
            else
                context.Result = new Microsoft.AspNetCore.Mvc.BadRequestObjectResult(new { message = "Could not validate modelstate" });

            base.OnActionExecuting(context);
        }
    }
}
