using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        /**
         * テスト定数
         */
        public const String TEST_CONST = "テストだよ！";

        /**
         * 
         */
        static void Main(string[] args)
        {
            Program a = new Program();
            Sand sand = new Sand();
            sand.kind = "すごい";
            sand.g = 10000;
            sand.playSand();

            UltimateSand uSand = new UltimateSand();
            uSand.kind = "ヤバい";
            uSand.g = 10;
            uSand.mass = 10000;
            uSand.playSand();

            a.output();

        }

        void output()
        {
            Console.Read();
        }
    }

    class UltimateSand : Sand
    {
        // 砂の質量
        public int mass = 0;

        internal void playSand()
        {
            Console.WriteLine("{0}の砂を{1}グラム使って遊んだ！", kind, g);
            Console.WriteLine("さらに質量を{0}に変えた！", mass);
        }
    }

    class Sand
    {
        /**
         * ※ メソッド/メンバ変数はアクセス修飾子を省略するとprivateになる！！！！
         */

        // 砂の種類
        public String kind = "ふつう";
        // グラム
        public int g = 0;


        internal void playSand()
        {
            Console.WriteLine("{0}の砂を{1}グラム使って遊んだ！", kind, g);
        }
    }
}
