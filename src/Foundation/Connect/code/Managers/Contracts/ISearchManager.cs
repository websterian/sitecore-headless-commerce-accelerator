//    Copyright 2020 EPAM Systems, Inc.
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

namespace Wooli.Foundation.Connect.Managers
{
    using System.Collections.Generic;

    using Models;
    using Models.Search;

    using Sitecore.Commerce.Engine.Connect.Search.Models;
    using Sitecore.Data;
    using Sitecore.Data.Items;

    public interface ISearchManager
    {
        Item GetCategory(string catalogName, string categoryName);

        List<Item> GetCategoryChildCategories(ID categoryId);

        List<Item> GetNavigationCategories();

        Item GetProduct(string catalogName, string productId);

        SearchResults GetProducts(
            string catalogName,
            ID categoryId,
            CommerceSearchOptions searchOptions,
            string searchKeyword);

        SearchResults SearchCatalogItemsByKeyword(
            string catalogName,
            string searchKeyword,
            CommerceSearchOptions searchOptions);
    }
}