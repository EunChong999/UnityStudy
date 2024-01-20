using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGunCommand : Command
{
    public override void Execute(GameActor actor)
    {
        actor.FireGun();
    }
}
