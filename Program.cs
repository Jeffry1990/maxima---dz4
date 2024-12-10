namespace ConsoleAppМаксима1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            int numberOfDrink;
            string exitCommand = "выход";

            while (isWork == true)
            {
                Console.WriteLine("Технология производства кофейных напитков. Выберите нужный напиток:" +
                $"\n1 - Эспрессо \n2 - Американо \n3 - Флэт Уайт \n4 - Каппучино \n5 - Латте \n6 - {exitCommand}");

                numberOfDrink = Convert.ToInt32(Console.ReadLine());

                switch (numberOfDrink)
                {
                    case 1:
                        CoffeMachine espresso = new CoffeMachine("Эспрессо", 30, 70, 0);
                        espresso.ShowTechicalPasport();
                        break;
                    case 2:
                        CoffeMachine americano = new CoffeMachine("Американо", 20, 180, 0);
                        americano.ShowTechicalPasport();
                        break;
                    case 3:
                        CoffeMachine flatWhite = new CoffeMachine("Флэт Уайт", 30, 130, 40);
                        flatWhite.ShowTechicalPasport();
                        break;
                    case 4:
                        CoffeMachine cappuchino = new CoffeMachine("Каппучино", 20, 120, 60);
                        cappuchino.ShowTechicalPasport();
                        break;
                    case 5:
                        CoffeMachine latte = new CoffeMachine("Латте", 10, 100, 90);
                        latte.ShowTechicalPasport();
                        break;
                    case 6:
                        isWork = false;
                        Console.WriteLine("Выход из программы!");
                        break;
                    default:
                        Console.WriteLine("Нет такой команды!");
                        break;
                }
            }
        }
    }

    class CoffeMachine
    {
        public string nameOfDrink;
        public int beans;
        public int water;
        public int milk;

        public CoffeMachine(string nameOfDrink, int beans, int water, int milk)
        {
            this.nameOfDrink = nameOfDrink;
            this.beans = beans;
            this.water = water;
            this.milk = milk;
        }

        public void ShowTechicalPasport()
        {
            Console.WriteLine($"Название напитка: {nameOfDrink} \nКоличество воды: {water}мл." +
                $" \nКоличество молока: {milk}мл." +
                $"\nКоличетсво кофейных зерен: {beans}гр.");
        }
    }
}