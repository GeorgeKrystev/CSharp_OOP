using System;

public class BitArray32
{
    private int number;

    public BitArray32(int number)
    {
        this.number = number;
    }

    public void SetBitAt(int bit, int index)
    {
        if(index < 0 || index > 31)
        {

            throw new ArgumentOutOfRangeException("index", "Index must be in range [0; 31]");
        }

        if (bit != 1 && bit != 0)
        {
            throw new ArgumentException("index", "Bit should be either 0 or 1");

        }

        int nullified = this.number & ~(1 << index);

        nullified |= bit << index;

        this.number = nullified;
    }

    public int this[int index]
    {
        get { return this.GetBit(index); }
        set
        {
            this.SetBitAt(value, index);
        }

    }


    public int GetBit(int index)
    {
        if(index < 0 || index > 31)
        {
            throw new ArgumentOutOfRangeException("index", "Index must be in range [0; 31]");
        }
        int bit = (this.number >> index) & 1;
        
        return bit;
    }

    public static BitArray32 operator +(BitArray32 a, BitArray32 b)
    {
        return new BitArray32(a.number + b.number);
    }

    public override string ToString()
    {
        return this.number.ToString();
    }
} 
