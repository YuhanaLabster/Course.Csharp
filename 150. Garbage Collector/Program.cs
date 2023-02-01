using System;

namespace _150._Garbage_Collector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Garbage Collection
                The .Net Framework provides an automatic memory management
                Human denis = new Human(); // allocates Memory
                The Framework takes care of reclaiming memory for reuse in the system, once objects are no longer being used


                Example of when garbage collection would kick in
                public void myFunction {
                Human denis = new Human(); // allocates Memory
                denis.teach();
                int age = denis.age;
                denis.getOlder();
                } <<- The function ends, the Object "denis" goes out of scope and there are no references to "denis" left
                

                What you need to know about Garbage Collection
                * You don't have to manually call the garbage collector (but you can)
                * The garbage collector requires processing power
                * The GC's goal is to free up memory but not use too much processing power
                * Memory isn't necessarily reclaimed right away
                * You can implement the finalizer method to execute code just before an object is released from memory by the GC.
             
                When does the Garbage Collector run?
                * When the system has low physical memory
                * when the memory allocated exceeds a pre-set threshold
                * when GC.Collect() is called. Even though this is a tricky method
             */
        }
    }
}
