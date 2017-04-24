using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour {


	public GameObject EquippedWeapon { get; set; }
	public GameObject playerHand;

	IWeapon _equippedWeapon;
	CharacterStats characterStats;

	void Start(){

		characterStats = GetComponent<CharacterStats> ();

	}



	public void EquipWeapon(Item itemToEquip){


		if (EquippedWeapon != null) {

			characterStats.RemoveStatBonus (EquippedWeapon.GetComponent<IWeapon>().Stats);
			Destroy (playerHand.transform.GetChild (0).gameObject);

		}

		EquippedWeapon = (GameObject)Instantiate (Resources.Load<GameObject> ("Weapons/" + itemToEquip.ObjectSlug), playerHand.transform.position, playerHand.transform.rotation);
		_equippedWeapon = EquippedWeapon.GetComponent<IWeapon> ();
		_equippedWeapon.Stats = itemToEquip.Stats;
		EquippedWeapon.transform.SetParent (playerHand.transform);
		characterStats.AddStatBonus (itemToEquip.Stats);
	}



	public void PerformWeaponAttack(){

		_equippedWeapon.PerformAttack ();

	}


}
