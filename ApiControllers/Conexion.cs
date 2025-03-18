using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("conexion")]
public class Conexion : Controller{
    [HttpGet("sql")]
    public IActionResult ListarCarrerasSql(){
        List<CarreraSQL> lista = new List<CarreraSQL>();

        SqlConnection conn = new SqlConnection(CadenasConexion.SQL_SERVER);
        SqlCommand cmd = new SqlCommand("select IdCarrera, Carrera from Carreras");
        cmd.Connection = conn;
        cmd.CommandType = System.Data.CommandType.Text;
        cmd.Connection.Open();

        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read()){
            CarreraSQL carrera = new CarreraSQL();
            Carrera.IdCarrera = reader.GetInt16("IdCarrera")
            Carrera.Carrera = reader.GetString("Carrera")
        }

        return Ok(lista);
    }

    [HttpGet("mongo")]
    public IActionResult ListarSalonesMongoDB(){
        return Ok("Me estoy conectando a MongoDb");
    }
   
}