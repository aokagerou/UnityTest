using UnityEngine;
using NUnit.Framework;

[TestFixture]
public class UnitTest {

    [TestCase(1, 2)]
	public void TestManTest (int a, int b) {
        Piece c = new Piece();
        int val = c.TestMan(a);
        Assert.AreEqual(val, b);
	}
}
