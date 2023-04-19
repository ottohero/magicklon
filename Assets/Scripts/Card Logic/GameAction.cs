using System.Collections;
using System.Collections.Generic;

using System;

using UnityEngine;

public class GameAction {
    private GameState oldState;
    private GameState newState;

    public GameAction(GameState state) {
        this.oldState = state;
    }
}
