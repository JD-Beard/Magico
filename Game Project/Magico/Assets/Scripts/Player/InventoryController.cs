using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {

	public PlayerWeaponController _playerWeaponController;
	public Item wand;


	void Start(){

		_playerWeaponController = GetComponent<PlayerWeaponController> ();

		List<BaseStat> wandStats = new List<BaseStat> ();
		wandStats.Add (new BaseStat (6, "Power", "Your power level."));
		wand = new Item (wandStats, "Wand");

	}


	void Update(){

		if (Input.GetKeyDown (KeyCode.V)) {

			_playerWeaponController.EquipWeapon (wand);

		}

	}
}
