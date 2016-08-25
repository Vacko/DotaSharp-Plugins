using DotaSharp;
using System.Linq;

namespace IsIllusion
{
    internal class Program
    {
        #region Static Methods

        public static void Main()
        {
            Drawing.OnDraw += DrawIllusion;
        }

        public static void DrawIllusion()
        {
            var enemyPlayers = ObjectMgr.GetEntities<Hero>().Where(x => x.IsEnemy()).ToList();

            foreach (var player in enemyPlayers)
                if (player.IsIllusion())
                {
                    Vector2 vScreen;
                    if (Drawing.WorldToScreen(player.NetworkOrigin, out vScreen))
                        Drawing.DrawText(vScreen.X, vScreen.Y, "Illusion", new Color(255, 255, 255));
                }
        }

        #endregion
    }
}