using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galaxy {

    public List<SolarSystem> SolarSystems;

    public Galaxy() {
        SolarSystems = new List<SolarSystem>();
    }

    public void Generate(int numStars) {
        for (int i = 0; i < numStars; i++) {
            SolarSystem ss = new SolarSystem();
            ss.Generate();
            SolarSystems.Add(ss);
        }
    }
}
