using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "Something really fun is happening... Are you aware of it?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
