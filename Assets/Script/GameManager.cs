using UnityEngine;

public class GameManager : MonoBehaviour
{
	public string loadedLevelNameForAd;
	public float adDelay = 120;
	float curTimePlusDelay;

	bool isTimeUp {
		get {
			return Time.unscaledTime > curTimePlusDelay;
		}
	}

	public void ResetTime ()
	{
		curTimePlusDelay = Time.unscaledTime + adDelay;
	}

	void OnIntersLoaded (object o, System.EventArgs args)
	{
		Debug.Log (" intersitialnya wes di load");
	}
	

	void OnIntersOpening (object o, System.EventArgs args)
	{
		Debug.Log (" intersitialnya lagi di bukak");
	}
	
	void OnIntersClosed (object o, System.EventArgs args)
	{
		Debug.Log (" intersitialnya wes di tutup");
	}
	
	void OnIntersLeaving (object o, System.EventArgs args)
	{
		Debug.Log (" intersitialnya metu soko aplikasi");
	}
	
	void Start ()
	{		
		ResetTime ();
	}

	void OnLevelWasLoaded (int level)
	{
		Debug.Log (Application.loadedLevelName + "Telah di load");
		if (Application.loadedLevelName == loadedLevelNameForAd) {
			if (isTimeUp) {
				ResetTime ();
			}
		}
	}
}
