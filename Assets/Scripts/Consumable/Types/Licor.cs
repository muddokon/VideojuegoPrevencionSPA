using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Este tipo de substancia te hace reaccionar tarde.
/// </summary>
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
        c.tieneLicor = true;
    }

    public override void Ended(CharacterInputController c)
    {
        base.Ended(c);
        Debug.Log("Trago terminado!");
        c.tieneLicor = false;
    }
}
