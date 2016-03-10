using UnityEngine;
using System.Collections;

public class SwapWeaponCommand : Command
{
    public override void Execute(GameActor actor)
    {
        actor.SwapWeapon();
    }
}


