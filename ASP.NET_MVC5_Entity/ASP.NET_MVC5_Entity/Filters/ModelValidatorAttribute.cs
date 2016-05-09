using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace ASP.NET_MVC5_Entity.Filters
{
	public class ModelValidatorAttribute : ActionFilterAttribute
	{
		//public override void OnActionExecuting(HttpActionContext actionContext)
		//{
		//	if (!actionContext.ModelState.IsValid)
		//	{
		//		actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, actionContext.ModelState);
		//	}


		//	base.OnActionExecuting(actionContext);
		//}
	}
}
