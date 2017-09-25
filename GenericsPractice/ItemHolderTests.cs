using NUnit.Framework;

namespace GenericsPractice
{
	[TestFixture]
	internal class ItemHolderTests
	{
		[Test]
		public void I_can_get_an_item_of_type_string()
		{
			var itemHolder = new ItemHolder<string>("randomString");

			var getResult = itemHolder.Get();

			Assert.That(getResult, Is.TypeOf<string>());
		}

		[Test]
		public void I_can_get_an_item_of_type_int()
		{
			var itemHolder = new ItemHolder<int>(12);

			var getResult = itemHolder.Get();

			Assert.That(getResult, Is.TypeOf<int>());
		}

		[Test]
		public void I_can_get_an_item_of_custom_type()
		{
			var itemHolder = new ItemHolder<Mia>(new Mia());

			var mia = itemHolder.Get();

			Assert.That(mia, Is.TypeOf<Mia>());
			Assert.That(Mia.Cat, Is.EqualTo("Elsie"));
			Assert.That(Mia.Age, Is.EqualTo(34));
		}

		[Test]
		public void I_can_get_multiple_items()
		{
			var multiItemHolder = new MultiItemHolder<string, int>("hi", 100);

			var item1 = multiItemHolder.GetFirstItem();
			var item2 = multiItemHolder.GetSecondItem();

			Assert.That(item1, Is.TypeOf<string>());
			Assert.That(item2, Is.TypeOf<int>());

		}

		private class Mia
		{
			public static string Cat { get { return "Elsie"; } }
			public static int Age { get { return 34; } }
		}
	}
}