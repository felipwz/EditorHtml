using System;

namespace EditorHtml
{
    public static class Menu
    {

        public static void Show()
        {
            Console.Clear();
            DrawScreen();
            var option = short.Parse(Console.ReadLine());
            Console.ReadKey();
            HandleMenuOption(option);



        }

        public static void DrawScreen()
        {


            LineMaker();
            ColumnMaker();
            WriteOptions();



        }

        public static void LineMaker()
        {


            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");
            Console.Write("+");

            Console.Write("\n");
        }

        public static void ColumnMaker()
        {


            for (int lines = 0; lines <= 15; lines++)
            {

                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");


                Console.Write("|");
                Console.Write("\n");

            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");
            Console.Write("+");

        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("-------------");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("Selecione uma opção:");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
            Console.SetCursorPosition(3, 11);
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Console.WriteLine("Editor"); break;
                case 2: Console.WriteLine("Editor"); break;
                case 3: Console.Clear(); Environment.Exit(0); break;
                default: Console.Clear(); Show(); break;
            }

        }
    }
}