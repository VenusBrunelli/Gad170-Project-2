using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    private string plantSpecies;
    private int plantValue;
    private float plantHealth;
    public string[] inventory = new string[3] { "Rose", "Sunflower", "Lily" };
    public Greenhouse greenhouse;
    

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlantStats(int newValue, float newHealth, string[] newSpecies)
    {
        plantSpecies = newSpecies[Random.Range(0, 2)];
        plantValue = newValue;
    }
    public float GetHealth()
    {
        return plantHealth;
        }
    public int GetValue()
    {
        return plantValue;
    }

    public string GetSpecies()
    { 
        return plantSpecies;
    }
    public void RemovePlant()
    {
        if (greenhouse != null)
        {
            greenhouse.RemovePlant(this);
        }
        Destroy(gameObject);
    }
    public void Start()
    {
        PlantStats(Random.Range(80, 1000), Random.Range(10, 1000), inventory = new string[3] { "Rose", "Sunflower", "Lily" });
    }
}
