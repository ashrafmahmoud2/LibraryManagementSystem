using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
	public class AuthorsController : Controller
	{
		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;

        public AuthorsController(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
			_mapper = mapper;
        }

        public IActionResult Index()
		{
			var Authors=_context.
			return View();
		}
	}
}
