namespace BookManagement.DataAccess
{
    public static class Guard
    {
        public static void AgainstNull(object argument, string argumentName)
        {
            if (argument == null)
            {
                throw new ArgumentNullException(argumentName, $"{argumentName} cannot be null.");
            }
        }
        public static void AgainstUnauthorized(object argument)
        {
            if (argument == null)
            {
                throw new UnauthorizedAccessException($"Failed to login. User with this email was not found.");
            }
        }

        public static void AgainsInvalidPassword(bool isTrue)
        {
            if (!isTrue)
            {
                throw new UnauthorizedAccessException($"Failed to login. Invalid password.");
            }
        }
    }
}
