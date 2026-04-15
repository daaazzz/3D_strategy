using UnityEngine;
using DG.Tweening;

public static class SlideInOut
{
    public static void SlideIn(RectTransform rect, Vector2 target, float duration)
    {
        rect.DOAnchorPos(target, duration).SetEase(Ease.InQuad);
    }
    public static void SlideOut(RectTransform rect, Vector2 target, float duration)
    {
        rect.DOAnchorPos(target, duration).SetEase(Ease.OutQuad);
    }
}
