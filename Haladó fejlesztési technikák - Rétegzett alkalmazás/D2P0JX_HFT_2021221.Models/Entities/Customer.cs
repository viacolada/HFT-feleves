using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace D2P0JX_HFT_2021221.Models.Entities
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int PizzaId { get; set; }

        [JsonIgnore]
        [NotMapped]
        public virtual Pizza Pizza { get; set; }
    }
}
