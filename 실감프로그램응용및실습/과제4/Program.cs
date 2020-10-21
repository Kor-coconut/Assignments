using System;
using System.Collections.Generic;

namespace Assingment4
{
    /*
    1. PC = 객체
    2. 클래스 다이어그램에 따라 정의
    3. PC의 숫자만큼 PCInfo 클래스 객체 생성
    4. PCInfo 매서드 생성
    5. 적절한 위치에 try-catch 모두 사용
    6. 예외는 사용자 정의 exception 최소 하나 이상 사용
    7. 매출정보 출력은 evet 이용
     */
    delegate void DsetPCInfo(int id, string cpu, int mem); //setPCInfo의 대리자
    delegate void Dstart(long time);// start의 대리자
    delegate int Dstop(long time); // stop의 대리자
    delegate int DgetTotal(); // getTotal의 대리자

    class LessZeroException : ApplicationException // 0보다 작거나 같을 경우를 예외 처리
    {
        public LessZeroException()
        {
        }
        public LessZeroException(string message) : base(message)
        {
        }
        public object Argument
        {
            get;
            set;
        }
        public string Range
        {
            get;
            set;
        }
    }
    class MemErorException : ApplicationException // 1 ~ 128 범위 밖의 경우를 예외 처리
    {
        public MemErorException()
        {
        }
        public MemErorException(string message) : base(message)
        {
        }
        public object Argument
        {
            get;
            set;
        }
        public string Range
        {
            get;
            set;
        }
    }

    class PCInfo
    {
        private int iId, iMem, iTotal;
        private string strCpu;
        private long lStart, lStop;

        public int IId
        {
            get { return iId; }
            set { iId = value; }
        }
        public int IMem // iMem의 property
        {
            get { return iMem; }
            set { iMem = value; }
        }
        public int ITotal // iTotal의 property
        {
            get { return iTotal; }
            set { iTotal = value; }
        }
        public string StrCpu // strCpu의 property
        {
            get { return strCpu; }
            set { strCpu = value; }
        }
        public long LStart // lStart의 property
        {
            get { return lStart; }
            set { lStart = value; }
        }
        public long LStop // lStop의 property
        {
            get { return lStop; }
            set { lStop = value; }
        }


        public PCInfo() // 생성자, 변수 초기화
        {
            IId = 0;
            IMem = 0;
            ITotal = 0;
            StrCpu = null;
            LStart = 0;
            LStop = 0;
        }
        public void setPCInfo(int id, string cpu, int mem) // PC Info 설정
        {
            IId = id;
            StrCpu = cpu;
            IMem = mem;
        }
        public void start(long time) // 시작 시간
        {
            LStart = time;
        }
        public int stop(long time) // 끝나는 시간
        {
            int use_time = (int)(time - LStart) / 60000;
            LStart = 0;
            return use_time;
        }
        public int getTotal() // 총 PC 이용 금액
        {
            return ITotal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<PCInfo> pcInfo = new List<PCInfo>();
            pcInfo = StartPrint_Setting(pcInfo);
            while (true)
            {
                int num = 0;
                Select_Menu(ref pcInfo, ref num);
                if (num == 4)
                {
                    break;
                }
            }
        }

        static int PCSetting(int iPC) // PC 예외 Throw 처리
        {
            int arg = iPC;
            if (arg <= 0) throw new LessZeroException()
            {
                Argument = arg,
                Range = "1 이상의 값"
            };
            return iPC;
        }
        static int MemSetting(int iMem)
        {
            int arg = iMem;
            if (0 >= arg || arg > 128) throw new MemErorException()
            {
                Argument = arg,
                Range = "1 ~ 128"
            };
            return iMem;
        }

        static public List<PCInfo> StartPrint_Setting(List<PCInfo> pcInfo) // 실행 시 초기 화면 및 설정
        {
            int pc, mem;
            string temp, cpu;
            while (pcInfo.Count == 0)
            {
                pcInfo.Clear();
                Console.Write("등록할 컴퓨터의 수량을 입력하세요 : ");
                try
                {
                    temp = Console.ReadLine();
                    pc = PCSetting(Convert.ToInt32(temp));
                    for (int i = 0; i < pc; i++)
                    {
                        pcInfo.Add(new PCInfo());
                        DsetPCInfo dsetPCInfo = new DsetPCInfo(pcInfo[i].setPCInfo); // 대리자 선언 및 사용

                        while (pcInfo[i].IMem == 0)
                        {
                            Console.WriteLine("PC {0}번", i);
                            Console.Write("컴퓨터의 기종(CPU)을 입력하세요 : ");
                            cpu = Console.ReadLine();
                            try
                            {
                                Console.Write("메모리의 양을 입력하세요(GB) : ");
                                temp = Console.ReadLine();
                                mem = MemSetting(Convert.ToInt32(temp));
                                dsetPCInfo(i, cpu, mem);
                            }
                            catch (FormatException e) // PC의 Memory가 정수가 아닐 때
                            {
                                Console.WriteLine("숫자를 입력하세요. 오류 : {0}", e);
                            }
                            catch (MemErorException e) // 만든 예외, Memory의 용량이 0 이하, 128 초과일 때
                            {
                                Console.WriteLine("오류 : {0}", e);
                                Console.WriteLine("Argument : {0}, Range : {1}", e.Argument, e.Range);
                            }
                        }
                    }
                }
                catch (FormatException e) // 등록할 PC의 수량이 정수가 아닐 때
                {
                    Console.WriteLine("숫자를 입력하세요. 오류 : {0}", e);
                }
                catch (LessZeroException e) // 만든 예외, PC의 수량이 0 이하일때
                {
                    Console.WriteLine("오류 : {0}", e);
                    Console.WriteLine("Argument : {0}, Range : {1}", e.Argument, e.Range);
                }
                catch (OverflowException e) // 등록할 PC의 수량이 Overflow 로 넘어갈 때
                {
                    Console.WriteLine("너무 큰 숫자를 입력했습니다. 오류 : {0}", e);
                }
            }

            return pcInfo;
        }

