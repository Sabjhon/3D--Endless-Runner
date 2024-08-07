using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generatelevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 56;
    public bool creatingSection = false;
    public int secNum;

    

    void Update()
    {
        if (creatingSection == false)
        {
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0,0,zPos), Quaternion.identity);
        zPos += 56;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
