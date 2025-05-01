using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputProvider : MonoBehaviour
{
	[field: SerializeField] public PlayerInput InputSystemActions { get; private set; }

	private void Awake()
	{
		if (InputSystemActions == null)
		{
			InputSystemActions = GetComponent<PlayerInput>();
		}
	}
}
