using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSolutions
{
    public class PagnationHelper<T>
    {
        List<T> _allItems = null;
        int _itemsPerPage = 0;

        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            ItemCount = collection.Count;
            _itemsPerPage = itemsPerPage;
            _allItems = collection.ToList();

            int i = 0;
            while (i < collection.Count)
            {
                i += itemsPerPage;
                PageCount++;
            }



        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get; set;
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get; set;
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            int realIndex = pageIndex != 0 ? (_itemsPerPage * pageIndex) : 0;

            int result = _allItems.Where((a, b) => b >= realIndex && b < realIndex + _itemsPerPage).Count();

            return result == 0 ? -1 : result;
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            int i = 0, result = 0;
            while (i <= itemIndex)
            {
                if (i != 0) { result++; }
                i += _itemsPerPage;
            }

            return itemIndex < 0 || itemIndex > _allItems.Count - 1 ? -1 : result;
        }
    }
}
