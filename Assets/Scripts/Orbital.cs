using UnityEngine;
using System;
using System.Collections;

public class Orbital {

    public Orbital parent;
    public float angle;
    public ulong orbitalDistance;
    public ulong timetoOrbit;

    public Vector3 Position {
        get {

            return new Vector3(
                Mathf.Sin(angle) * orbitalDistance,
                Mathf.Cos(angle) * orbitalDistance,
                0
            );
        }
        set {

        }
    }

    public void Update(ulong timeSinceStart) {
        float numOrbits = timeSinceStart / timetoOrbit;
        angle = numOrbits * 2 * Mathf.PI;
    }

    public void makeEarth() {
        angle = 0;
        orbitalDistance = 150000000000; // 150 million km
        timetoOrbit = 365 * 24 * 60 * 60;
    }

}
