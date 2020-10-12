using System;
using System.Collections.Generic;

namespace Assingment2_2
{
    /*
    <!-- Virtual로 Tex Overriding 할 것 -->
    [완] 1. Vehicle 클래스 설계
    [완] 2. Vehicle 클래스의 name, price property 생성
    [완] 3. Vehicle 클래스의 Tex Method Virtual 쓸 것
    [완] 4. Car 클래스 설계
    [완] 5. Car 클래스의 displacement property 생성
    [완] 6. Vehicle 클래스의 Tex Method Override 후 구현 (부모의 price 사용)
    [완] 7. Main 인 Driver 클래스 구현
    [완] 8. List <Car> 쓸 것
     */
    class Vehicle // Vehicle 클래스
    {
        private string model_Name;
        private int model_Price;

        public Vehicle()
        {
            model_Name = null;
            model_Price = 0;
        }

        public string Name // Name property
        {
            get { return model_Name; }
            set { model_Name = value; }
        }

        public int Price // Price property
        {
            get { return model_Price; }
            set { model_Price = value; }
        }

        public virtual double Vehicle_Tex() // For Override
        {
            double tex = 0;
            return tex;
        }
    }
    class Car : Vehicle // Car 클래스
    {
        private int displacement;
        public Car()
        {
            displacement = 0;
        }

        public int Displacement // Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }

        public override double Vehicle_Tex() // Tex Override
        {
            if(displacement >= 3000) // 배기량 3,000 이상
            {
                return base.Price * 0.05;
            }
            else if (1500 <= displacement && displacement < 3000) // 배기량 3000 미만 1500 이상
            {
                return base.Price * 0.13;
            }
            else // 그 외
            {
                return base.Price * 0.01;
            }
        }
    }

    class Driver
    {
        static void Main(string[] args)
        {
            Anser();
        }

        static void Anser() // 프로그램 시작
        {
            List<Car> myCars = Init();
            
            foreach (Car car in myCars) // foreach 문을 통한 List의 Car 클래스 출력
            {
                Console.WriteLine("모델명 : {0}, 가격 : {1:#,##0} \\, 배기량 : {2:#,##0} CC, 세금 : {3:#,##0.0###} \\", string.Format(car.Name), car.Price, car.Displacement, car.Vehicle_Tex());
             }
        }
        static List<Car> Init() // 예시로 List 초기화하는 함수
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car() { Displacement = 3500, Price = 40000000, Name = "제네시스" });
            cars.Add(new Car() { Displacement = 2000, Price = 30000000, Name = "오필러스" });
            cars.Add(new Car() { Displacement = 1000, Price = 15000000, Name = "리오"});

            return cars;
        }
    }
}