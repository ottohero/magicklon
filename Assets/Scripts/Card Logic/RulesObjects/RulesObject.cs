using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public abstract class RulesObject {
    public string Name;
    public ManaCost ManaCost;
    public Color Color;

    public CardTypes CardTypes;

    public List<Ability> Abilities;

    public int BasePower;
    public int BaseToughness;

    public Player Owner { get; set; }

    public RulesObject(Player Owner) {
        this.BasePower = 0;
        this.BaseToughness = 0;
        this.Owner = Owner;
    }

    public override string ToString() {
        string output = (Name ?? "unnamed") + " - ";
        output += ManaCost + " ";
        output += BasePower + "/" + BaseToughness + " ";

        output += CardTypes;
        output += Abilities;

        return output;
    }

    public RulesObject Copy() {
        RulesObject other = (RulesObject)this.MemberwiseClone();

        other.CardTypes = this.CardTypes?.Copy();

        other.Abilities = new List<Ability>();
        this.Abilities.ForEach((ability) => other.Abilities.Add(ability.Copy()));

        other.Owner = this.Owner.Copy();

        return other;
    }
}
