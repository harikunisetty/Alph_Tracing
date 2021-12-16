using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class SceneStartup : MonoBehaviour
{
	void Start ()
	{
		ShowAd ();
	}

	public void ShowAd ()
	{
		if (SceneManager.GetActiveScene ().name == "Logo") {
			AdsManager.instance.ShowAdvertisment (AdPackage.AdEvent.Event.ON_LOAD_LOGO_SCENE);
		} else if (SceneManager.GetActiveScene ().name == "Main") {
			AdsManager.instance.ShowAdvertisment (AdPackage.AdEvent.Event.ON_LOAD_MAIN_SCENE);
		} else if (SceneManager.GetActiveScene ().name == "LowercaseAlbum") {
			AdsManager.instance.ShowAdvertisment (AdPackage.AdEvent.Event.ON_LOAD_LOWERCASE_SCENE);
		} else if (SceneManager.GetActiveScene ().name == "UppercaseAlbum") {
			AdsManager.instance.ShowAdvertisment (AdPackage.AdEvent.Event.ON_LOAD_UPPERCASE_SCENE);
		} else if (SceneManager.GetActiveScene ().name == "NumbersAlbum") {
			AdsManager.instance.ShowAdvertisment (AdPackage.AdEvent.Event.ON_LOAD_NUMBERS_SCENE);
		} else if (SceneManager.GetActiveScene ().name == "ScentenceAlbum") {
			AdsManager.instance.ShowAdvertisment (AdPackage.AdEvent.Event.ON_LOAD_SCENTENCE_SCENE);
		} else if (SceneManager.GetActiveScene ().name == "Game") {
			AdsManager.instance.ShowAdvertisment (AdPackage.AdEvent.Event.ON_LOAD_GAME_SCENE);
		}
	}

	void OnDestroy ()
	{
		AdsManager.instance.HideAdvertisment ();
	}
}
