using Practice_2.Interfaces;

namespace Practice_2;

// появилась идея вынести роли в отдельный класс дабы отсутствовала возможность накосячить с названиями
public class RoleInfo 
{
    public enum Role 
    {
        Administrator,
        Trainer,
        Client
    }
    // при изменении ролей также нужно отредактировать enum Role
    private Role _role;
    
    // нечего каждому объекту отдельный словарь иметь
    // единственное назначение словаря - перевод на русский
    private static readonly Dictionary<Role, string> _roles = new ()
    {
        { Role.Administrator, "Администратор" },
        { Role.Trainer, "Тренер" },
        { Role.Client, "Клиент" }
    };
    
    private RoleInfo(Role role)
    {
        _role = role;
    }
    //дефолтная роль для любой персоны
    public RoleInfo():this(Role.Client)
    {
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
        return _roles[_role];
    }
}