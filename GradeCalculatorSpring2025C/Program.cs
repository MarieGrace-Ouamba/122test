//Written by Marie-Grace
// 1/28/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculatorSpring2025C
{
    public class GradeCalculayionSpring2025C
    {
        //class variables
        private double quiz1 = -99999.99;
        private double quiz2 = -99999.99;
        private double quiz3 = -99999.99;
        private double quiz4 = -99999.99;

        //Refactor with a list
        List<double> listOfQuizzes = new List<double> ();

        //So we should not do these because these are supposed to be calculated
        // private double total = -999999999.99;
        //private double average = -999999999.99;
        //private string letterGrade = "n/a";

        //gets and sets

        public double Quiz1
        {
            get { return this.quiz1; }
            set { this.quiz1 = value; }
                if (value >= 0.0 && value <= 100.0)
                {
                    this.quiz1 = value;
                }
                else
                {
                    this.quiz1 = -99999.99;
    }

        public double quiz2
        {
            get { return this.quiz2; }
            set { this.quiz2 = value; }
                if (value >= 0.0 && value <= 100.0)
                {
            this.quiz2 = value;
        }
                else
                {
            this.quiz2 = -99999.99;
        }

        public double quiz3
        { 
            get { return this.quiz3; }
            set { this.quiz3 = value; }
                if (value >= 0.0 && value <= 100.0)
                {
            this.quiz3 = value;
        }
                else
                {
            this.quiz3 = -99999.99;
        }

         public double quiz4
    {
        get { return this.quiz4; }
        set { this.quiz4 = value; }
                if (value >= 0.0 && value <= 100.0)
                {
            this.quiz4 = value;
        }
                else
                {
            this.quiz4 = -99999.99;
        }
    }
    //Now normally we would 

    //Methods
    public void AddQuiz(double aQuiz)
    {
        //add a Quiz to the List
        if (aQuiz >= 0.0 && aQuiz <= 100.0)
        {
            ListOfQuizzes.Add(aQuiz);
        }. l
    public double CalcTotal ()
    {
        double total = 0;
        //use the capitalized Quizzes so that we use the gets and sets 
        total = Quiz1 + Quiz2 + Quiz3 + Quiz4;
        return total;

    }

    public double CalcAverage()
    {
        double average = 0;
        //use the capitalized Quizzes so that we use the gets and sets 
        //This is better because of the DRY principle
        average = (CalcTotal()) / 4,0;
        return average;

    }

    public string CalcLetterGrade()
    {
        double average = 0.0;
        string letterGrade = "Z";
        //use the capitalized Quizzes so that we use the gets and sets 
        //average= (Quiz1 + Quiz2 + Quiz3 + Quiz4;) / 4.0;
        //Again DRY
        average = CalcAverage();
        if (average >= 0.0 && average <60.0 )
        {
            letterGrade = "F";
        }
        if (average >= 60.0 && average < 70.0)
        {
            letterGrade = "D";
        }
        if (average >= 70.0 && average < 80.0)
        {
            letterGrade = "C";
        }
        if (average >= 80.0 && average < 90.0)
        {
            letterGrade = "B";
        }
        if (average >= 90.0 && average < 100.0)
        {
            letterGrade = "A";
        }
        return letterGrade

    }
    public override string ToString()
    {

    }string message = "";
    message = message + "Quiz1: " + this.Quiz1 + "\n";
    message = message + "Quiz2: " + this.Quiz2 + "\n";
    message = message + "Quiz3: " + this.Quiz3 + "\n";
    message = message + "Quiz4: " + this.Quiz4 + "\n";
    message = message + "Total: " + this.CalcTotal() + "\n";
    message = message + "Quiz1: " + this.Quiz1 + "\n";



