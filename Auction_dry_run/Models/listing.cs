using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auction_dry_run.Models
{
    public class listing
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }
        public string ImagePath { get; set; }

        public bool sold { get; set; }



        [Required]
        //placeholder for identity of bidder
        public string IdUser { get; set; }
        [ForeignKey("IdUser")]

        public IdentityUser? User { get; set; }

        public List<Bid>? Bids { get; set; }

        //public List<Comment>? comments { get; set; }

        //blah





    }
}
