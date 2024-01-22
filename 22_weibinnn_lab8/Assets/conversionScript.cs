using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

   public class conversionScript : MonoBehaviour
{
    
        public Toggle USD;
        public Toggle YEN;
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

            if (USD.GetComponent<Toggle>().isOn == true && YEN.GetComponent<Toggle>().isOn == true)
            {
                DebugTxt.text = "Choose Either JPY or USD";
            }
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
            ValueTxt.text = "";
            TxtAmount.text = "";
        }
    }
