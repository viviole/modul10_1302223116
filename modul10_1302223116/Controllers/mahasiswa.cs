using Microsoft.AspNetCore.Mvc;

namespace modul10_1302223116.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mahasiswa : ControllerBase
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Matthew Theodore Lempas", "1302223116", ["PBO", "KPL", "UX"], 2022),
            new Mahasiswa("Marjauza Naswansyah", "1302220009", ["WGTIK", "DB", "KWU"], 2022),
            new Mahasiswa("Nizar Rasyiid", "1302220037", ["Proting", "PBO", "DB"], 2022),
            new Mahasiswa("Hasan Nurrahman Pane", "1302220031", ["UX", "DT", "IMK"], 2022),
            new Mahasiswa("Mattew Richard", "0000000000", ["PBO"], 2024)
        };

        // GET: api/<mahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        // GET api/<mahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        // POST api/<mahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        // DELETE api/<mahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
