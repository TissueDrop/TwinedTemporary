using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetherLink : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StartCoroutine("TetherLinkUpScaler");
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void StartTetherLinkDownScaler()
    {
        StartCoroutine("TetherLinkDownScaler");
    }

    IEnumerator TetherLinkUpScaler()
    {
        for (float i = 0; i <= 1; i += 0.05f)
        {
            transform.localScale = new Vector3(i, i, 0);
            yield return null;
        }
    }

    IEnumerator TetherLinkDownScaler()
    {
        for (float i = 1; i >= 0; i -= 0.05f)
        {
            transform.localScale = new Vector3(i, i, 0);
            yield return null;
        }

        List<GameObject> tmp = GameObject.Find("Tether").GetComponent<TetherManager>().GetLinkList();
        tmp[tmp.IndexOf(gameObject) + 1].GetComponent<HingeJoint2D>().connectedBody = tmp[tmp.IndexOf(gameObject)-1].GetComponent<Rigidbody2D>();
        tmp.Remove(gameObject);
        GameObject.Find("Tether").GetComponent<TetherManager>().SetLinkList(tmp);
        Destroy(gameObject);
    }
}
