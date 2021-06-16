using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class Parser
{
   
    public string fileLocation { get; set; }
    public List<string> lines { get; set; }

    //I am too lazy to type Beatmap.Instance.(code) 
    public Beatmap instance;

    public Parser(string fileLocation)
    {
        instance = Beatmap.Instance;
        this.fileLocation = fileLocation;
        this.lines = File.ReadAllLines(fileLocation).ToList();
    }

    public void changeFile(string fileLocation)
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
        int start = -1, finish = -1;

        //A section is any part of the file that references a beat, Eg 0000|00|--
        //The first variable measures the total sections in one measure
        //The second measures the current section the for loop is on, 1 indexed
        //The last tracks how many measures you have passed, 0 indexed
        int totalSectionCount = 0, onSectionNum = 0, measureCount = 0;

        //This list tracks the location of all the "--"s in the file
        List<int> locationOfMeasures = new List<int>();

        for (int lineNumber = 0; lineNumber < lines.Count; lineNumber++)
        {
            if (lines[lineNumber].Equals("--"))
            {
                locationOfMeasures.Add(lineNumber);
            }
        }

        //Main part of parser
        for (int i = 0; i < locationOfMeasures.Count - 1; i = i+1)
        {
            onSectionNum = 0;

            //Indicates where, on the file, a measure begins and ends
            start = locationOfMeasures[i];
            finish = locationOfMeasures[i+1];

            //Check to see when the first section starts (going to implement checking for attributes before sections later)
            for (int j = start + 1; j < finish; j++)
            {
                if (lines[j].IndexOf("|") == 4)
                {
                    //Changes start to the position of the first section
                    start = j;
                    break;
                }
            }

            totalSectionCount = finish - start;
;
            //Nested for loop to go through each measure. Keep in mind that int finish still takes place on the "--"s.
            for (int j = start; j < finish; j++)
            {
                onSectionNum++;
                //Checks each section for notes, ONLY BT FOR NOW
                for (int k = 0; k < 4; k++)
                {
                    switch (lines[j][k])
                    {
                        case '1':
                            instance.CreateNote(GetLaneButton(k), (instance.measureSize * measureCount) + instance.measureSize * ((float)onSectionNum / totalSectionCount));
                            break;
                        default:
                            break;
                    }
                }
            }

            measureCount++;
        }
    }

    //For use in KSHMap()
    public string GetLaneButton(int k)
    {
        switch (k)
        {
            case 0:
                Debug.Log(1);
                return "BT1";
            case 1:
                Debug.Log(2);
                return "BT2";
            case 2:
                Debug.Log(3);
                return "BT3";
            case 3:
                Debug.Log(4);
                return "BT4";
            default:
                break;
        }
        return null;
    }


    //BMS Parser, one seperate for Metadata and Map.
    public void BMSMeta()
    {

    }

    public void BMSMap()
    {

    }
}
