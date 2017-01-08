using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Orbital {

    public Orbital parent;
    public List<Orbital> childrens;
    public float angle;
    public ulong orbitalDistance;
    public ulong timetoOrbit;
    public int graphicID;

    public Orbital() {
        timetoOrbit = 1;
        childrens = new List<Orbital>();
    }

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
        for (int i = 0; i < childrens.Count; i++) {
            childrens[i].Update(timeSinceStart);
        }
    }

    public void makeEarth() {
        angle = 0;
        orbitalDistance = 150000000000; // 150 million km
        timetoOrbit = 365 * 24 * 60 * 60;
    }

    public void AddChild(Orbital orbital) {
        orbital.parent = this;
        childrens.Add(orbital);
    }

    public void RemoveChild(Orbital orbital) {
        orbital.parent = null;
        childrens.Remove(orbital);
    }

}
