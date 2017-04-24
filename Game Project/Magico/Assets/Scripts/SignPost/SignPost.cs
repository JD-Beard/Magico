using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignPost : ActionItem {


	public string[] Dialogue;
	public override void Interact(){


		DialogueManager.Instance.AddNewDialogue (Dialogue, "Sign Post");
			base.Interact();
		Debug.Log ("Talking to signpost");

	}


}
