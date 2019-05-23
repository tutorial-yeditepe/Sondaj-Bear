using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public void changeScene(string sceneName) {

        Application.LoadLevel(sceneName);

    }
    
   
}
