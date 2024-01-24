using System.Collections;
string[] words = { "hello", "wordlds", "my", "love" };
string GetString(string[] words)
{
    int i;
    var smashed = "";
    for ( i = 0; i < words.Length; i++)
    {
        smashed += words[i];
    }
    if (i != words.Length - 1)
    {
        smashed += ' ';
    }
    return smashed;
}


int Min(int[] list)
{
    int min = 99999999;
    for(int i=0; i < list.Length; i++)
    {
        if (list[i] < min)
        {
            min = list[i];
        }
    }
    return min;
}

int[] list = { 43, 23, 20, 56, 10, -5 };
int Max(int[] list)
{
    int max = list[0];
    for(int i=0; i < list.Length ; i++)
    {
        if (list[i] > max)
        {
            max = list[i];
        }
    }
    return max;
}

int[] arr = { 1, 2, 3, 4, 3, 2, 1 };
int FindEvenIndex(int[] arr)
{
    int result = -1;
    int sum1 = 0;
    int sum2 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < i; j++)
        {
            sum1 += arr[j];
        }
        for (int k = arr.Length - 1; k > i; k--)
        {
            sum2 += arr[k];
        }
        if (sum1 == sum2)
        {
            result = i;
        }
    }
    return result;
}
 int[] MoveZeroes(int[] arr)
{
    // This solution makes use of C#'s behaviour with unassigned ints in arrays: They are 0 by default.
    // So we basically only have to create a new array with the same size, and write non-zero values
    // in their usual order. Simple.
    int[] zeroesAtEnd = new int[arr.Length];
    int currIndex = -1;
    foreach (int num in arr)
    {
        if (num != 0)
        {
            currIndex++;
            zeroesAtEnd[currIndex] = num;
        }
    }
    return zeroesAtEnd;
}

object[] obj = {1,"22",12,2,"22222"};

object[] RemoveObj(object[] obj)
{
    ArrayList myAL = new ArrayList();

    for(int i = 0; i < obj.Length; i++)
    {
        if (i%2==0)
        {
            myAL.Add(obj[i]);
        }
    }
    return myAL.ToArray();
}
int CheckExam(string[] arr1, string[] arr2)
{
    int sum = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] == arr2[i])
        {
            sum += 4;
        }
        if (arr1[i] != arr2[i]) {

            if (arr2[i] != "")
            {
                sum--;
            }
        };
    }
    return sum > 0 ? sum : 0;
}

List<int> GetGovno(List<int> list)
{
    List<int> ReversedList = new List<int>();
    for (int i = list.Count() - 1; i >= 0; i--)
    {
        ReversedList.Add(list[i]);
    }
    return ReversedList;
}

Console.WriteLine(GetGovno(new List<int>() { 1, 5, 6, 8, 2, 4 }));



Console.WriteLine(CheckExam(new string[] { "a", "a", "c", "b" }, new string[] { "a", "a", "b", "" }));
Console.WriteLine(obj);
Console.WriteLine(MoveZeroes(arr));
Console.WriteLine(FindEvenIndex(arr));
Console.WriteLine(Max(list));
Console.WriteLine(GetString(words));