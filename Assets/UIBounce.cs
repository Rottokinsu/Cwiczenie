using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIBounce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOScale(transform.localScale * 1.2f, 1.0f)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
