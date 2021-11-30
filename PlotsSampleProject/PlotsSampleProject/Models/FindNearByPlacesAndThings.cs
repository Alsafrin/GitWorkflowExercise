using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlotsSampleProject.Models
{
    public class FindNearByPlacesAndThings
    {
        public string SelectAreas { get; set; }

        [Display(Name = "Enter a location")]
        [StringLength(75)]
        [Required]
        public string EnterLocation { get; set; }

        public string PriceRange { get; set; }

        public IEnumerable<Categories> CategoryList { get; set; }

        public IEnumerable<PopularCategories> lst { get; set; }


    }

    public class PopularCategories
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ButtonValue { get; set; }

        public string ImagePath { get; set; }

    }
    public class Categories
    {
        public int CategoryID { get; set; }

        public string CategoryTitle { get; set; }

        public string CategoryImagePath { get; set; }

    }
    public class RecentListing
    {
        public int RecentListingID { get; set; }
        public string RecentListingTitle { get; set; }
        public string RecentListingImagePath { get; set; }       
        public string RecentListingSellBy { get; set; }
        public string RecentListingReviews { get; set; }

        public string RecentListingDescription { get; set; }
        public string RecentListingIconImagePath1 { get; set; }
        public string RecentListingIconImagePath2 { get; set; }
        public string RecentListingIconImagePath3 { get; set; }

        public string RecentListingIconImagePath1Details { get; set; }
        public string RecentListingIconImagePath2Details { get; set; }
        public string RecentListingIconImagePath3Details { get; set; }
    }
    
}

//  public enum Areas
//  {
//     NewVillage,
//     OldTown,
//     ModernCity
//  }

