namespace HouseRent.Globals
{
    public static class SeedConstants
    {
        public static class User
        {
            public static readonly Guid AgentId = Guid.Parse("1242dddc-0194-4480-af5a-eaebf6b1818a");
            public const string AgentEmail = "agent@mail.com";
            public const string AgentFirstName = "John";
            public const string AgentLastName = "Doe";
            public const string AgentPassword = "agent123";

            public const string AgentSecurityStamp = "A3F1C1D2-9B8A-4F2E-9E1C-11A2B3C4D5E6";
            public const string AgentConcurrencyStamp = "B7E2D4C1-8F9A-4A3B-9C2D-22B3C4D5E6F7";


            public static readonly Guid GuestId = Guid.Parse("281b9a4c-3e1b-4a48-82d1-913772294c96");
            public const string GuestEmail = "guest@mail.com";
            public const string GuestFirstName = "Jane";
            public const string GuestMidName = "Smith";
            public const string GuestLastName = "Walker";
            public const string GuestPassword = "guest123";

            public const string GuestSecurityStamp = "C9D2E3F4-1A2B-4C3D-8E9F-33C4D5E6F7A8";
            public const string GuestConcurrencyStamp = "D1E2F3A4-5B6C-4D7E-9F8A-44D5E6F7A8B9";
        }

        public static class Agent
        {
            public static readonly Guid Id = Guid.Parse("31477e16-8128-4de9-a53a-4d8554dd4fbe");
            public const string Phone = "+359888888888";
            public static readonly Guid UserId = User.AgentId;
        }

        public static class Category
        {
            public static readonly Guid CottageId = Guid.Parse("033f9ce6-e88f-4584-8e7d-e079196a5b9b");
            public static readonly Guid SingleFamilyId = Guid.Parse("d4356aee-8c4c-4ef3-9a0a-54ad9e660dab");
            public static readonly Guid DuplexId = Guid.Parse("ccd5e50d-3301-44b4-9ef4-262cba953399");
            public static readonly Guid StudioId = Guid.Parse("5ce37447-2b29-4de2-b4ca-e137240c5eb1");

            public const string CottageName = "Cottage";
            public const string SingleFamilyName = "Single-Family";
            public const string DuplexName = "Duplex";
            public const string StudioName = "Studio";
        }

        public static class House
        {
            public static readonly Guid CottageHouseId = Guid.Parse("b5c15c7b-8702-47ac-8c91-e22984ad066b");
            public static readonly Guid SingleFamilyHouseId = Guid.Parse("0f60d9ce-328d-41a2-bae2-69af8e044068");
            public static readonly Guid DuplexHouseId = Guid.Parse("27fb3f74-c73c-416e-ba62-21bafa70c214");
            public static readonly Guid StudioHouseId = Guid.Parse("49f5c400-d5ff-4959-b873-7b2957f1f41a");

            public const string CottageTitle = "Beautiful Cottage";
            public const string CottageAddress = "123 Main St, Anytown";
            public const string CottageDescription = "A charming cottage with a lovely garden.";
            public const string CottageImage = "https://example.com/images/cottage.jpg";
            public const decimal CottagePrice = 1200.00m;
            public static readonly Guid CottageCategoryId = Category.CottageId;
            public static readonly Guid CottageAgentId = Agent.Id;

            public const string SingleFamilyTitle = "Modern Single-Family Home";
            public const string SingleFamilyAddress = "456 Oak Ave, Anytown";
            public const string SingleFamilyDescription = "A spacious single-family home with modern amenities.";
            public const string SingleFamilyImage = "https://example.com/images/single-family.jpg";
            public const decimal SingleFamilyPrice = 2000.00m;
            public static readonly Guid SingleFamilyCategoryId = Category.SingleFamilyId;
            public static readonly Guid SingleFamilyAgentId = Agent.Id;

            public const string DuplexTitle = "Cozy Duplex";
            public const string DuplexAddress = "789 Pine Rd, Anytown";
            public const string DuplexDescription = "A cozy duplex perfect for small families.";
            public const string DuplexImage = "https://example.com/images/duplex.jpg";
            public const decimal DuplexPrice = 1500.00m;
            public static readonly Guid DuplexCategoryId = Category.DuplexId;
            public static readonly Guid DuplexAgentId = Agent.Id;

            public const string StudioTitle = "Stylish Studio Apartment";
            public const string StudioAddress = "321 Elm St, Anytown";
            public const string StudioDescription = "A stylish studio apartment in the heart of the city.";
            public const string StudioImage = "https://example.com/images/studio.jpg";
            public const decimal StudioPrice = 1000.00m;
            public static readonly Guid StudioCategoryId = Category.StudioId;
            public static readonly Guid StudioAgentId = Agent.Id;
        }
    }
}
