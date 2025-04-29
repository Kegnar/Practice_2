using Practice_2.Interfaces;

namespace Practice_2;

// появилась идея вынести роли в отлдельный класс, дабы отсутствовала возможность накосячить с названиями
public class RoleInfo
{
    // при изменении ролей также нужно отредактировать enum Role
    private Role _role;
    // нечего каждому объекту отдельный словарь иметь
    private static Dictionary<Role, string> roles = new ()
    {
        { Role.Administrator, "Администратор" },
        { Role.Trainer, "Тренер" },
        { Role.Client, "Клиент" }
    };

    //дефолтная роль для любой персоны
    internal RoleInfo(Role role)
    {
        _role = role;
    }

    internal RoleInfo()
    {
        _role = Role.Client;
    }

    public void SetRole(Role role)
    {
        _role = role;
    }

    public RoleInfo GetRole()
    {
        return this;
    }

    public override string ToString()
    {
        return roles[_role];
    }

    
}