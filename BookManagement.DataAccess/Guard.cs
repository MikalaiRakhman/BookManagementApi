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
    }
}
