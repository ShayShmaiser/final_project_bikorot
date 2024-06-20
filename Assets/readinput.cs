using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class readinput : MonoBehaviour
{
    public string input;


    

    [SerializeField] private GameObject Y;
    [SerializeField] private GameObject A;
    [SerializeField] private GameObject Junct29l;
    [SerializeField] private GameObject AtoY;
    [SerializeField] private GameObject Yto85;
    [SerializeField] private GameObject Hto85;
    [SerializeField] private GameObject H;
    [SerializeField] private GameObject Junct29LJuliet;

    [SerializeField] private GameObject ACrossPos;
    [SerializeField] private GameObject YCrossPos;


    [SerializeField] private GameObject Junct29LPos;
    [SerializeField] private GameObject Juliet29LPos;
    [SerializeField] private GameObject HCrossPos;


    [SerializeField] private GameObject Junct29R;
    [SerializeField] private GameObject JunctToWest;
    [SerializeField] private GameObject JunctToEast;
    [SerializeField] private GameObject Junct29RJuliet;

    [SerializeField] private GameObject Junct29RPos;
    [SerializeField] private GameObject Juliet29RPos;

    [SerializeField] private GameObject MJ;
    [SerializeField] private GameObject MJToLima;
    [SerializeField] private GameObject LimaCross;
    [SerializeField] private GameObject LimaTo29L;
    [SerializeField] private GameObject Junct2329L;
    [SerializeField] private GameObject Junct2329R;
    [SerializeField] private GameObject KTo29R;

    [SerializeField] private GameObject MJCrossPos;
    [SerializeField] private GameObject LimaCrossPos;
    [SerializeField] private GameObject ConnectLeftPos;
    [SerializeField] private GameObject ConnectRightPos;

    [SerializeField] private GameObject empty;
    [SerializeField] private GameObject aEmpty;
    [SerializeField] private GameObject hEmpty;
    [SerializeField] private GameObject junct29lEmpty;
    [SerializeField] private GameObject juliet29lEmpty;
    [SerializeField] private GameObject junct29rEmpty;
    [SerializeField] private GameObject juliet29rEmpty;
    [SerializeField] private GameObject MJempty;
    [SerializeField] private GameObject limaEmpty;
    [SerializeField] private GameObject ConnectLeftEmpty;
    [SerializeField] private GameObject ConnectRightEmpty;


    [SerializeField] private GameObject rwy29Lactive;
    [SerializeField] private GameObject rwy29Ractive;
    [SerializeField] private GameObject rwy23active;

    [SerializeField] private GameObject Echo;
    [SerializeField] private GameObject Fox;
    [SerializeField] private GameObject Sierra1;
    [SerializeField] private GameObject Sierra2;
    [SerializeField] private GameObject Sierra3;
    [SerializeField] private GameObject Juliet1;
    [SerializeField] private GameObject Juliet2;
    [SerializeField] private GameObject India;
    [SerializeField] private GameObject Yankee;
    [SerializeField] private GameObject Yankee1;
    [SerializeField] private GameObject Papa;


    [SerializeField] private GameObject ReadbackE;
    public void readbackE()
    {
        ReadbackE.SetActive(false);
    }
    [SerializeField] private GameObject ReadbackF;
    public void readbackF()
    {
        ReadbackF.SetActive(false);
    }
    [SerializeField] private GameObject ReadbackS;
    public void readbackS()
    {
        ReadbackS.SetActive(false);
    }
    [SerializeField] private GameObject ReadbackY;
    public void readbackY()
    {
        ReadbackY.SetActive(false);
    }
    [SerializeField] private GameObject ReadbackP;
    public void readbackP()
    {
        ReadbackP.SetActive(false);
    }
    [SerializeField] private GameObject ReadbackJ;
    public void readbackJ()
    {
        ReadbackJ.SetActive(false);
    }
    [SerializeField] private GameObject ReadbackI;
    public void readbackI()
    {
        ReadbackI.SetActive(false);
    }
    [SerializeField] private GameObject Readback29l;
    [SerializeField] private GameObject Readback29r;
    public void readback29R()
    {
        Readback29r.SetActive(false);
    }
    [SerializeField] private GameObject Readback23;
    public void readback23()
    {
        Readback23.SetActive(false);
    }
    [SerializeField] private GameObject Readback29l2;
    public void readback29L2()
    {
        Readback29l2.SetActive(false);
    }
    [SerializeField] private GameObject Readback29r2;
    public void readback29R2()
    {
        Readback29r2.SetActive(false);
    }
    [SerializeField] private GameObject Readback232;
    public void readback232()
    {
        Readback232.SetActive(false);
    }
    [SerializeField] private GameObject ReadbackTw;
    public void readbackTw()
    {
        ReadbackTw.SetActive(false);
    }

    [SerializeField] private GameObject VacateE;
    public void vacateE()
    {
        VacateE.SetActive(false);
    }
    [SerializeField] private GameObject VacateF;
    public void vacateF()
    {
        VacateF.SetActive(false);
    }
    [SerializeField] private GameObject VacateS;
    public void vacateS()
    {
        VacateS.SetActive(false);
    }
    [SerializeField] private GameObject VacateY;
    public void vacateY()
    {
        VacateY.SetActive(false);
    }
    [SerializeField] private GameObject VacateP;
    public void vacateP()
    {
        VacateP.SetActive(false);
    }
    [SerializeField] private GameObject VacateJ;
    public void vacateJ()
    {
        VacateJ.SetActive(false);
    }
    [SerializeField] private GameObject VacateI;
    public void vacateI()
    {
        VacateI.SetActive(false);
    }
    [SerializeField] private GameObject Vacate29l;
    public void vacate29L()
    {
        Vacate29l.SetActive(false);
    }
    [SerializeField] private GameObject Vacate29r;
    public void vacate29R()
    {
        Vacate29r.SetActive(false);
    }

    [SerializeField] private GameObject Vacate23;
    public void vacate23()
    {
        Vacate23.SetActive(false);
    }
    [SerializeField] private GameObject VacateTw;
    public void vacateTW()
    {
        VacateTw.SetActive(false);
    }




    private void FixedUpdate()
    {
        Answer();
    }
    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);

    }
    public void Readback29L()
    {
        Readback29l.SetActive(false);
    }

    public void Answer()
    {
        if ((input == "הלל מאבק1 רשות לעלות 29 שמאל") || (input == "הלל אבק1 רשות לעלות 29 שמאל") || (input == "הלל מאבק1 רשות לעלות על 29 שמאל") || (input == "הלל אבק1 רשות לעלות על 29 שמאל") || (input == "הלל אבק1 רשות לעלות 29L") || (input == "הלל מאבק1 רשות לעלות 29L") || (input == "הלל אבק1 רשות לעלות על 29L") || (input == "הלל מאבק1 רשות לעלות על 29L") ||
            (input == "הלל מאבק 1 רשות לעלות 29 שמאל") || (input == "הלל אבק 1 רשות לעלות 29 שמאל") || (input == "הלל מאבק 1 רשות לעלות על 29 שמאל") || (input == "הלל אבק 1 רשות לעלות על 29 שמאל") || (input == "הלל אבק 1 רשות לעלות 29L") || (input == "הלל מאבק 1 רשות לעלות 29L") || (input == "הלל אבק 1 רשות לעלות על 29L") || (input == "הלל מאבק 1 רשות לעלות על 29L"))
        {
            H.SetActive(false);
            A.SetActive(false);
            Y.SetActive(false);
            AtoY.SetActive(false);
            Yto85.SetActive(false);
            Hto85.SetActive(false);
            Junct29l.SetActive(false);
            Junct29LJuliet.SetActive(false);
            rwy29Lactive.SetActive(false);
            Readback29l.SetActive(true);
            Invoke("Readback29L", 3);

        }



        if ((input == "29 שמאל פנוי מאבק1") || (input == "29L פנוי מאבק1") || (input == "29 שמאל פנוי מאבק 1") || (input == "29L פנוי מאבק 1"))
        {
            H.SetActive(true);
            A.SetActive(true);
            Y.SetActive(true);
            AtoY.SetActive(true);
            Yto85.SetActive(true);
            Hto85.SetActive(true);
            Junct29l.SetActive(true);
            Junct29LJuliet.SetActive(true);
            empty.SetActive(false);
            aEmpty.SetActive(false);
            hEmpty.SetActive(false);
            junct29lEmpty.SetActive(false);
            juliet29lEmpty.SetActive(false);
            rwy29Lactive.SetActive(true);
            Vacate29l.SetActive(true);
            Invoke("vacate29L", 3);



        }

        if ((input == "הלל מאבק1 רשות לעלות 29 ימין") || (input == "הלל אבק1 רשות לעלות 29 ימין") || (input == "הלל מאבק1 רשות לעלות על 29 ימין") || (input == "הלל אבק1 רשות לעלות על 29 ימין") || (input == "הלל אבק1 רשות לעלות 29R") || (input == "הלל מאבק1 רשות לעלות 29R") || (input == "הלל אבק1 רשות לעלות על 29R") || (input == "הלל מאבק1 רשות לעלות על 29R") ||
            (input == "הלל מאבק 1 רשות לעלות 29 ימין") || (input == "הלל אבק 1 רשות לעלות 29 ימין") || (input == "הלל מאבק 1 רשות לעלות על 29 ימין") || (input == "הלל אבק 1 רשות לעלות על 29 ימין") || (input == "הלל אבק 1 רשות לעלות 29R") || (input == "הלל מאבק 1 רשות לעלות 29R") || (input == "הלל אבק 1 רשות לעלות על 29R") || (input == "הלל מאבק 1 רשות לעלות על 29R"))
        {

            JunctToEast.SetActive(false);
            JunctToWest.SetActive(false);
            Junct29R.SetActive(false);
            Junct29RJuliet.SetActive(false);
            rwy29Ractive.SetActive(false);
            Readback29r.SetActive(true);
            Invoke("readback29R", 3);

        }

        if ((input == "29 ימין פנוי מאבק1") || (input == "29R פנוי מאבק1") || (input == "29 ימין פנוי מאבק 1") || (input == "29R פנוי מאבק 1"))
        {
            JunctToEast.SetActive(true);
            JunctToWest.SetActive(true);
            Junct29R.SetActive(true);
            Junct29RJuliet.SetActive(true);
            junct29rEmpty.SetActive(false);
            juliet29rEmpty.SetActive(false);
            rwy29Ractive.SetActive(true);
            Vacate29r.SetActive(true);
            Invoke("vacate29R", 3);

        }

        if ((input == "הלל מאבק1 רשות לעלות 23") || (input == "הלל אבק1 רשות לעלות 23") || (input == "הלל מאבק1 רשות לעלות על 23") || (input == "הלל אבק1 רשות לעלות על 23") || (input == "הלל אבק1 רשות לעלות 05") || (input == "הלל מאבק1 רשות לעלות 05") || (input == "הלל אבק1 רשות לעלות על 05") || (input == "הלל מאבק1 רשות לעלות על 05") ||
            (input == "הלל מאבק 1 רשות לעלות 23") || (input == "הלל אבק 1 רשות לעלות 23") || (input == "הלל מאבק 1 רשות לעלות על 23") || (input == "הלל אבק 1 רשות לעלות על 23") || (input == "הלל אבק 1 רשות לעלות 05") || (input == "הלל מאבק 1 רשות לעלות 05") || (input == "הלל אבק 1 רשות לעלות על 05") || (input == "הלל מאבק 1 רשות לעלות על 05"))
        {
            MJ.SetActive(false);
            MJToLima.SetActive(false);
            LimaCross.SetActive(false);
            LimaTo29L.SetActive(false);
            Junct2329L.SetActive(false);
            Junct2329R.SetActive(false);
            KTo29R.SetActive(false);
            rwy23active.SetActive(false);
            Readback23.SetActive(true);
            Invoke("readback23", 3);


        }

        if ((input == "23 פנוי מאבק1") || (input == "05 פנוי מאבק1") || (input == "23 פנוי מאבק 1") || (input == "05 פנוי מאבק 1"))
        {
            MJ.SetActive(true);
            MJToLima.SetActive(true);
            LimaCross.SetActive(true);
            LimaTo29L.SetActive(true);
            Junct2329L.SetActive(true);
            Junct2329R.SetActive(true);
            KTo29R.SetActive(true);
            MJempty.SetActive(false);
            limaEmpty.SetActive(false);
            ConnectLeftEmpty.SetActive(false);
            ConnectRightEmpty.SetActive(false);
            rwy23active.SetActive(true);
            Vacate23.SetActive(true);
            Invoke("vacate23", 3);


        }
        if ((input == "הלל מאבק1 רשות לחצות 29 שמאל בY") || (input == "הלל מאבק1 רשות לחצות 29 שמאל על Y") || (input == "הלל אבק1 רשות לחצות 29 שמאל בY") || (input == "הלל אבק1 רשות לחצות 29 שמאל על Y") || (input == "הלל מאבק1 רשות לחצות 29L בY") || (input == "הלל אבק1 רשות לחצות 29L עלY") ||
            (input == "הלל מאבק 1 רשות לחצות 29 שמאל בY") || (input == "הלל מאבק 1 רשות לחצות 29 שמאל על Y") || (input == "הלל אבק 1 רשות לחצות 29 שמאל בY") || (input == "הלל אבק 1 רשות לחצות 29 שמאל על Y") || (input == "הלל מאבק 1 רשות לחצות 29L בY") || (input == "הלל אבק 1 רשות לחצות 29L עלY") || (input == "הלל מאבק1 רשות לחצות 29 שמאל מY") || (input == "הלל מאבק 1 רשות לחצות 29 שמאל מY"))
        {
            Y.SetActive(false);
            YCrossPos.SetActive(true);
            Readback29l2.SetActive(true);
            Invoke("readback29L2", 3);

        }
        if (empty.activeSelf)
        {
            Y.SetActive(true);
            YCrossPos.SetActive(false);
        }

        if ((input == "הלל מאבק1 רשות לחצות 29 שמאל בA") || (input == "הלל מאבק1 רשות לחצות 29 שמאל על A") || (input == "הלל מאבק 1 רשות לחצות 29 שמאל בA") || (input == "הלל מאבק 1 רשות לחצות 29 שמאל על A") || (input == "הלל מאבק1רשות לחצות 29 שמאל מA") || (input == "הלל מאבק 1 רשות לחצות 29 שמאל מA"))
        {
            A.SetActive(false);
            ACrossPos.SetActive(true);
            Readback29l2.SetActive(true);
            Invoke("readback29L2", 3);

        }
        if (aEmpty.activeSelf)
        {
            A.SetActive(true);
            ACrossPos.SetActive(false);
        }
        if ((input == "הלל מאבק1 רשות לחצות 29 שמאל בH") || (input == "הלל מאבק1 רשות לחצות 29 שמאל על H") || (input == "הלל מאבק 1 רשות לחצות 29 שמאל בH") || (input == "הלל מאבק 1 רשות לחצות 29 שמאל על H") || (input == "הלל מאבק1 רשות לחצות 29 שמאל מH") || (input == "הלל מאבק 1 רשות לחצות 29 שמאל מH"))
        {
            H.SetActive(false);
            HCrossPos.SetActive(true);
            Readback29l2.SetActive(true);
            Invoke("readback29L2", 3);

        }
        if (hEmpty.activeSelf)
        {
            H.SetActive(true);
            HCrossPos.SetActive(false);
        }
        if (input == "הלל מאבק1 רשות לחצות 29 שמאל על 23" || (input == "הלל מאבק 1 רשות לחצות 29 שמאל על 23") || (input == "הלל מאבק1 רשות לחצות 29 שמאל ב23") || (input == "הלל מאבק 1 רשות לחצות 29 שמאל על 23"))
        {
            Junct29l.SetActive(false);
            Junct29LPos.SetActive(true);
            Readback29l2.SetActive(true);
            Invoke("readback29L2", 3);

        }
        if (junct29lEmpty.activeSelf)
        {
            Junct29l.SetActive(true);
            Junct29LPos.SetActive(false);
        }
        if (input == "הלל מאבק1 רשות לחצות 29 שמאל על J" || (input == "הלל מאבק 1 רשות לחצות 29 שמאל על J") || (input == "הלל מאבק1 רשות לחצות 29 שמאל בJ") || (input == "הלל מאבק 1 רשות לחצות 29 שמאל על J"))
        {
            Junct29LJuliet.SetActive(false);
            Juliet29LPos.SetActive(true);
            Readback29l2.SetActive(true);
            Invoke("readback29L2", 3);

        }
        if (juliet29lEmpty.activeSelf)
        {
            Junct29LJuliet.SetActive(true);
            Juliet29LPos.SetActive(false);
        }
        if (input == "הלל מאבק1 רשות לחצות 29 ימין על 23" || (input == "הלל מאבק 1 רשות לחצות 29 ימין על 23") || (input == "הלל מאבק1 רשות לחצות 29 ימין ב23") || (input == "הלל מאבק 1 רשות לחצות 29 ימין על 23"))
        {
            Junct29R.SetActive(false);
            Junct29RPos.SetActive(true);
            Readback29r2.SetActive(true);
            Invoke("readback29R2", 3);

        }
        if (junct29rEmpty.activeSelf)
        {
            Junct29R.SetActive(true);
            Junct29RPos.SetActive(false);
        }
        if (input == "הלל מאבק1 רשות לחצות 29 ימין על J" || (input == "הלל מאבק 1 רשות לחצות 29 ימין על J") || (input == "הלל מאבק1 רשות לחצות 29 ימין בJ") || (input == "הלל מאבק 1 רשות לחצות 29 ימין על J"))
        {
            Junct29RJuliet.SetActive(false);
            Juliet29LPos.SetActive(true);
            Readback29r2.SetActive(true);
            Invoke("readback29R2", 3);

        }
        if (juliet29rEmpty.activeSelf)
        {
            Junct29RJuliet.SetActive(true);
            Juliet29RPos.SetActive(false);
        }
        if ((input == "הלל מאבק1 רשות לחצות 23 בM") || (input == "הלל מאבק1 רשות לחצות 23 על M") || (input == "הלל מאבק 1 רשות לחצות 23 על M") || (input == "הלל מאבק 1 רשות לחצות 23 בM") || (input == "הלל מאבק1 רשות לחצות 23 מM") || (input == "הלל מאבק 1 רשות לחצות 23 מM"))
        {
            MJ.SetActive(false);
            MJCrossPos.SetActive(true);
            Readback232.SetActive(true);
            Invoke("readback232", 3);

        }
        if (MJempty.activeSelf)
        {
            MJ.SetActive(true);
            MJCrossPos.SetActive(false);
        }
        if ((input == "הלל מאבק1 רשות לחצות 23 בI") || (input == "הלל מאבק1 רשות לחצות 23 על I") || (input == "הלל מאבק 1 רשות לחצות 23 על I") || (input == "הלל מאבק 1 רשות לחצות 23 בI") || (input == "הלל מאבק1 רשות לחצות 23 מE") || (input == "הלל מאבק 1 רשות לחצות 23 מE"))
        {
            LimaCross.SetActive(false);
            LimaCrossPos.SetActive(true);
            Readback232.SetActive(true);
            Invoke("readback232", 3);

        }
        if (limaEmpty.activeSelf)
        {
            LimaCross.SetActive(true);
            LimaCrossPos.SetActive(false);
        }
        if ((input == "הלל מאבק1 רשות לחצות 23 על 29 שמאל") || (input == "הלל מאבק1 רשות לחצות 23 מ29 שמאל") || (input == "הלל מאבק 1 רשות לחצות 23 על 29 שמאל") || (input == "הלל מאבק 1 רשות לחצות 23 מ29 שמאל"))
        {
            Junct2329L.SetActive(false);
            ConnectLeftPos.SetActive(true);
            Readback232.SetActive(true);
            Invoke("readback232", 3);


        }
        if (ConnectLeftEmpty.activeSelf)
        {
            Junct2329L.SetActive(true);
            ConnectLeftPos.SetActive(false);

        }
        if ((input == "הלל מאבק1 רשות לחצות 23 על 29 ימין") || (input == "הלל מאבק1 רשות לחצות 23 מ29 ימין") || (input == "הלל מאבק 1 רשות לחצות 23 על 29 ימין") || (input == "הלל מאבק 1 רשות לחצות 23 מ29 ימין"))
        {
            Junct2329R.SetActive(false);
            ConnectRightPos.SetActive(true);
            Readback232.SetActive(true);
            Invoke("readback232", 3);


        }
        if (ConnectRightEmpty.activeSelf)
        {
            Junct2329R.SetActive(true);
            ConnectRightPos.SetActive(false);

        }
        if ((input == "הלל מאבק1 רשות לעלות E") || (input == "הלל מאבק1 רשות לעלות על E") || (input == "הלל מאבק 1 רשות לעלות E") || (input == "הלל מאבק 1 רשות לעלות על E"))
        {
            Echo.SetActive(false);
            ReadbackE.SetActive(true);
            Invoke("readbackE", 3);
        }
        if ((input == "E פנוי מאבק1") || (input == "E פנוי מאבק 1"))
        {
            Echo.SetActive(true);
            VacateE.SetActive(true);
            Invoke("vacateE", 3);

        }
        if ((input == "הלל מאבק1 רשות לעלות F") || (input == "הלל מאבק1 רשות לעלות על F") || (input == "הלל מאבק 1 רשות לעלות F") || (input == "הלל מאבק 1 רשות לעלות על F"))
        {
            Fox.SetActive(false);
            ReadbackF.SetActive(true);
            Invoke("readbackF", 3);
        }
        if ((input == "F פנוי מאבק1") || (input == "F פנוי מאבק 1"))
        {
            Fox.SetActive(true);
            VacateF.SetActive(true);
            Invoke("vacateF", 3);
        }

        if ((input == "הלל מאבק1 רשות לעלות S") || (input == "הלל מאבק1 רשות לעלות על S") || (input == "הלל מאבק 1 רשות לעלות S") || (input == "הלל מאבק 1 רשות לעלות על S"))
        {
            Sierra1.SetActive(false);
            Sierra2.SetActive(false);
            Sierra3.SetActive(false);
            ReadbackS.SetActive(true);
            Invoke("readbackS", 3);
        }
        if ((input == "S פנוי מאבק1") || (input == "S פנוי מאבק 1"))
        {
            Sierra1.SetActive(true);
            Sierra2.SetActive(true);
            Sierra3.SetActive(true);
            VacateS.SetActive(true);
            Invoke("vacateS", 3);
        }
        if ((input == "הלל מאבק1 רשות לעלות P") || (input == "הלל מאבק1 רשות לעלות על P") || (input == "הלל מאבק 1 רשות לעלות P") || (input == "הלל מאבק 1 רשות לעלות על P"))
        {
            Papa.SetActive(false);
            ReadbackP.SetActive(true);
            Invoke("readbackP", 3);
        }
        if ((input == "P פנוי מאבק1") || (input == "P פנוי מאבק 1"))
        {
            Papa.SetActive(true);
            VacateP.SetActive(true);
            Invoke("vacateP", 3);
        }
        if ((input == "הלל מאבק1 רשות לעלות J") || (input == "הלל מאבק1 רשות לעלות על J") || (input == "הלל מאבק 1 רשות לעלות J") || (input == "הלל מאבק 1 רשות לעלות על J"))
        {
            Juliet1.SetActive(false);
            Juliet2.SetActive(false);
            ReadbackJ.SetActive(true);
            Invoke("readbackJ", 3);
        }
        if ((input == "J פנוי מאבק1") || (input == "J פנוי מאבק 1"))
        {
            Juliet1.SetActive(true);
            Juliet2.SetActive(true);
            VacateJ.SetActive(true);
            Invoke("vacateJ", 3);
        }
        if ((input == "הלל מאבק1 רשות לעלות Y") || (input == "הלל מאבק1 רשות לעלות על Y") || (input == "הלל מאבק 1 רשות לעלות Y") || (input == "הלל מאבק 1 רשות לעלות על Y"))
        {
            Yankee.SetActive(false);
            Yankee1.SetActive(false);
            ReadbackY.SetActive(true);
            Invoke("readbackY", 3);
        }
        if ((input == "Y פנוי מאבק1") || (input == "Y פנוי מאבק 1"))
        {
            Yankee.SetActive(true);
            Yankee1.SetActive(true);
            VacateY.SetActive(true);
            Invoke("vacateY", 3);
        }
        if ((input == "הלל מאבק1 רשות לעלות I") || (input == "הלל מאבק1 רשות לעלות על I") || (input == "הלל מאבק 1 רשות לעלות I") || (input == "הלל מאבק 1 רשות לעלות על I"))
        {
            India.SetActive(false);
            ReadbackI.SetActive(true);
            Invoke("readbackI", 3);
        }
        if ((input == "I פנוי מאבק1") || (input == "I פנוי מאבק 1"))
        {
            India.SetActive(true);
            VacateI.SetActive(true);
            Invoke("vacateI", 3);
        }
        if ((input == "הלל מאבק1 רשות לעלות כל מסלולי ההסעה") || (input == "הלל מאבק 1 רשות לעלות כל מסלולי ההסעה") || (input == "הלל מאבק1 רשות לעלות על כל מסלולי ההסעה") || (input == "הלל מאבק 1 רשות לעלות על כל מסלולי ההסעה"))
        {
            Echo.SetActive(false);
            India.SetActive(false);
            Fox.SetActive(false);
            Sierra1.SetActive(false);
            Sierra2.SetActive(false);
            Sierra3.SetActive(false);
            Yankee.SetActive(false);
            Yankee1.SetActive(false);
            Juliet1.SetActive(false);
            Juliet2.SetActive(false);
            Papa.SetActive(false);
            ReadbackTw.SetActive(true);
            Invoke("readbackTw", 3);
        }
        if ((input == "כל מסלולי ההסעה פנויים מאבק1") || (input == "כל מסלולי ההסעה פנויים מאבק 1") || (input == "כל מסלולי ההסעה פנוים מאבק1") || (input == "כל מסלולי ההסעה פנוים מאבק 1"))
        {
            Echo.SetActive(true);
            India.SetActive(true);
            Fox.SetActive(true);
            Sierra1.SetActive(true);
            Sierra2.SetActive(true);
            Sierra3.SetActive(true);
            Yankee.SetActive(true);
            Yankee1.SetActive(true);
            Juliet1.SetActive(true);
            Juliet2.SetActive(true);
            Papa.SetActive(true);
            VacateTw.SetActive(true);
            Invoke("readbackTW", 3);
        }





    }
}