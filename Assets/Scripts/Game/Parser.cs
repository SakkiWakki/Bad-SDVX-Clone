using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class Parser
{
   
    public string fileLocation { get; set; }
    public List<string> lines { get; set; }

    public Parser(string fileLocation)
    {
        this.fileLocation = fileLocation;
        this.lines = File.ReadAllLines(fileLocation).ToList();
    }

    //KSH Parser, one seperate for Metadata and Map.
    public void KSHMeta()
    {
       
    }

    public void KSHMap()
    {
        //Start is the location of the first --, finish is the location of the next --. Bounds a measure
        int start, finish;

        //This list tracks the location of all the "--"s in the file
        List<int> locationOfMeasures = new List<int>();

        for (int i = 0; i < lines.Count; i++)
        {
            if (lines[i].Equals("--"))
            {
                locationOfMeasures.Add(i);
            }
        }
        for ()
    }

    //BMS Parser, one seperate for Metadata and Map.
    public void BMSMeta()
    {

    }

    public void BMSMap()
    {

    }

    public void changeFile(string fileLocation)
    {
        this.fileLocation = fileLocation;
        this.lines = File.ReadAllLines(fileLocation).ToList();
    }
}
