using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarPlayerPrefs : MonoBehaviour
{
    public void BorraPlayerPrefs(){
        PlayerPrefs.DeleteAll();
    }
}
