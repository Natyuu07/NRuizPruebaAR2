using UnityEngine;
using Vuforia;

public class SimpleBarcodeScanner : MonoBehaviour
{
    public GameObject Icono;
    public AudioSource SonidoBip1;
    public bool Sonar = true;
    public TMPro.TextMeshProUGUI barcodeAsText;
    BarcodeBehaviour mBarcodeBehaviour;
    void Start()
    {
        mBarcodeBehaviour = GetComponent<BarcodeBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mBarcodeBehaviour != null && mBarcodeBehaviour.InstanceData != null)
        {
           
            barcodeAsText.text = mBarcodeBehaviour.InstanceData.Text;
            //suena continuamente
            if (Sonar == true)
            {
                print("Bip");
                SonidoBip1.Play();

                Sonar = false;

                Icono.SetActive(false);
                            }
        }
        else
        {
            barcodeAsText.text = "";
            Sonar = true;
            Icono.SetActive(true);
        }
    }
}