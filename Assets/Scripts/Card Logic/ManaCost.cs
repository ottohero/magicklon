using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ManaCost {
    public Mana mana;

    public ManaCost(Mana mana) {
        this.mana = mana;
    }

    public uint getManaValue() {
        return mana.colorless + mana.white + mana.blue + mana.black + mana.red + mana.green;
    }

    public override string ToString() {
        string colorlessString = mana.colorless.ToString();
        if (mana.colorless == 0 && this.getManaValue() != 0) {
            colorlessString = "";
        }
        return colorlessString +
            new string('w', (int)mana.white) +
            new string('u', (int)mana.blue) +
            new string('b', (int)mana.black) +
            new string('r', (int)mana.red) +
            new string('g', (int)mana.green);
    }
}
