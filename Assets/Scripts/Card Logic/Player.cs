using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Player {
    int Life;

    public Player() {
        this.Life = 20;
    }

    public Player Copy() {
        return (Player)this.MemberwiseClone();
    }
}
