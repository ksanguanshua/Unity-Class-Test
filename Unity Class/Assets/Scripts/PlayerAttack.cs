using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject bullet;

    MeshRenderer mr;

    bool inactive;
    public Material reloading;
    Material active;
    int bulletsShot = 0;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        active = GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !inactive)
        {
            if(bulletsShot < 6)
            {
                Instantiate(bullet, this.transform.position, this.transform.rotation);
                bulletsShot++;
            }
            else
            {
                StartCoroutine(reload());
                inactive = true;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            StartCoroutine(reload());  
        }
    }

    IEnumerator reload()
    {
        inactive = true;
        mr.material = reloading;
        yield return new WaitForSeconds(2);
        mr.material = active;
        bulletsShot = 0;
        inactive = false;
    }
}
