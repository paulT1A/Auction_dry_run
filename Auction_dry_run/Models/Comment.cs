using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auction_dry_run.Models
{
    public class Comment
    {

        public int Id { get; set; }
        public string Title { get; set; }

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
