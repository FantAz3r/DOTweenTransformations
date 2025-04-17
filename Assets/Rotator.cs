using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Tween tween = transform.DORotate(_rotate, _duration).SetLoops(_repeats, _loopType);
        tween.SetEase(Ease.Linear);
    }
}
