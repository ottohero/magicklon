using System.Collections;
using System.Collections.Generic;

public class AcitvatedAbility : Ability {
    public Cost Cost;
    public AcitvatedAbility(
        List<Effect> effects,
        RulesObject source,
        Cost cost
        ) : base(effects, source) {

        this.Cost = cost;
    }
}