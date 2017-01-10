using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemView : MonoBehaviour {

    GameController gameController;
    SolarSystem solarSystem;
    public Sprite[] sprites;
    private long zoomLevel = 100000000000;

	// Use this for initialization
	void Start () {
        gameController = GameObject.FindObjectOfType<GameController>();
        ShowSolarSystem(0);
	}

    public void ShowSolarSystem(int solarSystemId) {
        solarSystem = gameController.galaxy.SolarSystems[solarSystemId];

        for (int i = 0; i < solarSystem.childrens.Count; i++) {
            MakeSpriteForOrbital(this.transform, solarSystem.childrens[i]);
        }
    }

    void MakeSpriteForOrbital(Transform transformParent, Orbital orbital) {
        GameObject go = new GameObject();
        go.transform.SetParent(transformParent);

        go.transform.position = orbital.Position / zoomLevel;

        SpriteRenderer sr = go.AddComponent<SpriteRenderer>();
        sr.sprite = sprites[orbital.graphicID];

        for (int i = 0; i < orbital.childrens.Count; i++) {
            MakeSpriteForOrbital(go.transform, orbital.childrens[i]);
        }
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
