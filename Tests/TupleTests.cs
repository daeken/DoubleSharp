using DoubleSharp.Linq;

namespace Tests; 

[TestFixture]
public class TupleTests {
	[Test]
	public void AsEnumerable() {
		Assert.Multiple(() => {
			Assert.That((3, 4).AsEnumerable(), Is.EqualTo((3, 5).Range()));
			Assert.That((3, 4, 5).AsEnumerable(), Is.EqualTo((3, 6).Range()));
			Assert.That((3, 4, 5, 6).AsEnumerable(), Is.EqualTo((3, 7).Range()));
			Assert.That((3, 4, 5, 6, 7).AsEnumerable(), Is.EqualTo((3, 8).Range()));
			Assert.That((3, 4, 5, 6, 7, 8).AsEnumerable(), Is.EqualTo((3, 9).Range()));
			Assert.That((3, 4, 5, 6, 7, 8, 9).AsEnumerable(), Is.EqualTo((3, 10).Range()));
			Assert.That((3, 4, 5, 6, 7, 8, 9, 10).AsEnumerable(), Is.EqualTo((3, 11).Range()));
			Assert.That((3, 4, 5, 6, 7, 8, 9, 10, 11).AsEnumerable(), Is.EqualTo((3, 12).Range()));
			Assert.That((3, 4, 5, 6, 7, 8, 9, 10, 11, 12).AsEnumerable(), Is.EqualTo((3, 13).Range()));
			Assert.That((3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13).AsEnumerable(), Is.EqualTo((3, 14).Range()));
			Assert.That((3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14).AsEnumerable(), Is.EqualTo((3, 15).Range()));
			Assert.That((3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15).AsEnumerable(), Is.EqualTo((3, 16).Range()));
			Assert.That((3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16).AsEnumerable(), Is.EqualTo((3, 17).Range()));
			Assert.That((3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17).AsEnumerable(), Is.EqualTo((3, 18).Range()));
			Assert.That((3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18).AsEnumerable(), Is.EqualTo((3, 19).Range()));
			Assert.That((3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19).AsEnumerable(), Is.EqualTo((3, 20).Range()));
			Assert.That((3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20).AsEnumerable(), Is.EqualTo((3, 21).Range()));
			Assert.That((3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21).AsEnumerable(), Is.EqualTo((3, 22).Range()));
			Assert.That((3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22).AsEnumerable(), Is.EqualTo((3, 23).Range()));
		});
	}
}