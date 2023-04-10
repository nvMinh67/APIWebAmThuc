using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using webanthuc.Migrations;

namespace webanthuc.Entity
{
    public class MyDbContext : IdentityDbContext<ApplicationUser>
    {
        public MyDbContext (DbContextOptions<MyDbContext> options) : base(options) { 
        }
        #region DbSet
        public DbSet<Dish> dishes { get; set; }
        public DbSet<Image_Dish> images_dishes { get; set; }
        public DbSet<Restaurant> restaurants { get; set;}
        public DbSet<Image_Restaurant> Image_Restaurants { get; set; }      
        public DbSet<Menu> menus { get; set; }
        public DbSet<Dish1> Dish1s { get; set; }
        public DbSet<Image_Dish1> Image_Dish1s { get;set; }
        public DbSet<Restaurant1> Restaurants1 { get; set; }
        public DbSet<Image_restaurant1> Image_Restaurant1s { get; set; }
        public DbSet<Menu1> menus1 { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<detailContact> DetailContacts { get; set; }
        public DbSet<DetailContact1> detailContact1s { get; set; }
        public DbSet<RestaurantDetail> restaurantDetails { get; set; }
        public DbSet<ApplicationUserRoles> ApplicationUserRole { get; set; }
        public DbSet<Hotel> hotels { get; set; }
        public DbSet<Image_Hotel> Image_Hotel { get; set;}
        public DbSet<TypeRoom> typeRooms { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<RoomDetail> RoomDetail { get; set; }
        public DbSet<ImageDetailRoom> ImageDetailRooms { get; set;}
        public DbSet<Room1> room1s { get; set; }
        public DbSet<TestDate> testDates { get; set; }
        #endregion
    }
}
