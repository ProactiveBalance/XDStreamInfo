namespace XDStreamInfo;

public static class DictionaryExtensions
{
    public static IDictionary<TKey, TValue> Merge<TKey, TValue>(
        this IDictionary<TKey, TValue> mergedDictionary,
        params IDictionary<TKey, TValue>[] dictionaries)
    {
        foreach (var dictionary in dictionaries)
        {
            foreach (var kvp in dictionary)
            {
                mergedDictionary.TryAdd(kvp.Key, kvp.Value);
            }
        }

        return mergedDictionary;
    } 
}