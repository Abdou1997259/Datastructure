using System;
using System.Collections;

public class Ip : IEnumerable
{
    public delegate void handler(string d);
    private string[] segment = new string[3];
    public event handler IpChanged;

    public Ip(string s1, string s2, string s3)
    {
        segment[0] = s1;
        segment[1] = s2;
        segment[2] = s3;
    }

    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        if (obj is Ip ip)
        {
            return this.segment[0] == ip.segment[0] && this.segment[1] == ip.segment[1] && this.segment[2] == ip.segment[2];
        }
        return false;
    }

    public IEnumerator GetEnumerator() => new Enumerator(this);

    public static bool operator ==(Ip left, Ip right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Ip left, Ip right)
    {
        return !left.Equals(right);
    }

    public string this[int id]
    {
        get
        {
            return segment[id];
        }
        set
        {
            segment[id] = value;
        }
    }

    public void change(string value)
    {
        IpChanged?.Invoke("value dksjfaks");
    }

    class Enumerator : IEnumerator
    {
        int CurrentIndex = -1;
        Ip _ip;

        public Enumerator(Ip ip)
        {
            this._ip = ip;
        }

        public object Current
        {
            get
            {
                if (CurrentIndex == -1)
                    throw new InvalidOperationException("the ip didn't start");
                if (CurrentIndex == _ip.segment.Length)
                    throw new InvalidOperationException("the Ip didn't End");
                return _ip.segment[CurrentIndex];
            }
        }

        public bool MoveNext()
        {
            if (CurrentIndex >= _ip.segment.Length - 1)
                return false;
            return ++CurrentIndex < _ip.segment.Length;
        }

        public void Reset()
        {
            CurrentIndex = -1;
        }
    }

    ~Ip()
    {
        Console.WriteLine("finalized!");
    }
}
