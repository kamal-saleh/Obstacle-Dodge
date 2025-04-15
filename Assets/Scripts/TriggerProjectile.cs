using UnityEngine;
using System.Collections.Generic;
public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] private List<GameObject> projectiles;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            foreach (GameObject projectile in projectiles)
            {
                if (projectile != null)
                {
                    projectile.SetActive(true);
                }
            }
        }
    }
}
