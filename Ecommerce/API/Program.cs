using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//ENDPOINTS - FUNCIONALIDADES

//REQUEST/REQUISIÇÃO
//  - URL e Método HTTP 
//  - Parâmetro opcional

//Métodos HTTP
//GET - Pegar alguma informação
//POST - Enviar alguma informação

//GET: /
app.MapGet("/", () => "Hello World!");

//GET: /testarurl
app.MapGet("/testarurl", () => "Primeira API");

//GET: /parametro/param
app.MapGet("/parametro/{param1}", 
    ([FromRoute] string param1) =>
{
    string result = param1 + " " + DateTime.Now;
    return result;
});

app.Run();
