using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeWeBet_Test_Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int StoreId { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }
        [ForeignKey("StoreId")]
        public Store? Store { get; set; }
        
    }
}
