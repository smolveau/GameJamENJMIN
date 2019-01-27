using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent : MonoBehaviour
{
	[SerializeField]
	UnityEvent m_onEnter, m_onExit;

	private void OnCollisionEnter2D(Collision2D other)
	{
		m_onEnter.Invoke();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		m_onEnter.Invoke();
	}

	private void OnCollisionExit2D(Collision2D other)
	{
		m_onExit.Invoke();
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		m_onExit.Invoke();
	}
}