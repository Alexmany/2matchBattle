using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int amountOfcells;
    public int amountIsSpawned;

    [Space]
    public GameObject cell_prefab;

    [Space]
    public Transform parentToCell;

    [Space]
    public Card[] cards;
    public List<Cell> _cells;

    int curr_card;

    void Start()
    {        
        SetupCells();
    }
   
    void SetupCells()
    {
        int r = Random.Range(0, cards.Length);

        if(cards[r].isUsed < 2 && curr_card != r)
        {
            cards[r].isUsed++;
            curr_card = r;
            InstantiateCell(cards[r]);            
        } 
        else
        {
            SetupCells();
        }
    }

    void InstantiateCell(Card newCard)
    {
        GameObject go = Instantiate(cell_prefab, parentToCell);

        Cell goCell = go.GetComponent<Cell>();

        goCell.icon = newCard.icon;
        goCell.id = newCard.id;
        goCell.gc = this;

        _cells.Add(goCell);

        amountIsSpawned++;

        if(amountIsSpawned < amountOfcells)
        {
            SetupCells();
        }
    }
}