using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosLogger : MonoBehaviour
{
    private GameObject arm1;
    private GameObject hand;
    private GameObject upbase;

    public Text rotText;
    public Text armRotText;
    public Text handRotText;
    public Text upbaseText;

    private float textLength = 400f;

    void Start()
    {
        hand = GameObject.Find("HEAD_ND");
        arm1 = GameObject.Find("ARM_1");
        upbase = GameObject.Find("UPBASE");
    }

    void Update()
    {
        double rot = transform.rotation.eulerAngles.y;
        if (rot > 180)
            rot -= 360;
        string rotString = "Base:" + rot.ToString("F2");
        rotText.text = rotString;
        rotText.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, textLength);

        double armRot = arm1.transform.rotation.eulerAngles.x;
        if (armRot > 180)
            armRot -= 360;
        string arm1RotString = "Arm:" + armRot.ToString("F2");
        armRotText.text = arm1RotString;
        armRotText.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, textLength);

        double handRot = hand.transform.rotation.eulerAngles.z;
        if (handRot > 180)
            handRot -= 360;
        string handRotString = "Hand:" + handRot.ToString("F2");
        handRotText.text = handRotString;
        handRotText.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, textLength);

        double upbaseRot = upbase.transform.rotation.eulerAngles.x;
        if (upbaseRot > 180)
            upbaseRot -= 360;
        string upbaseRotString = "Upbase:" + upbaseRot.ToString("F2");
        upbaseText.text = upbaseRotString;
        upbaseText.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, textLength);
    }
}
