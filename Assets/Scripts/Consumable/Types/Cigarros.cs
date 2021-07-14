using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Este tipo de substancia te hace ir rápido y sin control.
/// </summary>
public class Cigarros : Consumable
{
    // private 
    public override string GetConsumableName()
    {
        return "Cigarros";
    }

    public override ConsumableType GetConsumableType()
    {
        return ConsumableType.CIGAR;
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
        Debug.Log("Cigarros recogidos!");
        c.trackManager.maxSpeed = 100f;
        c.tieneCigarros = true;
    }

    public override void Ended(CharacterInputController c)
    {
        base.Ended(c);
        Debug.Log("Cigarros terminados!");
        c.trackManager.maxSpeed = 30f;
        c.tieneCigarros = false;
    }
}
