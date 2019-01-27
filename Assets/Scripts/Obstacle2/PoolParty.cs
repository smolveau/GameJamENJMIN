using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolParty : MonoBehaviour
{
    [SerializeField]
    GameObject spawner_;
    [SerializeField]
    GameObject obj_;
    [SerializeField]
    int nbObject_;

    private float offset_;
    private float minScale_; 
    private float maxScale_;

    // Start is called before the first frame update
    void Start()
    {
        minScale_ = 2.5f;
        maxScale_ = 5f;
        offset_ = 0;
        StartCoroutine("Spawn");
    }

    IEnumerator Spawn()
    {
        for (int i = 0; i < nbObject_; i++)
        {
            GameObject obj = Instantiate(obj_, spawner_.transform.position+(Vector3.right* offset_), Quaternion.identity);
            float scale = RandownScale();
            obj.transform.localScale = new Vector3(scale, scale, scale);
            offset_ += 5;
            if(offset_ >= 100)
            {
                offset_ = 0;
            }
            yield return new WaitForSeconds(0.5f);
        }
    }

    private float RandownScale()
    {

        return Random.Range(minScale_, maxScale_);
    }
}
