﻿// See https://aka.ms/new-console-template for more information
using System;
public class LitwareLib
{
    private int EmpNo;
    private string EmpName;
    private double Salary;
    private double HRA;
    private double TA;
    private double DA;
    private double PF;
    private double TDS;
    private double NetSalary;
    private double GrossSalary;

    public void input(int EmpNo, string EmpName)
    {
        this.EmpNo = EmpNo;
        this.EmpName = EmpName;
        
    }
    public void CalculateSalary(double Salary)
    {
        this.Salary = Salary;
        if (Salary < 5000)
        {
            this.HRA = 0.10 * Salary;
            this.TA = 0.05 * Salary;
            this.DA = 0.15 * Salary;

        }
        else if (Salary < 10000)
        {
            this.HRA = 0.15 * Salary;
            this.TA = 0.10 * Salary;
            this.DA = 0.20 * Salary;

        }
        else if (Salary < 15000)
        {
            this.HRA = 0.20 * Salary;
            this.TA = 0.15 * Salary;
            this.DA = 0.25 * Salary;

        }
        else if (Salary < 20000)
        {
            this.HRA = 0.25 * Salary;
            this.TA = 0.20 * Salary;
            this.DA = 0.30 * Salary;
        }
        else
        {

            this.HRA = 0.30 * Salary;
            this.TA = 0.25 * Salary;
            this.DA = 0.35 * Salary;
        } }
     public double Calcu()
        {
        
       this.GrossSalary = this.Salary + this.HRA + this.TA +this.DA;


        this.PF = 0.10 * this.GrossSalary;
        this.TDS = 0.18 * this.GrossSalary;
        this.NetSalary = this.GrossSalary – this.PF ;

        return this.GrossSalary;
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        LitwareLib l = new LitwareLib();
        l.input(5, "rahul");
        l.CalculateSalary(100);
        Console.WriteLine(l.Calcu());
    }
}