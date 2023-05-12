using System.Net;

namespace VehicleRentalPro.CustomModelWare
{
	public class ExceptionHandlerMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly ILogger<ExceptionHandlerMiddleware> _logger;

		public ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
		{
			_next = next;
			_logger = logger;
		}

		public async Task InvokeAsync(HttpContext context)
		{//HAta mesajlarin log ile yakalamak icin. daha sonra proram.cs -->
			try
			{
				await _next(context);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An unhandle exception occurred.");
				context.Response.StatusCode=(int)HttpStatusCode.InternalServerError;
				context.Response.ContentType = "application/json";
				await context.Response.WriteAsync("{\"message\":\"An error occured. Please try again later.");
			}
		}
	}
}
