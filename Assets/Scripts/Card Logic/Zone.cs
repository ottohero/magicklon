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
public class Zone {
    public List<RulesObject> ZoneList;
    public bool Hidden;

    public ZoneType ZoneType;

    public Zone() {
        this.ZoneList = new List<RulesObject>();
        this.Hidden = false;
    }

    public Zone Copy() {
        Zone other = (Zone)this.MemberwiseClone();
        other.ZoneList = new List<RulesObject>();
        this.ZoneList.ForEach((ro) => other.ZoneList.Add(ro.Copy()));

        return other;
    }
}

public class PlayerZones {
    public Zone Library;
    public Zone Hand;
    public Zone Graveyard;

    public PlayerZones() {
        this.Library = new Zone();
        this.Hand = new Zone();
        this.Graveyard = new Zone();
    }

    public PlayerZones Copy() {
        PlayerZones other = new PlayerZones();
        other.Library = this.Library.Copy();
        other.Hand = this.Hand.Copy();
        other.Graveyard = this.Graveyard.Copy();
        return other;
    }
}