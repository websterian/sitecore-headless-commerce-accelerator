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

using System.Web.Http;

namespace Wooli.Feature.Checkout.Controllers
{
    using System.Linq;
    using System.Net;
    using System.Web.Mvc;

    using Wooli.Feature.Checkout.Models;
    using Wooli.Foundation.Commerce.Repositories;
    using Wooli.Foundation.Extensions.Extensions;

   public class CartController : Controller
    {
        private readonly ICartRepository cartRepository;

        public CartController(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        [ActionName("get")]
        public ActionResult GetCart()
        {
            var model = this.cartRepository.GetCurrentCart();

            return this.JsonOk(model);
        }

        [HttpPost]
        [ActionName("add")]
        public ActionResult AddProductVariant([FromBody] CartItemDto cartItem)
        {
            var result = this.cartRepository.AddProductVariantToCart(cartItem.ProductId, cartItem.VariantId, cartItem.Quantity);

            if (result.Success)
            {
                return this.JsonOk(result.Data);
            }

            return this.JsonError(result.Errors?.ToArray(), HttpStatusCode.InternalServerError, tempData: result.Data);
        }

        [HttpPost]
        [ActionName("update")]
        public ActionResult Update([FromBody] CartItemDto cartItem)
        {
            var result = this.cartRepository.UpdateProductVariantQuantity(cartItem.ProductId, cartItem.VariantId, cartItem.Quantity);

            if (result.Success)
            {
                return this.JsonOk(result.Data);
            }

            return this.JsonError(result.Errors?.ToArray(), HttpStatusCode.InternalServerError, tempData: result.Data);
        }

        [HttpPost]
        [ActionName("addpromo")]
        public ActionResult AddPromoCode([FromBody] PromoCodeDto data)
        {
            var result = this.cartRepository.AddPromoCode(data.PromoCode);

            if (result.Success)
            {
                return this.JsonOk(result.Data);
            }

            return this.JsonError(result.Errors?.ToArray(), HttpStatusCode.InternalServerError, tempData: result.Data);
        }

        [HttpDelete]
        [ActionName("remove")]
        public ActionResult DeleteVariant(string cartLineId)
        {
            var result = this.cartRepository.RemoveProductVariantFromCart(cartLineId);
            if (result.Success)
            {
                return this.JsonOk(result.Data);
            }

            return this.JsonError(result.Errors?.ToArray(), HttpStatusCode.InternalServerError, tempData: result.Data);
        }
    }
}
