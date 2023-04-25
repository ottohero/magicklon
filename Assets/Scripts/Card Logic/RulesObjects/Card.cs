using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Card : RulesObject {
    public Card(
        Player owner,
        string name,
        ManaCost manaCost,
        CardTypes cardTypes,
        List<Ability> abilities,
        int? basePower,
        int? baseToughness
    ) : base(owner) {

        this.Name = name;

        this.ManaCost = manaCost;

        this.CardTypes = cardTypes;

        this.Abilities = abilities ?? new List<Ability>();

        this.BasePower = basePower ?? 0;
        this.BaseToughness = baseToughness ?? 0;
    }

    public void CopyValues(RulesObject rulesObject) {
        rulesObject.Name = this.Name;

        rulesObject.ManaCost = this.ManaCost;
        rulesObject.Color = this.Color;

        rulesObject.CardTypes = this.CardTypes;

        rulesObject.Abilities = this.Abilities;

        rulesObject.BasePower = this.BasePower;
        rulesObject.BaseToughness = this.BaseToughness;
    }
}