using Ice.Owl.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Ice.Owl.Data;


public class DbInitializer
{
    public static void Initializer(ModelBuilder builder)
    {
        builder.Entity<Item>().HasData(
            new Item("Shirt", "Ohio State shirt", "Nike", 29.99m)
            {
                Id = 1
            },
            new Item("Shorts", "Ohio State Shorts", "Nike", 44.99m)
            {
                Id = 2
            }
        );

    }
}
