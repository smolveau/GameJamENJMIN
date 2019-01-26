using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private BoxCollider2D bc;
    private Rigidbody2D rb;
    public PlayerInteraction m_player;

    [SerializeField]
    private GameObject button_sprite;


    public void Use(PlayerInteraction player)
    {
        m_player = player;
    }

    public void UnUse()
    {
        m_player = null;
    }
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        bc = gameObject.GetComponent<BoxCollider2D>();
    }
    
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            // Afficher bouton et player peut interagir avec
            button_sprite.active = true;
        }
            
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            // Afficher bouton et player peut interagir avec
            button_sprite.active = false;
        }
    }
}