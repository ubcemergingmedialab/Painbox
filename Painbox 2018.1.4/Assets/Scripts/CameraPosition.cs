using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraPosition : MonoBehaviour {

    private float positionUnits;
    private float rotationUnits;
    public Button leftButton, rightButton, forwardButton, backButton, upButton, downButton, rotateUp, rotateDown;
    public Text xText, yText, zText, rotateText, posUnitText, rotUnitText;
    public Slider posControl, rotControl;

	void Start () {
        Button left = leftButton.GetComponent<Button>();
        Button right = rightButton.GetComponent<Button>();
        Button up = upButton.GetComponent<Button>();
        Button down = downButton.GetComponent<Button>();
        Button forward = forwardButton.GetComponent<Button>();
        Button back = backButton.GetComponent<Button>();
        Button upR = rotateUp.GetComponent<Button>();
        Button downR = rotateDown.GetComponent<Button>();
        Slider posUnit = posControl.GetComponent<Slider>();
        Slider rotUnit = rotControl.GetComponent<Slider>();

        rotationUnits = VariableController.rotationUnits;
        positionUnits = VariableController.positionUnits;

        posUnit.value = positionUnits;
        rotUnit.value = rotationUnits;

        posUnit.onValueChanged.AddListener(posDragged);
        rotUnit.onValueChanged.AddListener(rotDragged);

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
        rotUnitText.text = "Rotation Units: " + rotationUnits;
        posUnitText.text = "Position Units: " + positionUnits;
    }
    void posDragged(float args)
    {
        positionUnits = args;
        posUnitText.text = "Position Units: " + positionUnits;
        VariableController.positionUnits = positionUnits;
    }
    void rotDragged(float args)
    {
        rotationUnits = args;
        rotUnitText.text = "Rotation Units: " + rotationUnits;
        VariableController.rotationUnits = rotationUnits;
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
