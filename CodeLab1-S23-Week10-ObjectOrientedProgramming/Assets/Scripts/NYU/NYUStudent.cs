using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUStudent : NYUPerson
    //extending from NYU person and has something in addition
{
    public float gpa = 4.0f;
    public int credits = 0;

    public NYUStudent(
        string name, string netId, 
        float gpa, int credits) :
        base (name, netId)
    {
        this.gpa = gpa;
        this.credits = credits;

        type = "NYU Student";
        //it recognizes from NYU person
    }

    public override string ShowRecord()
    {
        //return "lol i overrode your class you've been powned" // it'll replace the string and print only this
        return base.ShowRecord() + 
               "GPA: " + gpa;
    }
}