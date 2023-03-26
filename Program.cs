internal class Program
{
  private static void Main(string[] args)
  {
    Console.Clear();
    string intro = "Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3-м символам.\n";
    Console.WriteLine(intro);
    string source = "Parma.txt";
    string[] inArray = CreateArrayByString(GetStringByFile(source));
    Console.WriteLine($"Исходный массив: [{string.Join("_,_", inArray)}]\n");
    int minLen = 1;
    int maxLen = 3;
    string result = GetStringByArray(inArray, minLen, maxLen);
    string[] outArray = CreateArrayByString(result);
    Console.WriteLine($"Результат: [{string.Join("_,_", outArray)}]\n");
  }
  private static string[] CreateArrayByString(string text, string separator = " ")
  {
    text = text.Trim();
    string[] array = text.Split(separator);
    return array;
  }
  private static string GetStringByFile(string path)
  {
    string parma = File.ReadAllText(path).Trim();
    return parma;
  }
  private static string GetStringByArray(string[] array, int minsize, int maxsize, string separator = " ")
  {
    string result = string.Empty;
    int i = 0;
    int size = 0;
    while (i < array.Length)
    {
      size = array[i].Length;
      if (size >= minsize && size <= maxsize)
      {
        result = result + array[i] + separator;
      }
      i++;
    }
    return result;
  }
}
