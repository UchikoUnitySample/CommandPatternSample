using UnityEngine;
using System.Collections;


public class FireGunCommand : Command
{
    public override void Execute(GameActor actor)
    {
        actor.FireGun();
    }
}

