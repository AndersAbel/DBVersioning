using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegister
{
    class Car
    {
        public int CarId { get; set; }

        [ForeignKey("Owner")]
        public int OwnerId { get; set; }

        public Person Owner { get; set; }

        public string RegNo { get; set; }
    }
}
