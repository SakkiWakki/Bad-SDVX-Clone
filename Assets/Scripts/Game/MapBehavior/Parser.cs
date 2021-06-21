using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using System;

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


        List<List<int>> holdNotes = new List<List<int>>(new List<int>(), new List<int>(), new List<int>(), new List<int>(), new List<int>(), new List<int>());

        Debug.Log(locationOfMeasures.Count);

        //Main part of parser
        for (int i = 0; i < locationOfMeasures.Count - 1; i++)
        {
            totalSectionCount = 0;
            onSectionNum = -1;

            //Indicates where, on the file, a measure begins and ends
            start = locationOfMeasures[i];
            finish = locationOfMeasures[i+1];

            for (int j = start + 1; j < finish; j++)
            {
                if (lines[j].IndexOf("|") == 4)
                {
                    totalSectionCount++;
                }
            }
            //Nested for loop to go through each measure. Keep in mind that int finish still takes place on the "--"s.
            for (int j = start; j < finish; j++)
            {

                List<boolean> holdCheck = new List<boolean>(false, false, false, false, false, false); //check if hold notes ended

                onSectionNum++;
                //FX
                for (int k = 5; k < Math.Min(7, lines[j].Length); k++) //Bad implementation
                if (lines[j].IndexOf("|") == 4)
                {
                    onSectionNum++;
                    //FX
                    for (int k = 5; k < Math.Min(7, lines[j].Length); k++) //Bad implementation
                    {
                        switch (lines[j][k])
                        {
                            case '1':
                                //instance.CreateNote(GetLaneButton(k), measureCount, onSectionNum, totalSectionCount);
                                break;
                            case '2':
                                instance.CreateNote(GetLaneButton(k), measureCount, onSectionNum, totalSectionCount);
                                break;
                            default:
                                break;
                        }
                    }
                    //BT
                    for (int k = 0; k < 4; k++)
                    {

                        case '1':
                            instance.CreateNote(GetLaneButton(k), measureCount, onSectionNum, totalSectionCount);
                            break;
                        case '2':
                            if (!holdNotes[k].Contains(j)) {
                                
                                instance.createHoldNote(GetLaneButton(k), measureCount, onSectionNum, totalSectionCount);
                            }
                            break;
                        default:
                            break;
                        switch (lines[j][k])
                        {
                            case '1':
                                instance.CreateNote(GetLaneButton(k), measureCount, onSectionNum, totalSectionCount);
                                break;
                            case '2':
                                //instance.CreateNote(GetLaneButton(k), measureCount, onSectionNum, totalSectionCount);
                                break;
                            default:
                                break;
                        }

                    }
                }      
            }
            measureCount++;
        }
        Debug.Log(measureCount);
    }

    public void holdNoteHelper(int currentLine, int index) {

        List<int> lineNum = new List<int>();

        while (lines[currentLine][index] == 2) {
            lineNum 
            currentLine = currentLine + 1;
        }

    }

    //For use in KSHMap()
    public string GetLaneButton(int k)
    {
        switch (k)
        {
            case 0:
                return "BT1";
            case 1:
                return "BT2";
            case 2:
                return "BT3";
            case 3:
                return "BT4";
            case 5:
                return "FX1";
            case 6:
                return "FX2";
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
