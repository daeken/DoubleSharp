using DoubleSharp.Pretty;

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
			Assert.That(new Dictionary<string, int> {
				["Hello"] = 3,
				["World!"] = 7,
			}.ToPrettyString(), Is.EqualTo("Dictionary<string, int>[2] {\n\t[\"Hello\"] = 3, \n\t[\"World!\"] = 7\n}"));
		});
	}

	[Test]
	public void NestedCollectionTest() {
		Assert.Multiple(() => {
			Assert.That(new[,] { { 1, 2}, { 3, 4 }, { 5, 6 } }.ToPrettyString(), Is.EqualTo("int[3, 2] {\n\t{\n\t\t1, \n\t\t2\n\t}, \n\t{\n\t\t3, \n\t\t4\n\t}, \n\t{\n\t\t5, \n\t\t6\n\t}\n}"));
			Assert.That(new List<int[]> { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }.ToPrettyString(), Is.EqualTo(
				"List<int[]>[2] {\n\tint[3] {\n\t\t1, \n\t\t2, \n\t\t3\n\t}, \n\tint[3] {\n\t\t4, \n\t\t5, \n\t\t6\n\t}\n}"));
			Assert.That(new List<List<string>> { new() { "Hello", "World!" }, new() { "Zomg", "it" }, new() { "works" } }.ToPrettyString(), Is.EqualTo(
				"List<List<string>>[3] {\n\tList<string>[2] {\n\t\t\"Hello\", \n\t\t\"World!\"\n\t}, \n\tList<string>[2] {\n\t\t\"Zomg\", \n\t\t\"it\"\n\t}, \n\tList<string>[1] { \"works\" }\n}"));
			Assert.That(new Dictionary<string, List<int>> {
				["Hello"] = new() { 1, 2 },
				["World!"] = new(),
			}.ToPrettyString(), Is.EqualTo(
				"Dictionary<string, List<int>>[2] {\n\t[\"Hello\"] = List<int>[2] {\n\t\t1, \n\t\t2\n\t}, \n\t[\"World!\"] = List<int>[0]\n}"));
		});
	}
}