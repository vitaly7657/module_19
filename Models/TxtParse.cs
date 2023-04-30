namespace module_19.Models
{
    public class TxtParse
    {
        public static string ArrayPerson(int a, int b)
        {
            string[] lines = File.ReadAllLines("PhoneBook.txt");
            string[,] phoneBook = new string[lines.Length, lines[0].Split(' ').Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] pbTemp = lines[i].Split('#');
                for (int j = 0; j < pbTemp.Length; j++)
                    phoneBook[i, j] = pbTemp[j];
            }
            return phoneBook[a,b];
        }

    }
}
