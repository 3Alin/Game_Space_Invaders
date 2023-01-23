
namespace Proiect_Space_Invaders.Game
{
    internal static class Collision
    {
        public static bool isColliding(GameObject A, GameObject B)
        {
            return 
                A.x < (B.x + B.width) && (A.x + A.width) > B.x && 
                A.y < (B.y + B.height) && (A.y + A.height) > B.y;
        }
    }
}
