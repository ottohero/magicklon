using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public abstract class Ability {
    public List<Effect> Effects;
    public RulesObject Source;

    public Ability(List<Effect> effects, RulesObject source) {
        this.Effects = effects ?? new List<Effect>();
        this.Source = source;
    }

    public abstract Ability Copy();
}
