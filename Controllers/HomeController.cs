using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pasarela_pago.Models;

namespace pasarela_pago.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Pasarela()
    {
        return View();
    }

    [HttpPost]
    public ActionResult ProcesarPago(string cardNumber, string cardName, string cardMonth, string cardYear, string cardCvv, string shipping, double totalAmount)
    {
        // Procesa el pago aquí con los datos recibidos
        // ...

        // Imprimir los valores recibidos para depuración
        Console.WriteLine($"cardNumber: {cardNumber}");
        Console.WriteLine($"cardName: {cardName}");
        Console.WriteLine($"cardMonth: {cardMonth}");
        Console.WriteLine($"cardYear: {cardYear}");
        Console.WriteLine($"cardCvv: {cardCvv}");
        Console.WriteLine($"shipping: {shipping}");
        Console.WriteLine($"totalAmount: {totalAmount}");

        // Crear el mensaje con toda la información
        string message = $"Pago procesado para la tarjeta: {cardNumber}, " +
                         $"Nombre: {cardName}, " +
                         $"Fecha de expiración: {cardMonth}/{cardYear}, " +
                         $"CVV: {cardCvv}, " +
                         $"Dirección de envío: {shipping}, " +
                         $"Monto total: {totalAmount.ToString("0.00")}";

        // Guardar el mensaje en TempData para mostrarlo después de la redirección
        TempData["MessagePago"] = message;
        return RedirectToAction("Pasarela");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
