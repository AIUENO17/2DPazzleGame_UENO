using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ball : MonoBehaviour
{
    public bool deleteFlag;
    
    private Image thisImage;
    
    private RectTransform thisRectTransform;
    
    private BallGenarater kind;

    
    // 初期化処理
    private void Awake()
    {
        // アタッチされている各コンポーネントを取得
        thisImage = GetComponent<Image>();
        thisRectTransform = GetComponent<RectTransform>();

        // フラグを初期化
        deleteFlag = false;
    }

   
    // ピースの種類とそれに応じた色をセットする
    public void SetKind(BallGenarater pieceKind)
    {
        kind = pieceKind;
        SetColor();
    }

    // ピースの種類を返す
    public BallGenarater GetKind()
    {
        return kind;
    }

    // ピースのサイズをセットする
    public void SetSize(int size)
    {
        this.thisRectTransform.sizeDelta = Vector2.one * size;
    }

   
    // ピースの色を自身の種類の物に変える
    private void SetColor()
    {
        switch (kind)
        {
            case BallGenarater.FireBall:
                thisImage.color = Color.red;
                break;
            case BallGenarater.WaterBall:
                thisImage.color = Color.blue;
                break;
            case BallGenarater.WindBall:
                thisImage.color = Color.green;
                break;
            case BallGenarater.LightBall:
                thisImage.color = Color.yellow;
                break;
            case BallGenarater.DarkBall:
                thisImage.color = Color.black;
                break;
            case BallGenarater.PinkBall:
                thisImage.color = Color.magenta;
                break;
            default:
                break;
        }
    }
}