using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {



	public List<BaseStat> stats = new List<BaseStat>();



	void Start(){


		stats.Add (new BaseStat (4, "Power", "Your Power Level."));
		stats.Add (new BaseStat (2, "Mana", "Your Mana Level."));

	}


	public void AddStatBonus(List<BaseStat> statBonues){


		foreach (BaseStat statBonus in statBonues) {

			stats.Find (x=> x.StatName == statBonus.StatName).AddStatBonus(new StatBonus(statBonus.BaseValue));
		}
	}



	public void RemoveStatBonus(List<BaseStat> statBonues){


		foreach (BaseStat statBonus in statBonues) {

			stats.Find (x=> x.StatName == statBonus.StatName).RemoveStatBonus(new StatBonus(statBonus.BaseValue));
		}
	}
}
