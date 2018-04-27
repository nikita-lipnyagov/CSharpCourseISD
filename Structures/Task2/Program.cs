using System;

namespace Task2
{
    struct Train
    {
        public float number;
        DateTime departureTime;
        string destination;

        public void Set(){
            Console.WriteLine("--Заполнение информации о поезде--");
            Console.WriteLine("Введите номер поезда:");
            number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите название пункта назначения:");
            destination = Console.ReadLine();
            Console.WriteLine("Введите время отправления:");
            departureTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Информация о поезде успешно добавлена!\n");
        }
        public void Print(){
            Console.WriteLine("Номер поезда: " + number);
            Console.WriteLine("Пункт назначения: " + destination);
            Console.WriteLine("Время отправления: " + departureTime.Hour 
            + ":" + departureTime.Minute + "\n");
        }
        public static void Sort(Train[] trains){
            Train temp = new Train();
            int min;

            for (int i = 0; i < trains.Length-1; i++){
                for (int j = i+1; j < trains.Length; j++){
                    min = i;
                    if(trains[min].number > trains[j].number){
                        temp = trains[min];
                        trains[min] = trains[j];
                        trains[j] = temp;
                        min = j;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];
            for (int i = 0; i < trains.Length; i++){
                trains[i].Set();
            }
            Train.Sort(trains);

            Console.Write("Введите номер поезда, информацию о котором хотите узнать: ");
            int num = Int32.Parse(Console.ReadLine());
            bool isExist = false;
            for (int i = 0; i < trains.Length; i++){
                if(trains[i].number == num){
                    trains[i].Print();
                    isExist = true;
                }
            }
            if(isExist == false){
                 Console.WriteLine("Поезда с заданым номером не найдено!");
            }

            Console.WriteLine("Для завершения работы программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
