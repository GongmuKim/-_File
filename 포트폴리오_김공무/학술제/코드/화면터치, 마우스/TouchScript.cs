using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TouchScript : MonoBehaviour {

    IEnumerator Inappear()
    {
       yield return new WaitForSeconds(5.0f);
       GetComponent<Text>().enabled = true;
    }
    void Start ()
    {
        StartCoroutine(Inappear());
    }
	
	void Update ()
    {
	
	}
}
