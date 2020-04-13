//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.5.4
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "baseContent"
	/// <summary>BaseContent</summary>
	public partial interface IBaseContent : IPublishedContent
	{
		/// <summary>Picture</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		global::Umbraco.Core.Models.PublishedContent.IPublishedContent Picture { get; }

		/// <summary>Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		string Title { get; }
	}

	/// <summary>BaseContent</summary>
	[PublishedModel("baseContent")]
	public partial class BaseContent : PublishedContentModel, IBaseContent
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		public new const string ModelTypeAlias = "baseContent";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BaseContent, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public BaseContent(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Picture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		[ImplementPropertyType("picture")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent Picture => GetPicture(this);

		/// <summary>Static getter for Picture</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		public static global::Umbraco.Core.Models.PublishedContent.IPublishedContent GetPicture(IBaseContent that) => that.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("picture");

		///<summary>
		/// Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		[ImplementPropertyType("title")]
		public string Title => GetTitle(this);

		/// <summary>Static getter for Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		public static string GetTitle(IBaseContent that) => that.Value<string>("title");
	}
}