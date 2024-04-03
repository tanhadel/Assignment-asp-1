

using Microsoft.AspNetCore.Identity;

namespace Infrastracture.Entities;

public class UserEntity:IdentityUser
{

    [ProtectedPersonalData]
    public string FristName { get; set; } = null!;
    [ProtectedPersonalData]
    public string LastName { get; set; } = null!;


}
