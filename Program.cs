namespace ChessBoardLabb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  AngelicaLindström, NET23, Sundsvall

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // unicode, helps to show the squares, setting unicode standard output



            int userNumber = Program.GetIntUser();
            // saving userinput in Int called usernumber, by calling the method "GetIntUser."



            ChessBoard(userNumber);
            // Calling the method "ChessBord" and using the value in int "usernumber" to print the ChessBoards size.



        }

        static int GetIntUser()   // Method that gets the numberinput from user.
        {

            Console.WriteLine("Hej och välkommen till Schackspelet!");


            while (true) // while loop, gets the userinput
            {
                Console.Write("Var god att ange brädstorlek, använd siffror :");
                string inputUser = Console.ReadLine();

                if (int.TryParse(inputUser, out int userNumber)) // if true, save value in int usernNmber
                {
                    return userNumber; // mothod returns uderinput in Int, userNumber
                }
                else  // else, if the userinput is wrong, give the user messenge, the while loop keeps going.
                {
                    Console.WriteLine($"Oj! ({inputUser}) som du skrev in, är inte ett heltal. Försök igen.."); //Wrong message, try again..
                }
            }

        }

        private static void ChessBoard(int sizeBoard)  // Method that prints the chessboard

        {// Nestlad? forloop with if else.

            for (int horisonRow = 1; horisonRow <= sizeBoard; horisonRow++) //  for as long horisonRow it less or the same as the value in sizeBoard, Print.
            {
                for (int verticalColumn = 1; verticalColumn <= sizeBoard; verticalColumn++) //for as long verticalColumn it less or the same as the value in sizeBoard, Print
                {
                    if ((horisonRow + verticalColumn) % 2 == 0)  // if horisonRow + verticalColumn /2 gives no remanining value(0) = *(equal numnbers) Print.
                    {
                        Console.Write("□");
                    }
                    else // Else, (odd numbers) print this.
                    {
                        Console.Write("■");     // Choose print instead of PrintLine because of the outcome.
                    }
                }

                Console.WriteLine(); // new Line/row;
            }

            Console.WriteLine("Såhär ser Schackbrädet ut! Tack att du prova mitt program."); // thank you User
        }
    }
}