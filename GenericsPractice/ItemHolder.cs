using NUnit.Framework.Constraints;

namespace GenericsPractice
{
	public class ItemHolder<T>
	{
		private readonly T _item;

		public ItemHolder(T item)
		{
			_item = item;
		}

		public T Get()
		{
			return _item;
		}
	}

	internal class MultiItemHolder<T, T1>
	{
		private readonly T _item1;
		private readonly T1 _item2;

		public MultiItemHolder(T item1, T1 item2)
		{
			_item1 = item1;
			_item2 = item2;
		}

		public T GetFirstItem()
		{
			return _item1;
		}

		public T1 GetSecondItem()
		{
			return _item2;
		}
	}
}