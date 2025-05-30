using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organresipi.MVC.Models;



namespace Organresipi.MVC.Controllers
{
    public class ResepController
    {
        private List<ResepModel> daftarResep = new();

        public List<ResepModel> GetAll()
        {
            return daftarResep;
        }

        public void TambahResep(ResepModel resep)
        {
            daftarResep.Add(resep);
        }

        public void HapusResep(int id)
        {
            var resep = daftarResep.Find(r => r.Id == id);
            if (resep != null)
            {
                daftarResep.Remove(resep);
            }
        }
    }
}
