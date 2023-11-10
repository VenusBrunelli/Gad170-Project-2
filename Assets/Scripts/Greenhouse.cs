using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greenhouse : MonoBehaviour
{
    public GameObject Plant;
    public List<Flower> Plants = new List<Flower>();
    public Flower flower;
    // Start is called before the first frame update
    void Start()
    {
        AddNewPlant();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            flower.RemovePlant();
            Debug.Log("Plant Removed");
        }
    }
    public void CreateNewPlant()
    { Plant = Instantiate(Plant); }
    public void AddNewPlant()
    {
        Plants.Add(flower);
        CreateNewPlant();
    }
    public void RemovePlant(Flower plantToRemove)
    { 
        Plants.Remove(plantToRemove);
    }
    
}
