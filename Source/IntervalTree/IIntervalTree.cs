namespace Jamarino.IntervalTree;

public interface IIntervalTree<TKey, TValue> : IEnumerable<Interval<TKey, TValue>>
    where TKey : IComparable<TKey>
{
    int Count { get; }

    IEnumerable<TValue> Values { get; }

    void Add(TKey from, TKey to, TValue value);

    IEnumerable<TValue> Query(TKey key);

    IEnumerable<TValue> Query(TKey low, TKey high);

    void Remove(TValue value);

    void Remove(IEnumerable<TValue> values);

    void Clear();
}
