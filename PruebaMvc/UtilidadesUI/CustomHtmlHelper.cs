using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace PruebaMvc.UtilidadesUI
{
	public static class CustomHtmlHelper
	{
		public static MvcHtmlString RequiredLabelFor<TModel, TValue>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TValue>> expression, object htmlAttributes = null)
		{
			var data = ModelMetadata.FromLambdaExpression(expression, helper.ViewData);

			string htmlFieldName = ExpressionHelper.GetExpressionText(expression);

			string labelText = data.DisplayName ?? data.PropertyName ?? htmlFieldName.Split('.').Last();

			if (String.IsNullOrEmpty(labelText))
			{
				return MvcHtmlString.Empty;
			}

			TagBuilder label = new TagBuilder("label");

			if (htmlAttributes != null)
			{
				var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
				label.MergeAttributes(attributes);
			}

			label.Attributes.Add("for", helper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldId(htmlFieldName));

			TagBuilder span = new TagBuilder("span");
			span.Attributes.Add("class", "text-error");
			span.SetInnerText("*");

			label.InnerHtml = string.Format("{0} {1}", helper.Encode(labelText), span.ToString());

			return new MvcHtmlString(label.ToString());
		}
	}
}