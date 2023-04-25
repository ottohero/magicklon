using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class TriggeredAbility : Ability {
    public Func<GameState, GameState, bool> WillTrigger;

    public TriggeredAbility(
        List<Effect> effects,
        RulesObject source,
        Func<GameState, GameState, bool> willTrigger
        ) : base(effects, source) {

        this.WillTrigger = willTrigger;
    }

    List<Effect> Trigger(GameState oldState, GameState newState) {
        if (this.WillTrigger(oldState, newState)) {
            return this.Effects;
        }
        return new List<Effect>();
    }

    override public Ability Copy() {
        TriggeredAbility other = (TriggeredAbility)this.MemberwiseClone();

        return other;
    }

}