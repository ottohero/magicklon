using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class SpellAbility : Ability {
    public SpellAbility(List<Effect> effects, RulesObject source) : base(effects, source) {

    }

    override public Ability Copy() {
        SpellAbility other = (SpellAbility)this.MemberwiseClone();

        return other;
    }
}
