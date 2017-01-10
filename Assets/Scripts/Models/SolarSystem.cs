using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : Orbital {

    public void Generate() {
        Orbital myStar = new Orbital();
        myStar.graphicID = 0;
        this.AddChild(myStar);

        Orbital planet = new Orbital();
        planet.makeEarth();
        planet.graphicID = 1;
        myStar.AddChild(planet);
    }
}
