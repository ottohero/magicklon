using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public enum ZoneType {
    Library,
    Hand,
    Graveyard,
    Battlefield,
    Stack,
    Exile
}
public struct Zone {
    public List<RulesObject> ZoneList;
    public bool Hidden;

    public ZoneType ZoneType;

    public Zone() {
        this.ZoneList = new List<RulesObject>();
        this.Hidden = false;
    }
}

public struct PlayerZones {
    public Zone Library;
    public Zone Hand;
    public Zone Graveyard;

    public PlayerZones() {
        this.Library = new Zone();
        this.Hand = new Zone();
        this.Graveyard = new Zone();
    }
}