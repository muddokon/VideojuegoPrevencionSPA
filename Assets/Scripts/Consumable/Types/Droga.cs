using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droga : Consumable
{
    public override string GetConsumableName()
    {
        return "Droga";
    }

    public override ConsumableType GetConsumableType()
    {
        return ConsumableType.DRUG;
    }

    public override int GetPrice()
    {
        return 20;
    }

    public override int GetPremiumCost()
    {
        return 2;
    }
    
    public override IEnumerator Started(CharacterInputController c)
    {
        yield return base.Started(c);
        Debug.Log("Droga recogida!");
    }

    public override void Ended(CharacterInputController c)
    {
        base.Ended(c);
        Debug.Log("Droga Terminada!");
    }
}
