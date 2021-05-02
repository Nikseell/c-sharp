using System;

namespace Dogs
{
    class DogTest
    {
        static void Main(string[] args)
        {
            Dogs dog1 = new Dogs("Max", "Male", "Rocky", "Lady");
            Dogs dog2 = new Dogs("Rocky", "Male", "Sam", "Molly");
            Dogs dog3 = new Dogs("Sparky", "Male", string.Empty, string.Empty);
            Dogs dog4 = new Dogs("Buster", "Male", "Sparky", "Lady");
            Dogs dog5 = new Dogs("Sam", "Male", string.Empty, string.Empty);
            Dogs dog6 = new Dogs("Lady", "Female", string.Empty, string.Empty);
            Dogs dog7 = new Dogs("Molly", "Female", string.Empty, string.Empty);
            Dogs dog8 = new Dogs("Coco", "Female", "Buster", "Molly");

            dog8.FathersName();
            dog3.FathersName();

            dog8.HasSameMotherAs(dog2);
        }
    }
}
