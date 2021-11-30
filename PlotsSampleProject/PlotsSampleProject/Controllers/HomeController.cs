using PlotsSampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlotsSampleProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Pricelist = new List<String>() { "$100-$250", "$250-$500", "$500-1000", "$1000OrMore" };
            ViewBag.Pricelist = Pricelist;

            var Areas = new List<String>() { "New Village", "Old Town", "Modern City" };
            ViewBag.Areas = Areas;

            List<Categories> CategoryList = new List<Categories>()
            {
                new Categories { CategoryID = 1, CategoryTitle = "Apartments", CategoryImagePath = "../assets/images/search-icon-01.png"},
                new Categories { CategoryID = 2, CategoryTitle = "Food & Life", CategoryImagePath = "../assets/images/search-icon-02.png"},
                new Categories { CategoryID = 3, CategoryTitle = "Cars", CategoryImagePath = "../assets/images/search-icon-03.png"},
                new Categories { CategoryID = 4, CategoryTitle = "Shopping",CategoryImagePath = "../assets/images/search-icon-04.png"},
                new Categories { CategoryID = 5, CategoryTitle = "Traveling", CategoryImagePath = "../assets/images/search-icon-05.png"}

            };
            ViewBag.CategoryList = CategoryList;

            List<PopularCategories> lst = new List<PopularCategories>()
            {
                new PopularCategories { ID = 1, Title = "One Of The Most Trending Stuffs Right Now!", Description = "Plot Listing is a responsive Bootstrap 5 website template that included 4 different HTML pages. This template is provided by TemplateMo website. You can apply this layout for your static or dynamic CMS websites.", ButtonValue = "Discover More", ImagePath = "../assets/images/tabs-image-01.jpg"},
                new PopularCategories { ID = 2, Title = "Food and Lifestyle category is here", Description = "You can feel free to download, edit and apply this template for your website. Please tell your friends about TemplateMo website.", ButtonValue = "Explore More", ImagePath = "../assets/images/tabs-image-02.jpg"},
                new PopularCategories { ID = 3, Title = "Best car rentals for your trips!", Description = "Did you know? You can get the best free HTML templates on Too CSS blog. Visit the blog pages and explore fresh and latest website templates.", ButtonValue = "More Listing", ImagePath = "../assets/images/tabs-image-03.jpg"},
                new PopularCategories { ID = 4, Title = "Shopping List: Images from Unsplash", Description = "Image credits go to Unsplash website that provides free stock photos for anyone. Images used in this Plot Listing template are from Unsplash.", ButtonValue = "Discover More", ImagePath = "../assets/images/tabs-image-04.jpg"},
                new PopularCategories { ID = 5, Title = "Information and Safety Tips for Traveling", Description = "You are allowed to use this template for your commercial websites. You are NOT allowed to redistribute this template ZIP file on any Free CSS collection websites.", ButtonValue = "Read More", ImagePath = "../assets/images/tabs-image-05.jpg"}

            };
            ViewBag.lst = lst;

            List<RecentListing> RecentList = new List<RecentListing>()
            {
                new RecentListing { RecentListingID = 1, RecentListingTitle = "1. First Apartment Unit", RecentListingImagePath = "../assets/images/listing-01.jpg", RecentListingSellBy = "Sale Agent" ,RecentListingReviews = "(18) Reviews",RecentListingDescription = "2760 sq ft", RecentListingIconImagePath1 = "../assets/images/listing-icon-01.png", RecentListingIconImagePath2 = "../assets/images/listing-icon-02.png", RecentListingIconImagePath3 = "../assets/images/listing-icon-03.png" ,RecentListingIconImagePath1Details = "$450 - $950 / month with taxes", RecentListingIconImagePath2Details="4 Bedrooms",RecentListingIconImagePath3Details ="4 Bathrooms"},
                new RecentListing { RecentListingID = 2, RecentListingTitle = "2. Another House of Gaming", RecentListingImagePath = "../assets/images/listing-02.jpg", RecentListingSellBy = "Top Sale Agent" ,RecentListingReviews = "(24) Reviews",RecentListingDescription ="3650 sq ft",RecentListingIconImagePath1 = "../assets/images/listing-icon-01.png", RecentListingIconImagePath2 = "../assets/images/listing-icon-02.png", RecentListingIconImagePath3 = "../assets/images/listing-icon-03.png" ,RecentListingIconImagePath1Details = "$1,400 - $3,500 / month with taxes", RecentListingIconImagePath2Details="4 Bedrooms",RecentListingIconImagePath3Details ="3 Bathrooms"},
                new RecentListing { RecentListingID = 3, RecentListingTitle = "3. Secret Place Hidden House", RecentListingImagePath = "../assets/images/listing-03.jpg", RecentListingSellBy = "Best Property" ,RecentListingReviews = "(36) Reviews",RecentListingDescription ="5500 sq ft", RecentListingIconImagePath1 = "../assets/images/listing-icon-01.png", RecentListingIconImagePath2 = "../assets/images/listing-icon-02.png", RecentListingIconImagePath3 = "../assets/images/listing-icon-03.png" ,RecentListingIconImagePath1Details = "$1,500 - $3,600 / month with taxes", RecentListingIconImagePath2Details="4 Bedrooms",RecentListingIconImagePath3Details ="3 Bathrooms"},
                new RecentListing { RecentListingID = 4, RecentListingTitle = "4. Sunshine Fourth Apartment", RecentListingImagePath = "../assets/images/listing-04.jpg", RecentListingSellBy = "Sale Agent" ,RecentListingReviews = "(24) Reviews",RecentListingDescription ="3660 sq ft",RecentListingIconImagePath1 = "../assets/images/listing-icon-01.png", RecentListingIconImagePath2 = "../assets/images/listing-icon-02.png", RecentListingIconImagePath3 = "../assets/images/listing-icon-03.png" ,RecentListingIconImagePath1Details = "$3,600 / month with taxes", RecentListingIconImagePath2Details="5 Bedrooms",RecentListingIconImagePath3Details ="3 Bathrooms"},
                new RecentListing { RecentListingID = 5, RecentListingTitle = "5. Best House Of the Town", RecentListingImagePath = "../assets/images/listing-05.jpg", RecentListingSellBy = "Sale Agent" ,RecentListingReviews = "(32) Reviews",RecentListingDescription ="1750 sq ft",RecentListingIconImagePath1 = "../assets/images/listing-icon-01.png", RecentListingIconImagePath2 = "../assets/images/listing-icon-02.png", RecentListingIconImagePath3 = "../assets/images/listing-icon-03.png" ,RecentListingIconImagePath1Details = "$5,600 / month with taxes", RecentListingIconImagePath2Details="6 Bedrooms",RecentListingIconImagePath3Details ="3 Bathrooms"},
                new RecentListing { RecentListingID = 6, RecentListingTitle = "6. Amazing Pool Party Villa", RecentListingImagePath = "../assets/images/listing-06.jpg", RecentListingSellBy = "Sale Agent" ,RecentListingReviews = "(40) Reviews",RecentListingDescription ="3660 sq ft",RecentListingIconImagePath1 = "../assets/images/listing-icon-01.png", RecentListingIconImagePath2 = "../assets/images/listing-icon-02.png", RecentListingIconImagePath3 = "../assets/images/listing-icon-03.png" ,RecentListingIconImagePath1Details = "$3,850 / month with taxes", RecentListingIconImagePath2Details="4 Bedrooms",RecentListingIconImagePath3Details ="3 Bathrooms"},
                new RecentListing { RecentListingID = 7, RecentListingTitle = "7. Sunny Apartment", RecentListingImagePath = "../assets/images/listing-05.jpg", RecentListingSellBy = "Sale Agent" ,RecentListingReviews = "(24) Reviews",RecentListingDescription ="1640 sq ft",RecentListingIconImagePath1 = "../assets/images/listing-icon-01.png", RecentListingIconImagePath2 = "../assets/images/listing-icon-02.png", RecentListingIconImagePath3 = "../assets/images/listing-icon-03.png" ,RecentListingIconImagePath1Details = "$5,450 / month with taxes", RecentListingIconImagePath2Details="8 Bedrooms",RecentListingIconImagePath3Details ="5 Bathrooms"},
                new RecentListing { RecentListingID = 8, RecentListingTitle = "8. Third House of Gaming", RecentListingImagePath = "../assets/images/listing-02.jpg", RecentListingSellBy = "Sale Agent" ,RecentListingReviews = "(15) Reviews",RecentListingDescription ="1660 sq ft",RecentListingIconImagePath1 = "../assets/images/listing-icon-01.png", RecentListingIconImagePath2 = "../assets/images/listing-icon-02.png", RecentListingIconImagePath3 = "../assets/images/listing-icon-03.png" ,RecentListingIconImagePath1Details = "$5,520 / month with taxes", RecentListingIconImagePath2Details="5 Bedrooms",RecentListingIconImagePath3Details ="4 Bathrooms"},
                new RecentListing { RecentListingID = 9, RecentListingTitle = "9. Relaxing BBQ Party Villa", RecentListingImagePath = "../assets/images/listing-06.jpg", RecentListingSellBy = "Sale Agent" ,RecentListingReviews = "(20) Reviews",RecentListingDescription ="2880 sq ft",RecentListingIconImagePath1 = "../assets/images/listing-icon-01.png", RecentListingIconImagePath2 = "../assets/images/listing-icon-02.png", RecentListingIconImagePath3 = "../assets/images/listing-icon-03.png" ,RecentListingIconImagePath1Details = "$4,760 / month with taxes", RecentListingIconImagePath2Details="6 Bedrooms",RecentListingIconImagePath3Details ="4 Bathrooms"}
                
            };
            ViewBag.RecentList = RecentList;

            

            return View();
        }

        public ActionResult Category()
        {
           // ViewBag.Message = "Your Plotlist Category.";

            return View();
        }

        public ActionResult Listing()
        {
           // ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
           // ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}