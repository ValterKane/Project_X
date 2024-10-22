namespace Domain.DomainEntity;

public class UserAcc
{
    private UserAcc(Guid guid, string login, string hashPassword)
    {
        UserGuid = guid;
        Login = login;
        HashPassword = hashPassword;
    }
    public Guid UserGuid { get; private set; }
    public string Login { get; private set; }

    public string HashPassword { get; private set; }

    public static UserAcc Create(Guid guid, string login, string hashPassword)
    {
        return new UserAcc(guid, login, hashPassword);
    }
}
