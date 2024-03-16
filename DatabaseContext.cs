using EFCodefirstAssignment.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCodefirstAssignment
{
    public class DatabaseContext : DbContext
    {
        private readonly string _ConnectionString = "Host=ep-damp-firefly-a1zm2ud1.ap-southeast-1.aws.neon.tech;Database=demo;Username=sherrin1st;Password=71gbaEJqiskV";
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Create list of id for each model
            List<string> ProductIds = new() {
                "930b69b4-e6e5-4f00-aa02-8c43becc206f",
                "038a4f71-645b-43ea-a666-a41b71f94417",
                "83017a70-a8e4-4d8f-bbfe-93fbf068469e",
                "53156d54-0837-4c47-989c-355a33b3a226",
                "0abb6263-ba44-4302-ab37-29b774591c0e"
            };
            List<string> OrderProductIds = new()
            {
                "689a16ac-ec26-479b-a885-7b25f6180c9a",
                "85cf736a-4f7e-44b8-a98a-edacda0d9c4c",
                "068abe81-4295-425c-b70c-0352f4f5ca68",
                "febd503a-66d3-4e75-b900-332f290a6f03",
                "4775280f-a5fe-4b5b-8c59-fd31802db728",
                "91c466a1-8175-462f-b50d-9c0a4aadb8c3",
                "f113d2aa-9df3-4356-9fd3-c9db55536ce4",
                "1321180a-eb25-4c09-a546-d7725c4372ea",
                "11efbe6a-f05c-47cc-812c-e80eaa09a338",
                "1eec07e9-2c95-4673-8ba5-9bb1784adba7",
                "e4c68042-1033-4d99-9f5a-f1dab6bc905d",
                "035426e7-41f1-466a-ad85-d2ccf8cf24ca",
                "897e1a80-44cb-40d4-a394-f179e945018e",
                "6bf231c5-da52-48db-9926-a6d88bc5c9c9",
                "9529b65a-9111-44e8-a1b1-7251d02d6dda"
            };
            List<string> OrderIds = new()
            {
                "3af74220-4919-409f-aa36-2367f416bf7b",
                "59bdb25d-17f9-4442-9394-faab604a78e1",
                "39844691-1115-41fd-89cb-2621a85da67a",
                "15a645c5-6668-4948-acc9-765eee3cc4f6",
                "a635ad77-178e-41e0-8166-847d354213e4"
            };
            List<string> UserIds = new()
            {
                "80c56fa9-a7e2-4e95-9573-24ce1292f0be",
                "0054059f-d62a-41cb-8fe7-674cc674212c",
                "c08295cf-8d01-4c46-8a23-c53d351e3304",
                "a2e0227b-7b8a-4eb0-9663-3df28d89fb49",
                "a9da98bf-3d14-4819-be14-a7c0f0dac180"
            };

            //Generate 5 user
            for (int i = 0; i < UserIds.Count; i++)
            {
                modelBuilder.Entity<User>()
                    .HasData(new User
                    {
                        Id = Guid.Parse(UserIds[i]),
                        Name = "User " + i,
                        Email = "User" + i + "@gmail.com",
                        EmailConfirmed = true,
                        Password = "12345"
                    });
            }

            //Add 5 base product
            for (int i = 0; i < ProductIds.Count; i++)
            {
                modelBuilder.Entity<Product>()
                    .HasData(new Product
                    {
                        Id = Guid.Parse(ProductIds[i]),
                        Name = "Product " + i,
                        Description = "Description " + i
                    });
            }

            //Generate 5 order
            for (int i = 0; i < OrderIds.Count; i++)
            {
                modelBuilder.Entity<Order>()
                    .HasData(new Order
                    {
                        Id = Guid.Parse(OrderIds[i]),
                        Name = "Order " + i,
                        Description = "Description" + i,
                        UserId = Guid.Parse(UserIds[i]),
                    });
            }

            //Generate 15 order product
            for (int i = 0; i < OrderProductIds.Count; i++)
            {
                modelBuilder.Entity<OrderProduct>()
                    .HasData(new OrderProduct
                    {
                        Id = Guid.Parse(OrderProductIds[i]),
                        Name = "Order Product" + i,
                        Description = "Description " + i,
                        Discount = 0,
                        Note = "None",
                        Quantity = i,
                        OrderId = Guid.Parse(OrderIds[i / 3]),
                    });
            }
        }
    }
}
