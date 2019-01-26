using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private BoxCollider2D bc;
    [SerializeField] Rigidbody2D rb;
    [HideInInspector] public PlayerInteraction m_activePlayer;

    [SerializeField]
    SpriteRenderer m_sprite;

    [SerializeField, Range(0,100)] float m_force;

    [SerializeField] Color m_colIdle, m_colSelected, m_colActive;
    
    List<PlayerInteraction> m_playerList;


    public void Use(PlayerInteraction player)
    {
        if(!m_activePlayer)
        {
            m_activePlayer = player;
            m_sprite.color = m_colActive;
        }
    }

    public void UnUse()
    {
        m_activePlayer = null;
        m_sprite.color = m_colSelected;
    }

    public void Subscribe(PlayerInteraction player)
    {
        m_playerList.Add(player);

        if(!m_activePlayer)
        {
            m_sprite.color = m_colSelected;
        }
    }

    public void UnSubscribe(PlayerInteraction player)
    {
        m_playerList.Remove(player);

        if(!m_activePlayer)
        {
            if(m_playerList.Count == 0)
                m_sprite.color = m_colIdle;
        }
    }
    
    void Start()
    {
        bc = gameObject.GetComponent<BoxCollider2D>();
        m_playerList = new List<PlayerInteraction>();

        m_sprite = GetComponent<SpriteRenderer>();
    }
    
    public void Control(Vector2 input)
    {
        rb.AddForce(input * m_force);
    }
}