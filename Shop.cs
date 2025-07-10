using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRpg
{
    public class Shop
    {
        
        Stats stats = new Stats();

        private string[] items = {"철 대검", "낡은 도끼", "거장의 신발", "수상한 빨간 딸기", "할머니의 끝내주는 스튜" };
        private int[] prices = { 1200, 500, 700, 99999 , 200 };
        private bool[] isPurchased = { false, false, false, false, false };

        public Shop(Stats s)
        {
            stats = s; 
        }


        public void Store()
        {
            Console.Clear();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("[ 상 점 ]");
                Console.WriteLine("\n필요한 아이템을 얻을 수 있는 상점입니다.");

                Console.WriteLine($"\n[ 보유 골드 ] : {stats.stats[4]}G\n");

                for (int i = 0; i < items.Length; i++)
                {
                    string status = isPurchased[i] ? " [구매 완료]" : $" - {prices[i]}G";
                    Console.WriteLine($"{i + 1}. {items[i]}{status}");
                }
                Console.WriteLine("\n\n0. 나가기");

                Console.Write("\n구매할 아이템 번호를 입력하세요: ");
                string input = Console.ReadLine();

                if (input == "0")
                    break;

                if (int.TryParse(input, out int index) &&
                    index >= 1 && index <= items.Length)
                {
                    int i = index - 1;

                    if (isPurchased[i])
                    {
                        Console.WriteLine($"\n이미 '{items[i]}'을(를) 구매하셨습니다.");
                    }
                    else if (stats.stats[4] >= prices[i])
                    {
                        stats.stats[4] -= prices[i];
                        isPurchased[i] = true;
                        Console.WriteLine($"\n'{items[i]}'을(를) 구매했습니다!");
                    }
                    else
                    {
                        Console.WriteLine("\n골드가 부족합니다!");
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }

                Console.WriteLine("계속하려면 Enter 키를 누르세요...");
                Console.ReadLine();

            }
        }


            



        }
    }

