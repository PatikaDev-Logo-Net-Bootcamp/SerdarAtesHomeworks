using Homeworkfour.Business.DTOs;

namespace Homeworkfour.Business.Abstract
{
    public interface IJwtService
    {
        TokenDTO Authenticate(UserDTO user);
    }
}
