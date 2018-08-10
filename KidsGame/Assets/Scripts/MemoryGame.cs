using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryGame : MonoBehaviour {
    //Identifier Serialized field allows field to be editable in inspector
    [SerializeField] private GameObject CardBack;
    [SerializeField] private CardMatchController controller;
    

    //Method is called when the object is clicked
    public void OnMouseDown()
    {
        //Checks if the object is currently active
        if(CardBack.activeSelf && controller.canReveal)
        {
            //If the object is active set it false
            CardBack.SetActive(false);
            controller.CardRevealed(this);
            Debug.Log(this._id);
        }
    }
    private int _id;
    public int id
    {
        get { return _id; }
    }

    public void ChangeSprite(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;// This gets the sprite render component and changes the property of the sprite
    }

    public void Unreveal()
    {
        CardBack.SetActive(true);
    }

}
