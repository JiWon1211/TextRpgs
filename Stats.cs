using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRpg
{
    
    public class Stats
    {

        

        public int[ ] stats = { 1, 10, 5, 100, 1500 };
       public string race = "알 수 없음";
       public string userName = " ";
       
       public void ShowStats()
        {
            
            Console.Clear();

            Console.WriteLine($"{userName}님의 상태창입니다");
            Console.WriteLine($"\n종족 : {race} ");
            Console.WriteLine($"레벨 : {stats[0]}");
            Console.WriteLine($"공격력 : {stats[1]}");
            Console.WriteLine($"방어력 : {stats[2]}");
            Console.WriteLine($"체 력 : {stats[3]}");
            Console.WriteLine($"소지금액 : {stats[4]}G");
            
            
        }

    }

}
