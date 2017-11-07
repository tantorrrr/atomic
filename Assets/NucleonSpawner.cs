using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NucleonSpawner : MonoBehaviour {

    public float timeBetweenSpawns;
    public float distanceSpawns;
    public Nucleon[] prefabs;

	// Use this for initialization
	void Start () {
		
	}

    float lastTimeSinceSpawn;
	void FixedUpdate ()
    {
        lastTimeSinceSpawn += Time.deltaTime;
	    if(lastTimeSinceSpawn >= timeBetweenSpawns)
        {
            lastTimeSinceSpawn -= timeBetweenSpawns;
            SpawnNucleon();
        }
	}

    private void SpawnNucleon()
    {
        Nucleon prefab = prefabs[Random.Range(0, prefabs.Length)];
        Nucleon spawn = Instantiate<Nucleon>(prefab);
        spawn.transform.localScale = Vector3.one;
        spawn.transform.localPosition = Random.onUnitSphere * distanceSpawns;
    }
}
