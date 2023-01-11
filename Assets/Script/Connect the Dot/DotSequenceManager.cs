/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DotSequenceManager : GameParent
{
	public Image clearImage;
	public AudioClip introSound, correctSound, wrongSound;
	public Transform levelParent;
	public CongratzUIButtonGroup congratzUI;
	public List<Sprite> backgroundList = new List<Sprite> ();

	static int level_parent_index = 0;
	int bgIndex = 0;
	AudioSource source;
	ClearImageBehaviour image;
    
	/// inisialisasi atribute dan inisialisasi game
	void Start ()
	{
		source = GetComponent<AudioSource> ();
		image = transform.GetChild (0).GetComponent<ClearImageBehaviour> ();

		GetComponent<Image> ().sprite = backgroundList [bgIndex];
		bgIndex++;

		for (int i = 0; i < levelParent.childCount; i++) {
			levelParent.GetChild (i).GetComponent<DotParent> ().parentList_id = i;
			levelParent.GetChild (i).GetComponent<DotParent> ().setLineParent (transform.GetChild (1));
		}

		source.PlayOneShot (introSound);
		InitAlphabets ();
	}

	public override void OnNextButtonClick ()
	{
		level_parent_index = (level_parent_index + 1) % 10;
		congratzUI.OnActivatingUI (false);
		foreach (Transform t in transform.GetChild(1))
			Destroy (t.gameObject);

		InitAlphabets ();
	}

	public override void OnPrevButtonClick ()
	{
		level_parent_index = (level_parent_index - 1) % 10;
		congratzUI.OnActivatingUI (false);
		foreach (Transform t in transform.GetChild(1))
			Destroy (t.gameObject);

		InitAlphabets ();
	}

	protected override void InitAlphabets ()
	{
		//DotParent parentProblem;

		GetComponent<Image> ().sprite = backgroundList [bgIndex % backgroundList.Count];
		image.changeImage (level_parent_index);
		image.setClear ();
		bgIndex++;

		foreach (Transform t in levelParent) {
			if (t.GetComponent<DotParent> ().parentList_id == level_parent_index) {
				t.gameObject.SetActive (true);

//                if (t.GetComponent<DotParent>() != null)
//                    parentProblem = t.GetComponent<DotParent>();
			} else {
				t.gameObject.SetActive (false);
//                parentProblem = null;
			}
		}
	}

	public void correctAnswer ()
	{
		image.setVisible ();
		playSound (true);
		Invoke ("congrats", 0.5f);
	}
    
	public void playSound (bool a)
	{
		if (a)
			source.PlayOneShot (correctSound);
		else
			source.PlayOneShot (wrongSound);
	}

	private void congrats ()
	{
		congratzUI.OnActivatingUI (true);
	}
}
