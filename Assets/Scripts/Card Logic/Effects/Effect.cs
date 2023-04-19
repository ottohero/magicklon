using System.Collections;
using System.Collections.Generic;
using System;

using UnityEngine;

public abstract class Effect {
    public Action<GameState> PerformEffect;
    public List<List<RulesObject>> TargetsList;
    public List<Func<RulesObject, GameState, bool>> CheckValidTargetList;

    public Effect DeepCopy() {
        return (Effect)this.MemberwiseClone();
    }
}