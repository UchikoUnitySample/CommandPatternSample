using UnityEngine;
using System.Collections;
using System;

public abstract class Command
{
    abstract public void Execute(GameActor actor);
}

