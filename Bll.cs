using UnityEngine;
using System.Collections;

public class Bll : MonoBehaviour {
    
    //地板
	public GameObject Plane;
    // 颜色
	public Texture b1;
	public Texture b2;
	public Texture b3;
	public Texture b4;
    //位置
	public GameObject currentGameObject;
    //模型
	public GameObject p1;
	public GameObject p2;
	public GameObject p3;


    public GameObject a111;
      

	public void Sayhi()
	{
		Plane.GetComponent<Renderer> ().material.mainTexture = b4;
	}
	public void PlaneB1()
	{
		Sayhi ();
		Plane.GetComponent<Renderer> ().material.mainTexture = b1;
        Debug.Log("第一个颜色");
	}
	public void PlaneB2()
	{
		Sayhi ();
		Plane.GetComponent<Renderer> ().material.mainTexture = b2;
        Debug.Log("第二个颜色");
    }
	public void PlaneB3()
	{
		Sayhi ();
		Plane.GetComponent<Renderer> ().material.mainTexture = b3;
        Debug.Log("第三个颜色");
    }
	public void PlaneB4()
	{
		Sayhi ();
		Plane.GetComponent<Renderer> ().material.mainTexture = b4;
        Debug.Log("第四个颜色");
    }
	public void PlaneB5()
	{   
		GameObject temp = Instantiate (p1) as GameObject;
		temp.transform.position = currentGameObject.transform.position;
		temp.transform.rotation = currentGameObject.transform.rotation;
		GameObject.Destroy (currentGameObject);
		currentGameObject = temp;
        Debug.Log("第一个模型");
    }
	public void PlaneB6()
	{
		GameObject temp = Instantiate (p2) as GameObject;
		temp.transform.position = currentGameObject.transform.position;
		temp.transform.rotation = currentGameObject.transform.rotation;
		GameObject.Destroy (currentGameObject);
		currentGameObject = temp;
        Debug.Log("第二个模型");
    }
	public void PlaneB7()
	{
		GameObject temp = Instantiate (p3) as GameObject;
		temp.transform.position = currentGameObject.transform.position;
		temp.transform.rotation = currentGameObject.transform.rotation;
		GameObject.Destroy (currentGameObject);
		currentGameObject = temp;
        Debug.Log("第三个模型");
    }
}