        static int Info_Print(int pc, ref int num)
        {
            Console.WriteLine("============================");
            Console.WriteLine("1. 컴퓨터 사용 시작 [0 - {0}]", pc - 1);
            Console.WriteLine("2. 컴퓨터 사용 종료 [0 - {0}]", pc - 1);
            Console.WriteLine("3. 매출정보 출력");
            Console.WriteLine("4. 프로그램 종료");
            Console.WriteLine("============================");
            Console.Write("메뉴의 번호를 선택하세요(1-4) : ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e) // 선택 메뉴가 정수가 아닐 때
            {
                Console.WriteLine("숫자를 입력하세요. 오류 : {0}", e);
            }

            return num;
        }
        static void Select_Menu(ref List<PCInfo> pcInfo, ref int num)
        {
            switch (Info_Print(pcInfo.Count, ref num))
            {
                case 1:
                    StartPC(ref pcInfo);
                    break;
                case 2:
                    EndPC(ref pcInfo);
                    break;
                case 3:
                    Total_sales(ref pcInfo);
                    break;
                case 4:
                    Console.WriteLine("프로그램을 종료합니다.\n\n");
                    break;
                default:
                    Console.WriteLine("1번 ~ 4번 선택하세요.");
                    break;
            }
        }

        static void StartPC(ref List<PCInfo> pcInfo) // PC 시작 함수
        {
            Console.Write("컴퓨터의 번호를 입력하세요 : ");
            try
            {
                int pc_num = Convert.ToInt32(Console.ReadLine());
                if (pcInfo[pc_num].LStart != 0)
                {
                    Console.WriteLine("이미 사용중인 PC 입니다.");
                    return;
                }
                Dstart dstart = new Dstart(pcInfo[pc_num].start); // 대리자 객체 생성
                dstart(GetMilliSecByDate());
            }
            catch (ArgumentOutOfRangeException e) // pcInfo의 범위를 벗어날 때
            {
                Console.WriteLine("범위 내의 PC를 입력하세요. 오류 : {0}", e);
            }
            catch (FormatException e) // 등록할 PC의 수량이 정수가 아닐 때
            {
                Console.WriteLine("숫자를 입력하세요. 오류 : {0}", e);
            }
        }
        static void EndPC(ref List<PCInfo> pcInfo) // PC 종료 함수
        {
            Console.Write("컴퓨터의 번호를 입력하세요 : ");
            try
            {
                int pc_num = Convert.ToInt32(Console.ReadLine());
                int money, use_time = 0;
                if (pcInfo[pc_num].LStart == 0)
                {
                    Console.WriteLine("사용 되지 않은 PC 입니다.\n");
                    return;
                }
                Dstop dstop = new Dstop(pcInfo[pc_num].stop); // 대리자 객체 생성
                use_time = dstop(GetMilliSecByDate());
                money = use_time * 20;
                pcInfo[0].ITotal += money;
                Console.WriteLine("사용 시간은 {0}분 입니다.\n", use_time);
                Console.WriteLine("사용 금액은 {0}원 입니다.\n", money);
            }
            catch (ArgumentOutOfRangeException e) // pcInfo의 범위를 벗어날 때
            {
                Console.WriteLine("범위 내의 PC를 입력하세요. 오류 : {0}", e);
            }
            catch (FormatException e) // 등록할 PC의 수량이 정수가 아닐 때
            {
                Console.WriteLine("숫자를 입력하세요. 오류 : {0}", e);
            }
        }
        static long GetMilliSecByDate() // 현재 시간을 long 타입으로 가져옴
        {
            return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalMilliseconds;
        }
        static void Total_sales(ref List<PCInfo> pcInfo)
        {
            DgetTotal dgetTotal = new DgetTotal(pcInfo[0].getTotal); // Total의 대리자 객체 생성
            Console.WriteLine("총 매출액은 {0}원 입니다.\n", dgetTotal());
        }
    }
}