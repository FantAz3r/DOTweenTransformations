using DG.Tweening;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Painter : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private float _duration;
    [SerializeField] private float _wait;

    private WaitForSeconds _delay;
    private void Start()
    {
        _delay = new WaitForSeconds(_wait);
        _renderer = GetComponent<Renderer>();
        StartCoroutine(ChangeColorRoutine());
    }

    private IEnumerator ChangeColorRoutine()
    {
        while (true)
        {
            Color randomColor = new Color(Random.value, Random.value, Random.value);
            _renderer.material.DOColor(randomColor, _duration);
            yield return _delay;
        }
    }
}
