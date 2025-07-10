using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organresipi.MVC.Models
{
        public class ResepModel
        {
            public int Id { get; set; }
            public string NamaMasakan { get; set; }
            public string Deskripsi { get; set; }
            public List<BahanModel> BahanBahan { get; set; }
        }

}
