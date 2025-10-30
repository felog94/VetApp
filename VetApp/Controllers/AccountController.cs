using Microsoft.AspNetCore.Mvc;
using VetApp.Data;
using VetApp.Models;

public class AccountController : Controller
{
    private readonly VeterinariaContext _context;

    public AccountController(VeterinariaContext context)
    {
        _context = context;
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = _context.Usuarios
                .FirstOrDefault(u => u.Email == model.Email && u.Contraseña == model.Password);

            if (user != null)
            {
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError(string.Empty, "Intento de inicio de sesión no válido.");
        }
        return View(model);
    }
}