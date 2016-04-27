namespace RMIAuthServer
{
    public interface IUser
    {
        bool IsValidUser(string name, string password);
    }
}
