using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    public GameObject left,right, up, down;

    Vector3 _leftMostScreenPoint, _rightMostScreenPoint, _upMostScreenPoint, _downMostScreenPoint;
    Vector3 leftMostWorldPoint, rightMostWorldPoint, upMostWorldPoint, downMostWorldPoint;

    private void Awake()
    {
        _leftMostScreenPoint = new Vector3(0, Screen.height / 2, 0);
        _rightMostScreenPoint = new Vector3(Screen.width, Screen.height / 2, 0);
        _upMostScreenPoint = new Vector3(Screen.width / 2, 0, 0);
        _downMostScreenPoint = new Vector3(Screen.width / 2, Screen.height, 0);

        leftMostWorldPoint = Camera.main.ScreenToWorldPoint(_leftMostScreenPoint);
        rightMostWorldPoint = Camera.main.ScreenToWorldPoint(_rightMostScreenPoint);
        upMostWorldPoint = Camera.main.ScreenToWorldPoint(_upMostScreenPoint);
        downMostWorldPoint = Camera.main.ScreenToWorldPoint(_downMostScreenPoint);

        left.transform.position = leftMostWorldPoint;
        right.transform.position = rightMostWorldPoint;
        up.transform.position = upMostWorldPoint;
        down.transform.position = downMostWorldPoint;
    }
}
