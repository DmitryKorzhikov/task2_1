namespace task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sFIO = "Сердюков Иван Геннадьевич";
            int nAge = 22;
            string sMail = "Ser@mail.ru";
            double nProg = 70;
            double nMath = 77;
            double nPhis = 90;
            Console.WriteLine($"ФИО студента: {sFIO}, Возраст: {nAge} года");
            Console.WriteLine($"Баллы по программированию: {nProg}\nБаллы по математике: {nMath}\nБаллы по физике: {nPhis}");
            //Console.WriteLine($"Баллы по математике: {nMath}");
            //Console.WriteLine($"Баллы по физике: {nPhis}");
            Console.ReadKey();
        }
    }
}
