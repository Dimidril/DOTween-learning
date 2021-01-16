using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    void Start()
    {
        transform.DOMove(new Vector3(3, 5, 1), 3).From().SetLoops(-1, LoopType.Yoyo);
    }
}