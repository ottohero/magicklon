using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Permanent : RulesObject, IControllable {
    public Player Controller { get; set; }
    public Card Card;
    public bool Tapped;

    public Permanent(Player Owner, Player Controller, Card Card) : base(Owner) {
        this.Controller = Controller;
        this.Card = Card;
        this.Tapped = false;

        Card.CopyValues(this);
    }

    public override string ToString() {
        return base.ToString() + (Tapped ? "tapped" : "untapped");
    }

}
