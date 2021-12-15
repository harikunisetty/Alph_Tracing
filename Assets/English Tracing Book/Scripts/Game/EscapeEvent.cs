using UnityEngine;
using System.Collections;

public class EscapeEvent : MonoBehaviour
{
		
		public string sceneName;
		public bool leaveTheApplication;
		public bool loadShapesManagerSceneName;

		public void Update ()
		{
				if (Input.GetKeyDown (KeyCode.Escape)) {
						OnEscapeClick ();
				}
		}

	
		public void OnEscapeClick ()
		{
				if (leaveTheApplication) {
						GameObject exitConfirmDialog = GameObject.Find ("ExitConfirmDialog");
						if (exitConfirmDialog != null) {
								Dialog exitDialogComponent = exitConfirmDialog.GetComponent<Dialog> ();
								if (!exitDialogComponent.animator.GetBool ("On")) {
										exitDialogComponent.Show ();
										//AdsManager.instance.ShowAdvertisment (AdsManager.AdAPI.AdEvent.Event.ON_SHOW_EXIT_DIALOG);
								}
						}
				} else {
					if (loadShapesManagerSceneName) {
						StartCoroutine(SceneLoader.LoadSceneAsync (GameObject.Find(ShapesManager.shapesManagerReference).GetComponent<ShapesManager>().sceneName));
					} else {
						StartCoroutine (SceneLoader.LoadSceneAsync (sceneName));
					}
				}
		}
}