using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{
    private FixedJoint2D fixedJoint2D;
    private Collider2D m_collider2D;
    SpriteRenderer m_sprite;

    [SerializeField] Color m_colIdle, m_colSelected;

    private void Start()
    {
        m_sprite = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (!fixedJoint2D)
        {
            m_collider2D = collider;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (!fixedJoint2D)
        {
            m_collider2D = null;
        }
    }

    public void Use()
    {
        if (m_collider2D)
        {
            if (!fixedJoint2D)
            {
                fixedJoint2D = gameObject.AddComponent<FixedJoint2D>();
                fixedJoint2D.connectedBody = m_collider2D.GetComponent<Rigidbody2D>();

                m_sprite.color = m_colSelected;
            }
            else
            {
                Destroy(fixedJoint2D);
                m_collider2D = null;

                m_sprite.color = m_colIdle;
            }
        }
    }
}
