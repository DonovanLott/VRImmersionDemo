using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{

    public GameObject lever;
    bool switchOn;

    void Start()
    {
        switchOn = false;
        lever = this.gameObject;
    }


    void Update()
    {
        if (lever.transform.rotation.eulerAngles.x > 60f && lever.transform.rotation.eulerAngles.x < 180f && switchOn == false)
        {
            GenerateSwords();
            switchOn = true;
        }
    }

    void GenerateSwords()
    {
        GameObject correctSword = Instantiate(Resources.Load("CorrectSword", typeof(GameObject))) as GameObject;
        GameObject antiGravitySword = Instantiate(Resources.Load("AntiGravitySword", typeof(GameObject))) as GameObject;
        GameObject instantaneousSword = Instantiate(Resources.Load("InstantaneousSword", typeof(GameObject))) as GameObject;
        GameObject kinematicSword = Instantiate(Resources.Load("KinematicSword", typeof(GameObject))) as GameObject;
        GameObject lightVTSword = Instantiate(Resources.Load("LightVTSword", typeof(GameObject))) as GameObject;
        GameObject notGrabbableSword = Instantiate(Resources.Load("NotGrabbableSword", typeof(GameObject))) as GameObject;
        GameObject simpleSword = Instantiate(Resources.Load("SimpleSword", typeof(GameObject))) as GameObject;
        GameObject wrongAttachSword = Instantiate(Resources.Load("WrongAttachSword", typeof(GameObject))) as GameObject;
        GameObject demoTable = Instantiate(Resources.Load("DemoTable", typeof(GameObject))) as GameObject;
    }
}