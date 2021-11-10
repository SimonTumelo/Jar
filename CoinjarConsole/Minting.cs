using System;
using System.Collections.Generic;

public class Minting : Mints
{
    private static List<Coin> CoinsTypes { get; set; }

    static Minting()
    {
        Type mintType = typeof(Minting);
        CoinsTypes = new List<Coin>();
        CoinsTypes.Add(new Coin(mintType, 1, 0.0122f));
        CoinsTypes.Add(new Coin(mintType, 5, 0.0243f));
        CoinsTypes.Add(new Coin(mintType, 10, 0.0115f));
        CoinsTypes.Add(new Coin(mintType, 25, 0.027f));
    }

    public override Coin ManufactureCoinOfValue(int value)
    {
        Coin modelCoin = null;

        foreach (Coin coin in CoinsTypes)
        {
            if (coin.Value == value)
            {
                modelCoin = coin;
                break;
            }
        }

        if (modelCoin != null)
        {
            return new Coin(modelCoin.Mints, modelCoin.Value, modelCoin.Volume);
        }
        else
        {
            return null;
        }
    }
}
