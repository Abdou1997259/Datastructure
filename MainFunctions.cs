static class MainFunction
{

    public static void FilterArray<T>(IEnumerable<T> Method, Func<T,bool> pre)
    {
        foreach (var item in Method)
        {
            if (pre(item))
            {
                Console.WriteLine(item);
            }
        }
    }
}