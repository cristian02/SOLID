using Solid.Models;

namespace Solid.Abstractions;
public interface IAccountStorage
{
    void InsertAccount(Account account);
}
