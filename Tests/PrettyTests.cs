using DoubleSharp.Pretty;
using NUnit.Framework;

namespace Tests; 

[TestFixture]
public class PrettyTests {
	[Test]
	public void StringTest() {
		Assert.Multiple(() => {
			Assert.That("foo".ToPrettyString(), Is.EqualTo("\"foo\""));
			Assert.That("fo\no".ToPrettyString(), Is.EqualTo("\"fo\\no\""));
			Assert.That("fo\"o".ToPrettyString(), Is.EqualTo("\"fo\\\"o\""));
		});
	}

	[Test]
	public void TypeTest() {
		Assert.Multiple(() => {
			Assert.That(typeof(string).ToPrettyString(), Is.EqualTo("string"));
			Assert.That(typeof(string[]).ToPrettyString(), Is.EqualTo("string[]"));
			Assert.That(typeof(string[,]).ToPrettyString(), Is.EqualTo("string[,]"));
			Assert.That(typeof(string[,,,]).ToPrettyString(), Is.EqualTo("string[,,,]"));
			Assert.That(typeof(List<string>).ToPrettyString(), Is.EqualTo("List<string>"));
			Assert.That(typeof(IEnumerable<string>).ToPrettyString(), Is.EqualTo("IEnumerable<string>"));
			Assert.That(typeof(int).ToPrettyString(), Is.EqualTo("int"));
			Assert.That(typeof(uint).ToPrettyString(), Is.EqualTo("uint"));
			Assert.That(typeof(long).ToPrettyString(), Is.EqualTo("long"));
			Assert.That(typeof(ulong).ToPrettyString(), Is.EqualTo("ulong"));
			Assert.That(typeof(nint).ToPrettyString(), Is.EqualTo("nint"));
			Assert.That(typeof(nuint).ToPrettyString(), Is.EqualTo("nuint"));
			Assert.That(typeof(Dictionary<string, IReadOnlyList<uint>>).ToPrettyString(), Is.EqualTo("Dictionary<string, IReadOnlyList<uint>>"));
		});
	}

	[Test]
	public void SimpleCollectionTest() {
		Assert.Multiple(() => {
			Assert.That(new[] { 1, 2, 3, 4, 5, 6 }.ToPrettyString(), Is.EqualTo("int[6] {\n\t1, \n\t2, \n\t3, \n\t4, \n\t5, \n\t6\n}"));
			Assert.That(new List<int> { 1, 2, 3, 4, 5, 6 }.ToPrettyString(), Is.EqualTo("List<int>[6] {\n\t1, \n\t2, \n\t3, \n\t4, \n\t5, \n\t6\n}"));
			Assert.That(new List<string> { "Hello", "World!" }.ToPrettyString(), Is.EqualTo("List<string>[2] {\n\t\"Hello\", \n\t\"World!\"\n}"));
		});
	}
}