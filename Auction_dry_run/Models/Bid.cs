using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auction_dry_run.Models
{
    public class Bid
    {

        public int Id { get; set; }

        public double Price { get; set; }

        //below id copied from listign class -- as when user is deleted then bids will be deleted

        [Required]
        //placeholder for identity of bidder
        public string IdUser { get; set; }
        [ForeignKey("IdUser")]

        public IdentityUser? User { get; set; }

        public int? ListingId { get; set; }

        [ForeignKey("ListingId")]
        //listign property added rom other class for cooperation -- make nullable
        public listing? Listing { get; set; }



    }
}


