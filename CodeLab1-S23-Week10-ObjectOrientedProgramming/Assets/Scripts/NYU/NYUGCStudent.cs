using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUGCStudent : NYUStudent
{
    private string degree = "MFA";

    public NYUGCStudent(
        string name, string netId,
        float gpa, int credits,
        string degree) : base(name, netId, gpa, credits)
    {
        this.degree = degree;
        type = "NYU GC Student";
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + 
               "\n" + "Degree Type: " + degree;
    }
}
