using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testSceneManaager : MonoBehaviour
{
    [SerializeField] SceneAsset s;
 
    void Start(){
        SceneManager.LoadScene(s.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
