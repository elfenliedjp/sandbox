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

            // コンソールコミットテスト用のコメント

            UltimateSand uSand = new UltimateSand(0);
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

    class Sand
    {
        /**
         * ※ メソッド/メンバ変数はアクセス修飾子を省略するとprivateになる！！！！
         */
        // 砂の種類
        public String kind = "ふつう";
        // グラム
        public int g = 0;


        /**
         * オーバーライド元はvirtual
         */ 
        public virtual void playSand()
        {
            Console.WriteLine("{0}の砂を{1}グラム使って遊んだ！", kind, g);
        }
    }

    class UltimateSand : Sand
    {
        /**
         * コンストラクタのスコープって・・・
         */
        public UltimateSand(int mass)
        {
            this.mass = mass;
        }

        // 砂の質量
        public int mass = 0;

        /**
         * オーバーライド先はnewかoverride
         */
        public new void playSand()
        {
            Console.WriteLine("{0}の砂を{1}グラム使って遊んだ！", kind, g);
            Console.WriteLine("さらに質量を{0}に変えた！", mass);
        }
    }
}
