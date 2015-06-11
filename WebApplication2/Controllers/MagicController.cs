using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MagicController : ApiController
    {
        Magic[] magics = new Magic[]
        {
            new Magic {Id = 1, Name = "Alakazam"},
            new Magic {Id = 2, Name = "Alohamora"},
            new Magic {Id = 3, Name = "AAAAHHHHHH"}
        };

        public IEnumerable<Magic> GetAllMagics()
        {
            return magics;
        }

        public IHttpActionResult getMagic(int id)
        {
            var magic = magics.FirstOrDefault((p) => p.Id == id);
            if (magic == null)
            {
                return NotFound();
            }
            return Ok(magic);
        }
    }
}
