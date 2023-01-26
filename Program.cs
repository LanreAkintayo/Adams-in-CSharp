using System;
using System.IO;


namespace Adam{
    class TestCase{
        private string testCase;

        public TestCase(string _testCase){
            testCase = _testCase;
        }

        public int GetNoOfSteps(){
            int steps = 0;
            foreach(char letter in testCase){
                if (letter.ToString() == "D"){
                    break;
                }
                steps++;
            }

            return steps;
        }

        public string GetTestCase(){
            return testCase;
        }

        public void setTestCase(string _testCase){
            testCase = _testCase;
        }
    }


    class MainProgram{

        static void Main(string[] args){
            string fileName = "adam.in";
            StreamReader file = new StreamReader(fileName);

            int noOfTestCases = Convert.ToInt32(file.ReadLine());
            string[] allTests = new string[noOfTestCases];
            int[] allSteps = new int[noOfTestCases];

            for (int i = 0; i < noOfTestCases; i++){
                TestCase Test = new TestCase(file.ReadLine().ToString());
                int steps = Test.GetNoOfSteps();

                allTests[i] = Test.GetTestCase();
                allSteps[i] = steps;
            }

            for (int j = 0; j < noOfTestCases; j++){
                Console.WriteLine("{0} has {1} steps", allTests[j], allSteps[j]);
            }

        }
    }
}