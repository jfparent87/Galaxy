using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public Galaxy galaxy;

	void OnEnable () {
        galaxy = new Galaxy();
        galaxy.Generate(1);
	}
}
