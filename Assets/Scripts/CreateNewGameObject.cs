using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class CreateNewGameObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (var i in Enumerable.Range(0, 10))
        {
            var gb = new GameObject("character_" + i.ToString(), typeof(SpriteRenderer), typeof(Balance));
            var texture = new Texture2D(0, 0);
            var path = "Assets/Chara_Imgs/" + i.ToString() + ".png";
            var bytes = File.ReadAllBytes(path);
            texture.LoadImage(bytes);
            var rect = new Rect(0, 0, texture.width, texture.height);
            var sprite = Sprite.Create(texture, rect, Vector2.zero);
            var spriteRenderer = gb.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
