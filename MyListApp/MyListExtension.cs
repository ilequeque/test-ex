namespace MyListApp;

public static class MyListExtension
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        var res = new T[list.Count];
        for (var i = 0; i < list.Count; i++)
        {
            res[i] = list[i];
        }

        return res;
    }
}