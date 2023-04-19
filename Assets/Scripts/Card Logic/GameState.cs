using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class GameState {
    public List<Player> Players;
    public Dictionary<Player, PlayerZones> IndividualZones;

    public Zone Battlefield;
    public Zone Stack;
    public Zone Exile;

    public List<ResolutionContinuousEffect> ResolutionContinuousEffects;

    public GameState(int numberOfPlayers) {
        this.Players = new List<Player>();
        this.IndividualZones = new Dictionary<Player, PlayerZones>();

        for (int i = 0; i < numberOfPlayers; i++) {
            Player newPlayer = new Player();
            this.Players.Add(newPlayer);

            PlayerZones newPlayerZones = new PlayerZones();
            this.IndividualZones.Add(newPlayer, newPlayerZones);
        }

        this.Battlefield = new Zone();
        this.Stack = new Zone();
        this.Exile = new Zone();

        this.ResolutionContinuousEffects = new List<ResolutionContinuousEffect>();
    }

    public List<Zone> GetAllZones() {
        List<Zone> AllZones = new List<Zone>();
        AllZones.Add(Battlefield);
        AllZones.Add(Stack);
        AllZones.Add(Exile);
        foreach (Player p in Players) {
            AllZones.Add(IndividualZones[p].Library);
            AllZones.Add(IndividualZones[p].Hand);
            AllZones.Add(IndividualZones[p].Graveyard);
        }
        return AllZones;
    }

}
