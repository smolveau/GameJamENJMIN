using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{
    private FixedJoint2D fixedJoint2D;
    public Rigidbody2D m_rgbd;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Use();
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        m_rgbd = collider.GetComponent<Rigidbody2D>();
    }


    private void OnTriggerExit2D(Collider2D collider)
    {
        m_rgbd = null;
    }

    public void Use()
    {
        if (m_rgbd != null)
        {
            if (!fixedJoint2D)
            {
                fixedJoint2D = gameObject.AddComponent<FixedJoint2D>();
                fixedJoint2D.connectedBody = m_rgbd;
            }
            else
            {
                Destroy(fixedJoint2D);
            }
        }
    }
}
