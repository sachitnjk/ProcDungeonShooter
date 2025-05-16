using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PreGenTileBunchHandler : MonoBehaviour
{

	[SerializeField] private List<Tile> tilesUnderBunchList = new List<Tile>();

	public List<Tile> GetTilesUnderBunchList()
	{
		if(tilesUnderBunchList != null && tilesUnderBunchList.Count > 0)
		{
			return tilesUnderBunchList;
		}
		return null;
	}

}
