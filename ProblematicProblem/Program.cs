using System;
using System.Collections.Generic;
using System.Threading;


namespace ProblematicProblem
{
    internal class Program
    {

        static void Main(string[] args)
        {

            bool genAgain = false;


            var getActivities = new Activities();

            getActivities.Welcome();
            getActivities.UserInput();
            getActivities.ActivityReveal();
            getActivities.ActivityInput();
            getActivities.ActivityGen();
            genAgain = getActivities.LoopOrEnd();

            while (genAgain == true)
            {
                getActivities.ActivityGen();
                genAgain = getActivities.LoopOrEnd();
            }
            
            
            

        }
    }
}