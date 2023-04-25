using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Cost {
    public List<Effect> Effects;
    public ManaCost ManaCost;

    public Cost Copy() {
        return (Cost)this.MemberwiseClone();
    }

}
