using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private bool in_interaction = false;
    private Interactable interactable;

    Rigidbody2D m_rgbd;

    // Start is called before the first frame update
    void Start()
    {
        m_rgbd = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        interactable = col.GetComponent<Interactable>();

        if(interactable)
        {
            interactable.Subscribe(this);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(interactable)
        {
            interactable.UnSubscribe(this);
        }

        interactable = null;
    }

    public void Control(Vector2 input)
    {
        if(interactable != null && interactable.m_activePlayer == this)
        {
            interactable.Control(input);
        }
    }

    public void Use()
    {
        if(interactable != null)
        {
            if (!interactable.m_activePlayer)
            {
                Debug.Log("Player using interactable");
                interactable.Use(this);
                m_rgbd.constraints = RigidbodyConstraints2D.FreezeAll;
            }
            else if(interactable.m_activePlayer == this)
            {
                Debug.Log("Player unusing interactable");
                interactable.UnUse();
                m_rgbd.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }
}
