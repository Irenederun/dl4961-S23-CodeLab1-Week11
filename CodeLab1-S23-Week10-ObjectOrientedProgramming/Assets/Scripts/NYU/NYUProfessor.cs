using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUProfessor : NYUStaff
{
    public bool tenure = false;
    
    public NYUProfessor(string name, string netId, float salary, bool tenure) : base (name, netId, salary)
    {
        this.tenure= tenure;

        type = "NYU Professor";
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + 
               "\n" + "Tenured: " + tenure;
    }
}
