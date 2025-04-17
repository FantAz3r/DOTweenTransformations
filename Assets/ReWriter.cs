using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ReWriter : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Text _text;

    private WaitForSeconds _sleep;

    private void Start()
    {
        StartCoroutine(ReWrite());
    }

    private IEnumerator ReWrite()
    {
        while (enabled)
        {
            yield return _text.DOText("����� ������", _duration).WaitForCompletion();
            yield return _text.DOText("����� ��������", _duration).SetRelative().WaitForCompletion();
            yield return _text.DOText("����� �������", _duration, true, ScrambleMode.All).WaitForCompletion();
        }
    }
}
