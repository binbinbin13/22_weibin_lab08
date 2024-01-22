using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

   public class conversionScript : MonoBehaviour
{

    public Toggle USD;
    public Toggle YEN;
    public Toggle RM;
    public Toggle EUR;
    public Toggle KRW;
    public Toggle TWD;
    private float SGDamount;
    public InputField TxtAmount;
    private float Value;
    public InputField ValueTxt;
    public Text DebugTxt;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    public void Conversion()
    {

        try
        {

            SGDamount = float.Parse(TxtAmount.text);
            if (USD.GetComponent<Toggle>().isOn == true)
            {
                Value = SGDamount * 0.74f;
                ValueTxt.text = Value.ToString() + " USD";
            }
            if (YEN.GetComponent<Toggle>().isOn == true)
            {
                Value = SGDamount * 82.78f;
                ValueTxt.text = Value.ToString() + " JPY";
            }
            if (RM.GetComponent<Toggle>().isOn == true)
            {
                Value = SGDamount * 3.08f;
                ValueTxt.text = Value.ToString() + " JPY";
            }
            if (EUR.GetComponent<Toggle>().isOn == true)
            {
                Value = SGDamount * 0.63f;
                ValueTxt.text = Value.ToString() + " JPY";
            }
            if (KRW.GetComponent<Toggle>().isOn == true)
            {
                Value = SGDamount * 881.54f;
                ValueTxt.text = Value.ToString() + " JPY";
            }
            if (TWD.GetComponent<Toggle>().isOn == true)
            {
                Value = SGDamount * 20.73f;
                ValueTxt.text = Value.ToString() + " JPY";
            }


        }
        catch (System.Exception)
        {
            DebugTxt.text = "Amount Empty";
        }



    }
    public void ClearBtn()
    {
        YEN.GetComponent<Toggle>().isOn = false;
        USD.GetComponent<Toggle>().isOn = false;
        RM.GetComponent<Toggle>().isOn = false;
        EUR.GetComponent<Toggle>().isOn = false;
        KRW.GetComponent<Toggle>().isOn = false;
        TWD.GetComponent<Toggle>().isOn = false;
        ValueTxt.text = "";
        TxtAmount.text = "";
    }
}
