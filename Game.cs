using System;
using System.Security.Cryptography.X509Certificates;
using textRpg;

enum Info
{
    EXIT_GAME = 0,
    Show_STATUS,
    Show_INVENTOTY,
    OPEN_SHOP
    
}
public class Game
{

    public static void ShowLoading(string message = "로딩 중")
    {
        Console.Write($"\n{message}");

        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(300); // 0.5초 딜레이
            Console.Write(".");
        }

        Thread.Sleep(500); // 마지막 딜레이 약간 더
        Console.WriteLine(); 
    }


    private Stats stats;
    private Inventory inventory;
    private Shop shop;
    

    public Game()
	{
        stats = new Stats();
        inventory = new Inventory();
        shop = new Shop(stats);

        {
            

            // 환영인사 및 다음 행동 안내
            Console.WriteLine("스파르타 마을에 오신것을 환영합니다.");
            Console.Write("사용하실 모험가 이름을 입력해주세요 : ");
            string nickname = Console.ReadLine();
            
            ShowLoading("로딩 중");

            Console.WriteLine($"\n환영합니다! {nickname}님!");

            stats.userName = nickname;

            Console.WriteLine("\n전직할 직업을 입력해주세요");
            Console.WriteLine("1.전사 2.궁수 3.마법사");

            // 직업목록 
            string[] job = { "전사", "궁수", "마법사" };
            int num1 = int.Parse(Console.ReadLine());

            switch (num1)
            {
                case 1:
                    stats.race = job[0];
                    Console.WriteLine($"{job[0]}을 선택하셨습니다.");
                    break;
                case 2:
                    stats.race = job[1];
                    Console.WriteLine($"{job[1]}를 선택하셨습니다.");
                    break;
                case 3:
                    stats.race = job[2];
                    Console.WriteLine($"{job[2]}을 선택하셨습니다.");
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    return;
            }

           


            while (true)
            {
                Console.Clear();
                Console.WriteLine("모험을 시작하겠습니다. 행동을 선택해주세요.");

                // 행동 목록
                Console.WriteLine("1. 상태창");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("\n0. 게임종료");

                // 행동 실행
                int num2 = int.Parse(Console.ReadLine());


                
                switch (num2)
                {
                    
                    case (int)Info.Show_STATUS :
                        ShowLoading("이동 중");
                        Console.WriteLine("상태창을 오픈합니다");
                        //스텟창 열기 
                        stats.ShowStats();

                        Console.WriteLine("\n4. 나가기");
                        Console.Write("원하시는 행동을 입력해주세요: ");
                        string input = Console.ReadLine();
                        //뒤로 가기
                        if (input == "4")
                        {
                            Console.WriteLine("메인 메뉴로 돌아갑니다.");
                            break;
                        }


                        break;

                    case (int)Info.Show_INVENTOTY:
                        ShowLoading("이동 중");
                        Console.WriteLine("인벤토리를 오픈합니다");
                        //인벤토리창 열기
                        inventory.UserInventory();
                        
                        Console.WriteLine("\n4. 나가기");
                        Console.WriteLine("원하시는 행동을 입력해주세요.");
                        //뒤로가기
                        string input1 = Console.ReadLine();
                        if (input1 == "4")
                        {
                            Console.WriteLine("메인 메뉴로 돌아갑니다.");
                            break;
                        }

                        break;

                    case (int)Info.OPEN_SHOP :
                        ShowLoading("이동 중");
                        Console.WriteLine("상점을 오픈합니다");

                        shop.Store();
                        break;

                        if (input == "4")
                        {
                            Console.WriteLine("메인 메뉴로 돌아갑니다.");
                            break;
                        }

                    case (int)Info.EXIT_GAME :
                        Console.WriteLine("게임을 종료합니다.");
                        Environment.Exit(0);
                        return;

                    default:
                        Console.WriteLine("잘못된 입력입니다. ");
                        break;
                }
            }
        }




    }
}
