using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperTest.Model
{
    public class UserDomainViewModel
    {
        public UserDomainViewModel()
        {
            this.id = 99;
            this.nome = "ze";
        }

        public int id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
    }
}
