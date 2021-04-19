using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
	//int型の変数mpを宣言し、53で初期化してください
	private int mp = 53;
	
	//mpを消費して魔法攻撃をするMagic関数を作ってください
	//Magic関数内でmpを5以上の場合は5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
	public void Magic()
	{
		if(mp >= 5)
		{
			mp = mp - 5;
			Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
		}
		else
		{
			Debug.Log("MPが足りないため魔法が使えない。");
		}
	}	
}

public class Test : MonoBehaviour
{
	void Start()
	{
		//要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
		int[] array = {77,97,27,83,93};

		//for文を使い、配列の各要素の値を順番に表示してください
		for(int i = 0; i < 5; i++)
		{
			Debug.Log(array [i]);
		}

		//for文を使い、配列の各要素の値を逆順に表示してください
		for(int i = 4; i >= 0; i--)
		{
			Debug.Log(array [i]);
		}
		
		//Magic関数を呼び出して、魔法を使ってください
		for(int i = 0; i <= 10; i++)
		{
			Boss lastboss = new Boss();
			lastboss.Magic();
		}
		Debug.Log("MPが足りないため魔法が使えない。");
	}


    // Update is called once per frame
    void Update()
    {
        
    }
}