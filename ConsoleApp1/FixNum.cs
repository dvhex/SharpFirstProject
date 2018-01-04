using System;

public class FixNum
{
    private int _value;

    private const int range = 16;

	public FixNum(int value = 0)
	{
        _value = value << range;
	}

    public FixNum(double value)
    {
        value *= 1 << range;
        _value = (int)value;
    }

    public static FixNum operator +(FixNum a, FixNum b)
    {
        FixNum res = new FixNum
        {
            _value = a._value + b._value
        };
        return res;
    }

    public static FixNum operator -(FixNum a, FixNum b)
    {
        FixNum res = new FixNum
        {
            _value = a._value - b._value
        };
        return res;
    }

    public static FixNum operator *(FixNum a, FixNum b)
    {
        Int64 newvalue = a._value;
        newvalue *= b._value;
        newvalue >>= range;
        FixNum res = new FixNum
        {
            _value = (int)newvalue
        };
        return res;
    }

    public static FixNum operator /(FixNum a, FixNum b)
    {
        Int64 newvalue = a._value;
        newvalue <<= range;
        newvalue /= b._value;
        FixNum res = new FixNum
        {
            _value = (int)newvalue
        };
        return res;
    }

    public double ToDouble() => (double)_value / (1 << range);

    public override string ToString() => "" + ToDouble();

    public void Print() => Print(this);

    public static void Print(FixNum value) => Console.WriteLine(value.ToDouble());
}
