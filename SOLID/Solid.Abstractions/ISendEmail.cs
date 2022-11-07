using Solid.Models;
using System;
namespace Solid.Abstractions;
public interface ISendEmail
{
    void SendEmail(Account account);
}
