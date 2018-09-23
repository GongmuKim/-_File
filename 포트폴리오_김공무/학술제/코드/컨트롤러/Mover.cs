using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour 
{

	public float speed = 5;
	void Start () 
	{

	}
    void Update()
    {
            transform.Translate(1, 0, 0);
    }
}
