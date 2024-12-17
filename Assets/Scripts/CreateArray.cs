using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateArray : MonoBehaviour
{
    public GameObject prefab;
    public int N = 3;
    public int M = 4;

	private void Start()
	{
		for (int i = 0; i < N; i++)
		{
			for (int j = 0; j < M; j++) 
			{
				Vector3 position = new Vector3(i, j, 0);
				Instantiate(prefab, position, Quaternion.identity);
			}
		}
	}
}
