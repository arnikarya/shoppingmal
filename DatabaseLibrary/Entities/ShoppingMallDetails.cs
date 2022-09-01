using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Connection.Entities
{
    public class ShoppingMallDetails
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string ShoppingMallName { get; set; }= null!;
        [Column(TypeName = "Varchar(50)")]
        public string City { get; set; } = null!;
        [Column(TypeName = "Varchar(50)")]
        public string State{ get; set; }= null!;

        public int Built_in_Year { get; set; }
}
}

