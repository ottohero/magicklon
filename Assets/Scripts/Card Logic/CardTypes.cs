using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CardTypes {
    public List<Supertype> Supertypes = new List<Supertype>();
    public List<CardType> Types = new List<CardType>();
    public List<CreatureType> CreatureTypes = new List<CreatureType>();
    public List<LandType> LandTypes = new List<LandType>();

    public CardTypes(List<Supertype> supertypes, List<CardType> types, List<CreatureType> creatureTypes, List<LandType> landTypes) {
        this.Supertypes = supertypes ?? new List<Supertype>();
        this.Types = types ?? new List<CardType>();
        this.CreatureTypes = creatureTypes ?? new List<CreatureType>();
        this.LandTypes = landTypes ?? new List<LandType>();
    }

    public override string ToString() {
        string output = "";
        foreach (Supertype s in Supertypes) {
            output += s;
            output += " ";
        }
        foreach (CardType t in Types) {
            output += t;
            output += " ";
        }
        if (Types.Count > 0) {
            output += " - ";
        }

        foreach (CreatureType t in CreatureTypes) {
            output += t;
            output += " ";
        }
        foreach (LandType t in LandTypes) {
            output += t;
            output += " ";
        }
        return output;
    }

    public CardTypes Copy() {
        return (CardTypes)this.MemberwiseClone();
    }
}

public enum Supertype {
    Basic,
    Flash,
    Legendary
}

public enum CardType {
    Creature,
    Sorcery,
    Artifact
}

public enum CreatureType {
    Human,
    Dragon,
    Warrior,
    Wizard
}

public enum LandType {
    Plains,
    Island,
    Swamp,
    Mountain,
    Forest
}
