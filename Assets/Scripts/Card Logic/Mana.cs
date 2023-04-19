using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public struct Mana {
    public Mana(uint c, uint w, uint u, uint b, uint r, uint g) {
        this.colorless = c;
        this.white = w;
        this.blue = u;
        this.black = b;
        this.red = r;
        this.green = g;
    }

    public uint colorless;
    public uint white;
    public uint blue;
    public uint black;
    public uint red;
    public uint green;
}