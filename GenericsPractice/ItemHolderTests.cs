using NUnit.Framework;

namespace GenericsPractice
{
	[TestFixture]
	internal class ItemHolderTests
	{
		[Test]
		public void I_can_get_an_item_of_type_string()
		{
			var sut = new ItemHolder<string>("randomString");

			var getResult = sut.Get();

			Assert.That(getResult, Is.TypeOf<string>());
		}

		[Test]
		public void I_can_get_an_item_of_type_int()
		{
			var sut = new ItemHolder<int>(12);

			var getResult = sut.Get();

			Assert.That(getResult, Is.TypeOf<int>());
		}

		[Test]
		public void I_can_get_an_item_of_custom_type()
		{
			var sut = new ItemHolder<Mias>(new Mias());

			var mias = sut.Get();

			Assert.That(mias, Is.TypeOf<Mias>());
			Assert.That(mias.Cat, Is.EqualTo("Elsie"));
			Assert.That(mias.Age, Is.EqualTo(34));
		}

		[Test]
		public void I_can_get_multiple_items()
		{
			var sut = new MultiItemHolder<string, int>("hi", 100);

			var item1 = sut.GetFirstItem();
			var item2 = sut.GetSecondItem();

			Assert.That(item1, Is.TypeOf<string>());
			Assert.That(item2, Is.TypeOf<int>());

		}

		internal class Mias
		{
			public string Cat { get { return "Elsie"; } }
			public int Age { get { return 34; } }
		}
	}
}