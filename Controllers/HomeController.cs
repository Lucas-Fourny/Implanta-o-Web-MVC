using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public  IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Lucas", "122.122.122-12", "teste@teste.com", "Luna");
        Cliente cliente2 = new Cliente(02, "Talisson", "133.133.133-13", "teste1@teste.com", "Luna1");
        Cliente cliente3 = new Cliente(03, "Levi", "144.144.144-14", "teste2@teste.com", "Luna2");
        Cliente cliente4 = new Cliente(04, "Tahissi", "122.152.155-15", "teste3@teste.com", "Luna3");
        Cliente cliente5 = new Cliente(05, "Alteair", "122.166.166-12", "teste4@teste.com", "Luna4");
        
        List<Cliente> clienteLista = new List<Cliente>();
        clienteLista.Add(cliente1);
        clienteLista.Add(cliente2);
        clienteLista.Add(cliente3);
        clienteLista.Add(cliente4);
        clienteLista.Add(cliente5);

        ViewBag.clienteLista = clienteLista;

        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03,"BootsPet INC", "40.810.224/0001-83","boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-09","noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05,"Bifinho Forever", "18.760.614/0001-37","contato@bff.us");

        List<Fornecedor> fornecedorLista = new List<Fornecedor>();
        fornecedorLista.Add(fornecedor1);
        fornecedorLista.Add(fornecedor2);
        fornecedorLista.Add(fornecedor3);
        fornecedorLista.Add(fornecedor4);
        fornecedorLista.Add(fornecedor5);

        ViewBag.fornecedorLista = fornecedorLista;

        return View();
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
