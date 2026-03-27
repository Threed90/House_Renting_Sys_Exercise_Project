using HouseRent.Data;
using HouseRent.Data.DataModels;
using HouseRent.Globals;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class EntitiesSeeder : IHostedService
{
    private readonly IServiceProvider serviceProvider;

    public EntitiesSeeder(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        using var scope = serviceProvider.CreateScope();

        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        await SeedUsers(userManager);
        await SeedAgents(db);
        await SeedCategories(db);
        await SeedHouses(db);
    }

    private static async Task SeedUsers(UserManager<ApplicationUser> userManager)
    {
        

        if (await userManager.FindByEmailAsync(SeedConstants.User.AgentEmail) == null)
        {
            var user = new ApplicationUser
            {
                Id = SeedConstants.User.AgentId,
                UserName = SeedConstants.User.AgentEmail,
                Email = SeedConstants.User.AgentEmail,
                FirstName = SeedConstants.User.AgentFirstName,
                LastName = SeedConstants.User.AgentLastName
            };

            await userManager.CreateAsync(user, SeedConstants.User.AgentPassword);
        }


        if (await userManager.FindByEmailAsync(SeedConstants.User.GuestEmail) == null)
        {
            var user = new ApplicationUser
            {
                Id = SeedConstants.User.GuestId,
                UserName = SeedConstants.User.GuestEmail,
                Email = SeedConstants.User.GuestEmail,
                FirstName = SeedConstants.User.GuestFirstName,
                MidName = SeedConstants.User.GuestMidName,
                LastName = SeedConstants.User.GuestLastName
            };

            await userManager.CreateAsync(user, SeedConstants.User.GuestPassword);
        }
    }
    private static async Task SeedAgents(ApplicationDbContext db)
    {
        if (!db.Agents.Any(a => a.Id == SeedConstants.Agent.Id))
        {
            db.Agents.Add(new Agent
            {
                Id = SeedConstants.Agent.Id,
                PhoneNumber = SeedConstants.Agent.Phone,
                UserId = SeedConstants.User.AgentId
            });

            await db.SaveChangesAsync();
        }
    }
    private static async Task SeedCategories(ApplicationDbContext db)
    {
        if (!db.Categories.Any())
        {
            db.Categories.AddRange(new List<Category>
            {
                new Category
                {
                    Id = SeedConstants.Category.CottageId,
                    Name = SeedConstants.Category.CottageName
                },
                new Category
                {
                    Id = SeedConstants.Category.SingleFamilyId,
                    Name = SeedConstants.Category.SingleFamilyName
                },
                new Category
                {
                    Id = SeedConstants.Category.DuplexId,
                    Name = SeedConstants.Category.DuplexName
                },
                new Category
                {
                    Id = SeedConstants.Category.StudioId,
                    Name = SeedConstants.Category.StudioName
                }
            });

            await db.SaveChangesAsync();

        }
    }
    private static async Task SeedHouses(ApplicationDbContext db)
    {
        if (!db.Houses.Any())
        {
            db.Houses.AddRange(new List<House>
            {
                new House
                {
                    Id = SeedConstants.House.CottageHouseId,
                    Title = SeedConstants.House.CottageTitle,
                    Address = SeedConstants.House.CottageAddress,
                    Description = SeedConstants.House.CottageDescription,
                    ImageUrl = SeedConstants.House.CottageImage,
                    PricePerMonth = SeedConstants.House.CottagePrice,
                    CategoryId = SeedConstants.House.CottageCategoryId,
                    AgentId = SeedConstants.House.CottageAgentId
                },
                new House
                {
                    Id = SeedConstants.House.SingleFamilyHouseId,
                    Title = SeedConstants.House.SingleFamilyTitle,
                    Address = SeedConstants.House.SingleFamilyAddress,
                    Description = SeedConstants.House.SingleFamilyDescription,
                    ImageUrl = SeedConstants.House.SingleFamilyImage,
                    PricePerMonth = SeedConstants.House.SingleFamilyPrice,
                    CategoryId = SeedConstants.House.SingleFamilyCategoryId,
                    AgentId = SeedConstants.House.SingleFamilyAgentId
                },
                new House
                {
                    Id = SeedConstants.House.DuplexHouseId,
                    Title = SeedConstants.House.DuplexTitle,
                    Address = SeedConstants.House.DuplexAddress,
                    Description = SeedConstants.House.DuplexDescription,
                    ImageUrl = SeedConstants.House.DuplexImage,
                    PricePerMonth = SeedConstants.House.DuplexPrice,
                    CategoryId = SeedConstants.House.DuplexCategoryId,
                    AgentId = SeedConstants.House.DuplexAgentId
                },
                new House
                {
                    Id = SeedConstants.House.StudioHouseId,
                    Title = SeedConstants.House.StudioTitle,
                    Address = SeedConstants.House.StudioAddress,
                    Description = SeedConstants.House.StudioDescription,
                    ImageUrl = SeedConstants.House.StudioImage,
                    PricePerMonth = SeedConstants.House.StudioPrice,
                    CategoryId = SeedConstants.House.StudioCategoryId,
                    AgentId = SeedConstants.House.StudioAgentId
                }
            });

            await db.SaveChangesAsync();
        }
    }


    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}
