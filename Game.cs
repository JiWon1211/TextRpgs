using System;
using textRpg;


public class Game
{
    

    private Stats stats;
    private Inventory inventory;
    public Game()
	{
        stats = new Stats();
        inventory = new Inventory();
        {

            // 환영인사 및 다음 행동 안내
            Console.WriteLine("엘븐항구에 오신것을 환영합니다.");
            Console.Write("사용하실 모험가 이름을 입력해주세요 : ");
            string nickname = Console.ReadLine();

           

            Console.WriteLine($"환영합니다! {nickname}님!");

            stats.userName = nickname;

            Console.WriteLine("원하시는 종족을 입력해주세요");
            Console.WriteLine("1.휴먼 2.엘프 3.마족");

            // 직업목록 
            string[] job = { "휴먼", "엘프", "마족" };
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

                 const int Show_STATUS = 1;
                 const int Show_INVENTOTY = 2;
                 const int OPEN_SHOP = 3;

                switch (num2)
                {

                    case Show_STATUS : 
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

                    case Show_INVENTOTY:
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

                        if (input == "4")
                        {
                            Console.WriteLine("메인 메뉴로 돌아갑니다.");
                            break;
                        }
                    case OPEN_SHOP :
                        Console.WriteLine("상점을 오픈합니다");
                        break;

                        if (input == "4")
                        {
                            Console.WriteLine("메인 메뉴로 돌아갑니다.");
                            break;
                        }

                    case 0:
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
