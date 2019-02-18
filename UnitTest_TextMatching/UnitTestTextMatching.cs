using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CODE_TEST_MUHAMMAD_SULEMAN;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_TextMatching
{
    [TestClass]
    public class UnitTestTextMatching
    {
        [TestMethod]
        public void TextMatching()
        {
            string inputString = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea 25 25 26 10";           

            ArrayList expectedResult = new ArrayList() { 1, 26, 51 };
            ArrayList actualResult = inputString.FindSubString("Polly");
            CollectionAssert.AreEqual(expectedResult, actualResult);

            //expectedResult = new ArrayList() { 1, 26, 51 };
            //actualResult = inputString.FindSubString("polly");
            //CollectionAssert.AreEqual(expectedResult, actualResult);

            //expectedResult = new ArrayList() { 3, 28, 53, 78, 82 };
            //actualResult = inputString.FindSubString("ll");
            //CollectionAssert.AreEqual(expectedResult, actualResult);

            //expectedResult = new ArrayList() { 3, 28, 53, 78, 82 };
            //actualResult = inputString.FindSubString("Ll");
            //CollectionAssert.AreEqual(expectedResult, actualResult);

            //expectedResult = new ArrayList() { "<no matches>" };
            //actualResult = inputString.FindSubString("X");
            //CollectionAssert.AreEqual(expectedResult, actualResult);

            //expectedResult = new ArrayList() { "<no matches>" };
            //actualResult = inputString.FindSubString("Polx");
            //CollectionAssert.AreEqual(expectedResult, actualResult);

            //expectedResult = new ArrayList() { 22, 47 };
            //actualResult = inputString.FindSubString("on, ");
            //CollectionAssert.AreEqual(expectedResult, actualResult);

            //expectedResult = new ArrayList() { 75 };
            //actualResult = inputString.FindSubString("we'll");
            //CollectionAssert.AreEqual(expectedResult, actualResult);

            //expectedResult = new ArrayList() { 94, 97, 100 };
            //actualResult = inputString.FindSubString("2");
            //CollectionAssert.AreEqual(expectedResult, actualResult);
        }        
    }
}
