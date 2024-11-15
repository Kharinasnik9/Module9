namespace Task2
{
    internal class Program
    {
        public delegate void Sort(List<string> LastNames, int SortType);
        public static event Sort OnSort;

        static void Main(string[] args)
        {
            List<string> LastNames = new List<string>()
            {
                "Петров",
                "Трубицын",
                "Агафонов",
                "Яковлев",
                "Тронин"
            };

            OnSort += SortLastName;

            try
            {
                Console.WriteLine("Введите способ сортировки 1 (А-Я) или 2 (Я-А).");

                string TypeSort = Console.ReadLine();
                int TypeSortInt;

                if (!int.TryParse(TypeSort, out TypeSortInt) || (TypeSortInt < 1 || TypeSortInt > 2))
                {
                    throw new MyException("Введено неверное значение, введите 1 или 2");
                }

                OnSort?.Invoke(LastNames, TypeSortInt);

                Console.WriteLine("Отсортированные фамилии");

                foreach (string LastName in LastNames)
                {
                    Console.WriteLine(LastName);
                }
            }
            catch (MyException MyEx)
            {
                Console.WriteLine(MyEx.Message);
            }
            catch (Exception Ex)
            {
                Console.WriteLine($"Произошло исключение:{Ex.Message}");
            } 

            static void SortLastName (List<string> LastNames , int SortType)

            {
                int Sort = SortType;

                if (Sort == 1)
                {
                    LastNames.Sort();
                }
                else if (Sort == 2)
                {
                    LastNames.Sort((x, y) => string.Compare(y, x));
                }
                else
                {
                    throw new MyException("Ошибка сортировки, введите 1 или 2");
                }
            }
        }
    }
}
