﻿//    Copyright 2020 EPAM Systems, Inc.
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

namespace Wooli.Feature.Account.Controllers
{
    using System.Web.Mvc;

    using Foundation.Base.Services.Tracking;
    using Foundation.Commerce.Context;
    using Foundation.Commerce.Controllers;
    using Foundation.Commerce.Models.Entities.Addresses;
    using Foundation.Commerce.Services.Account;

    using Mappers;

    using Models.Requests;

    using Sitecore.Diagnostics;

    public class AccountsController : BaseController
    {
        private readonly IAccountService accountService;

        private readonly IAccountEntityMapper entityMapper;

        private readonly ITrackingService trackingService;

        private readonly IVisitorContext visitorContext;

        public AccountsController(
            IAccountService accountService,
            IAccountEntityMapper entityMapper,
            IVisitorContext visitorContext,
            ITrackingService trackingService)
        {
            Assert.ArgumentNotNull(accountService, nameof(accountService));
            Assert.ArgumentNotNull(entityMapper, nameof(entityMapper));
            Assert.ArgumentNotNull(visitorContext, nameof(visitorContext));
            Assert.ArgumentNotNull(trackingService, nameof(trackingService));

            this.accountService = accountService;
            this.entityMapper = entityMapper;
            this.visitorContext = visitorContext;
            this.trackingService = trackingService;
        }

        [HttpPost]
        [Authorize]
        [ActionName("address")]
        public ActionResult AddAddress(AddressRequest request)
        {
            return this.Execute(
                () => this.accountService.AddAddress(
                    this.visitorContext.ContactId,
                    this.entityMapper.Map<AddressRequest, Address>(request)));
        }

        [HttpPut]
        [Authorize]
        [ActionName("password")]
        public ActionResult ChangePassword(ChangePasswordRequest request)
        {
            return this.Execute(
                () =>
                {
                    this.trackingService.EnsureTracker();
                    return this.accountService.ChangePassword(request.Email, request.NewPassword, request.OldPassword);
                });
        }

        [HttpPost]
        [AllowAnonymous]
        [ActionName("account")]
        public ActionResult CreateAccount(CreateAccountRequest requests)
        {
            return this.Execute(
                () =>
                {
                    this.trackingService.EnsureTracker();
                    return this.accountService.CreateAccount(
                        requests.Email,
                        requests.FirstName,
                        requests.LastName,
                        requests.Password);
                });
        }

        [HttpGet]
        [AllowAnonymous]
        [ActionName("address")]
        public ActionResult GetAddress()
        {
            return this.Execute(() => this.accountService.GetAddress(this.visitorContext.ContactId));
        }

        [HttpDelete]
        [Authorize]
        [ActionName("address")]
        public ActionResult RemoveAddress(AddressRequest request)
        {
            return this.Execute(
                () => this.accountService.RemoveAddress(
                    this.visitorContext.ContactId,
                    this.entityMapper.Map<AddressRequest, Address>(request)));
        }

        [HttpPut]
        [Authorize]
        [ActionName("address")]
        public ActionResult UpdateAddress(AddressRequest request)
        {
            return this.Execute(
                () => this.accountService.UpdateAddress(
                    this.visitorContext.ContactId,
                    this.entityMapper.Map<AddressRequest, Address>(request)));
        }

        [HttpPut]
        [Authorize]
        [ActionName("account")]
        public ActionResult UpdateAccount(UpdateAccountRequest request)
        {
            return this.Execute(
                () => this.accountService.UpdateAccount(request.ContactId, request.FirstName, request.LastName));
        }

        [HttpPost]
        [AllowAnonymous]
        [ActionName("validate")]
        public ActionResult ValidateEmail(ValidateEmailRequest request)
        {
            return this.Execute(() => this.accountService.ValidateEmail(request.Email));
        }
    }
}