using DotaSharp;

namespace ZoomHack
{
    public class Program
    {
        #region Static Methods

        public static void Main()
        {
            Game.OnGameStart += OnGameStart;
        }

        public static void OnGameStart()
        {
            Console.FindVar("dota_camera_distance").RemoveFlags(ConVarFlags.FCVAR_CHEAT).SetValue(1500);
            Console.FindVar("r_farz").SetValue(18000);
        }

        #endregion
    }
}