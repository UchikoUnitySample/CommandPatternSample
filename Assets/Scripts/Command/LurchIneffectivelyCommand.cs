using UnityEngine;
using System.Collections;

public class LurchIneffectivelyCommand : Command
{
    public override void Execute(GameActor actor)
    {
        actor.LurchIneffectively();
    }
}

