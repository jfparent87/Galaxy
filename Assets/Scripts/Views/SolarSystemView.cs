using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemView : MonoBehaviour {

    GameController gameController;
    SolarSystem solarSystem;
    public Sprite[] sprites;

	// Use this for initialization
	void Start () {
        gameController = GameObject.FindObjectOfType<GameController>();
        ShowSolarSystem(0);
	}

    public void ShowSolarSystem(int solarSystemId) {
        solarSystem = gameController.galaxy.SolarSystems[solarSystemId];

        for (int i = 0; i < solarSystem.childrens.Count; i++) {
            Orbital orbital = solarSystem.childrens[i];

            GameObject go = new GameObject();
            go.transform.SetParent(this.transform);
            SpriteRenderer sr = go.AddComponent<SpriteRenderer>();
            sr.sprite = sprites[orbital.graphicID];
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
