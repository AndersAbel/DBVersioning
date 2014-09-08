using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [StringLength(20)]
        public string Brand { get; set; }

        [Index(IsUnique=true)]
        [StringLength(6)]
        public string RegNo { get; set; }
    }
}
