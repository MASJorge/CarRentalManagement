using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Make : BaseDomainModel //heredo de la base modelo para no escribir en cada clase el id etc
    {
        public string Name { get; set; }
        
    }
}
