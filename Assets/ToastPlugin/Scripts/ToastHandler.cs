using UnityEngine;
using System.Collections;

public class ToastHandler : MonoBehaviour {

	public static ToastHandler Instance;

	private AndroidJavaObject AndroidToastHandler;

	void Awake()
	{
		Instance = this;
		
		AndroidToastHandler = new AndroidJavaObject("ir.unity3d.toastunityplugin.ToastHandler");
	}


	public void Toast(string message , ToastType toasttype)
	{
		bool type = false;
		if (toasttype == ToastType.Long) {
			type = true;
		}
		AndroidToastHandler.Call("Toast" ,
		                         new AndroidJavaObject("java.lang.String" , message) ,
		                         new AndroidJavaObject("java.lang.Boolean" , type));
	}

}

public enum ToastType {
	Long ,
	Short
}
