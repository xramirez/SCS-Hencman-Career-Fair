using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour {

    public GameObject coin;
	// Use this for initialization
	void Start () {
        SpawnCoin();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnCoin()
    {
        Instantiate(coin, new Vector3(Random.Range(-25, 25), 1, Random.Range(-30,30)), transform.rotation);
        Instantiate(coin, new Vector3(Random.Range(-25, 25), 1, Random.Range(-30, 30)), transform.rotation);
        Instantiate(coin, new Vector3(Random.Range(-25, 25), 1, Random.Range(-30, 30)), transform.rotation);
        Invoke("SpawnCoin", Random.Range(4, 6));
    }
}
