using UnityEngine;
using UnityEngine.UI;

namespace greta
{
    public class SlotMachine : MonoBehaviour
    {
        public Text[] txts;
        private int a, b, c, d, e;
        private int count;
        private int index;
        private bool roll;

        public Image[] i = new Image[5];
        public int[] num = new int[5];

        private void Start()
        {
            

            foreach (Text item in txts) 
            {
                item.text = "0";
            }
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (count == 0 && !roll)
                {
                    roll = true;
                }
                else
                {
                    count++;
                    if (count == 3)
                    {
                        if(int.Parse(txts[0].text) == 7 && int.Parse(txts[1].text) == 7 && int.Parse(txts[2].text) ==7)
                        {
                            Debug.Log("Congratulation");
                        }
                    }

                    if (count == 4)
                    {
                        count = 0;
                    }

                }

            }

            if (roll)
            {
                for (int j = count; j < txts.Length; j++)
                {
                    txts[j].text = index + "";
                }

                if (Time.frameCount % 6 == 0)
                {
                    index++;

                    if (index > 9)
                    {
                        index = 0;
                    }
                }
            }
        }

    }

}
