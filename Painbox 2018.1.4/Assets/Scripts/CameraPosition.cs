using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraPosition : MonoBehaviour {

    public float positionUnits;
    public float rotationUnits;
    public Button leftButton, rightButton, forwardButton, backButton, upButton, downButton, rotateUp, rotateDown;
    public Text xText, yText, zText, rotateText;

	void Start () {
        Button left = leftButton.GetComponent<Button>();
        Button right = rightButton.GetComponent<Button>();
        Button up = upButton.GetComponent<Button>();
        Button down = downButton.GetComponent<Button>();
        Button forward = forwardButton.GetComponent<Button>();
        Button back = backButton.GetComponent<Button>();
        Button upR = rotateUp.GetComponent<Button>();
        Button downR = rotateDown.GetComponent<Button>();

        left.onClick.AddListener(leftClick);
        right.onClick.AddListener(rightClick);
        up.onClick.AddListener(upClick);
        down.onClick.AddListener(downClick);
        forward.onClick.AddListener(forwardClick);
        back.onClick.AddListener(backClick);
        upR.onClick.AddListener(rotateUpClick);
        downR.onClick.AddListener(rotateDownClick);

        xText.text = "X Pos:\n" + transform.position.x;
        yText.text = "Y Pos:\n" + transform.position.y;
        zText.text = "Z Pos:\n" + transform.position.z;
        rotateText.text = "Rotation:\n" + transform.eulerAngles.x;
    }


    void leftClick()
    {
        Vector3 initial = transform.position;
        initial.x -= positionUnits;
        transform.position = initial;

        xText.text = "X Pos:\n" + transform.position.x;
    }
    void rightClick()
    {
        Vector3 initial = transform.position;
        initial.x += positionUnits;
        transform.position = initial;

        xText.text = "X Pos:\n" + transform.position.x;
    }
    void upClick()
    {
        Vector3 initial = transform.position;
        initial.y += positionUnits;
        transform.position = initial;

        yText.text = "Y Pos:\n" + transform.position.y;
    }
    void downClick()
    {
        Vector3 initial = transform.position;
        initial.y -= positionUnits;
        transform.position = initial;

        yText.text = "Y Pos:\n" + transform.position.y;
    }
    void forwardClick()
    {
        Vector3 initial = transform.position;
        initial.z += positionUnits;
        transform.position = initial;

        zText.text = "Z Pos:\n" + transform.position.z;
    }
    void backClick()
    {
        Vector3 initial = transform.position;
        initial.z -= positionUnits;
        transform.position = initial;

        zText.text = "Z Pos:\n" + transform.position.z;
    }
    void rotateUpClick()
    {
        float xRotation = transform.eulerAngles.x;
        xRotation -= rotationUnits;
        transform.eulerAngles = new Vector3(xRotation, transform.eulerAngles.y, transform.eulerAngles.z);

        rotateText.text = "Rotation:\n" + transform.eulerAngles.x;
    }
    void rotateDownClick()
    {
        float xRotation = transform.eulerAngles.x;
        xRotation += rotationUnits;
        transform.eulerAngles = new Vector3(xRotation, transform.eulerAngles.y, transform.eulerAngles.z);

        rotateText.text = "Rotation:\n" + transform.eulerAngles.x;
    }
}
