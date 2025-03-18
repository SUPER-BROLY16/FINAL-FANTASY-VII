using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("conexion")]
public class Conexion : Controller {
    [HttpGet("sql")]
public IActionResult ListarCarrerasSql(){
    return Ok("Me estoy conectando a SQL Server");
}

[HttpGet("mongo")]
public IActionResult ListarSalonesMongoDb(){
    return Ok("Me estoy conectando a MongoDb");
}
}