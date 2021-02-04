using GameDemo.Entities;

namespace GameDemo.Concrete
{
   public interface IGamerCheckService
    {
        bool CheckIfRealGamer(Gamer gamer);
    }
}
