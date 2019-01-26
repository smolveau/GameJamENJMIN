using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private bool in_interaction = false;
    private Interactable interactable;
    private PlayerMovement m_playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        m_playerMovement = GetComponent<PlayerMovement>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        interactable = col.GetComponent<Interactable>();
    }

    void OnTriggerExit2D(Collider2D col)
    {
        interactable = null;
    }

    public void Use()
    {
        if(interactable != null)
        {
            if (!interactable.m_player)
            {
                Debug.Log("Player using interactable");
                interactable.Use(this);
                m_playerMovement.enabled = false;
            }
            else
            {
                Debug.Log("Player unusing interactable");
                interactable.UnUse();
                m_playerMovement.enabled = true;
            }
        }
    }
}
