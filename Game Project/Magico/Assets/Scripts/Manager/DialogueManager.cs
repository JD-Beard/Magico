﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public static DialogueManager Instance{ get; set; }

	public GameObject dialoguePanel;
	public List<string> dialogueLines = new List<string> ();
	public string npcName;
	Button continueButton;
	Text dialogueText, nameText;
	int dialogueIndex;



	void Awake () {

		continueButton = dialoguePanel.transform.FindChild ("Continue").GetComponent<Button> ();
		dialogueText = dialoguePanel.transform.FindChild ("Text").GetComponent<Text> ();
		nameText = dialoguePanel.transform.FindChild ("Name").GetChild (0).GetComponent<Text> ();
		continueButton.onClick.AddListener (delegate {
			ContinueDialogue ();
		});

		dialoguePanel.SetActive (false);
			
	

		if (Instance != null && Instance != this) {

			Destroy (gameObject);

		} else {

			Instance = this;

		}
		
	}
	
	public void AddNewDialogue(string[] lines, string npcName){

		dialogueIndex = 0;
		dialogueLines = new List<string> (lines.Length);
		dialogueLines.Clear ();
		dialogueLines.AddRange (lines);


		this.npcName = npcName;
		CreateDialogue ();

	}


	public void CreateDialogue(){

		dialogueText.text = dialogueLines [dialogueIndex];
		nameText.text = npcName;
		dialoguePanel.SetActive (true);

	}



	public void ContinueDialogue(){


		if (dialogueIndex < dialogueLines.Count - 1) {

			dialogueIndex++;
			dialogueText.text = dialogueLines [dialogueIndex];

		} else {

			dialoguePanel.SetActive (false);
		}
	}
}
