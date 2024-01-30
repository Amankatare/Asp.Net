using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestSharp;
using System.Diagnostics;
using WhatsappEnquiry.Data;
using WhatsappEnquiry.Models;

namespace WhatsappEnquiry.Controllers
{
    public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ApiContext _context;

        public HomeController(ILogger<HomeController> logger,ApiContext context)
		{
			_logger = logger;
			_context = context;
		}

		public IActionResult Index() 
		{
            //var list =  _context.apis.ToList();
			return View(); 
		}

        public IActionResult Create(WhatsappApiModel model)
        {
            if (ModelState.IsValid)
            {
                var url = "https://api.ultramsg.com/instance76285/messages/chat";
                var client = new RestClient(url);

                var request = new RestRequest(url, Method.Post);
                request.AddHeader("content-type", "application/pdf");
                request.AddQueryParameter("token", "tp3lrcx4aha78wy7");
                request.AddQueryParameter("to", "7223011067");
                request.AddQueryParameter("body", $"Name: {model.Name} \n + Email : {model.Email} \n + Phone: {model.Phone} \n + Message : {model.Message}"); 

                RestResponse response = client.Execute(request);
                var output = response.Content;
                Console.WriteLine(output);

                return View("Index", output + "\n\n Successfully sent");
            }

            return View("Create");
        }

        public IActionResult Privacy()
			{
				return View();
			}

			[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

			public IActionResult Error()
			{
				return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
			}
		}

	}
