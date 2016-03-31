using UnityEngine;
using System.Collections;
using Asset;

public class PlayerControll : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (InputMng.IsUp())
        {
            Vector3 pos = InputMng.GetPosition();
            GameObject obj = GameObject.Find("Piece");
            Piece piece = obj.GetComponent<Piece>();
            piece.Active = !piece.Active;
        }
	}
}
