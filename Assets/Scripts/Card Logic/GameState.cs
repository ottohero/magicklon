using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

    public GameState Copy() {
        GameState other = new GameState(this.Players.Count);

        this.Players.Zip(other.Players, (thisPlayer, otherPlayer) => { otherPlayer = thisPlayer.Copy(); return thisPlayer; });

        other.IndividualZones = new Dictionary<Player, PlayerZones>();

        other.Players.Zip(this.IndividualZones.Values, (player, playerZones) => { other.IndividualZones.Add(player, playerZones.Copy()); return player; });

        other.Battlefield = this.Battlefield.Copy();
        other.Stack = this.Stack.Copy();
        other.Exile = this.Exile.Copy();

        return other;
    }

}
