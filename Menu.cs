using System;

namespace EditorHtml
{
    public static class Menu
    {

        public static void Show()
        {
            Console.Clear();
            DrawScreen();
            Console.ReadKey();



        }

        public static void DrawScreen()
        {
            string currentPath = Environment.CurrentDirectory;
            int characterPath = currentPath.Length;

            LineMaker(characterPath);
            ColumnMaker(characterPath);
            WriteOptions();



        }

        public static void LineMaker(int characterPath)
        {
            int sizeCorrect = characterPath + 4;

            Console.Write("+");
            for (int i = 0; i <= sizeCorrect; i++)
                Console.Write("-");
            Console.Write("+");

            Console.Write("\n");
        }

        public static void ColumnMaker(int characterPath)
        {


            int sizeCorrect = characterPath + 4;

            for (int lines = 0; lines <= 15; lines++)
            {

                Console.Write("|");
                for (int i = 0; i <= sizeCorrect; i++)
                    Console.Write(" ");


                Console.Write("|");
                Console.Write("\n");

            }

            Console.Write("+");
            for (int i = 0; i <= sizeCorrect; i++)
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
    }
}