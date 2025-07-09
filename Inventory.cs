using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRpg
{
   
    public class Inventory
    {
        string[] items = { "천 갑옷", "롱소드","증폭의 고서" };

        bool[] isEquipped = { false, false, false };
        public void UserInventory()
        {

            Console.Clear();
            while (true)
            {
                Console.WriteLine("[ 인벤토리 ]");
                Console.WriteLine("\n1. 장착관리");

                string input = Console.ReadLine();
                if (input == "1")
                {
                    Equipped(); // 장착관리 실행
                }
                break;
            }
        }

        public void Equipped()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[ 인벤토리 ]");
                Console.WriteLine("--장착관리--");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                //아이템 목록 출력
                Console.WriteLine("\n---아이템 목록---");
                for (int i = 0; i < items.Length; i++)
                {
                    string display = isEquipped[ i ] ? $"[ E ] {items[i]}" : items[ i ];
                    Console.WriteLine($"{ i + 1 }.{display}");
                }
                Console.WriteLine("\n4. 나가기");
                Console.Write("장착/해제할 아이템 번호를 입력하세요: ");
                string input = Console.ReadLine();

                if (input == "4")
                    break;

                if (int.TryParse(input, out int index) &&
                    index >= 1 && index <= items.Length) 
                {
                    isEquipped[index - 1] = !isEquipped[index - 1];
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. Enter 키를 누르세요.");
                    Console.ReadLine();
                }
            }

        
        }
    }

    
}
