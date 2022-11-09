using System;
using System.Collections.Generic;
using System.Text;

namespace EighthNov
{
    internal class CleanCoding
    {
        //1 use meaningful names
        //2 use camel case(phoneNumber while declaring variables) and pascal case(PhoneNumber)
        //3 pay attention to the code formatting (ctrl k + ctrl f)
        //4 Add the comments where ever we need
        //5 reusuable code
        //6 keep class size small
        //7 use design patterns (solid, dry , kiss and more)
        //8 avoid magic strings/numbers (stop hard coding)
        //9 remove unwanted code i.e non using codes
        //10 dont use 'throw ex' in the catch block
        //11 use ternary operator
        //12 use null coalescing operator
        //13 use expression bodied methods
        //14 prefer string interpolation

        //2 and 3 bad code
        int variableA;
        int variableB;
        public int sum()
        {
            return variableA + variableB;
        }
    }

    //6 bad way
    public abstract class Human
    {
        public string name { get; set; }
        public int legs { get; set; }
        public int hands { get; set; }
        public int gender { get; set; }

        public abstract string Work();
        //public void Adults()
        //{
        //    Console.WriteLine("I am an adult including the properties of human");
        //}
        //public void Children()
        //{
        //    Console.WriteLine("I am a Child including the properties of human");
        //}
        //public void SeniorCitizens()
        //{
        //    Console.WriteLine("I am a Senior citizen including the properties of human");
        //}
        //public void Teenagers()
        //{
        //    Console.WriteLine("I am a teenagerincluding the properties of human");
        //}

    }

    //6 Good way
    public class Adults : Human
    {
        //13
        public override string Work() => "job/business";

    }
    public class Children : Human
    {
        public override string Work()
        {
            return "schooling";
        }
    }
    public class SeniorCitizen : Human
    {
        public override string Work()
        {
            return "Guiding";
        }
    }
    public class Teenagers : Human
    {
        public override string Work()
        {
            return "Enjoying";
        }
    }



}
