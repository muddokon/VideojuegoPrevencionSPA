using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Licor : Consumable
{
    public override string GetConsumableName()
    {
        return "Licor";
    }

    public override ConsumableType GetConsumableType()
    {
        return ConsumableType.ALCOHOL;
    }

    public override int GetPrice()
    {
        return 10;
    }

    public override int GetPremiumCost()
    {
        return 1;
    }
    
    public override IEnumerator Started(CharacterInputController c)
    {
        yield return base.Started(c);
        Debug.Log("Trago recogido!");
    }

    public override void Ended(CharacterInputController c)
    {
        base.Ended(c);
        Debug.Log("Trago terminado!");
    }
}
