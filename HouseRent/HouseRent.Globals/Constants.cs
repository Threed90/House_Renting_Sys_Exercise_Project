namespace HouseRent.Globals
{
    public static class Constants
    {
        public static class  Category
        {
            public const int NameMaxLength = 50;
        }

        public static class House
        {
            public const int TitleMinLength = 10;
            public const int TitleMaxLength = 50;

            public const int AddressMinLength = 30;
            public const int AddressMaxLength = 150;

            public const int DescriptionMinLength = 50;
            public const int DescriptionMaxLength = 500;

            public const int MinPricePerMonth = 0;
            public const int MaxPricePerMonth = 2000;
        }

        public static class Agent 
        {
            public const int PhoneNumberMinLength = 7;
            public const int PhoneNumberMaxLength = 15;
        }

        public static class User
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 50;

            public const int MidNameMinLength = 2;
            public const int MidNameMaxLength = 50;

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 50;

            public const int UserNameMinLength = 3;
            public const int UserNameMaxLength = 50;

            public const int PasswordMinLength = 3;
            public const int PasswordMaxLength = 50;
        }
    }
}
