using System.Collections.Generic;

namespace BasketCase.Util
{
    /*
     * This is a utility class that I like to use to have a slightly cleaner code to 
     * keep hashtable-like entries.
    */
    public abstract class Directory<TKey, TValue>
    {
        protected IDictionary<TKey, TValue> _entries;

        public Directory()
        {
            Initialize();
        }

        public IDictionary<TKey, TValue> Entries { get { return _entries; } }

        public void Initialize()
        {
            _entries = new Dictionary<TKey, TValue>();

            IntializeEntries();
        }

        public TValue Get(TKey key)
        {
            TValue value;
            if (_entries.TryGetValue(key, out value))
            {
                return value;
            }

            return default(TValue);
        }

        protected void Add(TKey key, TValue value)
        {
            if (_entries.ContainsKey(key)) return;

            _entries.Add(key, value);
        }

        protected abstract void IntializeEntries();
    }
}
