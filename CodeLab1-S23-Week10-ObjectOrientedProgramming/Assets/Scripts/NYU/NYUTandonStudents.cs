using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUTandonStudents : NYUStudent
{
    private string degree = "MFE";
    private int minCreditPerSem = 9;

    public NYUTandonStudents
        (string name, string netId, float gpa, int credits, string degree, int minCreditPerSem) :
        base(name, netId, gpa, credits)
    {
        this.degree = degree;
        this.minCreditPerSem = minCreditPerSem;

        type = "NYU Financial Engineering Student";
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + 
               "\n" + "Degree: " + degree + "\n" + "Minimum Credit per Semester: " + minCreditPerSem;
    }
}
