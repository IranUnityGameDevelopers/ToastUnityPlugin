using UnityEngine;
using System.Collections;

public class SimpleToastTest : MonoBehaviour {

	public ToastType toastType;
	public float timeIntervals;

	private string[] toasts = {
		"Hello" , 
		"I have a PC" , 
		"هاها فارسی هم کار می کنه"  ,
		"English is working as well" 

	};


	// Use this for initialization
	void Start () {
		if (timeIntervals == 0) {
			timeIntervals = 3;
		}
		InvokeRepeating("randomToast" , timeIntervals, timeIntervals );
	}


	void randomToast()
	{
		string message = toasts[Random.Range(0 , toasts.Length)];
		ToastHandler.Instance.Toast(message , toastType);
	}

}
