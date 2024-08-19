using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Text;
using Newtonsoft.Json.Linq;

namespace LibraryManagementSystem.Controllers
{
    // [Authorize(Roles = AppRoles.Admin)]
    public class UsersController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(ApplicationDbContext context, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var viewModels = _mapper.Map<IEnumerable<UserViewModel>>(users);
            return View(viewModels);
        }


        [HttpGet]
        [AjaxOnly]
        public async Task<IActionResult> Create()
        {
            var viewModel = new UserFormViewModel
            {
                Roles = await _roleManager.Roles
                                .Select(r => new SelectListItem
                                {
                                    Text = r.Name,
                                    Value = r.Name
                                })
                                .ToListAsync()
            };

            return PartialView("_Form", viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserFormViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            ApplicationUser user = new()
            {
                FullName = model.FullName,
                UserName = model.UserName,
                Email = model.Email,
             //   CreatedById = User.FindFirst(ClaimTypes.NameIdentifier)!.Value
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRolesAsync(user, model.SelectedRoles);
             

                var viewModel = _mapper.Map<UserViewModel>(user);
                return PartialView("_UserRow", viewModel);
            }

            return BadRequest(string.Join(',', result.Errors.Select(e => e.Description)));
        }

        [HttpGet]
        [AjaxOnly]
        public async Task<IActionResult> Edit(string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            if (user is null)
                return NotFound();

            var viewModel = _mapper.Map<UserFormViewModel>(user);
            viewModel.SelectedRoles = await _userManager.GetRolesAsync(user);
            viewModel.Roles = await _roleManager.Roles
                .Select(r => new SelectListItem
                {
                    Text = r.Name,
                    Value = r.Name
                }).ToListAsync();

            return PartialView("_Form", viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(UserFormViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var user = await _userManager.FindByIdAsync(model.Id);
            if (user is null)
                return NotFound();

            user = _mapper.Map(model, user);
            //user.LastUpdatedById = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
            user.LastUpdatedOn = DateTime.Now;

            var result=await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                var currentRoles= await _userManager.GetRolesAsync(user);
                var roleUpdate = !currentRoles.SequenceEqual(model.SelectedRoles);

                if(roleUpdate)
                {
                    await _userManager.RemoveFromRolesAsync(user, currentRoles);
                    await _userManager.AddToRolesAsync(user, model.SelectedRoles);
                 }

                await _userManager.UpdateSecurityStampAsync(user);

                var viewModel = _mapper.Map<UserViewModel>(user);
                return PartialView("_UserRow", viewModel);

            }
            return BadRequest(string.Join(',', result.Errors.Select(e => e.Description)));


        }


        [HttpPost]
        public async Task<IActionResult> ToggleStatus(string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            if (user is null)
                return NotFound();

            user.IsDeleted = !user.IsDeleted;
            user.LastUpdatedOn = DateTime.Now;
            //  user.LastUpdatedById=User.FindFirst(ClaimTypes.NameIdentifier)!.Value

            await _userManager.UpdateAsync(user);

            return Ok(user.LastUpdatedOn.ToString());


        }

        [HttpGet]
        [AjaxOnly]
        public async Task<IActionResult> ResetPassword(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user is null)
                return NotFound();

            var viewModel = new ResetPasswordFormViewModel { Id = user.Id };

            return PartialView("_ResetPasswordForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordFormViewModel model)
        {
            //stop in test rest password
            //uploda progect in descord
            if (!ModelState.IsValid)
                return BadRequest();

            var user = await _userManager.FindByIdAsync(model.Id);

            if (user is null)
                return NotFound();

            var currentPasswordHash = user.PasswordHash;

            await _userManager.RemovePasswordAsync(user);

            var result = await _userManager.AddPasswordAsync(user, model.Password);

            if (result.Succeeded)
            {

               // user.LastUpdatedById = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
                user.LastUpdatedOn = DateTime.Now;

                await _userManager.UpdateAsync(user);

                var viewModel = _mapper.Map<UserViewModel>(user);
                return PartialView("_UserRow", viewModel);
            }

            user.PasswordHash = currentPasswordHash;
            await _userManager.UpdateAsync(user);

            return BadRequest(string.Join(',', result.Errors.Select(e => e.Description)));
        }


        public async Task<IActionResult> AllowUserName(UserFormViewModel model)
        {
            var user = await _userManager.FindByNameAsync( model.UserName);
            var isAllowed = user is null || user.Id.Equals(model.Id);

            return Json(isAllowed);
        }
        public async Task<IActionResult> AllowEmail(UserFormViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            var isAllowed = user is null || user.Id.Equals(model.Id);

            return Json(isAllowed);
        }
    }
}
