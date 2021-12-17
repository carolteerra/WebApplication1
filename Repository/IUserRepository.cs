using WebApplication1.Data.VO;
using WebApplication1.Model;

namespace WebApplication1.Repository {
    public interface IUserRepository {

        User ValidateCredentials(UserVO user);

        User ValidateCredentials(string username);

        bool RevokeToken(string username);

        User RefreshUserInfo(User user);

    }
}
