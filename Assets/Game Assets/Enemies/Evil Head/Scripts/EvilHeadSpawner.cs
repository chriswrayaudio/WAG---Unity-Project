////////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2018 Audiokinetic Inc. / All Rights Reserved
//
////////////////////////////////////////////////////////////////////////

﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SphereCollider))]
public class EvilHeadSpawner : MonoBehaviour
{
    [Header("Object Links")]
    public GameObject EvilHead;
    public Vector3 SpawnOffset;
    public GameObject DestructionParticles;
    public AK.Wwise.Event DestructionSound;
    public bool SpawnOnAwake = false;

	private GameObject EH = null;

	void OnEnable()
    {
        if (SpawnOnAwake)
        {
            EH = SpawnEvilHead();
            EH.name = "Evil Head";
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (!SpawnOnAwake && col.CompareTag("Player"))
        {
            EH = SpawnEvilHead();
            EH.name = "Evil Head";
        }
    }

    public GameObject SpawnEvilHead()
    {
        //Disable the Sphere Trigger in order to not spawn any more Evil Heads
        GetComponent<SphereCollider>().enabled = false;

        return Instantiate(EvilHead, transform.position + SpawnOffset, Quaternion.identity) as GameObject;
    }

    void OnCollisionEnter(Collision col)
    {
        //Destroy the spawner when the Player walks into it.
        if (col.collider.CompareTag("Player"))
        {
            GameObject destructionParticles = (Instantiate(DestructionParticles, transform.position, Quaternion.identity)) as GameObject;
            Destroy(destructionParticles, 5f);
            DestructionSound.Post(destructionParticles);
            Destroy(this.gameObject);
        }
    }

	public void StopSoundOnSpawnedEvilHead()
	{
		if (EH)
		{
			AkSoundEngine.StopAll(EH);
		}
	}
}
