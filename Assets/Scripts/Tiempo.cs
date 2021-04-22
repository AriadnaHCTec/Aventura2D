using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetFloat ("runTime"/*, runTime*/);//lo comente porque marcaba error y me ponia en modo seguro
    }

    void OnDestroy() {
        var savedTime = PlayerPrefs.GetFloat ("runTime");
        PlayerPrefs.SetFloat ("runTime", savedTime + Time.timeSinceLevelLoad);
       
        Debug.Log (PlayerPrefs.GetFloat("runTime"));
    }
}
