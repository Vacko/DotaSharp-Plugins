using DotaSharp;

namespace Weather
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
            Console.FindVar("cl_weather").RemoveFlags(ConVarFlags.FCVAR_CHEAT).SetValue((int) WeatherType.Ash);
        }

        #endregion

        #region Nested Types, Enums, Delegates

        private enum WeatherType
        {
            Default = 0,
            Snow = 1,
            Rain = 2,
            Moonbeam = 3,
            Pestilence = 4,
            Harvest = 5,
            Sirocco = 6,
            Spring = 7,
            Ash = 8,
            Aurora = 9
        }

        #endregion
    }
}