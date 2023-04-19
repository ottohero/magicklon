using System.Collections;
using System.Collections.Generic;
using System;

using UnityEngine;

public struct ContinuousEffect : Effect {
    public Func<RulesObject, GameState, bool> AffectsChecker;
    public Action<GameState> EndEffect;
}
