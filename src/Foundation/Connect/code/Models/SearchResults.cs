//    Copyright 2019 EPAM Systems, Inc.
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System.Collections.Generic;
using System.Linq;
using Sitecore.Commerce.Engine.Connect.Search.Models;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;

namespace Wooli.Foundation.Connect.Models
{
    public class SearchResults
    {
        private IEnumerable<CommerceQueryFacet> facets;

        private IList<Item> searchResultItems;

        public SearchResults() : this(null, 0, 0, 0, null)
        {
        }

        public SearchResults(List<Item> searchResultItems, int totalItemCount, int totalPageCount,
            int currentPageNumber, IEnumerable<CommerceQueryFacet> facets)
        {
            SearchResultItems = searchResultItems ?? new List<Item>();
            TotalPageCount = totalPageCount;
            TotalItemCount = totalItemCount;
            Facets = facets ?? Enumerable.Empty<CommerceQueryFacet>();
            CurrentPageNumber = currentPageNumber;
        }

        public string DisplayName { get; set; }

        public Item NamedSearchItem { get; set; }

        public int TotalItemCount { get; set; }

        public int TotalPageCount { get; set; }

        public int CurrentPageNumber { get; set; }

        public IList<Item> SearchResultItems
        {
            get => searchResultItems;
            set
            {
                Assert.ArgumentNotNull(value, nameof(value));
                searchResultItems = value;
            }
        }

        public IEnumerable<CommerceQueryFacet> Facets
        {
            get => facets;
            set
            {
                Assert.ArgumentNotNull(value, nameof(value));
                facets = value;
            }
        }
    }
}