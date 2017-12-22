using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdExplosion : MonoBehaviour {
    
    private Collider[] hitColliders;
    public float blastRadius;
    public LayerMask explosionLayers;
    public float explosionPower;

   // void OnCollisionEnter(Collision col)
   // {

   //     ExplosionWork(col.contacts[0].point);
   //     Destroy(gameObject);
   //            
   // }


    public void ExplosionWork(Vector3 explosionPoint)
    {
        hitColliders = Physics.OverlapSphere(explosionPoint, blastRadius, explosionLayers);

        foreach(Collider hitCol in hitColliders)
        {
            if (hitCol.GetComponent<Rigidbody>()!=null)
            {
                hitCol.GetComponent<Rigidbody>().isKinematic = false;
                hitCol.GetComponent<Rigidbody>().AddExplosionForce(explosionPower,explosionPoint, blastRadius, 1, ForceMode.Impulse);
            }
        }

    }





    

}
