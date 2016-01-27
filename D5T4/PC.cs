﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PC
{
	public virtual CPU CPU
	{
		get;
		set;
	}

	public virtual List<GPU> GPU
	{
		get;
		set;
	}

	public virtual List<RAM> RAM
	{
		get;
		set;
	}

    public void PrintData()
    {
        Console.WriteLine("CPU:" + CPU.Cores + " cores " + CPU.Speed + "Ghz");
        foreach(GPU g in GPU)
        {
            Console.WriteLine("GPU:"+g.Name+" "+g.Memory+"gb");
        }
        foreach (RAM r in RAM)
        {
            Console.WriteLine("RAM:" + r.Memory + "gb");
        }
    }

}

