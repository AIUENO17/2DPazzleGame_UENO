using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenAnimationManager : MonoBehaviour
{

    private Queue<List<AnimData>> animQueue = new Queue<List<AnimData>>();
    bool isTween;
    int tweenAnimationcount;
    int endAnimCount;


    private void Update()
    {
        if (isTween)
        {
            return;
        }
        if (animQueue.Count > 0)
        {
            endAnimCount = 0;
            isTween = true;

            var queue = animQueue.Dequeue();
            var queue = animQueue.Dequeue();
            tweenAnimationcount = queue.Count;
            foreach (var data in queue)
            {
                var tween = data.targetObject.AddComponent<MoveTween>();
                tween.DoTween(data.targetObject.transform.position, data.targetPosition, data.duration, () =>
                {
                    endAnimCount++;
                    if (tweenAnimationcount == endAnimCount)
                    {
                        isTween = false;
                    }
                });
            }
        }
    }

    public void AddListAnimData(List<AnimData> animData)
    {
        animQueue.Enqueue(animData);
    }
}


