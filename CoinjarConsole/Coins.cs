using System;
using System.Collections.Generic;

public class Coin
{
    public Type Mints { get; private set; }

    public int Value { get; private set; }

    public float Volume { get; private set; }

    public Coin(Type mint, int value, float volume)
    {
        this.Mints = mint;
        this.Value = value;
        this.Volume = volume;
    }
}
