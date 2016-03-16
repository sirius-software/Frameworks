namespace Bridge.Google.Maps
{
    using System;

    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class MVCArray<T> : MVCObject
    {
        [Template("new google.maps.MVCArray()")]
        public extern MVCArray();

        [Template("new google.maps.MVCArray({array})")]
        public extern MVCArray(T[] array);

        public extern void Clear();

        public extern void ForEach(Func<T, int> callback);

        public extern T[] GetArray();

        public extern T GetAt(int i);

        public extern int GetLength();

        public extern void InsertAt(int i, T elem);

        public extern T Pop();

        public extern int Push(T elem);

        public extern T RemoveAt(int i);

        public extern void SetAt(int i, T elem);
    }
}