using LibraryManagementSystem.Core.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryManagementSystem.Controllers
{
	public class SubscribersController : Controller
	{
		//stop in section 25/10
        
		private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

		//	private readonly IImageServices _imageServices;

		public SubscribersController(ApplicationDbContext context, IMapper mapper
			//	IImageServices imageServices
			)
        {
            _context = context;
            _mapper = mapper;
			
          // , _imageServices = imageServices; 
        }

        public IActionResult Index()
		{	
			return View();
		}

		public IActionResult Create()
		{
			var viewModel = PopulateViewModel();
			return View("Form", viewModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(SubscriberFormViewModel model)
		{
			if (!ModelState.IsValid)
				return View("Form", PopulateViewModel(model));

			var subscriber = _mapper.Map<Subscriber>(model);

			var imageName = $"{Guid.NewGuid()}{Path.GetExtension(model.Image!.FileName)}";
			var imagePath = "/images/Subscribers";

	          //var (isUploaded, errorMessage) = await _imageService.UploadAsync(model.Image, imageName, imagePath, hasThumbnail: true);

			//if (!isUploaded)
			//{
			//	ModelState.AddModelError("Image", errorMessage!);
			//	return View("Form", PopulateViewModel(model));
			//}

			subscriber.ImageUrl = $"{imagePath}/{imageName}";
			subscriber.ImageThumbnailUrl = $"{imagePath}/thumb/{imageName}";
			subscriber.CreatedById = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
			_context.Add(subscriber);
			_context.SaveChanges();

			//TODO: Send welcome email


			//var subscriberId = _dataProtector.Protect(subscriber.Id.ToString());

			return RedirectToAction(nameof(Index));
		}



		public IActionResult Edit(int Id)
		{
			var subscriber = _context.Subscribers.Find(Id);

			if (subscriber is null)
				return NotFound();

			var model = _mapper.Map<SubscriberFormViewModel>(subscriber);
			var viewModel = PopulateViewModel(model);

			return View("Form", viewModel);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(SubscriberFormViewModel model)
		{
			if (!ModelState.IsValid)
				return View("Form", PopulateViewModel(model));



			var subscriber = _context.Subscribers.Find(model.Key);

			if (subscriber is null)
				return NotFound();

			//if (model.Image is not null)
			//{
			//	if (!string.IsNullOrEmpty(subscriber.ImageUrl))
			//		_imageService.Delete(subscriber.ImageUrl, subscriber.ImageThumbnailUrl);

			//	var imageName = $"{Guid.NewGuid()}{Path.GetExtension(model.Image.FileName)}";
			//	var imagePath = "/images/Subscribers";

			//	var (isUploaded, errorMessage) = await _imageService.UploadAsync(model.Image, imageName, imagePath, hasThumbnail: true);

			//	if (!isUploaded)
			//	{
			//		ModelState.AddModelError("Image", errorMessage!);
			//		return View("Form", PopulateViewModel(model));
			//	}

			//	model.ImageUrl = $"{imagePath}/{imageName}";
			//	model.ImageThumbnailUrl = $"{imagePath}/thumb/{imageName}";
			//}

			//else if (!string.IsNullOrEmpty(subscriber.ImageUrl))
			//{
			//	model.ImageUrl = subscriber.ImageUrl;
			//	model.ImageThumbnailUrl = subscriber.ImageThumbnailUrl;
			//}


			subscriber = _mapper.Map(model,subscriber);
			 subscriber.LastUpdatedById= User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
			 subscriber.LastUpdatedOn = DateTime.Now;


			_context.SaveChanges();


			return RedirectToAction(nameof(Index));
		}


		[HttpPost]
	    public IActionResult Search(SearchFormViewModel model)
		{

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var subscriber = _context.Subscribers
							.SingleOrDefault(s =>
									s.Email == model.Value
								|| s.NationalId == model.Value
								|| s.MobileNumber == model.Value);

			var viewModel = _mapper.Map<SubscriberSearchResultViewModel>(subscriber);

			//if (subscriber is not null)
			//	viewModel.Key = _dataProtector.Protect(subscriber.Id.ToString());

			return PartialView("Result", viewModel);
		}
		

		public IActionResult Details(int Id)
		{

			//stop video 


			//if (!ModelState.IsValid)
			//	return BadRequest();

			var subscriber = _context.Subscribers.Find(Id);

			if (subscriber is null)
				return NotFound();

			var viewModel=_mapper.Map<SubscriberDetailsFormViewModel>(subscriber);

			return View(viewModel);



		}



		public IActionResult GetAreas(int governorateId)
		{
			var areas = _context.Areas
					.Where(a => a.GovernorateId == governorateId && !a.IsDeleted)
					.OrderBy(g => g.Name)
					.ToList();

			return Ok(_mapper.Map<IEnumerable<SelectListItem>>(areas));
		}


		public IActionResult AllowNationalId(SubscriberFormViewModel model)
        {
            var subscriber = _context.Subscribers.FirstOrDefault(s => s.NationalId == model.NationalId);
            var isAllow = subscriber is null || subscriber.Id.Equals(model.Key);
            return Json(isAllow);
        }

        public IActionResult AllowMobileNumber(SubscriberFormViewModel model)
        {
            var subscriber = _context.Subscribers.FirstOrDefault(s => s.MobileNumber == model.MobileNumber);
            var isAllow = subscriber is null || subscriber.Id.Equals(model.Key);
            return Json(isAllow);
        } 
        public IActionResult AllowEmail(SubscriberFormViewModel model)
        {
            var subscriber = _context.Subscribers.FirstOrDefault(s => s.Email == model.Email);
            var isAllow = subscriber is null || subscriber.Id.Equals(model.Key);
            return Json(isAllow);
        }

        private SubscriberFormViewModel PopulateViewModel(SubscriberFormViewModel? model = null)
        {
            SubscriberFormViewModel viewModel= model is null?new SubscriberFormViewModel(): model;
            var governorates = _context.Governorates.Where(a => !a.IsDeleted).OrderBy(a => a.Name).ToList();
			viewModel.Governorates=_mapper.Map<IEnumerable<SelectListItem>>(governorates);

            if(model?.GovernorateId > 0)
            {
				var areas = _context.Areas
									.Where(a => a.GovernorateId == model.GovernorateId && !a.IsDeleted)
									.OrderBy(g => g.Name)
									.ToList();
			}
            return viewModel;

		}



	}
}
