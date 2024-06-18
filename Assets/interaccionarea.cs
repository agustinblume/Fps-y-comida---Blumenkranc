using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interaccionarea : MonoBehaviour
{
    public Text puntajetxt;
    public int puntosahora = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntajetxt.text = puntosahora.ToString();
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter llamado con" + other.gameObject.name);
        pikupstrip pikup;
        pikup = other.GetComponent<pikupstrip>();
        puntosahora += pikup.puntosali;
        if (pikup.comida == true)
        {
            Destroy(other.gameObject);
        }
        
    }
}
