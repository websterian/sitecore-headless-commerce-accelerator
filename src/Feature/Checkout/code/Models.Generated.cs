#pragma warning disable 1591
#pragma warning disable 0108
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Rainbow JS CodeGeneration.
//     (https://github.com/asmagin/rainbow-js-codegeneration)
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wooli.Feature.Checkout.Models
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Text;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using Glass.Mapper.Sc.Configuration;
    using Glass.Mapper.Sc.Fields;
    using Sitecore.Globalization;
    using Sitecore.Data;
    using Sitecore.Data.Items;

    using System.CodeDom.Compiler;
    using Wooli.Foundation.GlassMapper.Models;


    /// <summary>
    /// ICheckoutNavigation Interface
    /// <para>Path: /sitecore/templates/Wooli/Feature/Checkout/Data Sources/Checkout Navigation</para>
    /// <para>ID: 57cfa14b-718e-43c4-a1e0-5553ec8000b8</para>
    /// </summary>
    [SitecoreType(TemplateId="57cfa14b-718e-43c4-a1e0-5553ec8000b8")]
    public partial interface ICheckoutNavigation: IGlassBase
    {

        /// <summary>
        /// The  field.
        /// <para>Field Type: General Link</para>
        /// <para>Field ID: cb7502d8-cf47-4919-a528-ac7dcc1b636a</para>
        /// </summary>
        [SitecoreField("Back To Link")]
        Link BackToLink {get; set;}

        /// <summary>
        /// The  field.
        /// <para>Field Type: Multilist</para>
        /// <para>Field ID: 55a6fd7a-07be-4fcd-ab3a-138b4ecbdc6b</para>
        /// </summary>
        [SitecoreField("Checkout Steps")]
        IEnumerable<Guid> CheckoutSteps {get; set;}

        /// <summary>
        /// The  field.
        /// <para>Field Type: General Link</para>
        /// <para>Field ID: da2a953e-b11a-4be5-8dba-f2e2c45233b8</para>
        /// </summary>
        [SitecoreField("Info Link")]
        Link InfoLink {get; set;}

    }


    /// <summary>
    /// CheckoutNavigation Class
    /// <para>Path: /sitecore/templates/Wooli/Feature/Checkout/Data Sources/Checkout Navigation</para>
    /// <para>ID: 57cfa14b-718e-43c4-a1e0-5553ec8000b8</para>
    /// </summary>
    [SitecoreType(TemplateId="57cfa14b-718e-43c4-a1e0-5553ec8000b8")]
    public partial class CheckoutNavigation: GlassBase, ICheckoutNavigation
    {
        /// <summary>
        /// The TemplateId string for /sitecore/templates/Wooli/Feature/Checkout/Data Sources/Checkout Navigation
        /// </summary>
        public const string TemplateId = "57cfa14b-718e-43c4-a1e0-5553ec8000b8";

        /// <summary>
        /// The Back To Link field.
        /// <para>Field Type: General Link</para>
        /// <para>Field ID: cb7502d8-cf47-4919-a528-ac7dcc1b636a</para>
        /// </summary>
        [SitecoreField("Back To Link")]
        public Link BackToLink {get; set;}
        public const string BackToLinkFieldId = "cb7502d8-cf47-4919-a528-ac7dcc1b636a";
        public const string BackToLinkFieldName = "Back To Link";

        /// <summary>
        /// The Checkout Steps field.
        /// <para>Field Type: Multilist</para>
        /// <para>Field ID: 55a6fd7a-07be-4fcd-ab3a-138b4ecbdc6b</para>
        /// </summary>
        [SitecoreField("Checkout Steps")]
        public IEnumerable<Guid> CheckoutSteps {get; set;}
        public const string CheckoutStepsFieldId = "55a6fd7a-07be-4fcd-ab3a-138b4ecbdc6b";
        public const string CheckoutStepsFieldName = "Checkout Steps";

        /// <summary>
        /// The Info Link field.
        /// <para>Field Type: General Link</para>
        /// <para>Field ID: da2a953e-b11a-4be5-8dba-f2e2c45233b8</para>
        /// </summary>
        [SitecoreField("Info Link")]
        public Link InfoLink {get; set;}
        public const string InfoLinkFieldId = "da2a953e-b11a-4be5-8dba-f2e2c45233b8";
        public const string InfoLinkFieldName = "Info Link";

    }


    /// <summary>
    /// ICheckoutStep Interface
    /// <para>Path: /sitecore/templates/Wooli/Feature/Checkout/Abstract/_Checkout Step</para>
    /// <para>ID: 41bec638-40fe-4a75-ace5-f3377299d8fa</para>
    /// </summary>
    [SitecoreType(TemplateId="41bec638-40fe-4a75-ace5-f3377299d8fa")]
    public partial interface ICheckoutStep: IGlassBase
    {

        /// <summary>
        /// The  field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: 69f49102-c8c0-4e55-8f8e-c9cb130071e4</para>
        /// </summary>
        [SitecoreField("Checkout Step Name")]
        string CheckoutStepName {get; set;}

    }


    /// <summary>
    /// CheckoutStep Class
    /// <para>Path: /sitecore/templates/Wooli/Feature/Checkout/Abstract/_Checkout Step</para>
    /// <para>ID: 41bec638-40fe-4a75-ace5-f3377299d8fa</para>
    /// </summary>
    [SitecoreType(TemplateId="41bec638-40fe-4a75-ace5-f3377299d8fa")]
    public partial class CheckoutStep: GlassBase, ICheckoutStep
    {
        /// <summary>
        /// The TemplateId string for /sitecore/templates/Wooli/Feature/Checkout/Abstract/_Checkout Step
        /// </summary>
        public const string TemplateId = "41bec638-40fe-4a75-ace5-f3377299d8fa";

        /// <summary>
        /// The Checkout Step Name field.
        /// <para>Field Type: Single-Line Text</para>
        /// <para>Field ID: 69f49102-c8c0-4e55-8f8e-c9cb130071e4</para>
        /// </summary>
        [SitecoreField("Checkout Step Name")]
        public string CheckoutStepName {get; set;}
        public const string CheckoutStepNameFieldId = "69f49102-c8c0-4e55-8f8e-c9cb130071e4";
        public const string CheckoutStepNameFieldName = "Checkout Step Name";

    }

}