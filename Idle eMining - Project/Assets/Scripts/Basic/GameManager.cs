using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject shelfPrefab;

    private float posx = 0f;
    private float posy = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(shelfPrefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
