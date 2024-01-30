using Microsoft.EntityFrameworkCore;
using WhatsappEnquiry.Models;

namespace WhatsappEnquiry.Data
{
	public class ApiContext:DbContext
    {

		public ApiContext(DbContextOptions<ApiContext> options):base(options) { }

        public DbSet<WhatsappApiModel> apis { get; set; }
        
    }
}
