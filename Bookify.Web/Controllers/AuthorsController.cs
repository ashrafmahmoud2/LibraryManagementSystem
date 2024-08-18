﻿namespace LibraryManagementSystem.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AuthorsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var authors = _context.Authors.AsNoTracking().ToList();
            var viewModels = _mapper.Map<IEnumerable<AuthorViewModel>>(authors);
            return View(viewModels);
        }

        public IActionResult Create()
        {
            return PartialView("_Form");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AuthorFormViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();


            var author = _mapper.Map<Author>(model);
            _context.Add(author);
            _context.SaveChanges();

            var viewModel = _mapper.Map<AuthorViewModel>(author);
            return View("_AuthorRow", viewModel);
        }

        [HttpGet]
        [AjaxOnly]
        public IActionResult Edit(int id)
        {
            var author = _context.Authors.Find(id);


            var viewModel = _mapper.Map<AuthorFormViewModel>(author);
            return PartialView("_Form", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AuthorFormViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var author = _context.Authors.Find(model.Id);

            if (author is null)
                return NotFound();

            author = _mapper.Map(model, author);
            author.LastUpdatedOn = DateTime.Now;

            _context.SaveChanges();

            var viewModel = _mapper.Map<AuthorViewModel>(author);

            return PartialView("_AuthorRow", viewModel);
        }

        public IActionResult ToggleStatus(int Id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var author = _context.Authors.Find(Id);

            if (author is null)
                return NotFound();

            author.IsDeleted = !author.IsDeleted;
            _context.SaveChanges();
            var viewModel = _mapper.Map<AuthorViewModel>(author);

            return PartialView("_AuthorRow", viewModel);

        }

        public IActionResult AllowItem(AuthorFormViewModel model)
        {
            var author = _context.Authors.SingleOrDefault(c => c.Name == model.Name);
            var isAllowed = author is null || author.Id.Equals(model.Id);

            return Json(isAllowed);
        }
    }
}
