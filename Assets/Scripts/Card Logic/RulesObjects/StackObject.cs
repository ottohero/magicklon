using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class StackObject : RulesObject, IControllable {
    public Player Controller { get; set; }

    public StackObject(Player Owner, Player Controller) : base(Owner) {
        this.Controller = Controller;
    }
}
