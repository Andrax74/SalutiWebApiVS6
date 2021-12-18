using Microsoft.AspNetCore.Mvc;

namespace SalutiWebApi.Controllers
{
    [ApiController]
    [Route("api/saluti")]
    public class SalitiController
    {
        public string getSaluti()
        {
            return "Saluti, sono la tua prima web api creata in c#";
        }
    }
}
