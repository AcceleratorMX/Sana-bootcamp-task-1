namespace Sana_bootcamp_task_1.Models;

public interface IUserService
{
    bool Validate(User user);
}

public class UserService : IUserService
{
    public bool Validate(User user)
    {
        return !string.IsNullOrEmpty(user.FullName);
    }
}