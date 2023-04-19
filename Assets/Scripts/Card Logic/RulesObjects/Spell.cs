using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Spell : StackObject {
    public Card Card;

    public Spell(Player Owner, Player Controller, Card Card) : base(Owner, Controller) {
        this.Card = Card;

        Card.CopyValues(this);
    }
}