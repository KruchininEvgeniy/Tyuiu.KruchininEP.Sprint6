using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KruchininEP.Sprint6.Task6.V8.Lib
{
    public class DataService : ISprint6Task6V8
    {

        public string CollectTextFromFile(string path)
        {
            string[] a = File.ReadAllLines(path);
            string str = "";
            string z = "z";
            string res = "";
            foreach (string line in a)
            {
                str = str + " " + line;
            }
            string[] words = str.Split(' ').ToArray();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(z))
                {
                    res = res + " " + words[i];
                }
            }
            return res.Trim();
        }
    }


}