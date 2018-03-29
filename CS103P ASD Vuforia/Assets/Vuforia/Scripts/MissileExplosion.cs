using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileExplosion : MonoBehaviour {

	public float explosionRadius = 3F;
	public float explosionForce = 1000F;


	private void OnCollisionEnter(Collision collision) 
	{
		
		Collider[] collidersHit = Physics.OverlapSphere (transform.position, explosionRadius); 
		Destroy (gameObject);
		foreach (Collider collider in collidersHit)
		{
			Rigidbody targetbody = collider.GetComponent<Rigidbody>();
			if (targetbody == null) {
				continue;
			} 
			else 
			{
				targetbody.AddExplosionForce (explosionForce, transform.position, explosionRadius, 2.0F);
			}
		}

		

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
