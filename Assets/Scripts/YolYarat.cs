using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YolYarat : MonoBehaviour
{
    System.Random random = new System.Random();
    private GameObject Mor, Sarı, Turuncu, Kırmızı, Yeşil, Mavi, Deadline,Player,yol1,yol2,yol3,yol4,yol5,yol6,yol7,yol8,yol9,yol10,yol11,yol12;
    public GameObject Score;
    private float zMor, zSarı, zTuruncu, zKırmızı, zYeşil, zMavi,zDeadline,zPlayer,Zyol1,Zyol2,Zyol3,Zyol4,Zyol5,Zyol6,Zyol7,Zyol8,Zyol9,Zyol10,Zyol11,Zyol12;
    private int yMor, ySarı, yTuruncu, yKırmızı, yYeşil, yMavi,Yyol1,Yyol2,Yyol3,Yyol4,Yyol5,Yyol6,Yyol7,Yyol8,Yyol9,Yyol10,Yyol11,Yyol12;
   


    


    // Start is called before the first frame update
    void Start()
    {
        
        

        yMor = random.Next(0,4);
        ySarı = random.Next(0,4);
        yTuruncu = random.Next(0, 4);
        yKırmızı = random.Next(0,4);
        yYeşil = random.Next(0,4);
        yMavi = random.Next(0,4);
        Yyol1= random.Next(0,4);
        Yyol2= random.Next(0,4);
        Yyol3= random.Next(0,4);
        Yyol4= random.Next(0,4);
        Yyol5= random.Next(0,4);
        Yyol6= random.Next(0,4);
        Yyol7= random.Next(0,4);
        Yyol8= random.Next(0,4);
        Yyol9= random.Next(0,4);
        Yyol10= random.Next(0,4);
        Yyol11= random.Next(0,4);
        Yyol12= random.Next(0,4);
        Score = GameObject.FindGameObjectWithTag("Score");
        Player = GameObject.FindGameObjectWithTag("PlayerTag");
        Mor = GameObject.FindGameObjectWithTag("Mor");
        Sarı = GameObject.FindGameObjectWithTag("Sarı");
        Turuncu = GameObject.FindGameObjectWithTag("Turuncu");
        Kırmızı = GameObject.FindGameObjectWithTag("Kırmızı");
        Yeşil = GameObject.FindGameObjectWithTag("Yeşil");
        Mavi = GameObject.FindGameObjectWithTag("Mavi");
        Deadline = GameObject.FindGameObjectWithTag("Deadline");
        yol1= GameObject.FindGameObjectWithTag("1");
        yol2= GameObject.FindGameObjectWithTag("2");
        yol3= GameObject.FindGameObjectWithTag("3");
        yol4= GameObject.FindGameObjectWithTag("4");
        yol5= GameObject.FindGameObjectWithTag("5");
        yol6= GameObject.FindGameObjectWithTag("6");
        yol7= GameObject.FindGameObjectWithTag("7");
        yol8= GameObject.FindGameObjectWithTag("8");
        yol9= GameObject.FindGameObjectWithTag("9");
        yol10= GameObject.FindGameObjectWithTag("10");
        yol11= GameObject.FindGameObjectWithTag("11");
        yol12= GameObject.FindGameObjectWithTag("12");
        /*************************************************/
        Zyol1= yol1.GetComponent<Transform>().position.z;
        Zyol2= yol2.GetComponent<Transform>().position.z;
        Zyol3= yol3.GetComponent<Transform>().position.z;
        Zyol4= yol4.GetComponent<Transform>().position.z;
        Zyol5= yol5.GetComponent<Transform>().position.z;
        Zyol6= yol6.GetComponent<Transform>().position.z;
        Zyol7= yol7.GetComponent<Transform>().position.z;
        Zyol8= yol8.GetComponent<Transform>().position.z;
        Zyol9= yol9.GetComponent<Transform>().position.z;
        Zyol10= yol10.GetComponent<Transform>().position.z;
        Zyol11= yol11.GetComponent<Transform>().position.z;
        Zyol12= yol12.GetComponent<Transform>().position.z;
        /*****************************************************/
        zMor = Mor.GetComponent<Transform>().position.z;
        zSarı = Sarı.GetComponent<Transform>().position.z;
        zTuruncu = Turuncu.GetComponent<Transform>().position.z;
        zKırmızı = Kırmızı.GetComponent<Transform>().position.z;
        zYeşil = Yeşil.GetComponent<Transform>().position.z;
        zMavi = Mavi.GetComponent<Transform>().position.z;
        zPlayer  = Player.GetComponent<Transform>().position.z;
        Mor.GetComponent<Transform>().position = new Vector3(0,yMor,zMor);
        Sarı.GetComponent<Transform>().position = new Vector3(0,ySarı,zSarı);
        Turuncu.GetComponent<Transform>().position = new Vector3(0,yTuruncu,zTuruncu);
        Kırmızı.GetComponent<Transform>().position = new Vector3(0, yKırmızı, zKırmızı);
        Yeşil.GetComponent<Transform>().position = new Vector3(0, yYeşil, zYeşil);
        Mavi.GetComponent<Transform>().position = new Vector3(0, yMavi, zMavi);
        yol1.GetComponent<Transform>().position = new Vector3(0,Yyol1,Zyol1);
        yol2.GetComponent<Transform>().position = new Vector3(0,Yyol2,Zyol2);
        yol3.GetComponent<Transform>().position = new Vector3(0,Yyol3,Zyol3);
        yol4.GetComponent<Transform>().position = new Vector3(0,Yyol4,Zyol4);
        yol5.GetComponent<Transform>().position = new Vector3(0,Yyol5,Zyol5);
        yol6.GetComponent<Transform>().position = new Vector3(0,Yyol6,Zyol6);
        yol7.GetComponent<Transform>().position = new Vector3(0,Yyol7,Zyol7);
        yol8.GetComponent<Transform>().position = new Vector3(0,Yyol8,Zyol8);
        yol9.GetComponent<Transform>().position = new Vector3(0,Yyol9,Zyol9);
        yol10.GetComponent<Transform>().position = new Vector3(0,Yyol10,Zyol10);
        yol11.GetComponent<Transform>().position = new Vector3(0,Yyol11,Zyol11);
        yol12.GetComponent<Transform>().position = new Vector3(0,Yyol12,Zyol12);


    }

    // Update is called once per frame
    void FixedUpdate()
    {


        

        if (Convert.ToInt16(Player.GetComponent<Transform>().position.y) < 0)
        {
            Debug.Log("Failed");
            SceneManager.LoadScene("Giriş");

        }
        Score.GetComponent<Text>().text = Convert.ToString(Convert.ToInt16(Player.GetComponent<Transform>().position.z));
    }

    private void OnCollisionEnter(Collision collision)
    {
        yolTaşı();
        
        if (Convert.ToInt16(Player.GetComponent<Transform>().position.y)<0)
        {
            Debug.Log("Failed");
            SceneManager.LoadScene("Giriş");

        }
    }
    public void yolTaşı()
    {
        
        
        if (Player.GetComponent<Transform>().position.z - Mor.GetComponent<Transform>().position.z > 5.0f)
        {
            yMor = random.Next(0, 4);
            zMor += 90;
            Mor.GetComponent<Transform>().position = new Vector3(0, yMor, zMor);
            


        }
        if (Player.GetComponent<Transform>().position.z - Sarı.GetComponent<Transform>().position.z > 5.0f)
        {
            ySarı = random.Next(0,4);
            zSarı += 90;
            Sarı.GetComponent<Transform>().position = new Vector3(0, ySarı, zSarı);


        }
        if (Player.GetComponent<Transform>().position.z - Kırmızı.GetComponent<Transform>().position.z > 5.0f)
        {
            yKırmızı = random.Next(0,4);
            zKırmızı += 90;
            Kırmızı.GetComponent<Transform>().position = new Vector3(0, yKırmızı, zKırmızı);

        }
        if (Player.GetComponent<Transform>().position.z - Turuncu.GetComponent<Transform>().position.z > 5.0f)
        {
            yTuruncu = random.Next(4);
            zTuruncu += 90;
            Turuncu.GetComponent<Transform>().position = new Vector3(0, yTuruncu, zTuruncu);

        }
        if (Player.GetComponent<Transform>().position.z - Mavi.GetComponent<Transform>().position.z > 5.0f)
        {
            yMavi = random.Next(4);
            zMavi += 90;
            Mavi.GetComponent<Transform>().position = new Vector3(0, zMavi, zMavi);

        }
        if (Player.GetComponent<Transform>().position.z - Yeşil.GetComponent<Transform>().position.z > 5.0f)
        {
            yYeşil = random.Next(4);
            zYeşil += 90;
            Yeşil.GetComponent<Transform>().position = new Vector3(0, yYeşil, zYeşil);

        }
        if (Player.GetComponent<Transform>().position.z - yol1.GetComponent<Transform>().position.z > 5.0f)
        {
            Yyol1 = random.Next(4);
            Zyol1 += 90;
            yol1.GetComponent<Transform>().position = new Vector3(0, Yyol1, Zyol1);
        }
        if (Player.GetComponent<Transform>().position.z - yol2.GetComponent<Transform>().position.z > 5.0f)
        {
            Yyol2 = random.Next(4);
            Zyol2 += 90;
            yol2.GetComponent<Transform>().position = new Vector3(0, Yyol2, Zyol2);
        }
        if (Player.GetComponent<Transform>().position.z - yol3.GetComponent<Transform>().position.z > 5.0f)
        {
            Yyol3 = random.Next(4);
            Zyol3 += 90;
            yol3.GetComponent<Transform>().position = new Vector3(0, Yyol3, Zyol3);
        }
        if (Player.GetComponent<Transform>().position.z - yol4.GetComponent<Transform>().position.z > 5.0f)
        {
            Yyol4 = random.Next(4);
            Zyol4 += 90;
            yol4.GetComponent<Transform>().position = new Vector3(0, Yyol4, Zyol4);
        }
        if (Player.GetComponent<Transform>().position.z - yol5.GetComponent<Transform>().position.z > 5.0f)
        {
            Yyol5 = random.Next(4);
            Zyol5 += 90;
            yol5.GetComponent<Transform>().position = new Vector3(0, Yyol5, Zyol5);
        }
        if (Player.GetComponent<Transform>().position.z - yol6.GetComponent<Transform>().position.z > 5.0f)
        {
            Yyol6 = random.Next(4);
            Zyol6 += 90;
            yol6.GetComponent<Transform>().position = new Vector3(0, Yyol6, Zyol6);
        }
        if (Player.GetComponent<Transform>().position.z - yol7.GetComponent<Transform>().position.z > 5.0f)
        {
            Yyol7 = random.Next(4);
            Zyol7 += 90;
            yol7.GetComponent<Transform>().position = new Vector3(0, Yyol7, Zyol7);
        }
        if (Player.GetComponent<Transform>().position.z - yol8.GetComponent<Transform>().position.z > 5.0f)
        {
            Yyol8 = random.Next(4);
            Zyol8 += 90;
            yol8.GetComponent<Transform>().position = new Vector3(0, Yyol8, Zyol8);
        }
        if (Player.GetComponent<Transform>().position.z - yol9.GetComponent<Transform>().position.z > 5.0f)
        {
            Yyol9 = random.Next(4);
            Zyol9 += 90;
            yol9.GetComponent<Transform>().position = new Vector3(0, Yyol9, Zyol9);
        }
        if (Player.GetComponent<Transform>().position.z - yol10.GetComponent<Transform>().position.z > 5.0f)
        {
            Yyol10 = random.Next(4);
            Zyol10 += 90;
            yol10.GetComponent<Transform>().position = new Vector3(0, Yyol10, Zyol10);
        }
        if (Player.GetComponent<Transform>().position.z - yol11.GetComponent<Transform>().position.z > 5.0f)
        {
            Yyol11 = random.Next(4);
            Zyol11 += 90;
            yol11.GetComponent<Transform>().position = new Vector3(0, Yyol11, Zyol11);
        }
        if (Player.GetComponent<Transform>().position.z - yol12.GetComponent<Transform>().position.z > 5.0f)
        {
            Yyol12 = random.Next(4);
            Zyol12 += 90;
            yol12.GetComponent<Transform>().position = new Vector3(0, Yyol12, Zyol12);
        }
        //Debug.Log(Math.Abs(Player.GetComponent<Transform>().position.z));

    }
}
