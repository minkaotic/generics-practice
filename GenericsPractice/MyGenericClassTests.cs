using NUnit.Framework;

namespace GenericsPractice
{
	[TestFixture]
	internal class MyGenericClassTests
	{
		private MyGenericClass _sut;

		[Test]
		public void I_can_get_an_item_of_type_string_from_it()
		{
			_sut = new MyGenericClass();

			var getResult = _sut.Get();

			Assert.That(getResult, Is.TypeOf<string>());
		}
	}
}