using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gem : MonoBehaviour
{

	public GameObject sphere; //子オブジェクトのSphereオブジェクト
	
	public string ballName = ""; //Material検索用
								 //検索対象のMaterial名

	string[] ballMats = { "FireBall", "WaterBall", "WindBall", "LightBall", "PinkBall", "DarkBall" };

	void Start()
	{
		CreateGem();
	}

	public void CreateGem()
	{
		//マテリアルの名前をランダムで選択
		ballName = ballMats[Random.Range(0, ballMats.Length)];
		Debug.Log(ballName);
		//Resources > Materials > マテリアル(ランダム)を選択
		Sprite ballMat = Resources.Load<Sprite>("Materials/" + ballName) as Sprite;
		Debug.Log("ballMat" + ballMat);
		//Sphereのマテリアルをランダムで選択したマテリアルに変更
		this.GetComponent<Image>().sprite = ballMat;
	}
}
