using UnityEngine;
using System.Collections;

public class ToastHandler : MonoBehaviour {

	public static ToastHandler Instance;

	void Awake()
	{
		Instance = this;
	}


	public void Toast(string message , ToastType type)
	{

	}

}

public enum ToastType {
	Long ,
	Short
}
