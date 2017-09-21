using NUnit.Framework;

namespace GenericsPractice
{
	[TestFixture]
	internal class MyGenericClassTests
	{
		[Test]
		public void I_can_get_an_item_of_type_string_from_it()
		{
			var sut = new MyGenericClass();

			var getResult = sut.Get();

			Assert.That(getResult, Is.TypeOf<string>());
		}
	}
}