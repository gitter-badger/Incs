

using WebAssembly.Browser.DOM;
using System;
using System.Linq;
namespace Monsajem_Incs.Resources
{



	
namespace Html
{
	public class a_html
	{
		public static readonly string HtmlText = ((Func<string>)(() =>
		{
			byte[] ByteResult = null;
			var Result =
@"<html><head></head><body><a id=""Main"">
</a></body></html>";
			var Doc = Document.Parse(Result);
			var Elements = Doc.GetElementsByTagName("*").ToArray();
			foreach(var Element in Elements)
			{
				var MNsrc = Element.GetAttribute("MNsrc");
				if (MNsrc == "")
				MNsrc = null;
				if (MNsrc != null)
				{
					Element.RemoveAttribute("MNsrc");
					var TagName = Element.TagName.ToLower();
					switch(TagName)
					{
						case "script":
							Element.InnerHtml = (string)Type.GetType(MNsrc).GetField("TextContent").GetValue(null);
							break;
						case "img":
							Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
							break;
						case "link":
							if (Element.GetAttribute("type").ToLower() == "text/css")
							{
								var Style = Document.document.CreateElement<HTMLStyleElement>();
								Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
								Element.ParentElement.ReplaceChild(Style, Element);
							}
							break;
					}
				}
			}
			Result = "<html>\"" +"<head>" + Doc.GetElementsByTagName("head")[0].InnerHtml + "</head>" +"<body>" + Doc.GetElementsByTagName("body")[0].InnerHtml + "</body></html>";
			return Result;
		}))();

		public readonly HTMLElement Main;
		public a_html():this(false){}
		public a_html(bool IsGlobal)
		{
			if(IsGlobal==true)
			{
				var Document = new Document();
				Main= Document.GetElementById<HTMLElement>("Main");
				return;
			}
			var doc =  Document.Parse(HtmlText);
			var HeadTags = doc.Head.GetElementsByTagName("*").ToArray();
			foreach(var Tag in HeadTags)
			Document.document.Head.AppendChild(Tag);
			Main= doc.GetElementById<HTMLElement>("Main");
			var div = Document.document.CreateElement("Div");
			div.AppendChild(doc.Body);
			var Scripts = div.GetElementsByTagName("Script").ToArray();
			foreach(var Script in Scripts)
			{
				var NewScript = Document.document.CreateElement("Script");
				var Src = Script.GetAttribute("src");
				if(Src!=null)
					NewScript.SetAttribute("src",Src);
				NewScript.InnerHtml = Script.InnerHtml;
				Script.ParentElement.ReplaceChild(NewScript, Script);
			}
			div.SetStyleAttribute("display","none");
			Document.document.Body.AppendChild(div);
			Document.document.Body.RemoveChild(div);
			Main.Id="";
		}
	
	}
	public class button_html
	{
		public static readonly string HtmlText = ((Func<string>)(() =>
		{
			byte[] ByteResult = null;
			var Result =
@"<html><head></head><body><button id=""Main""></button></body></html>";
			var Doc = Document.Parse(Result);
			var Elements = Doc.GetElementsByTagName("*").ToArray();
			foreach(var Element in Elements)
			{
				var MNsrc = Element.GetAttribute("MNsrc");
				if (MNsrc == "")
				MNsrc = null;
				if (MNsrc != null)
				{
					Element.RemoveAttribute("MNsrc");
					var TagName = Element.TagName.ToLower();
					switch(TagName)
					{
						case "script":
							Element.InnerHtml = (string)Type.GetType(MNsrc).GetField("TextContent").GetValue(null);
							break;
						case "img":
							Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
							break;
						case "link":
							if (Element.GetAttribute("type").ToLower() == "text/css")
							{
								var Style = Document.document.CreateElement<HTMLStyleElement>();
								Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
								Element.ParentElement.ReplaceChild(Style, Element);
							}
							break;
					}
				}
			}
			Result = "<html>\"" +"<head>" + Doc.GetElementsByTagName("head")[0].InnerHtml + "</head>" +"<body>" + Doc.GetElementsByTagName("body")[0].InnerHtml + "</body></html>";
			return Result;
		}))();

		public readonly HTMLButtonElement Main;
		public button_html():this(false){}
		public button_html(bool IsGlobal)
		{
			if(IsGlobal==true)
			{
				var Document = new Document();
				Main= Document.GetElementById<HTMLButtonElement>("Main");
				return;
			}
			var doc =  Document.Parse(HtmlText);
			var HeadTags = doc.Head.GetElementsByTagName("*").ToArray();
			foreach(var Tag in HeadTags)
			Document.document.Head.AppendChild(Tag);
			Main= doc.GetElementById<HTMLButtonElement>("Main");
			var div = Document.document.CreateElement("Div");
			div.AppendChild(doc.Body);
			var Scripts = div.GetElementsByTagName("Script").ToArray();
			foreach(var Script in Scripts)
			{
				var NewScript = Document.document.CreateElement("Script");
				var Src = Script.GetAttribute("src");
				if(Src!=null)
					NewScript.SetAttribute("src",Src);
				NewScript.InnerHtml = Script.InnerHtml;
				Script.ParentElement.ReplaceChild(NewScript, Script);
			}
			div.SetStyleAttribute("display","none");
			Document.document.Body.AppendChild(div);
			Document.document.Body.RemoveChild(div);
			Main.Id="";
		}
	
	}
	public class Div_html
	{
		public static readonly string HtmlText = ((Func<string>)(() =>
		{
			byte[] ByteResult = null;
			var Result =
@"<html><head></head><body><div id=""Main"">
</div></body></html>";
			var Doc = Document.Parse(Result);
			var Elements = Doc.GetElementsByTagName("*").ToArray();
			foreach(var Element in Elements)
			{
				var MNsrc = Element.GetAttribute("MNsrc");
				if (MNsrc == "")
				MNsrc = null;
				if (MNsrc != null)
				{
					Element.RemoveAttribute("MNsrc");
					var TagName = Element.TagName.ToLower();
					switch(TagName)
					{
						case "script":
							Element.InnerHtml = (string)Type.GetType(MNsrc).GetField("TextContent").GetValue(null);
							break;
						case "img":
							Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
							break;
						case "link":
							if (Element.GetAttribute("type").ToLower() == "text/css")
							{
								var Style = Document.document.CreateElement<HTMLStyleElement>();
								Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
								Element.ParentElement.ReplaceChild(Style, Element);
							}
							break;
					}
				}
			}
			Result = "<html>\"" +"<head>" + Doc.GetElementsByTagName("head")[0].InnerHtml + "</head>" +"<body>" + Doc.GetElementsByTagName("body")[0].InnerHtml + "</body></html>";
			return Result;
		}))();

		public readonly HTMLDivElement Main;
		public Div_html():this(false){}
		public Div_html(bool IsGlobal)
		{
			if(IsGlobal==true)
			{
				var Document = new Document();
				Main= Document.GetElementById<HTMLDivElement>("Main");
				return;
			}
			var doc =  Document.Parse(HtmlText);
			var HeadTags = doc.Head.GetElementsByTagName("*").ToArray();
			foreach(var Tag in HeadTags)
			Document.document.Head.AppendChild(Tag);
			Main= doc.GetElementById<HTMLDivElement>("Main");
			var div = Document.document.CreateElement("Div");
			div.AppendChild(doc.Body);
			var Scripts = div.GetElementsByTagName("Script").ToArray();
			foreach(var Script in Scripts)
			{
				var NewScript = Document.document.CreateElement("Script");
				var Src = Script.GetAttribute("src");
				if(Src!=null)
					NewScript.SetAttribute("src",Src);
				NewScript.InnerHtml = Script.InnerHtml;
				Script.ParentElement.ReplaceChild(NewScript, Script);
			}
			div.SetStyleAttribute("display","none");
			Document.document.Body.AppendChild(div);
			Document.document.Body.RemoveChild(div);
			Main.Id="";
		}
	
	}
	public class Img_html
	{
		public static readonly string HtmlText = ((Func<string>)(() =>
		{
			byte[] ByteResult = null;
			var Result =
@"<html><head></head><body><img id=""Main""></body></html>";
			var Doc = Document.Parse(Result);
			var Elements = Doc.GetElementsByTagName("*").ToArray();
			foreach(var Element in Elements)
			{
				var MNsrc = Element.GetAttribute("MNsrc");
				if (MNsrc == "")
				MNsrc = null;
				if (MNsrc != null)
				{
					Element.RemoveAttribute("MNsrc");
					var TagName = Element.TagName.ToLower();
					switch(TagName)
					{
						case "script":
							Element.InnerHtml = (string)Type.GetType(MNsrc).GetField("TextContent").GetValue(null);
							break;
						case "img":
							Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
							break;
						case "link":
							if (Element.GetAttribute("type").ToLower() == "text/css")
							{
								var Style = Document.document.CreateElement<HTMLStyleElement>();
								Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
								Element.ParentElement.ReplaceChild(Style, Element);
							}
							break;
					}
				}
			}
			Result = "<html>\"" +"<head>" + Doc.GetElementsByTagName("head")[0].InnerHtml + "</head>" +"<body>" + Doc.GetElementsByTagName("body")[0].InnerHtml + "</body></html>";
			return Result;
		}))();

		public readonly HTMLImageElement Main;
		public Img_html():this(false){}
		public Img_html(bool IsGlobal)
		{
			if(IsGlobal==true)
			{
				var Document = new Document();
				Main= Document.GetElementById<HTMLImageElement>("Main");
				return;
			}
			var doc =  Document.Parse(HtmlText);
			var HeadTags = doc.Head.GetElementsByTagName("*").ToArray();
			foreach(var Tag in HeadTags)
			Document.document.Head.AppendChild(Tag);
			Main= doc.GetElementById<HTMLImageElement>("Main");
			var div = Document.document.CreateElement("Div");
			div.AppendChild(doc.Body);
			var Scripts = div.GetElementsByTagName("Script").ToArray();
			foreach(var Script in Scripts)
			{
				var NewScript = Document.document.CreateElement("Script");
				var Src = Script.GetAttribute("src");
				if(Src!=null)
					NewScript.SetAttribute("src",Src);
				NewScript.InnerHtml = Script.InnerHtml;
				Script.ParentElement.ReplaceChild(NewScript, Script);
			}
			div.SetStyleAttribute("display","none");
			Document.document.Body.AppendChild(div);
			Document.document.Body.RemoveChild(div);
			Main.Id="";
		}
	
	}
	public class input_html
	{
		public static readonly string HtmlText = ((Func<string>)(() =>
		{
			byte[] ByteResult = null;
			var Result =
@"<html><head></head><body><input id=""Main""></body></html>";
			var Doc = Document.Parse(Result);
			var Elements = Doc.GetElementsByTagName("*").ToArray();
			foreach(var Element in Elements)
			{
				var MNsrc = Element.GetAttribute("MNsrc");
				if (MNsrc == "")
				MNsrc = null;
				if (MNsrc != null)
				{
					Element.RemoveAttribute("MNsrc");
					var TagName = Element.TagName.ToLower();
					switch(TagName)
					{
						case "script":
							Element.InnerHtml = (string)Type.GetType(MNsrc).GetField("TextContent").GetValue(null);
							break;
						case "img":
							Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
							break;
						case "link":
							if (Element.GetAttribute("type").ToLower() == "text/css")
							{
								var Style = Document.document.CreateElement<HTMLStyleElement>();
								Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
								Element.ParentElement.ReplaceChild(Style, Element);
							}
							break;
					}
				}
			}
			Result = "<html>\"" +"<head>" + Doc.GetElementsByTagName("head")[0].InnerHtml + "</head>" +"<body>" + Doc.GetElementsByTagName("body")[0].InnerHtml + "</body></html>";
			return Result;
		}))();

		public readonly HTMLInputElement Main;
		public input_html():this(false){}
		public input_html(bool IsGlobal)
		{
			if(IsGlobal==true)
			{
				var Document = new Document();
				Main= Document.GetElementById<HTMLInputElement>("Main");
				return;
			}
			var doc =  Document.Parse(HtmlText);
			var HeadTags = doc.Head.GetElementsByTagName("*").ToArray();
			foreach(var Tag in HeadTags)
			Document.document.Head.AppendChild(Tag);
			Main= doc.GetElementById<HTMLInputElement>("Main");
			var div = Document.document.CreateElement("Div");
			div.AppendChild(doc.Body);
			var Scripts = div.GetElementsByTagName("Script").ToArray();
			foreach(var Script in Scripts)
			{
				var NewScript = Document.document.CreateElement("Script");
				var Src = Script.GetAttribute("src");
				if(Src!=null)
					NewScript.SetAttribute("src",Src);
				NewScript.InnerHtml = Script.InnerHtml;
				Script.ParentElement.ReplaceChild(NewScript, Script);
			}
			div.SetStyleAttribute("display","none");
			Document.document.Body.AppendChild(div);
			Document.document.Body.RemoveChild(div);
			Main.Id="";
		}
	
	}
	public class input_button_html
	{
		public static readonly string HtmlText = ((Func<string>)(() =>
		{
			byte[] ByteResult = null;
			var Result =
@"<html><head></head><body><input type=""button"" id=""Main""></body></html>";
			var Doc = Document.Parse(Result);
			var Elements = Doc.GetElementsByTagName("*").ToArray();
			foreach(var Element in Elements)
			{
				var MNsrc = Element.GetAttribute("MNsrc");
				if (MNsrc == "")
				MNsrc = null;
				if (MNsrc != null)
				{
					Element.RemoveAttribute("MNsrc");
					var TagName = Element.TagName.ToLower();
					switch(TagName)
					{
						case "script":
							Element.InnerHtml = (string)Type.GetType(MNsrc).GetField("TextContent").GetValue(null);
							break;
						case "img":
							Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
							break;
						case "link":
							if (Element.GetAttribute("type").ToLower() == "text/css")
							{
								var Style = Document.document.CreateElement<HTMLStyleElement>();
								Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
								Element.ParentElement.ReplaceChild(Style, Element);
							}
							break;
					}
				}
			}
			Result = "<html>\"" +"<head>" + Doc.GetElementsByTagName("head")[0].InnerHtml + "</head>" +"<body>" + Doc.GetElementsByTagName("body")[0].InnerHtml + "</body></html>";
			return Result;
		}))();

		public readonly HTMLInputElement Main;
		public input_button_html():this(false){}
		public input_button_html(bool IsGlobal)
		{
			if(IsGlobal==true)
			{
				var Document = new Document();
				Main= Document.GetElementById<HTMLInputElement>("Main");
				return;
			}
			var doc =  Document.Parse(HtmlText);
			var HeadTags = doc.Head.GetElementsByTagName("*").ToArray();
			foreach(var Tag in HeadTags)
			Document.document.Head.AppendChild(Tag);
			Main= doc.GetElementById<HTMLInputElement>("Main");
			var div = Document.document.CreateElement("Div");
			div.AppendChild(doc.Body);
			var Scripts = div.GetElementsByTagName("Script").ToArray();
			foreach(var Script in Scripts)
			{
				var NewScript = Document.document.CreateElement("Script");
				var Src = Script.GetAttribute("src");
				if(Src!=null)
					NewScript.SetAttribute("src",Src);
				NewScript.InnerHtml = Script.InnerHtml;
				Script.ParentElement.ReplaceChild(NewScript, Script);
			}
			div.SetStyleAttribute("display","none");
			Document.document.Body.AppendChild(div);
			Document.document.Body.RemoveChild(div);
			Main.Id="";
		}
	
	}
	public class input_CheckBox_html
	{
		public static readonly string HtmlText = ((Func<string>)(() =>
		{
			byte[] ByteResult = null;
			var Result =
@"<html><head></head><body><input type=""checkbox"" id=""Main""></body></html>";
			var Doc = Document.Parse(Result);
			var Elements = Doc.GetElementsByTagName("*").ToArray();
			foreach(var Element in Elements)
			{
				var MNsrc = Element.GetAttribute("MNsrc");
				if (MNsrc == "")
				MNsrc = null;
				if (MNsrc != null)
				{
					Element.RemoveAttribute("MNsrc");
					var TagName = Element.TagName.ToLower();
					switch(TagName)
					{
						case "script":
							Element.InnerHtml = (string)Type.GetType(MNsrc).GetField("TextContent").GetValue(null);
							break;
						case "img":
							Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
							break;
						case "link":
							if (Element.GetAttribute("type").ToLower() == "text/css")
							{
								var Style = Document.document.CreateElement<HTMLStyleElement>();
								Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
								Element.ParentElement.ReplaceChild(Style, Element);
							}
							break;
					}
				}
			}
			Result = "<html>\"" +"<head>" + Doc.GetElementsByTagName("head")[0].InnerHtml + "</head>" +"<body>" + Doc.GetElementsByTagName("body")[0].InnerHtml + "</body></html>";
			return Result;
		}))();

		public readonly HTMLInputElement Main;
		public input_CheckBox_html():this(false){}
		public input_CheckBox_html(bool IsGlobal)
		{
			if(IsGlobal==true)
			{
				var Document = new Document();
				Main= Document.GetElementById<HTMLInputElement>("Main");
				return;
			}
			var doc =  Document.Parse(HtmlText);
			var HeadTags = doc.Head.GetElementsByTagName("*").ToArray();
			foreach(var Tag in HeadTags)
			Document.document.Head.AppendChild(Tag);
			Main= doc.GetElementById<HTMLInputElement>("Main");
			var div = Document.document.CreateElement("Div");
			div.AppendChild(doc.Body);
			var Scripts = div.GetElementsByTagName("Script").ToArray();
			foreach(var Script in Scripts)
			{
				var NewScript = Document.document.CreateElement("Script");
				var Src = Script.GetAttribute("src");
				if(Src!=null)
					NewScript.SetAttribute("src",Src);
				NewScript.InnerHtml = Script.InnerHtml;
				Script.ParentElement.ReplaceChild(NewScript, Script);
			}
			div.SetStyleAttribute("display","none");
			Document.document.Body.AppendChild(div);
			Document.document.Body.RemoveChild(div);
			Main.Id="";
		}
	
	}
	public class input_File_html
	{
		public static readonly string HtmlText = ((Func<string>)(() =>
		{
			byte[] ByteResult = null;
			var Result =
@"<html><head></head><body><input type=""file"" id=""Main""></body></html>";
			var Doc = Document.Parse(Result);
			var Elements = Doc.GetElementsByTagName("*").ToArray();
			foreach(var Element in Elements)
			{
				var MNsrc = Element.GetAttribute("MNsrc");
				if (MNsrc == "")
				MNsrc = null;
				if (MNsrc != null)
				{
					Element.RemoveAttribute("MNsrc");
					var TagName = Element.TagName.ToLower();
					switch(TagName)
					{
						case "script":
							Element.InnerHtml = (string)Type.GetType(MNsrc).GetField("TextContent").GetValue(null);
							break;
						case "img":
							Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
							break;
						case "link":
							if (Element.GetAttribute("type").ToLower() == "text/css")
							{
								var Style = Document.document.CreateElement<HTMLStyleElement>();
								Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
								Element.ParentElement.ReplaceChild(Style, Element);
							}
							break;
					}
				}
			}
			Result = "<html>\"" +"<head>" + Doc.GetElementsByTagName("head")[0].InnerHtml + "</head>" +"<body>" + Doc.GetElementsByTagName("body")[0].InnerHtml + "</body></html>";
			return Result;
		}))();

		public readonly HTMLInputElement Main;
		public input_File_html():this(false){}
		public input_File_html(bool IsGlobal)
		{
			if(IsGlobal==true)
			{
				var Document = new Document();
				Main= Document.GetElementById<HTMLInputElement>("Main");
				return;
			}
			var doc =  Document.Parse(HtmlText);
			var HeadTags = doc.Head.GetElementsByTagName("*").ToArray();
			foreach(var Tag in HeadTags)
			Document.document.Head.AppendChild(Tag);
			Main= doc.GetElementById<HTMLInputElement>("Main");
			var div = Document.document.CreateElement("Div");
			div.AppendChild(doc.Body);
			var Scripts = div.GetElementsByTagName("Script").ToArray();
			foreach(var Script in Scripts)
			{
				var NewScript = Document.document.CreateElement("Script");
				var Src = Script.GetAttribute("src");
				if(Src!=null)
					NewScript.SetAttribute("src",Src);
				NewScript.InnerHtml = Script.InnerHtml;
				Script.ParentElement.ReplaceChild(NewScript, Script);
			}
			div.SetStyleAttribute("display","none");
			Document.document.Body.AppendChild(div);
			Document.document.Body.RemoveChild(div);
			Main.Id="";
		}
	
	}
	public class input_tel_html
	{
		public static readonly string HtmlText = ((Func<string>)(() =>
		{
			byte[] ByteResult = null;
			var Result =
@"<html><head></head><body><input type=""tel"" id=""Main""></body></html>";
			var Doc = Document.Parse(Result);
			var Elements = Doc.GetElementsByTagName("*").ToArray();
			foreach(var Element in Elements)
			{
				var MNsrc = Element.GetAttribute("MNsrc");
				if (MNsrc == "")
				MNsrc = null;
				if (MNsrc != null)
				{
					Element.RemoveAttribute("MNsrc");
					var TagName = Element.TagName.ToLower();
					switch(TagName)
					{
						case "script":
							Element.InnerHtml = (string)Type.GetType(MNsrc).GetField("TextContent").GetValue(null);
							break;
						case "img":
							Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
							break;
						case "link":
							if (Element.GetAttribute("type").ToLower() == "text/css")
							{
								var Style = Document.document.CreateElement<HTMLStyleElement>();
								Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
								Element.ParentElement.ReplaceChild(Style, Element);
							}
							break;
					}
				}
			}
			Result = "<html>\"" +"<head>" + Doc.GetElementsByTagName("head")[0].InnerHtml + "</head>" +"<body>" + Doc.GetElementsByTagName("body")[0].InnerHtml + "</body></html>";
			return Result;
		}))();

		public readonly HTMLInputElement Main;
		public input_tel_html():this(false){}
		public input_tel_html(bool IsGlobal)
		{
			if(IsGlobal==true)
			{
				var Document = new Document();
				Main= Document.GetElementById<HTMLInputElement>("Main");
				return;
			}
			var doc =  Document.Parse(HtmlText);
			var HeadTags = doc.Head.GetElementsByTagName("*").ToArray();
			foreach(var Tag in HeadTags)
			Document.document.Head.AppendChild(Tag);
			Main= doc.GetElementById<HTMLInputElement>("Main");
			var div = Document.document.CreateElement("Div");
			div.AppendChild(doc.Body);
			var Scripts = div.GetElementsByTagName("Script").ToArray();
			foreach(var Script in Scripts)
			{
				var NewScript = Document.document.CreateElement("Script");
				var Src = Script.GetAttribute("src");
				if(Src!=null)
					NewScript.SetAttribute("src",Src);
				NewScript.InnerHtml = Script.InnerHtml;
				Script.ParentElement.ReplaceChild(NewScript, Script);
			}
			div.SetStyleAttribute("display","none");
			Document.document.Body.AppendChild(div);
			Document.document.Body.RemoveChild(div);
			Main.Id="";
		}
	
	}
	public class input_Text_html
	{
		public static readonly string HtmlText = ((Func<string>)(() =>
		{
			byte[] ByteResult = null;
			var Result =
@"<html><head></head><body><input type=""text"" id=""Main""></body></html>";
			var Doc = Document.Parse(Result);
			var Elements = Doc.GetElementsByTagName("*").ToArray();
			foreach(var Element in Elements)
			{
				var MNsrc = Element.GetAttribute("MNsrc");
				if (MNsrc == "")
				MNsrc = null;
				if (MNsrc != null)
				{
					Element.RemoveAttribute("MNsrc");
					var TagName = Element.TagName.ToLower();
					switch(TagName)
					{
						case "script":
							Element.InnerHtml = (string)Type.GetType(MNsrc).GetField("TextContent").GetValue(null);
							break;
						case "img":
							Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
							break;
						case "link":
							if (Element.GetAttribute("type").ToLower() == "text/css")
							{
								var Style = Document.document.CreateElement<HTMLStyleElement>();
								Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
								Element.ParentElement.ReplaceChild(Style, Element);
							}
							break;
					}
				}
			}
			Result = "<html>\"" +"<head>" + Doc.GetElementsByTagName("head")[0].InnerHtml + "</head>" +"<body>" + Doc.GetElementsByTagName("body")[0].InnerHtml + "</body></html>";
			return Result;
		}))();

		public readonly HTMLInputElement Main;
		public input_Text_html():this(false){}
		public input_Text_html(bool IsGlobal)
		{
			if(IsGlobal==true)
			{
				var Document = new Document();
				Main= Document.GetElementById<HTMLInputElement>("Main");
				return;
			}
			var doc =  Document.Parse(HtmlText);
			var HeadTags = doc.Head.GetElementsByTagName("*").ToArray();
			foreach(var Tag in HeadTags)
			Document.document.Head.AppendChild(Tag);
			Main= doc.GetElementById<HTMLInputElement>("Main");
			var div = Document.document.CreateElement("Div");
			div.AppendChild(doc.Body);
			var Scripts = div.GetElementsByTagName("Script").ToArray();
			foreach(var Script in Scripts)
			{
				var NewScript = Document.document.CreateElement("Script");
				var Src = Script.GetAttribute("src");
				if(Src!=null)
					NewScript.SetAttribute("src",Src);
				NewScript.InnerHtml = Script.InnerHtml;
				Script.ParentElement.ReplaceChild(NewScript, Script);
			}
			div.SetStyleAttribute("display","none");
			Document.document.Body.AppendChild(div);
			Document.document.Body.RemoveChild(div);
			Main.Id="";
		}
	
	}
	public class Script_html
	{
		public static readonly string HtmlText = ((Func<string>)(() =>
		{
			byte[] ByteResult = null;
			var Result =
@"<html><head><script id=""Main"">
</script></head><body></body></html>";
			var Doc = Document.Parse(Result);
			var Elements = Doc.GetElementsByTagName("*").ToArray();
			foreach(var Element in Elements)
			{
				var MNsrc = Element.GetAttribute("MNsrc");
				if (MNsrc == "")
				MNsrc = null;
				if (MNsrc != null)
				{
					Element.RemoveAttribute("MNsrc");
					var TagName = Element.TagName.ToLower();
					switch(TagName)
					{
						case "script":
							Element.InnerHtml = (string)Type.GetType(MNsrc).GetField("TextContent").GetValue(null);
							break;
						case "img":
							Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
							break;
						case "link":
							if (Element.GetAttribute("type").ToLower() == "text/css")
							{
								var Style = Document.document.CreateElement<HTMLStyleElement>();
								Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
								Element.ParentElement.ReplaceChild(Style, Element);
							}
							break;
					}
				}
			}
			Result = "<html>\"" +"<head>" + Doc.GetElementsByTagName("head")[0].InnerHtml + "</head>" +"<body>" + Doc.GetElementsByTagName("body")[0].InnerHtml + "</body></html>";
			return Result;
		}))();

		public readonly HTMLElement Main;
		public Script_html():this(false){}
		public Script_html(bool IsGlobal)
		{
			if(IsGlobal==true)
			{
				var Document = new Document();
				Main= Document.GetElementById<HTMLElement>("Main");
				return;
			}
			var doc =  Document.Parse(HtmlText);
			var HeadTags = doc.Head.GetElementsByTagName("*").ToArray();
			foreach(var Tag in HeadTags)
			Document.document.Head.AppendChild(Tag);
			Main= doc.GetElementById<HTMLElement>("Main");
			var div = Document.document.CreateElement("Div");
			div.AppendChild(doc.Body);
			var Scripts = div.GetElementsByTagName("Script").ToArray();
			foreach(var Script in Scripts)
			{
				var NewScript = Document.document.CreateElement("Script");
				var Src = Script.GetAttribute("src");
				if(Src!=null)
					NewScript.SetAttribute("src",Src);
				NewScript.InnerHtml = Script.InnerHtml;
				Script.ParentElement.ReplaceChild(NewScript, Script);
			}
			div.SetStyleAttribute("display","none");
			Document.document.Body.AppendChild(div);
			Document.document.Body.RemoveChild(div);
			Main.Id="";
		}
	
	}
	
}
	
namespace Partials
{
	public class Modal_html
	{
		public static readonly string HtmlText = ((Func<string>)(() =>
		{
			byte[] ByteResult = null;
			var Result =
@"<html><head></head><body>

<div id=""myModal"" class=""mdl w3-display-container"" style=""width:100%;height:100%"">
    <style>
        /* The Modal (background) */
        .mdl {
            display: block; /* Hidden by default */
            position: fixed; /* Stay in place */
            z-index: 3; /* Sit on top */
            left: 0;
            top: 0;
            width: 100%; /* Full width */
            height: 100%; /* Full height */
            overflow: auto; /* Enable scroll if needed */
            background-color: rgb(0,0,0); /* Fallback color */
            background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
        }

        /* Modal Content */
        .mdl-content {
            background-color: rgba(255,255,255,0.8);
            padding: 0;
            border: 1px solid #888;
            width: 80vw;
            max-height: 100vh;
            box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2),0 6px 20px 0 rgba(0,0,0,0.19);
            -webkit-animation-name: animatetop;
            -webkit-animation-duration: 0.4s;
            animation-name: animatetop;
            animation-duration: 0.4s
        }

        /* Add Animation */
        @-webkit-keyframes animatetop {
            from {
                width: 10vw;
                max-height: 10vh;
                opacity: 0
            }

            to {
                width: 80vw;
                max-height: 100vh;
                opacity: 1
            }
        }

        @keyframes animatetop {
            from {
                width: 10vw;
                max-height: 10vh;
                opacity: 0
            }

            to {
                width: 80vw;
                max-height: 100vh;
                opacity: 1
            }
        }

        /* The Close Button */
        .mdlclose {
            color: darkred;
            float: right;
            font-size: 5vh;
            font-weight: bold;
            z-index: 4;
        }

            .mdlclose:hover,
            .mdlclose:focus {
                color: #000;
                text-decoration: none;
                cursor: pointer;
            }

        .mdl-header {
            padding: 2px 7px;
            background-color:rgba(21, 158, 189,0.8);
            color: white;
            min-height:6vh;
        }

        .mdl-body {
            padding: 10px 16px;
        }
    </style>

  <!-- Modal content -->
  <div class=""mdl-content w3-display-middle w3-round-large"">
    <div class=""mdl-header w3-round-large"">
      <span id=""Btn_Close"" class=""mdlclose"">×</span>
      <div id=""head""> </div>
    </div>
    <div id=""body"" class=""mdl-body w3-round-large"">
    </div>
  </div>
</div>

<script>
var modal = document.getElementById('myModal');
var span = document.getElementById(""Btn_Close"");
window.onclick = function(event) {
    if (event.target == modal) {
        span.click(); 
    }
}
</script>



</body></html>";
			var Doc = Document.Parse(Result);
			var Elements = Doc.GetElementsByTagName("*").ToArray();
			foreach(var Element in Elements)
			{
				var MNsrc = Element.GetAttribute("MNsrc");
				if (MNsrc == "")
				MNsrc = null;
				if (MNsrc != null)
				{
					Element.RemoveAttribute("MNsrc");
					var TagName = Element.TagName.ToLower();
					switch(TagName)
					{
						case "script":
							Element.InnerHtml = (string)Type.GetType(MNsrc).GetField("TextContent").GetValue(null);
							break;
						case "img":
							Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
							break;
						case "link":
							if (Element.GetAttribute("type").ToLower() == "text/css")
							{
								var Style = Document.document.CreateElement<HTMLStyleElement>();
								Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
								Element.ParentElement.ReplaceChild(Style, Element);
							}
							break;
					}
				}
			}
			Result = "<html>\"" +"<head>" + Doc.GetElementsByTagName("head")[0].InnerHtml + "</head>" +"<body>" + Doc.GetElementsByTagName("body")[0].InnerHtml + "</body></html>";
			return Result;
		}))();

		public readonly HTMLDivElement myModal;
		public readonly HTMLElement Btn_Close;
		public readonly HTMLDivElement head;
		public readonly HTMLDivElement body;
		public Modal_html():this(false){}
		public Modal_html(bool IsGlobal)
		{
			if(IsGlobal==true)
			{
				var Document = new Document();
				myModal= Document.GetElementById<HTMLDivElement>("myModal");
				Btn_Close= Document.GetElementById<HTMLElement>("Btn_Close");
				head= Document.GetElementById<HTMLDivElement>("head");
				body= Document.GetElementById<HTMLDivElement>("body");
				return;
			}
			var doc =  Document.Parse(HtmlText);
			var HeadTags = doc.Head.GetElementsByTagName("*").ToArray();
			foreach(var Tag in HeadTags)
			Document.document.Head.AppendChild(Tag);
			myModal= doc.GetElementById<HTMLDivElement>("myModal");
			Btn_Close= doc.GetElementById<HTMLElement>("Btn_Close");
			head= doc.GetElementById<HTMLDivElement>("head");
			body= doc.GetElementById<HTMLDivElement>("body");
			var div = Document.document.CreateElement("Div");
			div.AppendChild(doc.Body);
			var Scripts = div.GetElementsByTagName("Script").ToArray();
			foreach(var Script in Scripts)
			{
				var NewScript = Document.document.CreateElement("Script");
				var Src = Script.GetAttribute("src");
				if(Src!=null)
					NewScript.SetAttribute("src",Src);
				NewScript.InnerHtml = Script.InnerHtml;
				Script.ParentElement.ReplaceChild(NewScript, Script);
			}
			div.SetStyleAttribute("display","none");
			Document.document.Body.AppendChild(div);
			Document.document.Body.RemoveChild(div);
			myModal.Id="";
			Btn_Close.Id="";
			head.Id="";
			body.Id="";
		}
	
	}
	
	namespace Edit
	{
	public class Img_html
	{
		public static readonly string HtmlText = ((Func<string>)(() =>
		{
			byte[] ByteResult = null;
			var Result =
@"<html><head></head><body>
    <div id=""Main"">
        <div><img id=""Image""></div>
        <div>
            <input type=""file"" id=""ImageFile"">
        </div>
    </div>
    <script>
        var img = document.getElementById(""Image"");
        var ImageFile = document.getElementById(""ImageFile"");
        ImageFile.onchange = () => {

            if (ImageFile.files && ImageFile.files[0]) {
                var reader = new FileReader();

                reader.onload = function (e) {
                    img.setAttribute('src', e.target.result);
                };

                reader.readAsDataURL(ImageFile.files[0]);
            }
        };
    </script>

</body></html>";
			var Doc = Document.Parse(Result);
			var Elements = Doc.GetElementsByTagName("*").ToArray();
			foreach(var Element in Elements)
			{
				var MNsrc = Element.GetAttribute("MNsrc");
				if (MNsrc == "")
				MNsrc = null;
				if (MNsrc != null)
				{
					Element.RemoveAttribute("MNsrc");
					var TagName = Element.TagName.ToLower();
					switch(TagName)
					{
						case "script":
							Element.InnerHtml = (string)Type.GetType(MNsrc).GetField("TextContent").GetValue(null);
							break;
						case "img":
							Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
							break;
						case "link":
							if (Element.GetAttribute("type").ToLower() == "text/css")
							{
								var Style = Document.document.CreateElement<HTMLStyleElement>();
								Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
								Element.ParentElement.ReplaceChild(Style, Element);
							}
							break;
					}
				}
			}
			Result = "<html>\"" +"<head>" + Doc.GetElementsByTagName("head")[0].InnerHtml + "</head>" +"<body>" + Doc.GetElementsByTagName("body")[0].InnerHtml + "</body></html>";
			return Result;
		}))();

		public readonly HTMLDivElement Main;
		public readonly HTMLImageElement Image;
		public readonly HTMLInputElement ImageFile;
		public Img_html():this(false){}
		public Img_html(bool IsGlobal)
		{
			if(IsGlobal==true)
			{
				var Document = new Document();
				Main= Document.GetElementById<HTMLDivElement>("Main");
				Image= Document.GetElementById<HTMLImageElement>("Image");
				ImageFile= Document.GetElementById<HTMLInputElement>("ImageFile");
				return;
			}
			var doc =  Document.Parse(HtmlText);
			var HeadTags = doc.Head.GetElementsByTagName("*").ToArray();
			foreach(var Tag in HeadTags)
			Document.document.Head.AppendChild(Tag);
			Main= doc.GetElementById<HTMLDivElement>("Main");
			Image= doc.GetElementById<HTMLImageElement>("Image");
			ImageFile= doc.GetElementById<HTMLInputElement>("ImageFile");
			var div = Document.document.CreateElement("Div");
			div.AppendChild(doc.Body);
			var Scripts = div.GetElementsByTagName("Script").ToArray();
			foreach(var Script in Scripts)
			{
				var NewScript = Document.document.CreateElement("Script");
				var Src = Script.GetAttribute("src");
				if(Src!=null)
					NewScript.SetAttribute("src",Src);
				NewScript.InnerHtml = Script.InnerHtml;
				Script.ParentElement.ReplaceChild(NewScript, Script);
			}
			div.SetStyleAttribute("display","none");
			Document.document.Body.AppendChild(div);
			Document.document.Body.RemoveChild(div);
			Main.Id="";
			Image.Id="";
			ImageFile.Id="";
		}
	
		}
	public class Input_Count_html
	{
		public static readonly string HtmlText = ((Func<string>)(() =>
		{
			byte[] ByteResult = null;
			var Result =
@"<html><head></head><body><div id=""Main"">
    <input id=""txt_Count"" type=""tel"">
    <script>
        var input = document.getElementById(""txt_Count"");
        var Last = input.value;
        var LastStart = 0;
        var LastEnd = 0;
        input.onkeypress = function () {
            LastStart = input.selectionStart;
            LastEnd = input.selectionEnd;
        };

        input.oninput = function () {
            if (Number(input.value).toString() == ""NaN"") {
                input.value = Last;
                input.setSelectionRange(LastStart, LastEnd);
                return;
            }

            if (Number(input.value) < 0) {
                input.value = Last;
                input.setSelectionRange(LastStart, LastEnd);
                return;
            }

            if (Math.round(Number(input.value)).toString() != input.value && input.value != """") {

                input.value = Last;
                input.setSelectionRange(LastStart, LastEnd);
                return;
            }
            if (Number(input.value).toString() == ""0"") {
                input.value = """";
            }

            Last = input.value;
        };
    </script>
</div></body></html>";
			var Doc = Document.Parse(Result);
			var Elements = Doc.GetElementsByTagName("*").ToArray();
			foreach(var Element in Elements)
			{
				var MNsrc = Element.GetAttribute("MNsrc");
				if (MNsrc == "")
				MNsrc = null;
				if (MNsrc != null)
				{
					Element.RemoveAttribute("MNsrc");
					var TagName = Element.TagName.ToLower();
					switch(TagName)
					{
						case "script":
							Element.InnerHtml = (string)Type.GetType(MNsrc).GetField("TextContent").GetValue(null);
							break;
						case "img":
							Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
							break;
						case "link":
							if (Element.GetAttribute("type").ToLower() == "text/css")
							{
								var Style = Document.document.CreateElement<HTMLStyleElement>();
								Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
								Element.ParentElement.ReplaceChild(Style, Element);
							}
							break;
					}
				}
			}
			Result = "<html>\"" +"<head>" + Doc.GetElementsByTagName("head")[0].InnerHtml + "</head>" +"<body>" + Doc.GetElementsByTagName("body")[0].InnerHtml + "</body></html>";
			return Result;
		}))();

		public readonly HTMLDivElement Main;
		public readonly HTMLInputElement txt_Count;
		public Input_Count_html():this(false){}
		public Input_Count_html(bool IsGlobal)
		{
			if(IsGlobal==true)
			{
				var Document = new Document();
				Main= Document.GetElementById<HTMLDivElement>("Main");
				txt_Count= Document.GetElementById<HTMLInputElement>("txt_Count");
				return;
			}
			var doc =  Document.Parse(HtmlText);
			var HeadTags = doc.Head.GetElementsByTagName("*").ToArray();
			foreach(var Tag in HeadTags)
			Document.document.Head.AppendChild(Tag);
			Main= doc.GetElementById<HTMLDivElement>("Main");
			txt_Count= doc.GetElementById<HTMLInputElement>("txt_Count");
			var div = Document.document.CreateElement("Div");
			div.AppendChild(doc.Body);
			var Scripts = div.GetElementsByTagName("Script").ToArray();
			foreach(var Script in Scripts)
			{
				var NewScript = Document.document.CreateElement("Script");
				var Src = Script.GetAttribute("src");
				if(Src!=null)
					NewScript.SetAttribute("src",Src);
				NewScript.InnerHtml = Script.InnerHtml;
				Script.ParentElement.ReplaceChild(NewScript, Script);
			}
			div.SetStyleAttribute("display","none");
			Document.document.Body.AppendChild(div);
			Document.document.Body.RemoveChild(div);
			Main.Id="";
			txt_Count.Id="";
		}
	
		}
	
	}
	
}
	
namespace Preneeds
{
	public class Base_htm
	{
		public static readonly string HtmlText = ((Func<string>)(() =>
		{
			byte[] ByteResult = null;
			var Result =
@"<html><head></head><body>
    <div id=""PreLoad"">
        <link rel=""stylesheet"" mnsrc=""Monsajem_Incs.Resources.Preneeds.w3_css"">
        <link rel=""stylesheet"" mnsrc=""Monsajem_Incs.Resources.Preneeds.TextInput_balloon_css"">
        <link rel=""stylesheet"" mnsrc=""Monsajem_Incs.Resources.Preneeds.TextInput_Container_css"">
        <link rel=""stylesheet"" mnsrc=""Monsajem_Incs.Resources.Preneeds.bootstrap_min_css"">
        <script mnsrc=""Monsajem_Incs.Resources.Preneeds.jquery_1_12_4_min_js""></script>
        <script mnsrc=""Monsajem_Incs.Resources.Preneeds.bootstrap_notify_min_js""></script>
        <style>
            button
            {
                color:black;
            }
            @keyframes example {
                from {
                    opacity: 0;
                    width: 0
                }
            }

            * {
                animation-name: example;
                animation-duration: 0.5s;
                font-size:2vmin;
            }
        </style>
    </div>
    <div id=""MainElement"" style=""text-align:center;color:#fff;background:#134A46;width:100%;height:100%;""></div>

</body></html>";
			var Doc = Document.Parse(Result);
			var Elements = Doc.GetElementsByTagName("*").ToArray();
			foreach(var Element in Elements)
			{
				var MNsrc = Element.GetAttribute("MNsrc");
				if (MNsrc == "")
				MNsrc = null;
				if (MNsrc != null)
				{
					Element.RemoveAttribute("MNsrc");
					var TagName = Element.TagName.ToLower();
					switch(TagName)
					{
						case "script":
							Element.InnerHtml = (string)Type.GetType(MNsrc).GetField("TextContent").GetValue(null);
							break;
						case "img":
							Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
							break;
						case "link":
							if (Element.GetAttribute("type").ToLower() == "text/css")
							{
								var Style = Document.document.CreateElement<HTMLStyleElement>();
								Element.SetAttribute("src",(string)Type.GetType(MNsrc).GetField("Url").GetValue(null));
								Element.ParentElement.ReplaceChild(Style, Element);
							}
							break;
					}
				}
			}
			Result = "<html>\"" +"<head>" + Doc.GetElementsByTagName("head")[0].InnerHtml + "</head>" +"<body>" + Doc.GetElementsByTagName("body")[0].InnerHtml + "</body></html>";
			return Result;
		}))();

		public readonly HTMLDivElement PreLoad;
		public readonly HTMLDivElement MainElement;
		public Base_htm():this(false){}
		public Base_htm(bool IsGlobal)
		{
			if(IsGlobal==true)
			{
				var Document = new Document();
				PreLoad= Document.GetElementById<HTMLDivElement>("PreLoad");
				MainElement= Document.GetElementById<HTMLDivElement>("MainElement");
				return;
			}
			var doc =  Document.Parse(HtmlText);
			var HeadTags = doc.Head.GetElementsByTagName("*").ToArray();
			foreach(var Tag in HeadTags)
			Document.document.Head.AppendChild(Tag);
			PreLoad= doc.GetElementById<HTMLDivElement>("PreLoad");
			MainElement= doc.GetElementById<HTMLDivElement>("MainElement");
			var div = Document.document.CreateElement("Div");
			div.AppendChild(doc.Body);
			var Scripts = div.GetElementsByTagName("Script").ToArray();
			foreach(var Script in Scripts)
			{
				var NewScript = Document.document.CreateElement("Script");
				var Src = Script.GetAttribute("src");
				if(Src!=null)
					NewScript.SetAttribute("src",Src);
				NewScript.InnerHtml = Script.InnerHtml;
				Script.ParentElement.ReplaceChild(NewScript, Script);
			}
			div.SetStyleAttribute("display","none");
			Document.document.Body.AppendChild(div);
			Document.document.Body.RemoveChild(div);
			PreLoad.Id="";
			MainElement.Id="";
		}
	
	}
	public class bootstrap_notify_min_js
	{
		public static readonly string TextContent = ((Func<string>)(() =>
		{
			byte[] Result = null;
			{
				var ZipMemmory = new System.IO.MemoryStream(System.Convert.FromBase64String("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"));
				var DezippedMemory = new System.IO.MemoryStream();
				using (var Dezip = new System.IO.Compression.DeflateStream(ZipMemmory, System.IO.Compression.CompressionMode.Decompress))
				{
				Dezip.CopyTo(DezippedMemory);
				}
				Result = DezippedMemory.ToArray();
			}

			return System.Text.Encoding.UTF8.GetString(Result);
		}))();

	
	}
	public class bootstrap_min_css
	{
		public static readonly string Url ="data:image/gif;base64,LyohCiAqIEJvb3RzdHJhcCB2My4zLjEgKGh0dHA6Ly9nZXRib290c3RyYXAuY29tKQogKiBDb3B5cmlnaHQgMjAxMS0yMDE0IFR3aXR0ZXIsIEluYy4KICogTGljZW5zZWQgdW5kZXIgTUlUIChodHRwczovL2dpdGh1Yi5jb20vdHdicy9ib290c3RyYXAvYmxvYi9tYXN0ZXIvTElDRU5TRSkKICovLyohIG5vcm1hbGl6ZS5jc3MgdjMuMC4yIHwgTUlUIExpY2Vuc2UgfCBnaXQuaW8vbm9ybWFsaXplICovaHRtbHtmb250LWZhbWlseTpzYW5zLXNlcmlmOy13ZWJraXQtdGV4dC1zaXplLWFkanVzdDoxMDAlOy1tcy10ZXh0LXNpemUtYWRqdXN0OjEwMCV9Ym9keXttYXJnaW46MH1hcnRpY2xlLGFzaWRlLGRldGFpbHMsZmlnY2FwdGlvbixmaWd1cmUsZm9vdGVyLGhlYWRlcixoZ3JvdXAsbWFpbixtZW51LG5hdixzZWN0aW9uLHN1bW1hcnl7ZGlzcGxheTpibG9ja31hdWRpbyxjYW52YXMscHJvZ3Jlc3MsdmlkZW97ZGlzcGxheTppbmxpbmUtYmxvY2s7dmVydGljYWwtYWxpZ246YmFzZWxpbmV9YXVkaW86bm90KFtjb250cm9sc10pe2Rpc3BsYXk6bm9uZTtoZWlnaHQ6MH1baGlkZGVuXSx0ZW1wbGF0ZXtkaXNwbGF5Om5vbmV9YXtiYWNrZ3JvdW5kLWNvbG9yOnRyYW5zcGFyZW50fWE6YWN0aXZlLGE6aG92ZXJ7b3V0bGluZTowfWFiYnJbdGl0bGVde2JvcmRlci1ib3R0b206MXB4IGRvdHRlZH1iLHN0cm9uZ3tmb250LXdlaWdodDo3MDB9ZGZue2ZvbnQtc3R5bGU6aXRhbGljfWgxe21hcmdpbjouNjdlbSAwO2ZvbnQtc2l6ZToyZW19bWFya3tjb2xvcjojMDAwO2JhY2tncm91bmQ6I2ZmMH1zbWFsbHtmb250LXNpemU6ODAlfXN1YixzdXB7cG9zaXRpb246cmVsYXRpdmU7Zm9udC1zaXplOjc1JTtsaW5lLWhlaWdodDowO3ZlcnRpY2FsLWFsaWduOmJhc2VsaW5lfXN1cHt0b3A6LS41ZW19c3Vie2JvdHRvbTotLjI1ZW19aW1ne2JvcmRlcjowfXN2Zzpub3QoOnJvb3Qpe292ZXJmbG93OmhpZGRlbn1maWd1cmV7bWFyZ2luOjFlbSA0MHB4fWhye2hlaWdodDowOy13ZWJraXQtYm94LXNpemluZzpjb250ZW50LWJveDstbW96LWJveC1zaXppbmc6Y29udGVudC1ib3g7Ym94LXNpemluZzpjb250ZW50LWJveH1wcmV7b3ZlcmZsb3c6YXV0b31jb2RlLGtiZCxwcmUsc2FtcHtmb250LWZhbWlseTptb25vc3BhY2UsbW9ub3NwYWNlO2ZvbnQtc2l6ZToxZW19YnV0dG9uLGlucHV0LG9wdGdyb3VwLHNlbGVjdCx0ZXh0YXJlYXttYXJnaW46MDtmb250OmluaGVyaXQ7Y29sb3I6aW5oZXJpdH1idXR0b257b3ZlcmZsb3c6dmlzaWJsZX1idXR0b24sc2VsZWN0e3RleHQtdHJhbnNmb3JtOm5vbmV9YnV0dG9uLGh0bWwgaW5wdXRbdHlwZT1idXR0b25dLGlucHV0W3R5cGU9cmVzZXRdLGlucHV0W3R5cGU9c3VibWl0XXstd2Via2l0LWFwcGVhcmFuY2U6YnV0dG9uO2N1cnNvcjpwb2ludGVyfWJ1dHRvbltkaXNhYmxlZF0saHRtbCBpbnB1dFtkaXNhYmxlZF17Y3Vyc29yOmRlZmF1bHR9YnV0dG9uOjotbW96LWZvY3VzLWlubmVyLGlucHV0OjotbW96LWZvY3VzLWlubmVye3BhZGRpbmc6MDtib3JkZXI6MH1pbnB1dHtsaW5lLWhlaWdodDpub3JtYWx9aW5wdXRbdHlwZT1jaGVja2JveF0saW5wdXRbdHlwZT1yYWRpb117LXdlYmtpdC1ib3gtc2l6aW5nOmJvcmRlci1ib3g7LW1vei1ib3gtc2l6aW5nOmJvcmRlci1ib3g7Ym94LXNpemluZzpib3JkZXItYm94O3BhZGRpbmc6MH1pbnB1dFt0eXBlPW51bWJlcl06Oi13ZWJraXQtaW5uZXItc3Bpbi1idXR0b24saW5wdXRbdHlwZT1udW1iZXJdOjotd2Via2l0LW91dGVyLXNwaW4tYnV0dG9ue2hlaWdodDphdXRvfWlucHV0W3R5cGU9c2VhcmNoXXstd2Via2l0LWJveC1zaXppbmc6Y29udGVudC1ib3g7LW1vei1ib3gtc2l6aW5nOmNvbnRlbnQtYm94O2JveC1zaXppbmc6Y29udGVudC1ib3g7LXdlYmtpdC1hcHBlYXJhbmNlOnRleHRmaWVsZH1pbnB1dFt0eXBlPXNlYXJjaF06Oi13ZWJraXQtc2VhcmNoLWNhbmNlbC1idXR0b24saW5wdXRbdHlwZT1zZWFyY2hdOjotd2Via2l0LXNlYXJjaC1kZWNvcmF0aW9uey13ZWJraXQtYXBwZWFyYW5jZTpub25lfWZpZWxkc2V0e3BhZGRpbmc6LjM1ZW0gLjYyNWVtIC43NWVtO21hcmdpbjowIDJweDtib3JkZXI6MXB4IHNvbGlkIHNpbHZlcn1sZWdlbmR7cGFkZGluZzowO2JvcmRlcjowfXRleHRhcmVhe292ZXJmbG93OmF1dG99b3B0Z3JvdXB7Zm9udC13ZWlnaHQ6NzAwfXRhYmxle2JvcmRlci1zcGFjaW5nOjA7Ym9yZGVyLWNvbGxhcHNlOmNvbGxhcHNlfXRkLHRoe3BhZGRpbmc6MH0vKiEgU291cmNlOiBodHRwczovL2dpdGh1Yi5jb20vaDVicC9odG1sNS1ib2lsZXJwbGF0ZS9ibG9iL21hc3Rlci9zcmMvY3NzL21haW4uY3NzICovQG1lZGlhIHByaW50eyosOmJlZm9yZSw6YWZ0ZXJ7Y29sb3I6IzAwMCFpbXBvcnRhbnQ7dGV4dC1zaGFkb3c6bm9uZSFpbXBvcnRhbnQ7YmFja2dyb3VuZDp0cmFuc3BhcmVudCFpbXBvcnRhbnQ7LXdlYmtpdC1ib3gtc2hhZG93Om5vbmUhaW1wb3J0YW50O2JveC1zaGFkb3c6bm9uZSFpbXBvcnRhbnR9YSxhOnZpc2l0ZWR7dGV4dC1kZWNvcmF0aW9uOnVuZGVybGluZX1hW2hyZWZdOmFmdGVye2NvbnRlbnQ6IiAoIiBhdHRyKGhyZWYpICIpIn1hYmJyW3RpdGxlXTphZnRlcntjb250ZW50OiIgKCIgYXR0cih0aXRsZSkgIikifWFbaHJlZl49IiMiXTphZnRlcixhW2hyZWZePSJqYXZhc2NyaXB0OiJdOmFmdGVye2NvbnRlbnQ6IiJ9cHJlLGJsb2NrcXVvdGV7Ym9yZGVyOjFweCBzb2xpZCAjOTk5O3BhZ2UtYnJlYWstaW5zaWRlOmF2b2lkfXRoZWFke2Rpc3BsYXk6dGFibGUtaGVhZGVyLWdyb3VwfXRyLGltZ3twYWdlLWJyZWFrLWluc2lkZTphdm9pZH1pbWd7bWF4LXdpZHRoOjEwMCUhaW1wb3J0YW50fXAsaDIsaDN7b3JwaGFuczozO3dpZG93czozfWgyLGgze3BhZ2UtYnJlYWstYWZ0ZXI6YXZvaWR9c2VsZWN0e2JhY2tncm91bmQ6I2ZmZiFpbXBvcnRhbnR9Lm5hdmJhcntkaXNwbGF5Om5vbmV9LmJ0bj4uY2FyZXQsLmRyb3B1cD4uYnRuPi5jYXJldHtib3JkZXItdG9wLWNvbG9yOiMwMDAhaW1wb3J0YW50fS5sYWJlbHtib3JkZXI6MXB4IHNvbGlkICMwMDB9LnRhYmxle2JvcmRlci1jb2xsYXBzZTpjb2xsYXBzZSFpbXBvcnRhbnR9LnRhYmxlIHRkLC50YWJsZSB0aHtiYWNrZ3JvdW5kLWNvbG9yOiNmZmYhaW1wb3J0YW50fS50YWJsZS1ib3JkZXJlZCB0aCwudGFibGUtYm9yZGVyZWQgdGR7Ym9yZGVyOjFweCBzb2xpZCAjZGRkIWltcG9ydGFudH19QGZvbnQtZmFjZXtmb250LWZhbWlseTonR2x5cGhpY29ucyBIYWxmbGluZ3MnO3NyYzp1cmwoLi4vZm9udHMvZ2x5cGhpY29ucy1oYWxmbGluZ3MtcmVndWxhci5lb3QpO3NyYzp1cmwoLi4vZm9udHMvZ2x5cGhpY29ucy1oYWxmbGluZ3MtcmVndWxhci5lb3Q/I2llZml4KSBmb3JtYXQoJ2VtYmVkZGVkLW9wZW50eXBlJyksdXJsKC4uL2ZvbnRzL2dseXBoaWNvbnMtaGFsZmxpbmdzLXJlZ3VsYXIud29mZikgZm9ybWF0KCd3b2ZmJyksdXJsKC4uL2ZvbnRzL2dseXBoaWNvbnMtaGFsZmxpbmdzLXJlZ3VsYXIudHRmKSBmb3JtYXQoJ3RydWV0eXBlJyksdXJsKC4uL2ZvbnRzL2dseXBoaWNvbnMtaGFsZmxpbmdzLXJlZ3VsYXIuc3ZnI2dseXBoaWNvbnNfaGFsZmxpbmdzcmVndWxhcikgZm9ybWF0KCdzdmcnKX0uZ2x5cGhpY29ue3Bvc2l0aW9uOnJlbGF0aXZlO3RvcDoxcHg7ZGlzcGxheTppbmxpbmUtYmxvY2s7Zm9udC1mYW1pbHk6J0dseXBoaWNvbnMgSGFsZmxpbmdzJztmb250LXN0eWxlOm5vcm1hbDtmb250LXdlaWdodDo0MDA7bGluZS1oZWlnaHQ6MTstd2Via2l0LWZvbnQtc21vb3RoaW5nOmFudGlhbGlhc2VkOy1tb3otb3N4LWZvbnQtc21vb3RoaW5nOmdyYXlzY2FsZX0uZ2x5cGhpY29uLWFzdGVyaXNrOmJlZm9yZXtjb250ZW50OiJcMmEifS5nbHlwaGljb24tcGx1czpiZWZvcmV7Y29udGVudDoiXDJiIn0uZ2x5cGhpY29uLWV1cm86YmVmb3JlLC5nbHlwaGljb24tZXVyOmJlZm9yZXtjb250ZW50OiJcMjBhYyJ9LmdseXBoaWNvbi1taW51czpiZWZvcmV7Y29udGVudDoiXDIyMTIifS5nbHlwaGljb24tY2xvdWQ6YmVmb3Jle2NvbnRlbnQ6IlwyNjAxIn0uZ2x5cGhpY29uLWVudmVsb3BlOmJlZm9yZXtjb250ZW50OiJcMjcwOSJ9LmdseXBoaWNvbi1wZW5jaWw6YmVmb3Jle2NvbnRlbnQ6IlwyNzBmIn0uZ2x5cGhpY29uLWdsYXNzOmJlZm9yZXtjb250ZW50OiJcZTAwMSJ9LmdseXBoaWNvbi1tdXNpYzpiZWZvcmV7Y29udGVudDoiXGUwMDIifS5nbHlwaGljb24tc2VhcmNoOmJlZm9yZXtjb250ZW50OiJcZTAwMyJ9LmdseXBoaWNvbi1oZWFydDpiZWZvcmV7Y29udGVudDoiXGUwMDUifS5nbHlwaGljb24tc3RhcjpiZWZvcmV7Y29udGVudDoiXGUwMDYifS5nbHlwaGljb24tc3Rhci1lbXB0eTpiZWZvcmV7Y29udGVudDoiXGUwMDcifS5nbHlwaGljb24tdXNlcjpiZWZvcmV7Y29udGVudDoiXGUwMDgifS5nbHlwaGljb24tZmlsbTpiZWZvcmV7Y29udGVudDoiXGUwMDkifS5nbHlwaGljb24tdGgtbGFyZ2U6YmVmb3Jle2NvbnRlbnQ6IlxlMDEwIn0uZ2x5cGhpY29uLXRoOmJlZm9yZXtjb250ZW50OiJcZTAxMSJ9LmdseXBoaWNvbi10aC1saXN0OmJlZm9yZXtjb250ZW50OiJcZTAxMiJ9LmdseXBoaWNvbi1vazpiZWZvcmV7Y29udGVudDoiXGUwMTMifS5nbHlwaGljb24tcmVtb3ZlOmJlZm9yZXtjb250ZW50OiJcZTAxNCJ9LmdseXBoaWNvbi16b29tLWluOmJlZm9yZXtjb250ZW50OiJcZTAxNSJ9LmdseXBoaWNvbi16b29tLW91dDpiZWZvcmV7Y29udGVudDoiXGUwMTYifS5nbHlwaGljb24tb2ZmOmJlZm9yZXtjb250ZW50OiJcZTAxNyJ9LmdseXBoaWNvbi1zaWduYWw6YmVmb3Jle2NvbnRlbnQ6IlxlMDE4In0uZ2x5cGhpY29uLWNvZzpiZWZvcmV7Y29udGVudDoiXGUwMTkifS5nbHlwaGljb24tdHJhc2g6YmVmb3Jle2NvbnRlbnQ6IlxlMDIwIn0uZ2x5cGhpY29uLWhvbWU6YmVmb3Jle2NvbnRlbnQ6IlxlMDIxIn0uZ2x5cGhpY29uLWZpbGU6YmVmb3Jle2NvbnRlbnQ6IlxlMDIyIn0uZ2x5cGhpY29uLXRpbWU6YmVmb3Jle2NvbnRlbnQ6IlxlMDIzIn0uZ2x5cGhpY29uLXJvYWQ6YmVmb3Jle2NvbnRlbnQ6IlxlMDI0In0uZ2x5cGhpY29uLWRvd25sb2FkLWFsdDpiZWZvcmV7Y29udGVudDoiXGUwMjUifS5nbHlwaGljb24tZG93bmxvYWQ6YmVmb3Jle2NvbnRlbnQ6IlxlMDI2In0uZ2x5cGhpY29uLXVwbG9hZDpiZWZvcmV7Y29udGVudDoiXGUwMjcifS5nbHlwaGljb24taW5ib3g6YmVmb3Jle2NvbnRlbnQ6IlxlMDI4In0uZ2x5cGhpY29uLXBsYXktY2lyY2xlOmJlZm9yZXtjb250ZW50OiJcZTAyOSJ9LmdseXBoaWNvbi1yZXBlYXQ6YmVmb3Jle2NvbnRlbnQ6IlxlMDMwIn0uZ2x5cGhpY29uLXJlZnJlc2g6YmVmb3Jle2NvbnRlbnQ6IlxlMDMxIn0uZ2x5cGhpY29uLWxpc3QtYWx0OmJlZm9yZXtjb250ZW50OiJcZTAzMiJ9LmdseXBoaWNvbi1sb2NrOmJlZm9yZXtjb250ZW50OiJcZTAzMyJ9LmdseXBoaWNvbi1mbGFnOmJlZm9yZXtjb250ZW50OiJcZTAzNCJ9LmdseXBoaWNvbi1oZWFkcGhvbmVzOmJlZm9yZXtjb250ZW50OiJcZTAzNSJ9LmdseXBoaWNvbi12b2x1bWUtb2ZmOmJlZm9yZXtjb250ZW50OiJcZTAzNiJ9LmdseXBoaWNvbi12b2x1bWUtZG93bjpiZWZvcmV7Y29udGVudDoiXGUwMzcifS5nbHlwaGljb24tdm9sdW1lLXVwOmJlZm9yZXtjb250ZW50OiJcZTAzOCJ9LmdseXBoaWNvbi1xcmNvZGU6YmVmb3Jle2NvbnRlbnQ6IlxlMDM5In0uZ2x5cGhpY29uLWJhcmNvZGU6YmVmb3Jle2NvbnRlbnQ6IlxlMDQwIn0uZ2x5cGhpY29uLXRhZzpiZWZvcmV7Y29udGVudDoiXGUwNDEifS5nbHlwaGljb24tdGFnczpiZWZvcmV7Y29udGVudDoiXGUwNDIifS5nbHlwaGljb24tYm9vazpiZWZvcmV7Y29udGVudDoiXGUwNDMifS5nbHlwaGljb24tYm9va21hcms6YmVmb3Jle2NvbnRlbnQ6IlxlMDQ0In0uZ2x5cGhpY29uLXByaW50OmJlZm9yZXtjb250ZW50OiJcZTA0NSJ9LmdseXBoaWNvbi1jYW1lcmE6YmVmb3Jle2NvbnRlbnQ6IlxlMDQ2In0uZ2x5cGhpY29uLWZvbnQ6YmVmb3Jle2NvbnRlbnQ6IlxlMDQ3In0uZ2x5cGhpY29uLWJvbGQ6YmVmb3Jle2NvbnRlbnQ6IlxlMDQ4In0uZ2x5cGhpY29uLWl0YWxpYzpiZWZvcmV7Y29udGVudDoiXGUwNDkifS5nbHlwaGljb24tdGV4dC1oZWlnaHQ6YmVmb3Jle2NvbnRlbnQ6IlxlMDUwIn0uZ2x5cGhpY29uLXRleHQtd2lkdGg6YmVmb3Jle2NvbnRlbnQ6IlxlMDUxIn0uZ2x5cGhpY29uLWFsaWduLWxlZnQ6YmVmb3Jle2NvbnRlbnQ6IlxlMDUyIn0uZ2x5cGhpY29uLWFsaWduLWNlbnRlcjpiZWZvcmV7Y29udGVudDoiXGUwNTMifS5nbHlwaGljb24tYWxpZ24tcmlnaHQ6YmVmb3Jle2NvbnRlbnQ6IlxlMDU0In0uZ2x5cGhpY29uLWFsaWduLWp1c3RpZnk6YmVmb3Jle2NvbnRlbnQ6IlxlMDU1In0uZ2x5cGhpY29uLWxpc3Q6YmVmb3Jle2NvbnRlbnQ6IlxlMDU2In0uZ2x5cGhpY29uLWluZGVudC1sZWZ0OmJlZm9yZXtjb250ZW50OiJcZTA1NyJ9LmdseXBoaWNvbi1pbmRlbnQtcmlnaHQ6YmVmb3Jle2NvbnRlbnQ6IlxlMDU4In0uZ2x5cGhpY29uLWZhY2V0aW1lLXZpZGVvOmJlZm9yZXtjb250ZW50OiJcZTA1OSJ9LmdseXBoaWNvbi1waWN0dXJlOmJlZm9yZXtjb250ZW50OiJcZTA2MCJ9LmdseXBoaWNvbi1tYXAtbWFya2VyOmJlZm9yZXtjb250ZW50OiJcZTA2MiJ9LmdseXBoaWNvbi1hZGp1c3Q6YmVmb3Jle2NvbnRlbnQ6IlxlMDYzIn0uZ2x5cGhpY29uLXRpbnQ6YmVmb3Jle2NvbnRlbnQ6IlxlMDY0In0uZ2x5cGhpY29uLWVkaXQ6YmVmb3Jle2NvbnRlbnQ6IlxlMDY1In0uZ2x5cGhpY29uLXNoYXJlOmJlZm9yZXtjb250ZW50OiJcZTA2NiJ9LmdseXBoaWNvbi1jaGVjazpiZWZvcmV7Y29udGVudDoiXGUwNjcifS5nbHlwaGljb24tbW92ZTpiZWZvcmV7Y29udGVudDoiXGUwNjgifS5nbHlwaGljb24tc3RlcC1iYWNrd2FyZDpiZWZvcmV7Y29udGVudDoiXGUwNjkifS5nbHlwaGljb24tZmFzdC1iYWNrd2FyZDpiZWZvcmV7Y29udGVudDoiXGUwNzAifS5nbHlwaGljb24tYmFja3dhcmQ6YmVmb3Jle2NvbnRlbnQ6IlxlMDcxIn0uZ2x5cGhpY29uLXBsYXk6YmVmb3Jle2NvbnRlbnQ6IlxlMDcyIn0uZ2x5cGhpY29uLXBhdXNlOmJlZm9yZXtjb250ZW50OiJcZTA3MyJ9LmdseXBoaWNvbi1zdG9wOmJlZm9yZXtjb250ZW50OiJcZTA3NCJ9LmdseXBoaWNvbi1mb3J3YXJkOmJlZm9yZXtjb250ZW50OiJcZTA3NSJ9LmdseXBoaWNvbi1mYXN0LWZvcndhcmQ6YmVmb3Jle2NvbnRlbnQ6IlxlMDc2In0uZ2x5cGhpY29uLXN0ZXAtZm9yd2FyZDpiZWZvcmV7Y29udGVudDoiXGUwNzcifS5nbHlwaGljb24tZWplY3Q6YmVmb3Jle2NvbnRlbnQ6IlxlMDc4In0uZ2x5cGhpY29uLWNoZXZyb24tbGVmdDpiZWZvcmV7Y29udGVudDoiXGUwNzkifS5nbHlwaGljb24tY2hldnJvbi1yaWdodDpiZWZvcmV7Y29udGVudDoiXGUwODAifS5nbHlwaGljb24tcGx1cy1zaWduOmJlZm9yZXtjb250ZW50OiJcZTA4MSJ9LmdseXBoaWNvbi1taW51cy1zaWduOmJlZm9yZXtjb250ZW50OiJcZTA4MiJ9LmdseXBoaWNvbi1yZW1vdmUtc2lnbjpiZWZvcmV7Y29udGVudDoiXGUwODMifS5nbHlwaGljb24tb2stc2lnbjpiZWZvcmV7Y29udGVudDoiXGUwODQifS5nbHlwaGljb24tcXVlc3Rpb24tc2lnbjpiZWZvcmV7Y29udGVudDoiXGUwODUifS5nbHlwaGljb24taW5mby1zaWduOmJlZm9yZXtjb250ZW50OiJcZTA4NiJ9LmdseXBoaWNvbi1zY3JlZW5zaG90OmJlZm9yZXtjb250ZW50OiJcZTA4NyJ9LmdseXBoaWNvbi1yZW1vdmUtY2lyY2xlOmJlZm9yZXtjb250ZW50OiJcZTA4OCJ9LmdseXBoaWNvbi1vay1jaXJjbGU6YmVmb3Jle2NvbnRlbnQ6IlxlMDg5In0uZ2x5cGhpY29uLWJhbi1jaXJjbGU6YmVmb3Jle2NvbnRlbnQ6IlxlMDkwIn0uZ2x5cGhpY29uLWFycm93LWxlZnQ6YmVmb3Jle2NvbnRlbnQ6IlxlMDkxIn0uZ2x5cGhpY29uLWFycm93LXJpZ2h0OmJlZm9yZXtjb250ZW50OiJcZTA5MiJ9LmdseXBoaWNvbi1hcnJvdy11cDpiZWZvcmV7Y29udGVudDoiXGUwOTMifS5nbHlwaGljb24tYXJyb3ctZG93bjpiZWZvcmV7Y29udGVudDoiXGUwOTQifS5nbHlwaGljb24tc2hhcmUtYWx0OmJlZm9yZXtjb250ZW50OiJcZTA5NSJ9LmdseXBoaWNvbi1yZXNpemUtZnVsbDpiZWZvcmV7Y29udGVudDoiXGUwOTYifS5nbHlwaGljb24tcmVzaXplLXNtYWxsOmJlZm9yZXtjb250ZW50OiJcZTA5NyJ9LmdseXBoaWNvbi1leGNsYW1hdGlvbi1zaWduOmJlZm9yZXtjb250ZW50OiJcZTEwMSJ9LmdseXBoaWNvbi1naWZ0OmJlZm9yZXtjb250ZW50OiJcZTEwMiJ9LmdseXBoaWNvbi1sZWFmOmJlZm9yZXtjb250ZW50OiJcZTEwMyJ9LmdseXBoaWNvbi1maXJlOmJlZm9yZXtjb250ZW50OiJcZTEwNCJ9LmdseXBoaWNvbi1leWUtb3BlbjpiZWZvcmV7Y29udGVudDoiXGUxMDUifS5nbHlwaGljb24tZXllLWNsb3NlOmJlZm9yZXtjb250ZW50OiJcZTEwNiJ9LmdseXBoaWNvbi13YXJuaW5nLXNpZ246YmVmb3Jle2NvbnRlbnQ6IlxlMTA3In0uZ2x5cGhpY29uLXBsYW5lOmJlZm9yZXtjb250ZW50OiJcZTEwOCJ9LmdseXBoaWNvbi1jYWxlbmRhcjpiZWZvcmV7Y29udGVudDoiXGUxMDkifS5nbHlwaGljb24tcmFuZG9tOmJlZm9yZXtjb250ZW50OiJcZTExMCJ9LmdseXBoaWNvbi1jb21tZW50OmJlZm9yZXtjb250ZW50OiJcZTExMSJ9LmdseXBoaWNvbi1tYWduZXQ6YmVmb3Jle2NvbnRlbnQ6IlxlMTEyIn0uZ2x5cGhpY29uLWNoZXZyb24tdXA6YmVmb3Jle2NvbnRlbnQ6IlxlMTEzIn0uZ2x5cGhpY29uLWNoZXZyb24tZG93bjpiZWZvcmV7Y29udGVudDoiXGUxMTQifS5nbHlwaGljb24tcmV0d2VldDpiZWZvcmV7Y29udGVudDoiXGUxMTUifS5nbHlwaGljb24tc2hvcHBpbmctY2FydDpiZWZvcmV7Y29udGVudDoiXGUxMTYifS5nbHlwaGljb24tZm9sZGVyLWNsb3NlOmJlZm9yZXtjb250ZW50OiJcZTExNyJ9LmdseXBoaWNvbi1mb2xkZXItb3BlbjpiZWZvcmV7Y29udGVudDoiXGUxMTgifS5nbHlwaGljb24tcmVzaXplLXZlcnRpY2FsOmJlZm9yZXtjb250ZW50OiJcZTExOSJ9LmdseXBoaWNvbi1yZXNpemUtaG9yaXpvbnRhbDpiZWZvcmV7Y29udGVudDoiXGUxMjAifS5nbHlwaGljb24taGRkOmJlZm9yZXtjb250ZW50OiJcZTEyMSJ9LmdseXBoaWNvbi1idWxsaG9ybjpiZWZvcmV7Y29udGVudDoiXGUxMjIifS5nbHlwaGljb24tYmVsbDpiZWZvcmV7Y29udGVudDoiXGUxMjMifS5nbHlwaGljb24tY2VydGlmaWNhdGU6YmVmb3Jle2NvbnRlbnQ6IlxlMTI0In0uZ2x5cGhpY29uLXRodW1icy11cDpiZWZvcmV7Y29udGVudDoiXGUxMjUifS5nbHlwaGljb24tdGh1bWJzLWRvd246YmVmb3Jle2NvbnRlbnQ6IlxlMTI2In0uZ2x5cGhpY29uLWhhbmQtcmlnaHQ6YmVmb3Jle2NvbnRlbnQ6IlxlMTI3In0uZ2x5cGhpY29uLWhhbmQtbGVmdDpiZWZvcmV7Y29udGVudDoiXGUxMjgifS5nbHlwaGljb24taGFuZC11cDpiZWZvcmV7Y29udGVudDoiXGUxMjkifS5nbHlwaGljb24taGFuZC1kb3duOmJlZm9yZXtjb250ZW50OiJcZTEzMCJ9LmdseXBoaWNvbi1jaXJjbGUtYXJyb3ctcmlnaHQ6YmVmb3Jle2NvbnRlbnQ6IlxlMTMxIn0uZ2x5cGhpY29uLWNpcmNsZS1hcnJvdy1sZWZ0OmJlZm9yZXtjb250ZW50OiJcZTEzMiJ9LmdseXBoaWNvbi1jaXJjbGUtYXJyb3ctdXA6YmVmb3Jle2NvbnRlbnQ6IlxlMTMzIn0uZ2x5cGhpY29uLWNpcmNsZS1hcnJvdy1kb3duOmJlZm9yZXtjb250ZW50OiJcZTEzNCJ9LmdseXBoaWNvbi1nbG9iZTpiZWZvcmV7Y29udGVudDoiXGUxMzUifS5nbHlwaGljb24td3JlbmNoOmJlZm9yZXtjb250ZW50OiJcZTEzNiJ9LmdseXBoaWNvbi10YXNrczpiZWZvcmV7Y29udGVudDoiXGUxMzcifS5nbHlwaGljb24tZmlsdGVyOmJlZm9yZXtjb250ZW50OiJcZTEzOCJ9LmdseXBoaWNvbi1icmllZmNhc2U6YmVmb3Jle2NvbnRlbnQ6IlxlMTM5In0uZ2x5cGhpY29uLWZ1bGxzY3JlZW46YmVmb3Jle2NvbnRlbnQ6IlxlMTQwIn0uZ2x5cGhpY29uLWRhc2hib2FyZDpiZWZvcmV7Y29udGVudDoiXGUxNDEifS5nbHlwaGljb24tcGFwZXJjbGlwOmJlZm9yZXtjb250ZW50OiJcZTE0MiJ9LmdseXBoaWNvbi1oZWFydC1lbXB0eTpiZWZvcmV7Y29udGVudDoiXGUxNDMifS5nbHlwaGljb24tbGluazpiZWZvcmV7Y29udGVudDoiXGUxNDQifS5nbHlwaGljb24tcGhvbmU6YmVmb3Jle2NvbnRlbnQ6IlxlMTQ1In0uZ2x5cGhpY29uLXB1c2hwaW46YmVmb3Jle2NvbnRlbnQ6IlxlMTQ2In0uZ2x5cGhpY29uLXVzZDpiZWZvcmV7Y29udGVudDoiXGUxNDgifS5nbHlwaGljb24tZ2JwOmJlZm9yZXtjb250ZW50OiJcZTE0OSJ9LmdseXBoaWNvbi1zb3J0OmJlZm9yZXtjb250ZW50OiJcZTE1MCJ9LmdseXBoaWNvbi1zb3J0LWJ5LWFscGhhYmV0OmJlZm9yZXtjb250ZW50OiJcZTE1MSJ9LmdseXBoaWNvbi1zb3J0LWJ5LWFscGhhYmV0LWFsdDpiZWZvcmV7Y29udGVudDoiXGUxNTIifS5nbHlwaGljb24tc29ydC1ieS1vcmRlcjpiZWZvcmV7Y29udGVudDoiXGUxNTMifS5nbHlwaGljb24tc29ydC1ieS1vcmRlci1hbHQ6YmVmb3Jle2NvbnRlbnQ6IlxlMTU0In0uZ2x5cGhpY29uLXNvcnQtYnktYXR0cmlidXRlczpiZWZvcmV7Y29udGVudDoiXGUxNTUifS5nbHlwaGljb24tc29ydC1ieS1hdHRyaWJ1dGVzLWFsdDpiZWZvcmV7Y29udGVudDoiXGUxNTYifS5nbHlwaGljb24tdW5jaGVja2VkOmJlZm9yZXtjb250ZW50OiJcZTE1NyJ9LmdseXBoaWNvbi1leHBhbmQ6YmVmb3Jle2NvbnRlbnQ6IlxlMTU4In0uZ2x5cGhpY29uLWNvbGxhcHNlLWRvd246YmVmb3Jle2NvbnRlbnQ6IlxlMTU5In0uZ2x5cGhpY29uLWNvbGxhcHNlLXVwOmJlZm9yZXtjb250ZW50OiJcZTE2MCJ9LmdseXBoaWNvbi1sb2ctaW46YmVmb3Jle2NvbnRlbnQ6IlxlMTYxIn0uZ2x5cGhpY29uLWZsYXNoOmJlZm9yZXtjb250ZW50OiJcZTE2MiJ9LmdseXBoaWNvbi1sb2ctb3V0OmJlZm9yZXtjb250ZW50OiJcZTE2MyJ9LmdseXBoaWNvbi1uZXctd2luZG93OmJlZm9yZXtjb250ZW50OiJcZTE2NCJ9LmdseXBoaWNvbi1yZWNvcmQ6YmVmb3Jle2NvbnRlbnQ6IlxlMTY1In0uZ2x5cGhpY29uLXNhdmU6YmVmb3Jle2NvbnRlbnQ6IlxlMTY2In0uZ2x5cGhpY29uLW9wZW46YmVmb3Jle2NvbnRlbnQ6IlxlMTY3In0uZ2x5cGhpY29uLXNhdmVkOmJlZm9yZXtjb250ZW50OiJcZTE2OCJ9LmdseXBoaWNvbi1pbXBvcnQ6YmVmb3Jle2NvbnRlbnQ6IlxlMTY5In0uZ2x5cGhpY29uLWV4cG9ydDpiZWZvcmV7Y29udGVudDoiXGUxNzAifS5nbHlwaGljb24tc2VuZDpiZWZvcmV7Y29udGVudDoiXGUxNzEifS5nbHlwaGljb24tZmxvcHB5LWRpc2s6YmVmb3Jle2NvbnRlbnQ6IlxlMTcyIn0uZ2x5cGhpY29uLWZsb3BweS1zYXZlZDpiZWZvcmV7Y29udGVudDoiXGUxNzMifS5nbHlwaGljb24tZmxvcHB5LXJlbW92ZTpiZWZvcmV7Y29udGVudDoiXGUxNzQifS5nbHlwaGljb24tZmxvcHB5LXNhdmU6YmVmb3Jle2NvbnRlbnQ6IlxlMTc1In0uZ2x5cGhpY29uLWZsb3BweS1vcGVuOmJlZm9yZXtjb250ZW50OiJcZTE3NiJ9LmdseXBoaWNvbi1jcmVkaXQtY2FyZDpiZWZvcmV7Y29udGVudDoiXGUxNzcifS5nbHlwaGljb24tdHJhbnNmZXI6YmVmb3Jle2NvbnRlbnQ6IlxlMTc4In0uZ2x5cGhpY29uLWN1dGxlcnk6YmVmb3Jle2NvbnRlbnQ6IlxlMTc5In0uZ2x5cGhpY29uLWhlYWRlcjpiZWZvcmV7Y29udGVudDoiXGUxODAifS5nbHlwaGljb24tY29tcHJlc3NlZDpiZWZvcmV7Y29udGVudDoiXGUxODEifS5nbHlwaGljb24tZWFycGhvbmU6YmVmb3Jle2NvbnRlbnQ6IlxlMTgyIn0uZ2x5cGhpY29uLXBob25lLWFsdDpiZWZvcmV7Y29udGVudDoiXGUxODMifS5nbHlwaGljb24tdG93ZXI6YmVmb3Jle2NvbnRlbnQ6IlxlMTg0In0uZ2x5cGhpY29uLXN0YXRzOmJlZm9yZXtjb250ZW50OiJcZTE4NSJ9LmdseXBoaWNvbi1zZC12aWRlbzpiZWZvcmV7Y29udGVudDoiXGUxODYifS5nbHlwaGljb24taGQtdmlkZW86YmVmb3Jle2NvbnRlbnQ6IlxlMTg3In0uZ2x5cGhpY29uLXN1YnRpdGxlczpiZWZvcmV7Y29udGVudDoiXGUxODgifS5nbHlwaGljb24tc291bmQtc3RlcmVvOmJlZm9yZXtjb250ZW50OiJcZTE4OSJ9LmdseXBoaWNvbi1zb3VuZC1kb2xieTpiZWZvcmV7Y29udGVudDoiXGUxOTAifS5nbHlwaGljb24tc291bmQtNS0xOmJlZm9yZXtjb250ZW50OiJcZTE5MSJ9LmdseXBoaWNvbi1zb3VuZC02LTE6YmVmb3Jle2NvbnRlbnQ6IlxlMTkyIn0uZ2x5cGhpY29uLXNvdW5kLTctMTpiZWZvcmV7Y29udGVudDoiXGUxOTMifS5nbHlwaGljb24tY29weXJpZ2h0LW1hcms6YmVmb3Jle2NvbnRlbnQ6IlxlMTk0In0uZ2x5cGhpY29uLXJlZ2lzdHJhdGlvbi1tYXJrOmJlZm9yZXtjb250ZW50OiJcZTE5NSJ9LmdseXBoaWNvbi1jbG91ZC1kb3dubG9hZDpiZWZvcmV7Y29udGVudDoiXGUxOTcifS5nbHlwaGljb24tY2xvdWQtdXBsb2FkOmJlZm9yZXtjb250ZW50OiJcZTE5OCJ9LmdseXBoaWNvbi10cmVlLWNvbmlmZXI6YmVmb3Jle2NvbnRlbnQ6IlxlMTk5In0uZ2x5cGhpY29uLXRyZWUtZGVjaWR1b3VzOmJlZm9yZXtjb250ZW50OiJcZTIwMCJ9Knstd2Via2l0LWJveC1zaXppbmc6Ym9yZGVyLWJveDstbW96LWJveC1zaXppbmc6Ym9yZGVyLWJveDtib3gtc2l6aW5nOmJvcmRlci1ib3h9OmJlZm9yZSw6YWZ0ZXJ7LXdlYmtpdC1ib3gtc2l6aW5nOmJvcmRlci1ib3g7LW1vei1ib3gtc2l6aW5nOmJvcmRlci1ib3g7Ym94LXNpemluZzpib3JkZXItYm94fWh0bWx7Zm9udC1zaXplOjEwcHg7LXdlYmtpdC10YXAtaGlnaGxpZ2h0LWNvbG9yOnJnYmEoMCwwLDAsMCl9Ym9keXtmb250LWZhbWlseToiSGVsdmV0aWNhIE5ldWUiLEhlbHZldGljYSxBcmlhbCxzYW5zLXNlcmlmO2ZvbnQtc2l6ZToxNHB4O2xpbmUtaGVpZ2h0OjEuNDI4NTcxNDM7Y29sb3I6IzMzMztiYWNrZ3JvdW5kLWNvbG9yOiNmZmZ9aW5wdXQsYnV0dG9uLHNlbGVjdCx0ZXh0YXJlYXtmb250LWZhbWlseTppbmhlcml0O2ZvbnQtc2l6ZTppbmhlcml0O2xpbmUtaGVpZ2h0OmluaGVyaXR9YXtjb2xvcjojMzM3YWI3O3RleHQtZGVjb3JhdGlvbjpub25lfWE6aG92ZXIsYTpmb2N1c3tjb2xvcjojMjM1MjdjO3RleHQtZGVjb3JhdGlvbjp1bmRlcmxpbmV9YTpmb2N1c3tvdXRsaW5lOnRoaW4gZG90dGVkO291dGxpbmU6NXB4IGF1dG8gLXdlYmtpdC1mb2N1cy1yaW5nLWNvbG9yO291dGxpbmUtb2Zmc2V0Oi0ycHh9ZmlndXJle21hcmdpbjowfWltZ3t2ZXJ0aWNhbC1hbGlnbjptaWRkbGV9LmltZy1yZXNwb25zaXZlLC50aHVtYm5haWw+aW1nLC50aHVtYm5haWwgYT5pbWcsLmNhcm91c2VsLWlubmVyPi5pdGVtPmltZywuY2Fyb3VzZWwtaW5uZXI+Lml0ZW0+YT5pbWd7ZGlzcGxheTpibG9jazttYXgtd2lkdGg6MTAwJTtoZWlnaHQ6YXV0b30uaW1nLXJvdW5kZWR7Ym9yZGVyLXJhZGl1czo2cHh9LmltZy10aHVtYm5haWx7ZGlzcGxheTppbmxpbmUtYmxvY2s7bWF4LXdpZHRoOjEwMCU7aGVpZ2h0OmF1dG87cGFkZGluZzo0cHg7bGluZS1oZWlnaHQ6MS40Mjg1NzE0MztiYWNrZ3JvdW5kLWNvbG9yOiNmZmY7Ym9yZGVyOjFweCBzb2xpZCAjZGRkO2JvcmRlci1yYWRpdXM6NHB4Oy13ZWJraXQtdHJhbnNpdGlvbjphbGwgLjJzIGVhc2UtaW4tb3V0Oy1vLXRyYW5zaXRpb246YWxsIC4ycyBlYXNlLWluLW91dDt0cmFuc2l0aW9uOmFsbCAuMnMgZWFzZS1pbi1vdXR9LmltZy1jaXJjbGV7Ym9yZGVyLXJhZGl1czo1MCV9aHJ7bWFyZ2luLXRvcDoyMHB4O21hcmdpbi1ib3R0b206MjBweDtib3JkZXI6MDtib3JkZXItdG9wOjFweCBzb2xpZCAjZWVlfS5zci1vbmx5e3Bvc2l0aW9uOmFic29sdXRlO3dpZHRoOjFweDtoZWlnaHQ6MXB4O3BhZGRpbmc6MDttYXJnaW46LTFweDtvdmVyZmxvdzpoaWRkZW47Y2xpcDpyZWN0KDAsMCwwLDApO2JvcmRlcjowfS5zci1vbmx5LWZvY3VzYWJsZTphY3RpdmUsLnNyLW9ubHktZm9jdXNhYmxlOmZvY3Vze3Bvc2l0aW9uOnN0YXRpYzt3aWR0aDphdXRvO2hlaWdodDphdXRvO21hcmdpbjowO292ZXJmbG93OnZpc2libGU7Y2xpcDphdXRvfWgxLGgyLGgzLGg0LGg1LGg2LC5oMSwuaDIsLmgzLC5oNCwuaDUsLmg2e2ZvbnQtZmFtaWx5OmluaGVyaXQ7Zm9udC13ZWlnaHQ6NTAwO2xpbmUtaGVpZ2h0OjEuMTtjb2xvcjppbmhlcml0fWgxIHNtYWxsLGgyIHNtYWxsLGgzIHNtYWxsLGg0IHNtYWxsLGg1IHNtYWxsLGg2IHNtYWxsLC5oMSBzbWFsbCwuaDIgc21hbGwsLmgzIHNtYWxsLC5oNCBzbWFsbCwuaDUgc21hbGwsLmg2IHNtYWxsLGgxIC5zbWFsbCxoMiAuc21hbGwsaDMgLnNtYWxsLGg0IC5zbWFsbCxoNSAuc21hbGwsaDYgLnNtYWxsLC5oMSAuc21hbGwsLmgyIC5zbWFsbCwuaDMgLnNtYWxsLC5oNCAuc21hbGwsLmg1IC5zbWFsbCwuaDYgLnNtYWxse2ZvbnQtd2VpZ2h0OjQwMDtsaW5lLWhlaWdodDoxO2NvbG9yOiM3Nzd9aDEsLmgxLGgyLC5oMixoMywuaDN7bWFyZ2luLXRvcDoyMHB4O21hcmdpbi1ib3R0b206MTBweH1oMSBzbWFsbCwuaDEgc21hbGwsaDIgc21hbGwsLmgyIHNtYWxsLGgzIHNtYWxsLC5oMyBzbWFsbCxoMSAuc21hbGwsLmgxIC5zbWFsbCxoMiAuc21hbGwsLmgyIC5zbWFsbCxoMyAuc21hbGwsLmgzIC5zbWFsbHtmb250LXNpemU6NjUlfWg0LC5oNCxoNSwuaDUsaDYsLmg2e21hcmdpbi10b3A6MTBweDttYXJnaW4tYm90dG9tOjEwcHh9aDQgc21hbGwsLmg0IHNtYWxsLGg1IHNtYWxsLC5oNSBzbWFsbCxoNiBzbWFsbCwuaDYgc21hbGwsaDQgLnNtYWxsLC5oNCAuc21hbGwsaDUgLnNtYWxsLC5oNSAuc21hbGwsaDYgLnNtYWxsLC5oNiAuc21hbGx7Zm9udC1zaXplOjc1JX1oMSwuaDF7Zm9udC1zaXplOjM2cHh9aDIsLmgye2ZvbnQtc2l6ZTozMHB4fWgzLC5oM3tmb250LXNpemU6MjRweH1oNCwuaDR7Zm9udC1zaXplOjE4cHh9aDUsLmg1e2ZvbnQtc2l6ZToxNHB4fWg2LC5oNntmb250LXNpemU6MTJweH1we21hcmdpbjowIDAgMTBweH0ubGVhZHttYXJnaW4tYm90dG9tOjIwcHg7Zm9udC1zaXplOjE2cHg7Zm9udC13ZWlnaHQ6MzAwO2xpbmUtaGVpZ2h0OjEuNH1AbWVkaWEgKG1pbi13aWR0aDo3NjhweCl7LmxlYWR7Zm9udC1zaXplOjIxcHh9fXNtYWxsLC5zbWFsbHtmb250LXNpemU6ODUlfW1hcmssLm1hcmt7cGFkZGluZzouMmVtO2JhY2tncm91bmQtY29sb3I6I2ZjZjhlM30udGV4dC1sZWZ0e3RleHQtYWxpZ246bGVmdH0udGV4dC1yaWdodHt0ZXh0LWFsaWduOnJpZ2h0fS50ZXh0LWNlbnRlcnt0ZXh0LWFsaWduOmNlbnRlcn0udGV4dC1qdXN0aWZ5e3RleHQtYWxpZ246anVzdGlmeX0udGV4dC1ub3dyYXB7d2hpdGUtc3BhY2U6bm93cmFwfS50ZXh0LWxvd2VyY2FzZXt0ZXh0LXRyYW5zZm9ybTpsb3dlcmNhc2V9LnRleHQtdXBwZXJjYXNle3RleHQtdHJhbnNmb3JtOnVwcGVyY2FzZX0udGV4dC1jYXBpdGFsaXple3RleHQtdHJhbnNmb3JtOmNhcGl0YWxpemV9LnRleHQtbXV0ZWR7Y29sb3I6Izc3N30udGV4dC1wcmltYXJ5e2NvbG9yOiMzMzdhYjd9YS50ZXh0LXByaW1hcnk6aG92ZXJ7Y29sb3I6IzI4NjA5MH0udGV4dC1zdWNjZXNze2NvbG9yOiMzYzc2M2R9YS50ZXh0LXN1Y2Nlc3M6aG92ZXJ7Y29sb3I6IzJiNTQyY30udGV4dC1pbmZve2NvbG9yOiMzMTcwOGZ9YS50ZXh0LWluZm86aG92ZXJ7Y29sb3I6IzI0NTI2OX0udGV4dC13YXJuaW5ne2NvbG9yOiM4YTZkM2J9YS50ZXh0LXdhcm5pbmc6aG92ZXJ7Y29sb3I6IzY2NTEyY30udGV4dC1kYW5nZXJ7Y29sb3I6I2E5NDQ0Mn1hLnRleHQtZGFuZ2VyOmhvdmVye2NvbG9yOiM4NDM1MzR9LmJnLXByaW1hcnl7Y29sb3I6I2ZmZjtiYWNrZ3JvdW5kLWNvbG9yOiMzMzdhYjd9YS5iZy1wcmltYXJ5OmhvdmVye2JhY2tncm91bmQtY29sb3I6IzI4NjA5MH0uYmctc3VjY2Vzc3tiYWNrZ3JvdW5kLWNvbG9yOiNkZmYwZDh9YS5iZy1zdWNjZXNzOmhvdmVye2JhY2tncm91bmQtY29sb3I6I2MxZTJiM30uYmctaW5mb3tiYWNrZ3JvdW5kLWNvbG9yOiNkOWVkZjd9YS5iZy1pbmZvOmhvdmVye2JhY2tncm91bmQtY29sb3I6I2FmZDllZX0uYmctd2FybmluZ3tiYWNrZ3JvdW5kLWNvbG9yOiNmY2Y4ZTN9YS5iZy13YXJuaW5nOmhvdmVye2JhY2tncm91bmQtY29sb3I6I2Y3ZWNiNX0uYmctZGFuZ2Vye2JhY2tncm91bmQtY29sb3I6I2YyZGVkZX1hLmJnLWRhbmdlcjpob3ZlcntiYWNrZ3JvdW5kLWNvbG9yOiNlNGI5Yjl9LnBhZ2UtaGVhZGVye3BhZGRpbmctYm90dG9tOjlweDttYXJnaW46NDBweCAwIDIwcHg7Ym9yZGVyLWJvdHRvbToxcHggc29saWQgI2VlZX11bCxvbHttYXJnaW4tdG9wOjA7bWFyZ2luLWJvdHRvbToxMHB4fXVsIHVsLG9sIHVsLHVsIG9sLG9sIG9se21hcmdpbi1ib3R0b206MH0ubGlzdC11bnN0eWxlZHtwYWRkaW5nLWxlZnQ6MDtsaXN0LXN0eWxlOm5vbmV9Lmxpc3QtaW5saW5le3BhZGRpbmctbGVmdDowO21hcmdpbi1sZWZ0Oi01cHg7bGlzdC1zdHlsZTpub25lfS5saXN0LWlubGluZT5saXtkaXNwbGF5OmlubGluZS1ibG9jaztwYWRkaW5nLXJpZ2h0OjVweDtwYWRkaW5nLWxlZnQ6NXB4fWRse21hcmdpbi10b3A6MDttYXJnaW4tYm90dG9tOjIwcHh9ZHQsZGR7bGluZS1oZWlnaHQ6MS40Mjg1NzE0M31kdHtmb250LXdlaWdodDo3MDB9ZGR7bWFyZ2luLWxlZnQ6MH1AbWVkaWEgKG1pbi13aWR0aDo3NjhweCl7LmRsLWhvcml6b250YWwgZHR7ZmxvYXQ6bGVmdDt3aWR0aDoxNjBweDtvdmVyZmxvdzpoaWRkZW47Y2xlYXI6bGVmdDt0ZXh0LWFsaWduOnJpZ2h0O3RleHQtb3ZlcmZsb3c6ZWxsaXBzaXM7d2hpdGUtc3BhY2U6bm93cmFwfS5kbC1ob3Jpem9udGFsIGRke21hcmdpbi1sZWZ0OjE4MHB4fX1hYmJyW3RpdGxlXSxhYmJyW2RhdGEtb3JpZ2luYWwtdGl0bGVde2N1cnNvcjpoZWxwO2JvcmRlci1ib3R0b206MXB4IGRvdHRlZCAjNzc3fS5pbml0aWFsaXNte2ZvbnQtc2l6ZTo5MCU7dGV4dC10cmFuc2Zvcm06dXBwZXJjYXNlfWJsb2NrcXVvdGV7cGFkZGluZzoxMHB4IDIwcHg7bWFyZ2luOjAgMCAyMHB4O2ZvbnQtc2l6ZToxNy41cHg7Ym9yZGVyLWxlZnQ6NXB4IHNvbGlkICNlZWV9YmxvY2txdW90ZSBwOmxhc3QtY2hpbGQsYmxvY2txdW90ZSB1bDpsYXN0LWNoaWxkLGJsb2NrcXVvdGUgb2w6bGFzdC1jaGlsZHttYXJnaW4tYm90dG9tOjB9YmxvY2txdW90ZSBmb290ZXIsYmxvY2txdW90ZSBzbWFsbCxibG9ja3F1b3RlIC5zbWFsbHtkaXNwbGF5OmJsb2NrO2ZvbnQtc2l6ZTo4MCU7bGluZS1oZWlnaHQ6MS40Mjg1NzE0Mztjb2xvcjojNzc3fWJsb2NrcXVvdGUgZm9vdGVyOmJlZm9yZSxibG9ja3F1b3RlIHNtYWxsOmJlZm9yZSxibG9ja3F1b3RlIC5zbWFsbDpiZWZvcmV7Y29udGVudDonXDIwMTQgXDAwQTAnfS5ibG9ja3F1b3RlLXJldmVyc2UsYmxvY2txdW90ZS5wdWxsLXJpZ2h0e3BhZGRpbmctcmlnaHQ6MTVweDtwYWRkaW5nLWxlZnQ6MDt0ZXh0LWFsaWduOnJpZ2h0O2JvcmRlci1yaWdodDo1cHggc29saWQgI2VlZTtib3JkZXItbGVmdDowfS5ibG9ja3F1b3RlLXJldmVyc2UgZm9vdGVyOmJlZm9yZSxibG9ja3F1b3RlLnB1bGwtcmlnaHQgZm9vdGVyOmJlZm9yZSwuYmxvY2txdW90ZS1yZXZlcnNlIHNtYWxsOmJlZm9yZSxibG9ja3F1b3RlLnB1bGwtcmlnaHQgc21hbGw6YmVmb3JlLC5ibG9ja3F1b3RlLXJldmVyc2UgLnNtYWxsOmJlZm9yZSxibG9ja3F1b3RlLnB1bGwtcmlnaHQgLnNtYWxsOmJlZm9yZXtjb250ZW50OicnfS5ibG9ja3F1b3RlLXJldmVyc2UgZm9vdGVyOmFmdGVyLGJsb2NrcXVvdGUucHVsbC1yaWdodCBmb290ZXI6YWZ0ZXIsLmJsb2NrcXVvdGUtcmV2ZXJzZSBzbWFsbDphZnRlcixibG9ja3F1b3RlLnB1bGwtcmlnaHQgc21hbGw6YWZ0ZXIsLmJsb2NrcXVvdGUtcmV2ZXJzZSAuc21hbGw6YWZ0ZXIsYmxvY2txdW90ZS5wdWxsLXJpZ2h0IC5zbWFsbDphZnRlcntjb250ZW50OidcMDBBMCBcMjAxNCd9YWRkcmVzc3ttYXJnaW4tYm90dG9tOjIwcHg7Zm9udC1zdHlsZTpub3JtYWw7bGluZS1oZWlnaHQ6MS40Mjg1NzE0M31jb2RlLGtiZCxwcmUsc2FtcHtmb250LWZhbWlseTpNZW5sbyxNb25hY28sQ29uc29sYXMsIkNvdXJpZXIgTmV3Iixtb25vc3BhY2V9Y29kZXtwYWRkaW5nOjJweCA0cHg7Zm9udC1zaXplOjkwJTtjb2xvcjojYzcyNTRlO2JhY2tncm91bmQtY29sb3I6I2Y5ZjJmNDtib3JkZXItcmFkaXVzOjRweH1rYmR7cGFkZGluZzoycHggNHB4O2ZvbnQtc2l6ZTo5MCU7Y29sb3I6I2ZmZjtiYWNrZ3JvdW5kLWNvbG9yOiMzMzM7Ym9yZGVyLXJhZGl1czozcHg7LXdlYmtpdC1ib3gtc2hhZG93Omluc2V0IDAgLTFweCAwIHJnYmEoMCwwLDAsLjI1KTtib3gtc2hhZG93Omluc2V0IDAgLTFweCAwIHJnYmEoMCwwLDAsLjI1KX1rYmQga2Jke3BhZGRpbmc6MDtmb250LXNpemU6MTAwJTtmb250LXdlaWdodDo3MDA7LXdlYmtpdC1ib3gtc2hhZG93Om5vbmU7Ym94LXNoYWRvdzpub25lfXByZXtkaXNwbGF5OmJsb2NrO3BhZGRpbmc6OS41cHg7bWFyZ2luOjAgMCAxMHB4O2ZvbnQtc2l6ZToxM3B4O2xpbmUtaGVpZ2h0OjEuNDI4NTcxNDM7Y29sb3I6IzMzMzt3b3JkLWJyZWFrOmJyZWFrLWFsbDt3b3JkLXdyYXA6YnJlYWstd29yZDtiYWNrZ3JvdW5kLWNvbG9yOiNmNWY1ZjU7Ym9yZGVyOjFweCBzb2xpZCAjY2NjO2JvcmRlci1yYWRpdXM6NHB4fXByZSBjb2Rle3BhZGRpbmc6MDtmb250LXNpemU6aW5oZXJpdDtjb2xvcjppbmhlcml0O3doaXRlLXNwYWNlOnByZS13cmFwO2JhY2tncm91bmQtY29sb3I6dHJhbnNwYXJlbnQ7Ym9yZGVyLXJhZGl1czowfS5wcmUtc2Nyb2xsYWJsZXttYXgtaGVpZ2h0OjM0MHB4O292ZXJmbG93LXk6c2Nyb2xsfS5jb250YWluZXJ7cGFkZGluZy1yaWdodDoxNXB4O3BhZGRpbmctbGVmdDoxNXB4O21hcmdpbi1yaWdodDphdXRvO21hcmdpbi1sZWZ0OmF1dG99QG1lZGlhIChtaW4td2lkdGg6NzY4cHgpey5jb250YWluZXJ7d2lkdGg6NzUwcHh9fUBtZWRpYSAobWluLXdpZHRoOjk5MnB4KXsuY29udGFpbmVye3dpZHRoOjk3MHB4fX1AbWVkaWEgKG1pbi13aWR0aDoxMjAwcHgpey5jb250YWluZXJ7d2lkdGg6MTE3MHB4fX0uY29udGFpbmVyLWZsdWlke3BhZGRpbmctcmlnaHQ6MTVweDtwYWRkaW5nLWxlZnQ6MTVweDttYXJnaW4tcmlnaHQ6YXV0bzttYXJnaW4tbGVmdDphdXRvfS5yb3d7bWFyZ2luLXJpZ2h0Oi0xNXB4O21hcmdpbi1sZWZ0Oi0xNXB4fS5jb2wteHMtMSwuY29sLXNtLTEsLmNvbC1tZC0xLC5jb2wtbGctMSwuY29sLXhzLTIsLmNvbC1zbS0yLC5jb2wtbWQtMiwuY29sLWxnLTIsLmNvbC14cy0zLC5jb2wtc20tMywuY29sLW1kLTMsLmNvbC1sZy0zLC5jb2wteHMtNCwuY29sLXNtLTQsLmNvbC1tZC00LC5jb2wtbGctNCwuY29sLXhzLTUsLmNvbC1zbS01LC5jb2wtbWQtNSwuY29sLWxnLTUsLmNvbC14cy02LC5jb2wtc20tNiwuY29sLW1kLTYsLmNvbC1sZy02LC5jb2wteHMtNywuY29sLXNtLTcsLmNvbC1tZC03LC5jb2wtbGctNywuY29sLXhzLTgsLmNvbC1zbS04LC5jb2wtbWQtOCwuY29sLWxnLTgsLmNvbC14cy05LC5jb2wtc20tOSwuY29sLW1kLTksLmNvbC1sZy05LC5jb2wteHMtMTAsLmNvbC1zbS0xMCwuY29sLW1kLTEwLC5jb2wtbGctMTAsLmNvbC14cy0xMSwuY29sLXNtLTExLC5jb2wtbWQtMTEsLmNvbC1sZy0xMSwuY29sLXhzLTEyLC5jb2wtc20tMTIsLmNvbC1tZC0xMiwuY29sLWxnLTEye3Bvc2l0aW9uOnJlbGF0aXZlO21pbi1oZWlnaHQ6MXB4O3BhZGRpbmctcmlnaHQ6MTVweDtwYWRkaW5nLWxlZnQ6MTVweH0uY29sLXhzLTEsLmNvbC14cy0yLC5jb2wteHMtMywuY29sLXhzLTQsLmNvbC14cy01LC5jb2wteHMtNiwuY29sLXhzLTcsLmNvbC14cy04LC5jb2wteHMtOSwuY29sLXhzLTEwLC5jb2wteHMtMTEsLmNvbC14cy0xMntmbG9hdDpsZWZ0fS5jb2wteHMtMTJ7d2lkdGg6MTAwJX0uY29sLXhzLTExe3dpZHRoOjkxLjY2NjY2NjY3JX0uY29sLXhzLTEwe3dpZHRoOjgzLjMzMzMzMzMzJX0uY29sLXhzLTl7d2lkdGg6NzUlfS5jb2wteHMtOHt3aWR0aDo2Ni42NjY2NjY2NyV9LmNvbC14cy03e3dpZHRoOjU4LjMzMzMzMzMzJX0uY29sLXhzLTZ7d2lkdGg6NTAlfS5jb2wteHMtNXt3aWR0aDo0MS42NjY2NjY2NyV9LmNvbC14cy00e3dpZHRoOjMzLjMzMzMzMzMzJX0uY29sLXhzLTN7d2lkdGg6MjUlfS5jb2wteHMtMnt3aWR0aDoxNi42NjY2NjY2NyV9LmNvbC14cy0xe3dpZHRoOjguMzMzMzMzMzMlfS5jb2wteHMtcHVsbC0xMntyaWdodDoxMDAlfS5jb2wteHMtcHVsbC0xMXtyaWdodDo5MS42NjY2NjY2NyV9LmNvbC14cy1wdWxsLTEwe3JpZ2h0OjgzLjMzMzMzMzMzJX0uY29sLXhzLXB1bGwtOXtyaWdodDo3NSV9LmNvbC14cy1wdWxsLTh7cmlnaHQ6NjYuNjY2NjY2NjclfS5jb2wteHMtcHVsbC03e3JpZ2h0OjU4LjMzMzMzMzMzJX0uY29sLXhzLXB1bGwtNntyaWdodDo1MCV9LmNvbC14cy1wdWxsLTV7cmlnaHQ6NDEuNjY2NjY2NjclfS5jb2wteHMtcHVsbC00e3JpZ2h0OjMzLjMzMzMzMzMzJX0uY29sLXhzLXB1bGwtM3tyaWdodDoyNSV9LmNvbC14cy1wdWxsLTJ7cmlnaHQ6MTYuNjY2NjY2NjclfS5jb2wteHMtcHVsbC0xe3JpZ2h0OjguMzMzMzMzMzMlfS5jb2wteHMtcHVsbC0we3JpZ2h0OmF1dG99LmNvbC14cy1wdXNoLTEye2xlZnQ6MTAwJX0uY29sLXhzLXB1c2gtMTF7bGVmdDo5MS42NjY2NjY2NyV9LmNvbC14cy1wdXNoLTEwe2xlZnQ6ODMuMzMzMzMzMzMlfS5jb2wteHMtcHVzaC05e2xlZnQ6NzUlfS5jb2wteHMtcHVzaC04e2xlZnQ6NjYuNjY2NjY2NjclfS5jb2wteHMtcHVzaC03e2xlZnQ6NTguMzMzMzMzMzMlfS5jb2wteHMtcHVzaC02e2xlZnQ6NTAlfS5jb2wteHMtcHVzaC01e2xlZnQ6NDEuNjY2NjY2NjclfS5jb2wteHMtcHVzaC00e2xlZnQ6MzMuMzMzMzMzMzMlfS5jb2wteHMtcHVzaC0ze2xlZnQ6MjUlfS5jb2wteHMtcHVzaC0ye2xlZnQ6MTYuNjY2NjY2NjclfS5jb2wteHMtcHVzaC0xe2xlZnQ6OC4zMzMzMzMzMyV9LmNvbC14cy1wdXNoLTB7bGVmdDphdXRvfS5jb2wteHMtb2Zmc2V0LTEye21hcmdpbi1sZWZ0OjEwMCV9LmNvbC14cy1vZmZzZXQtMTF7bWFyZ2luLWxlZnQ6OTEuNjY2NjY2NjclfS5jb2wteHMtb2Zmc2V0LTEwe21hcmdpbi1sZWZ0OjgzLjMzMzMzMzMzJX0uY29sLXhzLW9mZnNldC05e21hcmdpbi1sZWZ0Ojc1JX0uY29sLXhzLW9mZnNldC04e21hcmdpbi1sZWZ0OjY2LjY2NjY2NjY3JX0uY29sLXhzLW9mZnNldC03e21hcmdpbi1sZWZ0OjU4LjMzMzMzMzMzJX0uY29sLXhzLW9mZnNldC02e21hcmdpbi1sZWZ0OjUwJX0uY29sLXhzLW9mZnNldC01e21hcmdpbi1sZWZ0OjQxLjY2NjY2NjY3JX0uY29sLXhzLW9mZnNldC00e21hcmdpbi1sZWZ0OjMzLjMzMzMzMzMzJX0uY29sLXhzLW9mZnNldC0ze21hcmdpbi1sZWZ0OjI1JX0uY29sLXhzLW9mZnNldC0ye21hcmdpbi1sZWZ0OjE2LjY2NjY2NjY3JX0uY29sLXhzLW9mZnNldC0xe21hcmdpbi1sZWZ0OjguMzMzMzMzMzMlfS5jb2wteHMtb2Zmc2V0LTB7bWFyZ2luLWxlZnQ6MH1AbWVkaWEgKG1pbi13aWR0aDo3NjhweCl7LmNvbC1zbS0xLC5jb2wtc20tMiwuY29sLXNtLTMsLmNvbC1zbS00LC5jb2wtc20tNSwuY29sLXNtLTYsLmNvbC1zbS03LC5jb2wtc20tOCwuY29sLXNtLTksLmNvbC1zbS0xMCwuY29sLXNtLTExLC5jb2wtc20tMTJ7ZmxvYXQ6bGVmdH0uY29sLXNtLTEye3dpZHRoOjEwMCV9LmNvbC1zbS0xMXt3aWR0aDo5MS42NjY2NjY2NyV9LmNvbC1zbS0xMHt3aWR0aDo4My4zMzMzMzMzMyV9LmNvbC1zbS05e3dpZHRoOjc1JX0uY29sLXNtLTh7d2lkdGg6NjYuNjY2NjY2NjclfS5jb2wtc20tN3t3aWR0aDo1OC4zMzMzMzMzMyV9LmNvbC1zbS02e3dpZHRoOjUwJX0uY29sLXNtLTV7d2lkdGg6NDEuNjY2NjY2NjclfS5jb2wtc20tNHt3aWR0aDozMy4zMzMzMzMzMyV9LmNvbC1zbS0ze3dpZHRoOjI1JX0uY29sLXNtLTJ7d2lkdGg6MTYuNjY2NjY2NjclfS5jb2wtc20tMXt3aWR0aDo4LjMzMzMzMzMzJX0uY29sLXNtLXB1bGwtMTJ7cmlnaHQ6MTAwJX0uY29sLXNtLXB1bGwtMTF7cmlnaHQ6OTEuNjY2NjY2NjclfS5jb2wtc20tcHVsbC0xMHtyaWdodDo4My4zMzMzMzMzMyV9LmNvbC1zbS1wdWxsLTl7cmlnaHQ6NzUlfS5jb2wtc20tcHVsbC04e3JpZ2h0OjY2LjY2NjY2NjY3JX0uY29sLXNtLXB1bGwtN3tyaWdodDo1OC4zMzMzMzMzMyV9LmNvbC1zbS1wdWxsLTZ7cmlnaHQ6NTAlfS5jb2wtc20tcHVsbC01e3JpZ2h0OjQxLjY2NjY2NjY3JX0uY29sLXNtLXB1bGwtNHtyaWdodDozMy4zMzMzMzMzMyV9LmNvbC1zbS1wdWxsLTN7cmlnaHQ6MjUlfS5jb2wtc20tcHVsbC0ye3JpZ2h0OjE2LjY2NjY2NjY3JX0uY29sLXNtLXB1bGwtMXtyaWdodDo4LjMzMzMzMzMzJX0uY29sLXNtLXB1bGwtMHtyaWdodDphdXRvfS5jb2wtc20tcHVzaC0xMntsZWZ0OjEwMCV9LmNvbC1zbS1wdXNoLTExe2xlZnQ6OTEuNjY2NjY2NjclfS5jb2wtc20tcHVzaC0xMHtsZWZ0OjgzLjMzMzMzMzMzJX0uY29sLXNtLXB1c2gtOXtsZWZ0Ojc1JX0uY29sLXNtLXB1c2gtOHtsZWZ0OjY2LjY2NjY2NjY3JX0uY29sLXNtLXB1c2gtN3tsZWZ0OjU4LjMzMzMzMzMzJX0uY29sLXNtLXB1c2gtNntsZWZ0OjUwJX0uY29sLXNtLXB1c2gtNXtsZWZ0OjQxLjY2NjY2NjY3JX0uY29sLXNtLXB1c2gtNHtsZWZ0OjMzLjMzMzMzMzMzJX0uY29sLXNtLXB1c2gtM3tsZWZ0OjI1JX0uY29sLXNtLXB1c2gtMntsZWZ0OjE2LjY2NjY2NjY3JX0uY29sLXNtLXB1c2gtMXtsZWZ0OjguMzMzMzMzMzMlfS5jb2wtc20tcHVzaC0we2xlZnQ6YXV0b30uY29sLXNtLW9mZnNldC0xMnttYXJnaW4tbGVmdDoxMDAlfS5jb2wtc20tb2Zmc2V0LTExe21hcmdpbi1sZWZ0OjkxLjY2NjY2NjY3JX0uY29sLXNtLW9mZnNldC0xMHttYXJnaW4tbGVmdDo4My4zMzMzMzMzMyV9LmNvbC1zbS1vZmZzZXQtOXttYXJnaW4tbGVmdDo3NSV9LmNvbC1zbS1vZmZzZXQtOHttYXJnaW4tbGVmdDo2Ni42NjY2NjY2NyV9LmNvbC1zbS1vZmZzZXQtN3ttYXJnaW4tbGVmdDo1OC4zMzMzMzMzMyV9LmNvbC1zbS1vZmZzZXQtNnttYXJnaW4tbGVmdDo1MCV9LmNvbC1zbS1vZmZzZXQtNXttYXJnaW4tbGVmdDo0MS42NjY2NjY2NyV9LmNvbC1zbS1vZmZzZXQtNHttYXJnaW4tbGVmdDozMy4zMzMzMzMzMyV9LmNvbC1zbS1vZmZzZXQtM3ttYXJnaW4tbGVmdDoyNSV9LmNvbC1zbS1vZmZzZXQtMnttYXJnaW4tbGVmdDoxNi42NjY2NjY2NyV9LmNvbC1zbS1vZmZzZXQtMXttYXJnaW4tbGVmdDo4LjMzMzMzMzMzJX0uY29sLXNtLW9mZnNldC0we21hcmdpbi1sZWZ0OjB9fUBtZWRpYSAobWluLXdpZHRoOjk5MnB4KXsuY29sLW1kLTEsLmNvbC1tZC0yLC5jb2wtbWQtMywuY29sLW1kLTQsLmNvbC1tZC01LC5jb2wtbWQtNiwuY29sLW1kLTcsLmNvbC1tZC04LC5jb2wtbWQtOSwuY29sLW1kLTEwLC5jb2wtbWQtMTEsLmNvbC1tZC0xMntmbG9hdDpsZWZ0fS5jb2wtbWQtMTJ7d2lkdGg6MTAwJX0uY29sLW1kLTExe3dpZHRoOjkxLjY2NjY2NjY3JX0uY29sLW1kLTEwe3dpZHRoOjgzLjMzMzMzMzMzJX0uY29sLW1kLTl7d2lkdGg6NzUlfS5jb2wtbWQtOHt3aWR0aDo2Ni42NjY2NjY2NyV9LmNvbC1tZC03e3dpZHRoOjU4LjMzMzMzMzMzJX0uY29sLW1kLTZ7d2lkdGg6NTAlfS5jb2wtbWQtNXt3aWR0aDo0MS42NjY2NjY2NyV9LmNvbC1tZC00e3dpZHRoOjMzLjMzMzMzMzMzJX0uY29sLW1kLTN7d2lkdGg6MjUlfS5jb2wtbWQtMnt3aWR0aDoxNi42NjY2NjY2NyV9LmNvbC1tZC0xe3dpZHRoOjguMzMzMzMzMzMlfS5jb2wtbWQtcHVsbC0xMntyaWdodDoxMDAlfS5jb2wtbWQtcHVsbC0xMXtyaWdodDo5MS42NjY2NjY2NyV9LmNvbC1tZC1wdWxsLTEwe3JpZ2h0OjgzLjMzMzMzMzMzJX0uY29sLW1kLXB1bGwtOXtyaWdodDo3NSV9LmNvbC1tZC1wdWxsLTh7cmlnaHQ6NjYuNjY2NjY2NjclfS5jb2wtbWQtcHVsbC03e3JpZ2h0OjU4LjMzMzMzMzMzJX0uY29sLW1kLXB1bGwtNntyaWdodDo1MCV9LmNvbC1tZC1wdWxsLTV7cmlnaHQ6NDEuNjY2NjY2NjclfS5jb2wtbWQtcHVsbC00e3JpZ2h0OjMzLjMzMzMzMzMzJX0uY29sLW1kLXB1bGwtM3tyaWdodDoyNSV9LmNvbC1tZC1wdWxsLTJ7cmlnaHQ6MTYuNjY2NjY2NjclfS5jb2wtbWQtcHVsbC0xe3JpZ2h0OjguMzMzMzMzMzMlfS5jb2wtbWQtcHVsbC0we3JpZ2h0OmF1dG99LmNvbC1tZC1wdXNoLTEye2xlZnQ6MTAwJX0uY29sLW1kLXB1c2gtMTF7bGVmdDo5MS42NjY2NjY2NyV9LmNvbC1tZC1wdXNoLTEwe2xlZnQ6ODMuMzMzMzMzMzMlfS5jb2wtbWQtcHVzaC05e2xlZnQ6NzUlfS5jb2wtbWQtcHVzaC04e2xlZnQ6NjYuNjY2NjY2NjclfS5jb2wtbWQtcHVzaC03e2xlZnQ6NTguMzMzMzMzMzMlfS5jb2wtbWQtcHVzaC02e2xlZnQ6NTAlfS5jb2wtbWQtcHVzaC01e2xlZnQ6NDEuNjY2NjY2NjclfS5jb2wtbWQtcHVzaC00e2xlZnQ6MzMuMzMzMzMzMzMlfS5jb2wtbWQtcHVzaC0ze2xlZnQ6MjUlfS5jb2wtbWQtcHVzaC0ye2xlZnQ6MTYuNjY2NjY2NjclfS5jb2wtbWQtcHVzaC0xe2xlZnQ6OC4zMzMzMzMzMyV9LmNvbC1tZC1wdXNoLTB7bGVmdDphdXRvfS5jb2wtbWQtb2Zmc2V0LTEye21hcmdpbi1sZWZ0OjEwMCV9LmNvbC1tZC1vZmZzZXQtMTF7bWFyZ2luLWxlZnQ6OTEuNjY2NjY2NjclfS5jb2wtbWQtb2Zmc2V0LTEwe21hcmdpbi1sZWZ0OjgzLjMzMzMzMzMzJX0uY29sLW1kLW9mZnNldC05e21hcmdpbi1sZWZ0Ojc1JX0uY29sLW1kLW9mZnNldC04e21hcmdpbi1sZWZ0OjY2LjY2NjY2NjY3JX0uY29sLW1kLW9mZnNldC03e21hcmdpbi1sZWZ0OjU4LjMzMzMzMzMzJX0uY29sLW1kLW9mZnNldC02e21hcmdpbi1sZWZ0OjUwJX0uY29sLW1kLW9mZnNldC01e21hcmdpbi1sZWZ0OjQxLjY2NjY2NjY3JX0uY29sLW1kLW9mZnNldC00e21hcmdpbi1sZWZ0OjMzLjMzMzMzMzMzJX0uY29sLW1kLW9mZnNldC0ze21hcmdpbi1sZWZ0OjI1JX0uY29sLW1kLW9mZnNldC0ye21hcmdpbi1sZWZ0OjE2LjY2NjY2NjY3JX0uY29sLW1kLW9mZnNldC0xe21hcmdpbi1sZWZ0OjguMzMzMzMzMzMlfS5jb2wtbWQtb2Zmc2V0LTB7bWFyZ2luLWxlZnQ6MH19QG1lZGlhIChtaW4td2lkdGg6MTIwMHB4KXsuY29sLWxnLTEsLmNvbC1sZy0yLC5jb2wtbGctMywuY29sLWxnLTQsLmNvbC1sZy01LC5jb2wtbGctNiwuY29sLWxnLTcsLmNvbC1sZy04LC5jb2wtbGctOSwuY29sLWxnLTEwLC5jb2wtbGctMTEsLmNvbC1sZy0xMntmbG9hdDpsZWZ0fS5jb2wtbGctMTJ7d2lkdGg6MTAwJX0uY29sLWxnLTExe3dpZHRoOjkxLjY2NjY2NjY3JX0uY29sLWxnLTEwe3dpZHRoOjgzLjMzMzMzMzMzJX0uY29sLWxnLTl7d2lkdGg6NzUlfS5jb2wtbGctOHt3aWR0aDo2Ni42NjY2NjY2NyV9LmNvbC1sZy03e3dpZHRoOjU4LjMzMzMzMzMzJX0uY29sLWxnLTZ7d2lkdGg6NTAlfS5jb2wtbGctNXt3aWR0aDo0MS42NjY2NjY2NyV9LmNvbC1sZy00e3dpZHRoOjMzLjMzMzMzMzMzJX0uY29sLWxnLTN7d2lkdGg6MjUlfS5jb2wtbGctMnt3aWR0aDoxNi42NjY2NjY2NyV9LmNvbC1sZy0xe3dpZHRoOjguMzMzMzMzMzMlfS5jb2wtbGctcHVsbC0xMntyaWdodDoxMDAlfS5jb2wtbGctcHVsbC0xMXtyaWdodDo5MS42NjY2NjY2NyV9LmNvbC1sZy1wdWxsLTEwe3JpZ2h0OjgzLjMzMzMzMzMzJX0uY29sLWxnLXB1bGwtOXtyaWdodDo3NSV9LmNvbC1sZy1wdWxsLTh7cmlnaHQ6NjYuNjY2NjY2NjclfS5jb2wtbGctcHVsbC03e3JpZ2h0OjU4LjMzMzMzMzMzJX0uY29sLWxnLXB1bGwtNntyaWdodDo1MCV9LmNvbC1sZy1wdWxsLTV7cmlnaHQ6NDEuNjY2NjY2NjclfS5jb2wtbGctcHVsbC00e3JpZ2h0OjMzLjMzMzMzMzMzJX0uY29sLWxnLXB1bGwtM3tyaWdodDoyNSV9LmNvbC1sZy1wdWxsLTJ7cmlnaHQ6MTYuNjY2NjY2NjclfS5jb2wtbGctcHVsbC0xe3JpZ2h0OjguMzMzMzMzMzMlfS5jb2wtbGctcHVsbC0we3JpZ2h0OmF1dG99LmNvbC1sZy1wdXNoLTEye2xlZnQ6MTAwJX0uY29sLWxnLXB1c2gtMTF7bGVmdDo5MS42NjY2NjY2NyV9LmNvbC1sZy1wdXNoLTEwe2xlZnQ6ODMuMzMzMzMzMzMlfS5jb2wtbGctcHVzaC05e2xlZnQ6NzUlfS5jb2wtbGctcHVzaC04e2xlZnQ6NjYuNjY2NjY2NjclfS5jb2wtbGctcHVzaC03e2xlZnQ6NTguMzMzMzMzMzMlfS5jb2wtbGctcHVzaC02e2xlZnQ6NTAlfS5jb2wtbGctcHVzaC01e2xlZnQ6NDEuNjY2NjY2NjclfS5jb2wtbGctcHVzaC00e2xlZnQ6MzMuMzMzMzMzMzMlfS5jb2wtbGctcHVzaC0ze2xlZnQ6MjUlfS5jb2wtbGctcHVzaC0ye2xlZnQ6MTYuNjY2NjY2NjclfS5jb2wtbGctcHVzaC0xe2xlZnQ6OC4zMzMzMzMzMyV9LmNvbC1sZy1wdXNoLTB7bGVmdDphdXRvfS5jb2wtbGctb2Zmc2V0LTEye21hcmdpbi1sZWZ0OjEwMCV9LmNvbC1sZy1vZmZzZXQtMTF7bWFyZ2luLWxlZnQ6OTEuNjY2NjY2NjclfS5jb2wtbGctb2Zmc2V0LTEwe21hcmdpbi1sZWZ0OjgzLjMzMzMzMzMzJX0uY29sLWxnLW9mZnNldC05e21hcmdpbi1sZWZ0Ojc1JX0uY29sLWxnLW9mZnNldC04e21hcmdpbi1sZWZ0OjY2LjY2NjY2NjY3JX0uY29sLWxnLW9mZnNldC03e21hcmdpbi1sZWZ0OjU4LjMzMzMzMzMzJX0uY29sLWxnLW9mZnNldC02e21hcmdpbi1sZWZ0OjUwJX0uY29sLWxnLW9mZnNldC01e21hcmdpbi1sZWZ0OjQxLjY2NjY2NjY3JX0uY29sLWxnLW9mZnNldC00e21hcmdpbi1sZWZ0OjMzLjMzMzMzMzMzJX0uY29sLWxnLW9mZnNldC0ze21hcmdpbi1sZWZ0OjI1JX0uY29sLWxnLW9mZnNldC0ye21hcmdpbi1sZWZ0OjE2LjY2NjY2NjY3JX0uY29sLWxnLW9mZnNldC0xe21hcmdpbi1sZWZ0OjguMzMzMzMzMzMlfS5jb2wtbGctb2Zmc2V0LTB7bWFyZ2luLWxlZnQ6MH19dGFibGV7YmFja2dyb3VuZC1jb2xvcjp0cmFuc3BhcmVudH1jYXB0aW9ue3BhZGRpbmctdG9wOjhweDtwYWRkaW5nLWJvdHRvbTo4cHg7Y29sb3I6Izc3Nzt0ZXh0LWFsaWduOmxlZnR9dGh7dGV4dC1hbGlnbjpsZWZ0fS50YWJsZXt3aWR0aDoxMDAlO21heC13aWR0aDoxMDAlO21hcmdpbi1ib3R0b206MjBweH0udGFibGU+dGhlYWQ+dHI+dGgsLnRhYmxlPnRib2R5PnRyPnRoLC50YWJsZT50Zm9vdD50cj50aCwudGFibGU+dGhlYWQ+dHI+dGQsLnRhYmxlPnRib2R5PnRyPnRkLC50YWJsZT50Zm9vdD50cj50ZHtwYWRkaW5nOjhweDtsaW5lLWhlaWdodDoxLjQyODU3MTQzO3ZlcnRpY2FsLWFsaWduOnRvcDtib3JkZXItdG9wOjFweCBzb2xpZCAjZGRkfS50YWJsZT50aGVhZD50cj50aHt2ZXJ0aWNhbC1hbGlnbjpib3R0b207Ym9yZGVyLWJvdHRvbToycHggc29saWQgI2RkZH0udGFibGU+Y2FwdGlvbit0aGVhZD50cjpmaXJzdC1jaGlsZD50aCwudGFibGU+Y29sZ3JvdXArdGhlYWQ+dHI6Zmlyc3QtY2hpbGQ+dGgsLnRhYmxlPnRoZWFkOmZpcnN0LWNoaWxkPnRyOmZpcnN0LWNoaWxkPnRoLC50YWJsZT5jYXB0aW9uK3RoZWFkPnRyOmZpcnN0LWNoaWxkPnRkLC50YWJsZT5jb2xncm91cCt0aGVhZD50cjpmaXJzdC1jaGlsZD50ZCwudGFibGU+dGhlYWQ6Zmlyc3QtY2hpbGQ+dHI6Zmlyc3QtY2hpbGQ+dGR7Ym9yZGVyLXRvcDowfS50YWJsZT50Ym9keSt0Ym9keXtib3JkZXItdG9wOjJweCBzb2xpZCAjZGRkfS50YWJsZSAudGFibGV7YmFja2dyb3VuZC1jb2xvcjojZmZmfS50YWJsZS1jb25kZW5zZWQ+dGhlYWQ+dHI+dGgsLnRhYmxlLWNvbmRlbnNlZD50Ym9keT50cj50aCwudGFibGUtY29uZGVuc2VkPnRmb290PnRyPnRoLC50YWJsZS1jb25kZW5zZWQ+dGhlYWQ+dHI+dGQsLnRhYmxlLWNvbmRlbnNlZD50Ym9keT50cj50ZCwudGFibGUtY29uZGVuc2VkPnRmb290PnRyPnRke3BhZGRpbmc6NXB4fS50YWJsZS1ib3JkZXJlZHtib3JkZXI6MXB4IHNvbGlkICNkZGR9LnRhYmxlLWJvcmRlcmVkPnRoZWFkPnRyPnRoLC50YWJsZS1ib3JkZXJlZD50Ym9keT50cj50aCwudGFibGUtYm9yZGVyZWQ+dGZvb3Q+dHI+dGgsLnRhYmxlLWJvcmRlcmVkPnRoZWFkPnRyPnRkLC50YWJsZS1ib3JkZXJlZD50Ym9keT50cj50ZCwudGFibGUtYm9yZGVyZWQ+dGZvb3Q+dHI+dGR7Ym9yZGVyOjFweCBzb2xpZCAjZGRkfS50YWJsZS1ib3JkZXJlZD50aGVhZD50cj50aCwudGFibGUtYm9yZGVyZWQ+dGhlYWQ+dHI+dGR7Ym9yZGVyLWJvdHRvbS13aWR0aDoycHh9LnRhYmxlLXN0cmlwZWQ+dGJvZHk+dHI6bnRoLWNoaWxkKG9kZCl7YmFja2dyb3VuZC1jb2xvcjojZjlmOWY5fS50YWJsZS1ob3Zlcj50Ym9keT50cjpob3ZlcntiYWNrZ3JvdW5kLWNvbG9yOiNmNWY1ZjV9dGFibGUgY29sW2NsYXNzKj1jb2wtXXtwb3NpdGlvbjpzdGF0aWM7ZGlzcGxheTp0YWJsZS1jb2x1bW47ZmxvYXQ6bm9uZX10YWJsZSB0ZFtjbGFzcyo9Y29sLV0sdGFibGUgdGhbY2xhc3MqPWNvbC1de3Bvc2l0aW9uOnN0YXRpYztkaXNwbGF5OnRhYmxlLWNlbGw7ZmxvYXQ6bm9uZX0udGFibGU+dGhlYWQ+dHI+dGQuYWN0aXZlLC50YWJsZT50Ym9keT50cj50ZC5hY3RpdmUsLnRhYmxlPnRmb290PnRyPnRkLmFjdGl2ZSwudGFibGU+dGhlYWQ+dHI+dGguYWN0aXZlLC50YWJsZT50Ym9keT50cj50aC5hY3RpdmUsLnRhYmxlPnRmb290PnRyPnRoLmFjdGl2ZSwudGFibGU+dGhlYWQ+dHIuYWN0aXZlPnRkLC50YWJsZT50Ym9keT50ci5hY3RpdmU+dGQsLnRhYmxlPnRmb290PnRyLmFjdGl2ZT50ZCwudGFibGU+dGhlYWQ+dHIuYWN0aXZlPnRoLC50YWJsZT50Ym9keT50ci5hY3RpdmU+dGgsLnRhYmxlPnRmb290PnRyLmFjdGl2ZT50aHtiYWNrZ3JvdW5kLWNvbG9yOiNmNWY1ZjV9LnRhYmxlLWhvdmVyPnRib2R5PnRyPnRkLmFjdGl2ZTpob3ZlciwudGFibGUtaG92ZXI+dGJvZHk+dHI+dGguYWN0aXZlOmhvdmVyLC50YWJsZS1ob3Zlcj50Ym9keT50ci5hY3RpdmU6aG92ZXI+dGQsLnRhYmxlLWhvdmVyPnRib2R5PnRyOmhvdmVyPi5hY3RpdmUsLnRhYmxlLWhvdmVyPnRib2R5PnRyLmFjdGl2ZTpob3Zlcj50aHtiYWNrZ3JvdW5kLWNvbG9yOiNlOGU4ZTh9LnRhYmxlPnRoZWFkPnRyPnRkLnN1Y2Nlc3MsLnRhYmxlPnRib2R5PnRyPnRkLnN1Y2Nlc3MsLnRhYmxlPnRmb290PnRyPnRkLnN1Y2Nlc3MsLnRhYmxlPnRoZWFkPnRyPnRoLnN1Y2Nlc3MsLnRhYmxlPnRib2R5PnRyPnRoLnN1Y2Nlc3MsLnRhYmxlPnRmb290PnRyPnRoLnN1Y2Nlc3MsLnRhYmxlPnRoZWFkPnRyLnN1Y2Nlc3M+dGQsLnRhYmxlPnRib2R5PnRyLnN1Y2Nlc3M+dGQsLnRhYmxlPnRmb290PnRyLnN1Y2Nlc3M+dGQsLnRhYmxlPnRoZWFkPnRyLnN1Y2Nlc3M+dGgsLnRhYmxlPnRib2R5PnRyLnN1Y2Nlc3M+dGgsLnRhYmxlPnRmb290PnRyLnN1Y2Nlc3M+dGh7YmFja2dyb3VuZC1jb2xvcjojZGZmMGQ4fS50YWJsZS1ob3Zlcj50Ym9keT50cj50ZC5zdWNjZXNzOmhvdmVyLC50YWJsZS1ob3Zlcj50Ym9keT50cj50aC5zdWNjZXNzOmhvdmVyLC50YWJsZS1ob3Zlcj50Ym9keT50ci5zdWNjZXNzOmhvdmVyPnRkLC50YWJsZS1ob3Zlcj50Ym9keT50cjpob3Zlcj4uc3VjY2VzcywudGFibGUtaG92ZXI+dGJvZHk+dHIuc3VjY2Vzczpob3Zlcj50aHtiYWNrZ3JvdW5kLWNvbG9yOiNkMGU5YzZ9LnRhYmxlPnRoZWFkPnRyPnRkLmluZm8sLnRhYmxlPnRib2R5PnRyPnRkLmluZm8sLnRhYmxlPnRmb290PnRyPnRkLmluZm8sLnRhYmxlPnRoZWFkPnRyPnRoLmluZm8sLnRhYmxlPnRib2R5PnRyPnRoLmluZm8sLnRhYmxlPnRmb290PnRyPnRoLmluZm8sLnRhYmxlPnRoZWFkPnRyLmluZm8+dGQsLnRhYmxlPnRib2R5PnRyLmluZm8+dGQsLnRhYmxlPnRmb290PnRyLmluZm8+dGQsLnRhYmxlPnRoZWFkPnRyLmluZm8+dGgsLnRhYmxlPnRib2R5PnRyLmluZm8+dGgsLnRhYmxlPnRmb290PnRyLmluZm8+dGh7YmFja2dyb3VuZC1jb2xvcjojZDllZGY3fS50YWJsZS1ob3Zlcj50Ym9keT50cj50ZC5pbmZvOmhvdmVyLC50YWJsZS1ob3Zlcj50Ym9keT50cj50aC5pbmZvOmhvdmVyLC50YWJsZS1ob3Zlcj50Ym9keT50ci5pbmZvOmhvdmVyPnRkLC50YWJsZS1ob3Zlcj50Ym9keT50cjpob3Zlcj4uaW5mbywudGFibGUtaG92ZXI+dGJvZHk+dHIuaW5mbzpob3Zlcj50aHtiYWNrZ3JvdW5kLWNvbG9yOiNjNGUzZjN9LnRhYmxlPnRoZWFkPnRyPnRkLndhcm5pbmcsLnRhYmxlPnRib2R5PnRyPnRkLndhcm5pbmcsLnRhYmxlPnRmb290PnRyPnRkLndhcm5pbmcsLnRhYmxlPnRoZWFkPnRyPnRoLndhcm5pbmcsLnRhYmxlPnRib2R5PnRyPnRoLndhcm5pbmcsLnRhYmxlPnRmb290PnRyPnRoLndhcm5pbmcsLnRhYmxlPnRoZWFkPnRyLndhcm5pbmc+dGQsLnRhYmxlPnRib2R5PnRyLndhcm5pbmc+dGQsLnRhYmxlPnRmb290PnRyLndhcm5pbmc+dGQsLnRhYmxlPnRoZWFkPnRyLndhcm5pbmc+dGgsLnRhYmxlPnRib2R5PnRyLndhcm5pbmc+dGgsLnRhYmxlPnRmb290PnRyLndhcm5pbmc+dGh7YmFja2dyb3VuZC1jb2xvcjojZmNmOGUzfS50YWJsZS1ob3Zlcj50Ym9keT50cj50ZC53YXJuaW5nOmhvdmVyLC50YWJsZS1ob3Zlcj50Ym9keT50cj50aC53YXJuaW5nOmhvdmVyLC50YWJsZS1ob3Zlcj50Ym9keT50ci53YXJuaW5nOmhvdmVyPnRkLC50YWJsZS1ob3Zlcj50Ym9keT50cjpob3Zlcj4ud2FybmluZywudGFibGUtaG92ZXI+dGJvZHk+dHIud2FybmluZzpob3Zlcj50aHtiYWNrZ3JvdW5kLWNvbG9yOiNmYWYyY2N9LnRhYmxlPnRoZWFkPnRyPnRkLmRhbmdlciwudGFibGU+dGJvZHk+dHI+dGQuZGFuZ2VyLC50YWJsZT50Zm9vdD50cj50ZC5kYW5nZXIsLnRhYmxlPnRoZWFkPnRyPnRoLmRhbmdlciwudGFibGU+dGJvZHk+dHI+dGguZGFuZ2VyLC50YWJsZT50Zm9vdD50cj50aC5kYW5nZXIsLnRhYmxlPnRoZWFkPnRyLmRhbmdlcj50ZCwudGFibGU+dGJvZHk+dHIuZGFuZ2VyPnRkLC50YWJsZT50Zm9vdD50ci5kYW5nZXI+dGQsLnRhYmxlPnRoZWFkPnRyLmRhbmdlcj50aCwudGFibGU+dGJvZHk+dHIuZGFuZ2VyPnRoLC50YWJsZT50Zm9vdD50ci5kYW5nZXI+dGh7YmFja2dyb3VuZC1jb2xvcjojZjJkZWRlfS50YWJsZS1ob3Zlcj50Ym9keT50cj50ZC5kYW5nZXI6aG92ZXIsLnRhYmxlLWhvdmVyPnRib2R5PnRyPnRoLmRhbmdlcjpob3ZlciwudGFibGUtaG92ZXI+dGJvZHk+dHIuZGFuZ2VyOmhvdmVyPnRkLC50YWJsZS1ob3Zlcj50Ym9keT50cjpob3Zlcj4uZGFuZ2VyLC50YWJsZS1ob3Zlcj50Ym9keT50ci5kYW5nZXI6aG92ZXI+dGh7YmFja2dyb3VuZC1jb2xvcjojZWJjY2NjfS50YWJsZS1yZXNwb25zaXZle21pbi1oZWlnaHQ6LjAxJTtvdmVyZmxvdy14OmF1dG99QG1lZGlhIHNjcmVlbiBhbmQgKG1heC13aWR0aDo3NjdweCl7LnRhYmxlLXJlc3BvbnNpdmV7d2lkdGg6MTAwJTttYXJnaW4tYm90dG9tOjE1cHg7b3ZlcmZsb3cteTpoaWRkZW47LW1zLW92ZXJmbG93LXN0eWxlOi1tcy1hdXRvaGlkaW5nLXNjcm9sbGJhcjtib3JkZXI6MXB4IHNvbGlkICNkZGR9LnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxle21hcmdpbi1ib3R0b206MH0udGFibGUtcmVzcG9uc2l2ZT4udGFibGU+dGhlYWQ+dHI+dGgsLnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlPnRib2R5PnRyPnRoLC50YWJsZS1yZXNwb25zaXZlPi50YWJsZT50Zm9vdD50cj50aCwudGFibGUtcmVzcG9uc2l2ZT4udGFibGU+dGhlYWQ+dHI+dGQsLnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlPnRib2R5PnRyPnRkLC50YWJsZS1yZXNwb25zaXZlPi50YWJsZT50Zm9vdD50cj50ZHt3aGl0ZS1zcGFjZTpub3dyYXB9LnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVke2JvcmRlcjowfS50YWJsZS1yZXNwb25zaXZlPi50YWJsZS1ib3JkZXJlZD50aGVhZD50cj50aDpmaXJzdC1jaGlsZCwudGFibGUtcmVzcG9uc2l2ZT4udGFibGUtYm9yZGVyZWQ+dGJvZHk+dHI+dGg6Zmlyc3QtY2hpbGQsLnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRmb290PnRyPnRoOmZpcnN0LWNoaWxkLC50YWJsZS1yZXNwb25zaXZlPi50YWJsZS1ib3JkZXJlZD50aGVhZD50cj50ZDpmaXJzdC1jaGlsZCwudGFibGUtcmVzcG9uc2l2ZT4udGFibGUtYm9yZGVyZWQ+dGJvZHk+dHI+dGQ6Zmlyc3QtY2hpbGQsLnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRmb290PnRyPnRkOmZpcnN0LWNoaWxke2JvcmRlci1sZWZ0OjB9LnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRoZWFkPnRyPnRoOmxhc3QtY2hpbGQsLnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRib2R5PnRyPnRoOmxhc3QtY2hpbGQsLnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRmb290PnRyPnRoOmxhc3QtY2hpbGQsLnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRoZWFkPnRyPnRkOmxhc3QtY2hpbGQsLnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRib2R5PnRyPnRkOmxhc3QtY2hpbGQsLnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRmb290PnRyPnRkOmxhc3QtY2hpbGR7Ym9yZGVyLXJpZ2h0OjB9LnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRib2R5PnRyOmxhc3QtY2hpbGQ+dGgsLnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRmb290PnRyOmxhc3QtY2hpbGQ+dGgsLnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRib2R5PnRyOmxhc3QtY2hpbGQ+dGQsLnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRmb290PnRyOmxhc3QtY2hpbGQ+dGR7Ym9yZGVyLWJvdHRvbTowfX1maWVsZHNldHttaW4td2lkdGg6MDtwYWRkaW5nOjA7bWFyZ2luOjA7Ym9yZGVyOjB9bGVnZW5ke2Rpc3BsYXk6YmxvY2s7d2lkdGg6MTAwJTtwYWRkaW5nOjA7bWFyZ2luLWJvdHRvbToyMHB4O2ZvbnQtc2l6ZToyMXB4O2xpbmUtaGVpZ2h0OmluaGVyaXQ7Y29sb3I6IzMzMztib3JkZXI6MDtib3JkZXItYm90dG9tOjFweCBzb2xpZCAjZTVlNWU1fWxhYmVse2Rpc3BsYXk6aW5saW5lLWJsb2NrO21heC13aWR0aDoxMDAlO21hcmdpbi1ib3R0b206NXB4O2ZvbnQtd2VpZ2h0OjcwMH1pbnB1dFt0eXBlPXNlYXJjaF17LXdlYmtpdC1ib3gtc2l6aW5nOmJvcmRlci1ib3g7LW1vei1ib3gtc2l6aW5nOmJvcmRlci1ib3g7Ym94LXNpemluZzpib3JkZXItYm94fWlucHV0W3R5cGU9cmFkaW9dLGlucHV0W3R5cGU9Y2hlY2tib3hde21hcmdpbjo0cHggMCAwO21hcmdpbi10b3A6MXB4IFw5O2xpbmUtaGVpZ2h0Om5vcm1hbH1pbnB1dFt0eXBlPWZpbGVde2Rpc3BsYXk6YmxvY2t9aW5wdXRbdHlwZT1yYW5nZV17ZGlzcGxheTpibG9jazt3aWR0aDoxMDAlfXNlbGVjdFttdWx0aXBsZV0sc2VsZWN0W3NpemVde2hlaWdodDphdXRvfWlucHV0W3R5cGU9ZmlsZV06Zm9jdXMsaW5wdXRbdHlwZT1yYWRpb106Zm9jdXMsaW5wdXRbdHlwZT1jaGVja2JveF06Zm9jdXN7b3V0bGluZTp0aGluIGRvdHRlZDtvdXRsaW5lOjVweCBhdXRvIC13ZWJraXQtZm9jdXMtcmluZy1jb2xvcjtvdXRsaW5lLW9mZnNldDotMnB4fW91dHB1dHtkaXNwbGF5OmJsb2NrO3BhZGRpbmctdG9wOjdweDtmb250LXNpemU6MTRweDtsaW5lLWhlaWdodDoxLjQyODU3MTQzO2NvbG9yOiM1NTV9LmZvcm0tY29udHJvbHtkaXNwbGF5OmJsb2NrO3dpZHRoOjEwMCU7aGVpZ2h0OjM0cHg7cGFkZGluZzo2cHggMTJweDtmb250LXNpemU6MTRweDtsaW5lLWhlaWdodDoxLjQyODU3MTQzO2NvbG9yOiM1NTU7YmFja2dyb3VuZC1jb2xvcjojZmZmO2JhY2tncm91bmQtaW1hZ2U6bm9uZTtib3JkZXI6MXB4IHNvbGlkICNjY2M7Ym9yZGVyLXJhZGl1czo0cHg7LXdlYmtpdC1ib3gtc2hhZG93Omluc2V0IDAgMXB4IDFweCByZ2JhKDAsMCwwLC4wNzUpO2JveC1zaGFkb3c6aW5zZXQgMCAxcHggMXB4IHJnYmEoMCwwLDAsLjA3NSk7LXdlYmtpdC10cmFuc2l0aW9uOmJvcmRlci1jb2xvciBlYXNlLWluLW91dCAuMTVzLC13ZWJraXQtYm94LXNoYWRvdyBlYXNlLWluLW91dCAuMTVzOy1vLXRyYW5zaXRpb246Ym9yZGVyLWNvbG9yIGVhc2UtaW4tb3V0IC4xNXMsYm94LXNoYWRvdyBlYXNlLWluLW91dCAuMTVzO3RyYW5zaXRpb246Ym9yZGVyLWNvbG9yIGVhc2UtaW4tb3V0IC4xNXMsYm94LXNoYWRvdyBlYXNlLWluLW91dCAuMTVzfS5mb3JtLWNvbnRyb2w6Zm9jdXN7Ym9yZGVyLWNvbG9yOiM2NmFmZTk7b3V0bGluZTowOy13ZWJraXQtYm94LXNoYWRvdzppbnNldCAwIDFweCAxcHggcmdiYSgwLDAsMCwuMDc1KSwwIDAgOHB4IHJnYmEoMTAyLDE3NSwyMzMsLjYpO2JveC1zaGFkb3c6aW5zZXQgMCAxcHggMXB4IHJnYmEoMCwwLDAsLjA3NSksMCAwIDhweCByZ2JhKDEwMiwxNzUsMjMzLC42KX0uZm9ybS1jb250cm9sOjotbW96LXBsYWNlaG9sZGVye2NvbG9yOiM5OTk7b3BhY2l0eToxfS5mb3JtLWNvbnRyb2w6LW1zLWlucHV0LXBsYWNlaG9sZGVye2NvbG9yOiM5OTl9LmZvcm0tY29udHJvbDo6LXdlYmtpdC1pbnB1dC1wbGFjZWhvbGRlcntjb2xvcjojOTk5fS5mb3JtLWNvbnRyb2xbZGlzYWJsZWRdLC5mb3JtLWNvbnRyb2xbcmVhZG9ubHldLGZpZWxkc2V0W2Rpc2FibGVkXSAuZm9ybS1jb250cm9se2N1cnNvcjpub3QtYWxsb3dlZDtiYWNrZ3JvdW5kLWNvbG9yOiNlZWU7b3BhY2l0eToxfXRleHRhcmVhLmZvcm0tY29udHJvbHtoZWlnaHQ6YXV0b31pbnB1dFt0eXBlPXNlYXJjaF17LXdlYmtpdC1hcHBlYXJhbmNlOm5vbmV9QG1lZGlhIHNjcmVlbiBhbmQgKC13ZWJraXQtbWluLWRldmljZS1waXhlbC1yYXRpbzowKXtpbnB1dFt0eXBlPWRhdGVdLGlucHV0W3R5cGU9dGltZV0saW5wdXRbdHlwZT1kYXRldGltZS1sb2NhbF0saW5wdXRbdHlwZT1tb250aF17bGluZS1oZWlnaHQ6MzRweH1pbnB1dFt0eXBlPWRhdGVdLmlucHV0LXNtLGlucHV0W3R5cGU9dGltZV0uaW5wdXQtc20saW5wdXRbdHlwZT1kYXRldGltZS1sb2NhbF0uaW5wdXQtc20saW5wdXRbdHlwZT1tb250aF0uaW5wdXQtc217bGluZS1oZWlnaHQ6MzBweH1pbnB1dFt0eXBlPWRhdGVdLmlucHV0LWxnLGlucHV0W3R5cGU9dGltZV0uaW5wdXQtbGcsaW5wdXRbdHlwZT1kYXRldGltZS1sb2NhbF0uaW5wdXQtbGcsaW5wdXRbdHlwZT1tb250aF0uaW5wdXQtbGd7bGluZS1oZWlnaHQ6NDZweH19LmZvcm0tZ3JvdXB7bWFyZ2luLWJvdHRvbToxNXB4fS5yYWRpbywuY2hlY2tib3h7cG9zaXRpb246cmVsYXRpdmU7ZGlzcGxheTpibG9jazttYXJnaW4tdG9wOjEwcHg7bWFyZ2luLWJvdHRvbToxMHB4fS5yYWRpbyBsYWJlbCwuY2hlY2tib3ggbGFiZWx7bWluLWhlaWdodDoyMHB4O3BhZGRpbmctbGVmdDoyMHB4O21hcmdpbi1ib3R0b206MDtmb250LXdlaWdodDo0MDA7Y3Vyc29yOnBvaW50ZXJ9LnJhZGlvIGlucHV0W3R5cGU9cmFkaW9dLC5yYWRpby1pbmxpbmUgaW5wdXRbdHlwZT1yYWRpb10sLmNoZWNrYm94IGlucHV0W3R5cGU9Y2hlY2tib3hdLC5jaGVja2JveC1pbmxpbmUgaW5wdXRbdHlwZT1jaGVja2JveF17cG9zaXRpb246YWJzb2x1dGU7bWFyZ2luLXRvcDo0cHggXDk7bWFyZ2luLWxlZnQ6LTIwcHh9LnJhZGlvKy5yYWRpbywuY2hlY2tib3grLmNoZWNrYm94e21hcmdpbi10b3A6LTVweH0ucmFkaW8taW5saW5lLC5jaGVja2JveC1pbmxpbmV7ZGlzcGxheTppbmxpbmUtYmxvY2s7cGFkZGluZy1sZWZ0OjIwcHg7bWFyZ2luLWJvdHRvbTowO2ZvbnQtd2VpZ2h0OjQwMDt2ZXJ0aWNhbC1hbGlnbjptaWRkbGU7Y3Vyc29yOnBvaW50ZXJ9LnJhZGlvLWlubGluZSsucmFkaW8taW5saW5lLC5jaGVja2JveC1pbmxpbmUrLmNoZWNrYm94LWlubGluZXttYXJnaW4tdG9wOjA7bWFyZ2luLWxlZnQ6MTBweH1pbnB1dFt0eXBlPXJhZGlvXVtkaXNhYmxlZF0saW5wdXRbdHlwZT1jaGVja2JveF1bZGlzYWJsZWRdLGlucHV0W3R5cGU9cmFkaW9dLmRpc2FibGVkLGlucHV0W3R5cGU9Y2hlY2tib3hdLmRpc2FibGVkLGZpZWxkc2V0W2Rpc2FibGVkXSBpbnB1dFt0eXBlPXJhZGlvXSxmaWVsZHNldFtkaXNhYmxlZF0gaW5wdXRbdHlwZT1jaGVja2JveF17Y3Vyc29yOm5vdC1hbGxvd2VkfS5yYWRpby1pbmxpbmUuZGlzYWJsZWQsLmNoZWNrYm94LWlubGluZS5kaXNhYmxlZCxmaWVsZHNldFtkaXNhYmxlZF0gLnJhZGlvLWlubGluZSxmaWVsZHNldFtkaXNhYmxlZF0gLmNoZWNrYm94LWlubGluZXtjdXJzb3I6bm90LWFsbG93ZWR9LnJhZGlvLmRpc2FibGVkIGxhYmVsLC5jaGVja2JveC5kaXNhYmxlZCBsYWJlbCxmaWVsZHNldFtkaXNhYmxlZF0gLnJhZGlvIGxhYmVsLGZpZWxkc2V0W2Rpc2FibGVkXSAuY2hlY2tib3ggbGFiZWx7Y3Vyc29yOm5vdC1hbGxvd2VkfS5mb3JtLWNvbnRyb2wtc3RhdGlje3BhZGRpbmctdG9wOjdweDtwYWRkaW5nLWJvdHRvbTo3cHg7bWFyZ2luLWJvdHRvbTowfS5mb3JtLWNvbnRyb2wtc3RhdGljLmlucHV0LWxnLC5mb3JtLWNvbnRyb2wtc3RhdGljLmlucHV0LXNte3BhZGRpbmctcmlnaHQ6MDtwYWRkaW5nLWxlZnQ6MH0uaW5wdXQtc20sLmZvcm0tZ3JvdXAtc20gLmZvcm0tY29udHJvbHtoZWlnaHQ6MzBweDtwYWRkaW5nOjVweCAxMHB4O2ZvbnQtc2l6ZToxMnB4O2xpbmUtaGVpZ2h0OjEuNTtib3JkZXItcmFkaXVzOjNweH1zZWxlY3QuaW5wdXQtc20sc2VsZWN0LmZvcm0tZ3JvdXAtc20gLmZvcm0tY29udHJvbHtoZWlnaHQ6MzBweDtsaW5lLWhlaWdodDozMHB4fXRleHRhcmVhLmlucHV0LXNtLHRleHRhcmVhLmZvcm0tZ3JvdXAtc20gLmZvcm0tY29udHJvbCxzZWxlY3RbbXVsdGlwbGVdLmlucHV0LXNtLHNlbGVjdFttdWx0aXBsZV0uZm9ybS1ncm91cC1zbSAuZm9ybS1jb250cm9se2hlaWdodDphdXRvfS5pbnB1dC1sZywuZm9ybS1ncm91cC1sZyAuZm9ybS1jb250cm9se2hlaWdodDo0NnB4O3BhZGRpbmc6MTBweCAxNnB4O2ZvbnQtc2l6ZToxOHB4O2xpbmUtaGVpZ2h0OjEuMzM7Ym9yZGVyLXJhZGl1czo2cHh9c2VsZWN0LmlucHV0LWxnLHNlbGVjdC5mb3JtLWdyb3VwLWxnIC5mb3JtLWNvbnRyb2x7aGVpZ2h0OjQ2cHg7bGluZS1oZWlnaHQ6NDZweH10ZXh0YXJlYS5pbnB1dC1sZyx0ZXh0YXJlYS5mb3JtLWdyb3VwLWxnIC5mb3JtLWNvbnRyb2wsc2VsZWN0W211bHRpcGxlXS5pbnB1dC1sZyxzZWxlY3RbbXVsdGlwbGVdLmZvcm0tZ3JvdXAtbGcgLmZvcm0tY29udHJvbHtoZWlnaHQ6YXV0b30uaGFzLWZlZWRiYWNre3Bvc2l0aW9uOnJlbGF0aXZlfS5oYXMtZmVlZGJhY2sgLmZvcm0tY29udHJvbHtwYWRkaW5nLXJpZ2h0OjQyLjVweH0uZm9ybS1jb250cm9sLWZlZWRiYWNre3Bvc2l0aW9uOmFic29sdXRlO3RvcDowO3JpZ2h0OjA7ei1pbmRleDoyO2Rpc3BsYXk6YmxvY2s7d2lkdGg6MzRweDtoZWlnaHQ6MzRweDtsaW5lLWhlaWdodDozNHB4O3RleHQtYWxpZ246Y2VudGVyO3BvaW50ZXItZXZlbnRzOm5vbmV9LmlucHV0LWxnKy5mb3JtLWNvbnRyb2wtZmVlZGJhY2t7d2lkdGg6NDZweDtoZWlnaHQ6NDZweDtsaW5lLWhlaWdodDo0NnB4fS5pbnB1dC1zbSsuZm9ybS1jb250cm9sLWZlZWRiYWNre3dpZHRoOjMwcHg7aGVpZ2h0OjMwcHg7bGluZS1oZWlnaHQ6MzBweH0uaGFzLXN1Y2Nlc3MgLmhlbHAtYmxvY2ssLmhhcy1zdWNjZXNzIC5jb250cm9sLWxhYmVsLC5oYXMtc3VjY2VzcyAucmFkaW8sLmhhcy1zdWNjZXNzIC5jaGVja2JveCwuaGFzLXN1Y2Nlc3MgLnJhZGlvLWlubGluZSwuaGFzLXN1Y2Nlc3MgLmNoZWNrYm94LWlubGluZSwuaGFzLXN1Y2Nlc3MucmFkaW8gbGFiZWwsLmhhcy1zdWNjZXNzLmNoZWNrYm94IGxhYmVsLC5oYXMtc3VjY2Vzcy5yYWRpby1pbmxpbmUgbGFiZWwsLmhhcy1zdWNjZXNzLmNoZWNrYm94LWlubGluZSBsYWJlbHtjb2xvcjojM2M3NjNkfS5oYXMtc3VjY2VzcyAuZm9ybS1jb250cm9se2JvcmRlci1jb2xvcjojM2M3NjNkOy13ZWJraXQtYm94LXNoYWRvdzppbnNldCAwIDFweCAxcHggcmdiYSgwLDAsMCwuMDc1KTtib3gtc2hhZG93Omluc2V0IDAgMXB4IDFweCByZ2JhKDAsMCwwLC4wNzUpfS5oYXMtc3VjY2VzcyAuZm9ybS1jb250cm9sOmZvY3Vze2JvcmRlci1jb2xvcjojMmI1NDJjOy13ZWJraXQtYm94LXNoYWRvdzppbnNldCAwIDFweCAxcHggcmdiYSgwLDAsMCwuMDc1KSwwIDAgNnB4ICM2N2IxNjg7Ym94LXNoYWRvdzppbnNldCAwIDFweCAxcHggcmdiYSgwLDAsMCwuMDc1KSwwIDAgNnB4ICM2N2IxNjh9Lmhhcy1zdWNjZXNzIC5pbnB1dC1ncm91cC1hZGRvbntjb2xvcjojM2M3NjNkO2JhY2tncm91bmQtY29sb3I6I2RmZjBkODtib3JkZXItY29sb3I6IzNjNzYzZH0uaGFzLXN1Y2Nlc3MgLmZvcm0tY29udHJvbC1mZWVkYmFja3tjb2xvcjojM2M3NjNkfS5oYXMtd2FybmluZyAuaGVscC1ibG9jaywuaGFzLXdhcm5pbmcgLmNvbnRyb2wtbGFiZWwsLmhhcy13YXJuaW5nIC5yYWRpbywuaGFzLXdhcm5pbmcgLmNoZWNrYm94LC5oYXMtd2FybmluZyAucmFkaW8taW5saW5lLC5oYXMtd2FybmluZyAuY2hlY2tib3gtaW5saW5lLC5oYXMtd2FybmluZy5yYWRpbyBsYWJlbCwuaGFzLXdhcm5pbmcuY2hlY2tib3ggbGFiZWwsLmhhcy13YXJuaW5nLnJhZGlvLWlubGluZSBsYWJlbCwuaGFzLXdhcm5pbmcuY2hlY2tib3gtaW5saW5lIGxhYmVse2NvbG9yOiM4YTZkM2J9Lmhhcy13YXJuaW5nIC5mb3JtLWNvbnRyb2x7Ym9yZGVyLWNvbG9yOiM4YTZkM2I7LXdlYmtpdC1ib3gtc2hhZG93Omluc2V0IDAgMXB4IDFweCByZ2JhKDAsMCwwLC4wNzUpO2JveC1zaGFkb3c6aW5zZXQgMCAxcHggMXB4IHJnYmEoMCwwLDAsLjA3NSl9Lmhhcy13YXJuaW5nIC5mb3JtLWNvbnRyb2w6Zm9jdXN7Ym9yZGVyLWNvbG9yOiM2NjUxMmM7LXdlYmtpdC1ib3gtc2hhZG93Omluc2V0IDAgMXB4IDFweCByZ2JhKDAsMCwwLC4wNzUpLDAgMCA2cHggI2MwYTE2Yjtib3gtc2hhZG93Omluc2V0IDAgMXB4IDFweCByZ2JhKDAsMCwwLC4wNzUpLDAgMCA2cHggI2MwYTE2Yn0uaGFzLXdhcm5pbmcgLmlucHV0LWdyb3VwLWFkZG9ue2NvbG9yOiM4YTZkM2I7YmFja2dyb3VuZC1jb2xvcjojZmNmOGUzO2JvcmRlci1jb2xvcjojOGE2ZDNifS5oYXMtd2FybmluZyAuZm9ybS1jb250cm9sLWZlZWRiYWNre2NvbG9yOiM4YTZkM2J9Lmhhcy1lcnJvciAuaGVscC1ibG9jaywuaGFzLWVycm9yIC5jb250cm9sLWxhYmVsLC5oYXMtZXJyb3IgLnJhZGlvLC5oYXMtZXJyb3IgLmNoZWNrYm94LC5oYXMtZXJyb3IgLnJhZGlvLWlubGluZSwuaGFzLWVycm9yIC5jaGVja2JveC1pbmxpbmUsLmhhcy1lcnJvci5yYWRpbyBsYWJlbCwuaGFzLWVycm9yLmNoZWNrYm94IGxhYmVsLC5oYXMtZXJyb3IucmFkaW8taW5saW5lIGxhYmVsLC5oYXMtZXJyb3IuY2hlY2tib3gtaW5saW5lIGxhYmVse2NvbG9yOiNhOTQ0NDJ9Lmhhcy1lcnJvciAuZm9ybS1jb250cm9se2JvcmRlci1jb2xvcjojYTk0NDQyOy13ZWJraXQtYm94LXNoYWRvdzppbnNldCAwIDFweCAxcHggcmdiYSgwLDAsMCwuMDc1KTtib3gtc2hhZG93Omluc2V0IDAgMXB4IDFweCByZ2JhKDAsMCwwLC4wNzUpfS5oYXMtZXJyb3IgLmZvcm0tY29udHJvbDpmb2N1c3tib3JkZXItY29sb3I6Izg0MzUzNDstd2Via2l0LWJveC1zaGFkb3c6aW5zZXQgMCAxcHggMXB4IHJnYmEoMCwwLDAsLjA3NSksMCAwIDZweCAjY2U4NDgzO2JveC1zaGFkb3c6aW5zZXQgMCAxcHggMXB4IHJnYmEoMCwwLDAsLjA3NSksMCAwIDZweCAjY2U4NDgzfS5oYXMtZXJyb3IgLmlucHV0LWdyb3VwLWFkZG9ue2NvbG9yOiNhOTQ0NDI7YmFja2dyb3VuZC1jb2xvcjojZjJkZWRlO2JvcmRlci1jb2xvcjojYTk0NDQyfS5oYXMtZXJyb3IgLmZvcm0tY29udHJvbC1mZWVkYmFja3tjb2xvcjojYTk0NDQyfS5oYXMtZmVlZGJhY2sgbGFiZWx+LmZvcm0tY29udHJvbC1mZWVkYmFja3t0b3A6MjVweH0uaGFzLWZlZWRiYWNrIGxhYmVsLnNyLW9ubHl+LmZvcm0tY29udHJvbC1mZWVkYmFja3t0b3A6MH0uaGVscC1ibG9ja3tkaXNwbGF5OmJsb2NrO21hcmdpbi10b3A6NXB4O21hcmdpbi1ib3R0b206MTBweDtjb2xvcjojNzM3MzczfUBtZWRpYSAobWluLXdpZHRoOjc2OHB4KXsuZm9ybS1pbmxpbmUgLmZvcm0tZ3JvdXB7ZGlzcGxheTppbmxpbmUtYmxvY2s7bWFyZ2luLWJvdHRvbTowO3ZlcnRpY2FsLWFsaWduOm1pZGRsZX0uZm9ybS1pbmxpbmUgLmZvcm0tY29udHJvbHtkaXNwbGF5OmlubGluZS1ibG9jazt3aWR0aDphdXRvO3ZlcnRpY2FsLWFsaWduOm1pZGRsZX0uZm9ybS1pbmxpbmUgLmZvcm0tY29udHJvbC1zdGF0aWN7ZGlzcGxheTppbmxpbmUtYmxvY2t9LmZvcm0taW5saW5lIC5pbnB1dC1ncm91cHtkaXNwbGF5OmlubGluZS10YWJsZTt2ZXJ0aWNhbC1hbGlnbjptaWRkbGV9LmZvcm0taW5saW5lIC5pbnB1dC1ncm91cCAuaW5wdXQtZ3JvdXAtYWRkb24sLmZvcm0taW5saW5lIC5pbnB1dC1ncm91cCAuaW5wdXQtZ3JvdXAtYnRuLC5mb3JtLWlubGluZSAuaW5wdXQtZ3JvdXAgLmZvcm0tY29udHJvbHt3aWR0aDphdXRvfS5mb3JtLWlubGluZSAuaW5wdXQtZ3JvdXA+LmZvcm0tY29udHJvbHt3aWR0aDoxMDAlfS5mb3JtLWlubGluZSAuY29udHJvbC1sYWJlbHttYXJnaW4tYm90dG9tOjA7dmVydGljYWwtYWxpZ246bWlkZGxlfS5mb3JtLWlubGluZSAucmFkaW8sLmZvcm0taW5saW5lIC5jaGVja2JveHtkaXNwbGF5OmlubGluZS1ibG9jazttYXJnaW4tdG9wOjA7bWFyZ2luLWJvdHRvbTowO3ZlcnRpY2FsLWFsaWduOm1pZGRsZX0uZm9ybS1pbmxpbmUgLnJhZGlvIGxhYmVsLC5mb3JtLWlubGluZSAuY2hlY2tib3ggbGFiZWx7cGFkZGluZy1sZWZ0OjB9LmZvcm0taW5saW5lIC5yYWRpbyBpbnB1dFt0eXBlPXJhZGlvXSwuZm9ybS1pbmxpbmUgLmNoZWNrYm94IGlucHV0W3R5cGU9Y2hlY2tib3hde3Bvc2l0aW9uOnJlbGF0aXZlO21hcmdpbi1sZWZ0OjB9LmZvcm0taW5saW5lIC5oYXMtZmVlZGJhY2sgLmZvcm0tY29udHJvbC1mZWVkYmFja3t0b3A6MH19LmZvcm0taG9yaXpvbnRhbCAucmFkaW8sLmZvcm0taG9yaXpvbnRhbCAuY2hlY2tib3gsLmZvcm0taG9yaXpvbnRhbCAucmFkaW8taW5saW5lLC5mb3JtLWhvcml6b250YWwgLmNoZWNrYm94LWlubGluZXtwYWRkaW5nLXRvcDo3cHg7bWFyZ2luLXRvcDowO21hcmdpbi1ib3R0b206MH0uZm9ybS1ob3Jpem9udGFsIC5yYWRpbywuZm9ybS1ob3Jpem9udGFsIC5jaGVja2JveHttaW4taGVpZ2h0OjI3cHh9LmZvcm0taG9yaXpvbnRhbCAuZm9ybS1ncm91cHttYXJnaW4tcmlnaHQ6LTE1cHg7bWFyZ2luLWxlZnQ6LTE1cHh9QG1lZGlhIChtaW4td2lkdGg6NzY4cHgpey5mb3JtLWhvcml6b250YWwgLmNvbnRyb2wtbGFiZWx7cGFkZGluZy10b3A6N3B4O21hcmdpbi1ib3R0b206MDt0ZXh0LWFsaWduOnJpZ2h0fX0uZm9ybS1ob3Jpem9udGFsIC5oYXMtZmVlZGJhY2sgLmZvcm0tY29udHJvbC1mZWVkYmFja3tyaWdodDoxNXB4fUBtZWRpYSAobWluLXdpZHRoOjc2OHB4KXsuZm9ybS1ob3Jpem9udGFsIC5mb3JtLWdyb3VwLWxnIC5jb250cm9sLWxhYmVse3BhZGRpbmctdG9wOjE0LjNweH19QG1lZGlhIChtaW4td2lkdGg6NzY4cHgpey5mb3JtLWhvcml6b250YWwgLmZvcm0tZ3JvdXAtc20gLmNvbnRyb2wtbGFiZWx7cGFkZGluZy10b3A6NnB4fX0uYnRue2Rpc3BsYXk6aW5saW5lLWJsb2NrO3BhZGRpbmc6NnB4IDEycHg7bWFyZ2luLWJvdHRvbTowO2ZvbnQtc2l6ZToxNHB4O2ZvbnQtd2VpZ2h0OjQwMDtsaW5lLWhlaWdodDoxLjQyODU3MTQzO3RleHQtYWxpZ246Y2VudGVyO3doaXRlLXNwYWNlOm5vd3JhcDt2ZXJ0aWNhbC1hbGlnbjptaWRkbGU7LW1zLXRvdWNoLWFjdGlvbjptYW5pcHVsYXRpb247dG91Y2gtYWN0aW9uOm1hbmlwdWxhdGlvbjtjdXJzb3I6cG9pbnRlcjstd2Via2l0LXVzZXItc2VsZWN0Om5vbmU7LW1vei11c2VyLXNlbGVjdDpub25lOy1tcy11c2VyLXNlbGVjdDpub25lO3VzZXItc2VsZWN0Om5vbmU7YmFja2dyb3VuZC1pbWFnZTpub25lO2JvcmRlcjoxcHggc29saWQgdHJhbnNwYXJlbnQ7Ym9yZGVyLXJhZGl1czo0cHh9LmJ0bjpmb2N1cywuYnRuOmFjdGl2ZTpmb2N1cywuYnRuLmFjdGl2ZTpmb2N1cywuYnRuLmZvY3VzLC5idG46YWN0aXZlLmZvY3VzLC5idG4uYWN0aXZlLmZvY3Vze291dGxpbmU6dGhpbiBkb3R0ZWQ7b3V0bGluZTo1cHggYXV0byAtd2Via2l0LWZvY3VzLXJpbmctY29sb3I7b3V0bGluZS1vZmZzZXQ6LTJweH0uYnRuOmhvdmVyLC5idG46Zm9jdXMsLmJ0bi5mb2N1c3tjb2xvcjojMzMzO3RleHQtZGVjb3JhdGlvbjpub25lfS5idG46YWN0aXZlLC5idG4uYWN0aXZle2JhY2tncm91bmQtaW1hZ2U6bm9uZTtvdXRsaW5lOjA7LXdlYmtpdC1ib3gtc2hhZG93Omluc2V0IDAgM3B4IDVweCByZ2JhKDAsMCwwLC4xMjUpO2JveC1zaGFkb3c6aW5zZXQgMCAzcHggNXB4IHJnYmEoMCwwLDAsLjEyNSl9LmJ0bi5kaXNhYmxlZCwuYnRuW2Rpc2FibGVkXSxmaWVsZHNldFtkaXNhYmxlZF0gLmJ0bntwb2ludGVyLWV2ZW50czpub25lO2N1cnNvcjpub3QtYWxsb3dlZDtmaWx0ZXI6YWxwaGEob3BhY2l0eT02NSk7LXdlYmtpdC1ib3gtc2hhZG93Om5vbmU7Ym94LXNoYWRvdzpub25lO29wYWNpdHk6LjY1fS5idG4tZGVmYXVsdHtjb2xvcjojMzMzO2JhY2tncm91bmQtY29sb3I6I2ZmZjtib3JkZXItY29sb3I6I2NjY30uYnRuLWRlZmF1bHQ6aG92ZXIsLmJ0bi1kZWZhdWx0OmZvY3VzLC5idG4tZGVmYXVsdC5mb2N1cywuYnRuLWRlZmF1bHQ6YWN0aXZlLC5idG4tZGVmYXVsdC5hY3RpdmUsLm9wZW4+LmRyb3Bkb3duLXRvZ2dsZS5idG4tZGVmYXVsdHtjb2xvcjojMzMzO2JhY2tncm91bmQtY29sb3I6I2U2ZTZlNjtib3JkZXItY29sb3I6I2FkYWRhZH0uYnRuLWRlZmF1bHQ6YWN0aXZlLC5idG4tZGVmYXVsdC5hY3RpdmUsLm9wZW4+LmRyb3Bkb3duLXRvZ2dsZS5idG4tZGVmYXVsdHtiYWNrZ3JvdW5kLWltYWdlOm5vbmV9LmJ0bi1kZWZhdWx0LmRpc2FibGVkLC5idG4tZGVmYXVsdFtkaXNhYmxlZF0sZmllbGRzZXRbZGlzYWJsZWRdIC5idG4tZGVmYXVsdCwuYnRuLWRlZmF1bHQuZGlzYWJsZWQ6aG92ZXIsLmJ0bi1kZWZhdWx0W2Rpc2FibGVkXTpob3ZlcixmaWVsZHNldFtkaXNhYmxlZF0gLmJ0bi1kZWZhdWx0OmhvdmVyLC5idG4tZGVmYXVsdC5kaXNhYmxlZDpmb2N1cywuYnRuLWRlZmF1bHRbZGlzYWJsZWRdOmZvY3VzLGZpZWxkc2V0W2Rpc2FibGVkXSAuYnRuLWRlZmF1bHQ6Zm9jdXMsLmJ0bi1kZWZhdWx0LmRpc2FibGVkLmZvY3VzLC5idG4tZGVmYXVsdFtkaXNhYmxlZF0uZm9jdXMsZmllbGRzZXRbZGlzYWJsZWRdIC5idG4tZGVmYXVsdC5mb2N1cywuYnRuLWRlZmF1bHQuZGlzYWJsZWQ6YWN0aXZlLC5idG4tZGVmYXVsdFtkaXNhYmxlZF06YWN0aXZlLGZpZWxkc2V0W2Rpc2FibGVkXSAuYnRuLWRlZmF1bHQ6YWN0aXZlLC5idG4tZGVmYXVsdC5kaXNhYmxlZC5hY3RpdmUsLmJ0bi1kZWZhdWx0W2Rpc2FibGVkXS5hY3RpdmUsZmllbGRzZXRbZGlzYWJsZWRdIC5idG4tZGVmYXVsdC5hY3RpdmV7YmFja2dyb3VuZC1jb2xvcjojZmZmO2JvcmRlci1jb2xvcjojY2NjfS5idG4tZGVmYXVsdCAuYmFkZ2V7Y29sb3I6I2ZmZjtiYWNrZ3JvdW5kLWNvbG9yOiMzMzN9LmJ0bi1wcmltYXJ5e2NvbG9yOiNmZmY7YmFja2dyb3VuZC1jb2xvcjojMzM3YWI3O2JvcmRlci1jb2xvcjojMmU2ZGE0fS5idG4tcHJpbWFyeTpob3ZlciwuYnRuLXByaW1hcnk6Zm9jdXMsLmJ0bi1wcmltYXJ5LmZvY3VzLC5idG4tcHJpbWFyeTphY3RpdmUsLmJ0bi1wcmltYXJ5LmFjdGl2ZSwub3Blbj4uZHJvcGRvd24tdG9nZ2xlLmJ0bi1wcmltYXJ5e2NvbG9yOiNmZmY7YmFja2dyb3VuZC1jb2xvcjojMjg2MDkwO2JvcmRlci1jb2xvcjojMjA0ZDc0fS5idG4tcHJpbWFyeTphY3RpdmUsLmJ0bi1wcmltYXJ5LmFjdGl2ZSwub3Blbj4uZHJvcGRvd24tdG9nZ2xlLmJ0bi1wcmltYXJ5e2JhY2tncm91bmQtaW1hZ2U6bm9uZX0uYnRuLXByaW1hcnkuZGlzYWJsZWQsLmJ0bi1wcmltYXJ5W2Rpc2FibGVkXSxmaWVsZHNldFtkaXNhYmxlZF0gLmJ0bi1wcmltYXJ5LC5idG4tcHJpbWFyeS5kaXNhYmxlZDpob3ZlciwuYnRuLXByaW1hcnlbZGlzYWJsZWRdOmhvdmVyLGZpZWxkc2V0W2Rpc2FibGVkXSAuYnRuLXByaW1hcnk6aG92ZXIsLmJ0bi1wcmltYXJ5LmRpc2FibGVkOmZvY3VzLC5idG4tcHJpbWFyeVtkaXNhYmxlZF06Zm9jdXMsZmllbGRzZXRbZGlzYWJsZWRdIC5idG4tcHJpbWFyeTpmb2N1cywuYnRuLXByaW1hcnkuZGlzYWJsZWQuZm9jdXMsLmJ0bi1wcmltYXJ5W2Rpc2FibGVkXS5mb2N1cyxmaWVsZHNldFtkaXNhYmxlZF0gLmJ0bi1wcmltYXJ5LmZvY3VzLC5idG4tcHJpbWFyeS5kaXNhYmxlZDphY3RpdmUsLmJ0bi1wcmltYXJ5W2Rpc2FibGVkXTphY3RpdmUsZmllbGRzZXRbZGlzYWJsZWRdIC5idG4tcHJpbWFyeTphY3RpdmUsLmJ0bi1wcmltYXJ5LmRpc2FibGVkLmFjdGl2ZSwuYnRuLXByaW1hcnlbZGlzYWJsZWRdLmFjdGl2ZSxmaWVsZHNldFtkaXNhYmxlZF0gLmJ0bi1wcmltYXJ5LmFjdGl2ZXtiYWNrZ3JvdW5kLWNvbG9yOiMzMzdhYjc7Ym9yZGVyLWNvbG9yOiMyZTZkYTR9LmJ0bi1wcmltYXJ5IC5iYWRnZXtjb2xvcjojMzM3YWI3O2JhY2tncm91bmQtY29sb3I6I2ZmZn0uYnRuLXN1Y2Nlc3N7Y29sb3I6I2ZmZjtiYWNrZ3JvdW5kLWNvbG9yOiM1Y2I4NWM7Ym9yZGVyLWNvbG9yOiM0Y2FlNGN9LmJ0bi1zdWNjZXNzOmhvdmVyLC5idG4tc3VjY2Vzczpmb2N1cywuYnRuLXN1Y2Nlc3MuZm9jdXMsLmJ0bi1zdWNjZXNzOmFjdGl2ZSwuYnRuLXN1Y2Nlc3MuYWN0aXZlLC5vcGVuPi5kcm9wZG93bi10b2dnbGUuYnRuLXN1Y2Nlc3N7Y29sb3I6I2ZmZjtiYWNrZ3JvdW5kLWNvbG9yOiM0NDlkNDQ7Ym9yZGVyLWNvbG9yOiMzOTg0Mzl9LmJ0bi1zdWNjZXNzOmFjdGl2ZSwuYnRuLXN1Y2Nlc3MuYWN0aXZlLC5vcGVuPi5kcm9wZG93bi10b2dnbGUuYnRuLXN1Y2Nlc3N7YmFja2dyb3VuZC1pbWFnZTpub25lfS5idG4tc3VjY2Vzcy5kaXNhYmxlZCwuYnRuLXN1Y2Nlc3NbZGlzYWJsZWRdLGZpZWxkc2V0W2Rpc2FibGVkXSAuYnRuLXN1Y2Nlc3MsLmJ0bi1zdWNjZXNzLmRpc2FibGVkOmhvdmVyLC5idG4tc3VjY2Vzc1tkaXNhYmxlZF06aG92ZXIsZmllbGRzZXRbZGlzYWJsZWRdIC5idG4tc3VjY2Vzczpob3ZlciwuYnRuLXN1Y2Nlc3MuZGlzYWJsZWQ6Zm9jdXMsLmJ0bi1zdWNjZXNzW2Rpc2FibGVkXTpmb2N1cyxmaWVsZHNldFtkaXNhYmxlZF0gLmJ0bi1zdWNjZXNzOmZvY3VzLC5idG4tc3VjY2Vzcy5kaXNhYmxlZC5mb2N1cywuYnRuLXN1Y2Nlc3NbZGlzYWJsZWRdLmZvY3VzLGZpZWxkc2V0W2Rpc2FibGVkXSAuYnRuLXN1Y2Nlc3MuZm9jdXMsLmJ0bi1zdWNjZXNzLmRpc2FibGVkOmFjdGl2ZSwuYnRuLXN1Y2Nlc3NbZGlzYWJsZWRdOmFjdGl2ZSxmaWVsZHNldFtkaXNhYmxlZF0gLmJ0bi1zdWNjZXNzOmFjdGl2ZSwuYnRuLXN1Y2Nlc3MuZGlzYWJsZWQuYWN0aXZlLC5idG4tc3VjY2Vzc1tkaXNhYmxlZF0uYWN0aXZlLGZpZWxkc2V0W2Rpc2FibGVkXSAuYnRuLXN1Y2Nlc3MuYWN0aXZle2JhY2tncm91bmQtY29sb3I6IzVjYjg1Yztib3JkZXItY29sb3I6IzRjYWU0Y30uYnRuLXN1Y2Nlc3MgLmJhZGdle2NvbG9yOiM1Y2I4NWM7YmFja2dyb3VuZC1jb2xvcjojZmZmfS5idG4taW5mb3tjb2xvcjojZmZmO2JhY2tncm91bmQtY29sb3I6IzViYzBkZTtib3JkZXItY29sb3I6IzQ2YjhkYX0uYnRuLWluZm86aG92ZXIsLmJ0bi1pbmZvOmZvY3VzLC5idG4taW5mby5mb2N1cywuYnRuLWluZm86YWN0aXZlLC5idG4taW5mby5hY3RpdmUsLm9wZW4+LmRyb3Bkb3duLXRvZ2dsZS5idG4taW5mb3tjb2xvcjojZmZmO2JhY2tncm91bmQtY29sb3I6IzMxYjBkNTtib3JkZXItY29sb3I6IzI2OWFiY30uYnRuLWluZm86YWN0aXZlLC5idG4taW5mby5hY3RpdmUsLm9wZW4+LmRyb3Bkb3duLXRvZ2dsZS5idG4taW5mb3tiYWNrZ3JvdW5kLWltYWdlOm5vbmV9LmJ0bi1pbmZvLmRpc2FibGVkLC5idG4taW5mb1tkaXNhYmxlZF0sZmllbGRzZXRbZGlzYWJsZWRdIC5idG4taW5mbywuYnRuLWluZm8uZGlzYWJsZWQ6aG92ZXIsLmJ0bi1pbmZvW2Rpc2FibGVkXTpob3ZlcixmaWVsZHNldFtkaXNhYmxlZF0gLmJ0bi1pbmZvOmhvdmVyLC5idG4taW5mby5kaXNhYmxlZDpmb2N1cywuYnRuLWluZm9bZGlzYWJsZWRdOmZvY3VzLGZpZWxkc2V0W2Rpc2FibGVkXSAuYnRuLWluZm86Zm9jdXMsLmJ0bi1pbmZvLmRpc2FibGVkLmZvY3VzLC5idG4taW5mb1tkaXNhYmxlZF0uZm9jdXMsZmllbGRzZXRbZGlzYWJsZWRdIC5idG4taW5mby5mb2N1cywuYnRuLWluZm8uZGlzYWJsZWQ6YWN0aXZlLC5idG4taW5mb1tkaXNhYmxlZF06YWN0aXZlLGZpZWxkc2V0W2Rpc2FibGVkXSAuYnRuLWluZm86YWN0aXZlLC5idG4taW5mby5kaXNhYmxlZC5hY3RpdmUsLmJ0bi1pbmZvW2Rpc2FibGVkXS5hY3RpdmUsZmllbGRzZXRbZGlzYWJsZWRdIC5idG4taW5mby5hY3RpdmV7YmFja2dyb3VuZC1jb2xvcjojNWJjMGRlO2JvcmRlci1jb2xvcjojNDZiOGRhfS5idG4taW5mbyAuYmFkZ2V7Y29sb3I6IzViYzBkZTtiYWNrZ3JvdW5kLWNvbG9yOiNmZmZ9LmJ0bi13YXJuaW5ne2NvbG9yOiNmZmY7YmFja2dyb3VuZC1jb2xvcjojZjBhZDRlO2JvcmRlci1jb2xvcjojZWVhMjM2fS5idG4td2FybmluZzpob3ZlciwuYnRuLXdhcm5pbmc6Zm9jdXMsLmJ0bi13YXJuaW5nLmZvY3VzLC5idG4td2FybmluZzphY3RpdmUsLmJ0bi13YXJuaW5nLmFjdGl2ZSwub3Blbj4uZHJvcGRvd24tdG9nZ2xlLmJ0bi13YXJuaW5ne2NvbG9yOiNmZmY7YmFja2dyb3VuZC1jb2xvcjojZWM5NzFmO2JvcmRlci1jb2xvcjojZDU4NTEyfS5idG4td2FybmluZzphY3RpdmUsLmJ0bi13YXJuaW5nLmFjdGl2ZSwub3Blbj4uZHJvcGRvd24tdG9nZ2xlLmJ0bi13YXJuaW5ne2JhY2tncm91bmQtaW1hZ2U6bm9uZX0uYnRuLXdhcm5pbmcuZGlzYWJsZWQsLmJ0bi13YXJuaW5nW2Rpc2FibGVkXSxmaWVsZHNldFtkaXNhYmxlZF0gLmJ0bi13YXJuaW5nLC5idG4td2FybmluZy5kaXNhYmxlZDpob3ZlciwuYnRuLXdhcm5pbmdbZGlzYWJsZWRdOmhvdmVyLGZpZWxkc2V0W2Rpc2FibGVkXSAuYnRuLXdhcm5pbmc6aG92ZXIsLmJ0bi13YXJuaW5nLmRpc2FibGVkOmZvY3VzLC5idG4td2FybmluZ1tkaXNhYmxlZF06Zm9jdXMsZmllbGRzZXRbZGlzYWJsZWRdIC5idG4td2FybmluZzpmb2N1cywuYnRuLXdhcm5pbmcuZGlzYWJsZWQuZm9jdXMsLmJ0bi13YXJuaW5nW2Rpc2FibGVkXS5mb2N1cyxmaWVsZHNldFtkaXNhYmxlZF0gLmJ0bi13YXJuaW5nLmZvY3VzLC5idG4td2FybmluZy5kaXNhYmxlZDphY3RpdmUsLmJ0bi13YXJuaW5nW2Rpc2FibGVkXTphY3RpdmUsZmllbGRzZXRbZGlzYWJsZWRdIC5idG4td2FybmluZzphY3RpdmUsLmJ0bi13YXJuaW5nLmRpc2FibGVkLmFjdGl2ZSwuYnRuLXdhcm5pbmdbZGlzYWJsZWRdLmFjdGl2ZSxmaWVsZHNldFtkaXNhYmxlZF0gLmJ0bi13YXJuaW5nLmFjdGl2ZXtiYWNrZ3JvdW5kLWNvbG9yOiNmMGFkNGU7Ym9yZGVyLWNvbG9yOiNlZWEyMzZ9LmJ0bi13YXJuaW5nIC5iYWRnZXtjb2xvcjojZjBhZDRlO2JhY2tncm91bmQtY29sb3I6I2ZmZn0uYnRuLWRhbmdlcntjb2xvcjojZmZmO2JhY2tncm91bmQtY29sb3I6I2Q5NTM0Zjtib3JkZXItY29sb3I6I2Q0M2YzYX0uYnRuLWRhbmdlcjpob3ZlciwuYnRuLWRhbmdlcjpmb2N1cywuYnRuLWRhbmdlci5mb2N1cywuYnRuLWRhbmdlcjphY3RpdmUsLmJ0bi1kYW5nZXIuYWN0aXZlLC5vcGVuPi5kcm9wZG93bi10b2dnbGUuYnRuLWRhbmdlcntjb2xvcjojZmZmO2JhY2tncm91bmQtY29sb3I6I2M5MzAyYztib3JkZXItY29sb3I6I2FjMjkyNX0uYnRuLWRhbmdlcjphY3RpdmUsLmJ0bi1kYW5nZXIuYWN0aXZlLC5vcGVuPi5kcm9wZG93bi10b2dnbGUuYnRuLWRhbmdlcntiYWNrZ3JvdW5kLWltYWdlOm5vbmV9LmJ0bi1kYW5nZXIuZGlzYWJsZWQsLmJ0bi1kYW5nZXJbZGlzYWJsZWRdLGZpZWxkc2V0W2Rpc2FibGVkXSAuYnRuLWRhbmdlciwuYnRuLWRhbmdlci5kaXNhYmxlZDpob3ZlciwuYnRuLWRhbmdlcltkaXNhYmxlZF06aG92ZXIsZmllbGRzZXRbZGlzYWJsZWRdIC5idG4tZGFuZ2VyOmhvdmVyLC5idG4tZGFuZ2VyLmRpc2FibGVkOmZvY3VzLC5idG4tZGFuZ2VyW2Rpc2FibGVkXTpmb2N1cyxmaWVsZHNldFtkaXNhYmxlZF0gLmJ0bi1kYW5nZXI6Zm9jdXMsLmJ0bi1kYW5nZXIuZGlzYWJsZWQuZm9jdXMsLmJ0bi1kYW5nZXJbZGlzYWJsZWRdLmZvY3VzLGZpZWxkc2V0W2Rpc2FibGVkXSAuYnRuLWRhbmdlci5mb2N1cywuYnRuLWRhbmdlci5kaXNhYmxlZDphY3RpdmUsLmJ0bi1kYW5nZXJbZGlzYWJsZWRdOmFjdGl2ZSxmaWVsZHNldFtkaXNhYmxlZF0gLmJ0bi1kYW5nZXI6YWN0aXZlLC5idG4tZGFuZ2VyLmRpc2FibGVkLmFjdGl2ZSwuYnRuLWRhbmdlcltkaXNhYmxlZF0uYWN0aXZlLGZpZWxkc2V0W2Rpc2FibGVkXSAuYnRuLWRhbmdlci5hY3RpdmV7YmFja2dyb3VuZC1jb2xvcjojZDk1MzRmO2JvcmRlci1jb2xvcjojZDQzZjNhfS5idG4tZGFuZ2VyIC5iYWRnZXtjb2xvcjojZDk1MzRmO2JhY2tncm91bmQtY29sb3I6I2ZmZn0uYnRuLWxpbmt7Zm9udC13ZWlnaHQ6NDAwO2NvbG9yOiMzMzdhYjc7Ym9yZGVyLXJhZGl1czowfS5idG4tbGluaywuYnRuLWxpbms6YWN0aXZlLC5idG4tbGluay5hY3RpdmUsLmJ0bi1saW5rW2Rpc2FibGVkXSxmaWVsZHNldFtkaXNhYmxlZF0gLmJ0bi1saW5re2JhY2tncm91bmQtY29sb3I6dHJhbnNwYXJlbnQ7LXdlYmtpdC1ib3gtc2hhZG93Om5vbmU7Ym94LXNoYWRvdzpub25lfS5idG4tbGluaywuYnRuLWxpbms6aG92ZXIsLmJ0bi1saW5rOmZvY3VzLC5idG4tbGluazphY3RpdmV7Ym9yZGVyLWNvbG9yOnRyYW5zcGFyZW50fS5idG4tbGluazpob3ZlciwuYnRuLWxpbms6Zm9jdXN7Y29sb3I6IzIzNTI3Yzt0ZXh0LWRlY29yYXRpb246dW5kZXJsaW5lO2JhY2tncm91bmQtY29sb3I6dHJhbnNwYXJlbnR9LmJ0bi1saW5rW2Rpc2FibGVkXTpob3ZlcixmaWVsZHNldFtkaXNhYmxlZF0gLmJ0bi1saW5rOmhvdmVyLC5idG4tbGlua1tkaXNhYmxlZF06Zm9jdXMsZmllbGRzZXRbZGlzYWJsZWRdIC5idG4tbGluazpmb2N1c3tjb2xvcjojNzc3O3RleHQtZGVjb3JhdGlvbjpub25lfS5idG4tbGcsLmJ0bi1ncm91cC1sZz4uYnRue3BhZGRpbmc6MTBweCAxNnB4O2ZvbnQtc2l6ZToxOHB4O2xpbmUtaGVpZ2h0OjEuMzM7Ym9yZGVyLXJhZGl1czo2cHh9LmJ0bi1zbSwuYnRuLWdyb3VwLXNtPi5idG57cGFkZGluZzo1cHggMTBweDtmb250LXNpemU6MTJweDtsaW5lLWhlaWdodDoxLjU7Ym9yZGVyLXJhZGl1czozcHh9LmJ0bi14cywuYnRuLWdyb3VwLXhzPi5idG57cGFkZGluZzoxcHggNXB4O2ZvbnQtc2l6ZToxMnB4O2xpbmUtaGVpZ2h0OjEuNTtib3JkZXItcmFkaXVzOjNweH0uYnRuLWJsb2Nre2Rpc3BsYXk6YmxvY2s7d2lkdGg6MTAwJX0uYnRuLWJsb2NrKy5idG4tYmxvY2t7bWFyZ2luLXRvcDo1cHh9aW5wdXRbdHlwZT1zdWJtaXRdLmJ0bi1ibG9jayxpbnB1dFt0eXBlPXJlc2V0XS5idG4tYmxvY2ssaW5wdXRbdHlwZT1idXR0b25dLmJ0bi1ibG9ja3t3aWR0aDoxMDAlfS5mYWRle29wYWNpdHk6MDstd2Via2l0LXRyYW5zaXRpb246b3BhY2l0eSAuMTVzIGxpbmVhcjstby10cmFuc2l0aW9uOm9wYWNpdHkgLjE1cyBsaW5lYXI7dHJhbnNpdGlvbjpvcGFjaXR5IC4xNXMgbGluZWFyfS5mYWRlLmlue29wYWNpdHk6MX0uY29sbGFwc2V7ZGlzcGxheTpub25lO3Zpc2liaWxpdHk6aGlkZGVufS5jb2xsYXBzZS5pbntkaXNwbGF5OmJsb2NrO3Zpc2liaWxpdHk6dmlzaWJsZX10ci5jb2xsYXBzZS5pbntkaXNwbGF5OnRhYmxlLXJvd310Ym9keS5jb2xsYXBzZS5pbntkaXNwbGF5OnRhYmxlLXJvdy1ncm91cH0uY29sbGFwc2luZ3twb3NpdGlvbjpyZWxhdGl2ZTtoZWlnaHQ6MDtvdmVyZmxvdzpoaWRkZW47LXdlYmtpdC10cmFuc2l0aW9uLXRpbWluZy1mdW5jdGlvbjplYXNlOy1vLXRyYW5zaXRpb24tdGltaW5nLWZ1bmN0aW9uOmVhc2U7dHJhbnNpdGlvbi10aW1pbmctZnVuY3Rpb246ZWFzZTstd2Via2l0LXRyYW5zaXRpb24tZHVyYXRpb246LjM1czstby10cmFuc2l0aW9uLWR1cmF0aW9uOi4zNXM7dHJhbnNpdGlvbi1kdXJhdGlvbjouMzVzOy13ZWJraXQtdHJhbnNpdGlvbi1wcm9wZXJ0eTpoZWlnaHQsdmlzaWJpbGl0eTstby10cmFuc2l0aW9uLXByb3BlcnR5OmhlaWdodCx2aXNpYmlsaXR5O3RyYW5zaXRpb24tcHJvcGVydHk6aGVpZ2h0LHZpc2liaWxpdHl9LmNhcmV0e2Rpc3BsYXk6aW5saW5lLWJsb2NrO3dpZHRoOjA7aGVpZ2h0OjA7bWFyZ2luLWxlZnQ6MnB4O3ZlcnRpY2FsLWFsaWduOm1pZGRsZTtib3JkZXItdG9wOjRweCBzb2xpZDtib3JkZXItcmlnaHQ6NHB4IHNvbGlkIHRyYW5zcGFyZW50O2JvcmRlci1sZWZ0OjRweCBzb2xpZCB0cmFuc3BhcmVudH0uZHJvcGRvd257cG9zaXRpb246cmVsYXRpdmV9LmRyb3Bkb3duLXRvZ2dsZTpmb2N1c3tvdXRsaW5lOjB9LmRyb3Bkb3duLW1lbnV7cG9zaXRpb246YWJzb2x1dGU7dG9wOjEwMCU7bGVmdDowO3otaW5kZXg6MTAwMDtkaXNwbGF5Om5vbmU7ZmxvYXQ6bGVmdDttaW4td2lkdGg6MTYwcHg7cGFkZGluZzo1cHggMDttYXJnaW46MnB4IDAgMDtmb250LXNpemU6MTRweDt0ZXh0LWFsaWduOmxlZnQ7bGlzdC1zdHlsZTpub25lO2JhY2tncm91bmQtY29sb3I6I2ZmZjstd2Via2l0LWJhY2tncm91bmQtY2xpcDpwYWRkaW5nLWJveDtiYWNrZ3JvdW5kLWNsaXA6cGFkZGluZy1ib3g7Ym9yZGVyOjFweCBzb2xpZCAjY2NjO2JvcmRlcjoxcHggc29saWQgcmdiYSgwLDAsMCwuMTUpO2JvcmRlci1yYWRpdXM6NHB4Oy13ZWJraXQtYm94LXNoYWRvdzowIDZweCAxMnB4IHJnYmEoMCwwLDAsLjE3NSk7Ym94LXNoYWRvdzowIDZweCAxMnB4IHJnYmEoMCwwLDAsLjE3NSl9LmRyb3Bkb3duLW1lbnUucHVsbC1yaWdodHtyaWdodDowO2xlZnQ6YXV0b30uZHJvcGRvd24tbWVudSAuZGl2aWRlcntoZWlnaHQ6MXB4O21hcmdpbjo5cHggMDtvdmVyZmxvdzpoaWRkZW47YmFja2dyb3VuZC1jb2xvcjojZTVlNWU1fS5kcm9wZG93bi1tZW51PmxpPmF7ZGlzcGxheTpibG9jaztwYWRkaW5nOjNweCAyMHB4O2NsZWFyOmJvdGg7Zm9udC13ZWlnaHQ6NDAwO2xpbmUtaGVpZ2h0OjEuNDI4NTcxNDM7Y29sb3I6IzMzMzt3aGl0ZS1zcGFjZTpub3dyYXB9LmRyb3Bkb3duLW1lbnU+bGk+YTpob3ZlciwuZHJvcGRvd24tbWVudT5saT5hOmZvY3Vze2NvbG9yOiMyNjI2MjY7dGV4dC1kZWNvcmF0aW9uOm5vbmU7YmFja2dyb3VuZC1jb2xvcjojZjVmNWY1fS5kcm9wZG93bi1tZW51Pi5hY3RpdmU+YSwuZHJvcGRvd24tbWVudT4uYWN0aXZlPmE6aG92ZXIsLmRyb3Bkb3duLW1lbnU+LmFjdGl2ZT5hOmZvY3Vze2NvbG9yOiNmZmY7dGV4dC1kZWNvcmF0aW9uOm5vbmU7YmFja2dyb3VuZC1jb2xvcjojMzM3YWI3O291dGxpbmU6MH0uZHJvcGRvd24tbWVudT4uZGlzYWJsZWQ+YSwuZHJvcGRvd24tbWVudT4uZGlzYWJsZWQ+YTpob3ZlciwuZHJvcGRvd24tbWVudT4uZGlzYWJsZWQ+YTpmb2N1c3tjb2xvcjojNzc3fS5kcm9wZG93bi1tZW51Pi5kaXNhYmxlZD5hOmhvdmVyLC5kcm9wZG93bi1tZW51Pi5kaXNhYmxlZD5hOmZvY3Vze3RleHQtZGVjb3JhdGlvbjpub25lO2N1cnNvcjpub3QtYWxsb3dlZDtiYWNrZ3JvdW5kLWNvbG9yOnRyYW5zcGFyZW50O2JhY2tncm91bmQtaW1hZ2U6bm9uZTtmaWx0ZXI6cHJvZ2lkOkRYSW1hZ2VUcmFuc2Zvcm0uTWljcm9zb2Z0LmdyYWRpZW50KGVuYWJsZWQ9ZmFsc2UpfS5vcGVuPi5kcm9wZG93bi1tZW51e2Rpc3BsYXk6YmxvY2t9Lm9wZW4+YXtvdXRsaW5lOjB9LmRyb3Bkb3duLW1lbnUtcmlnaHR7cmlnaHQ6MDtsZWZ0OmF1dG99LmRyb3Bkb3duLW1lbnUtbGVmdHtyaWdodDphdXRvO2xlZnQ6MH0uZHJvcGRvd24taGVhZGVye2Rpc3BsYXk6YmxvY2s7cGFkZGluZzozcHggMjBweDtmb250LXNpemU6MTJweDtsaW5lLWhlaWdodDoxLjQyODU3MTQzO2NvbG9yOiM3Nzc7d2hpdGUtc3BhY2U6bm93cmFwfS5kcm9wZG93bi1iYWNrZHJvcHtwb3NpdGlvbjpmaXhlZDt0b3A6MDtyaWdodDowO2JvdHRvbTowO2xlZnQ6MDt6LWluZGV4Ojk5MH0ucHVsbC1yaWdodD4uZHJvcGRvd24tbWVudXtyaWdodDowO2xlZnQ6YXV0b30uZHJvcHVwIC5jYXJldCwubmF2YmFyLWZpeGVkLWJvdHRvbSAuZHJvcGRvd24gLmNhcmV0e2NvbnRlbnQ6IiI7Ym9yZGVyLXRvcDowO2JvcmRlci1ib3R0b206NHB4IHNvbGlkfS5kcm9wdXAgLmRyb3Bkb3duLW1lbnUsLm5hdmJhci1maXhlZC1ib3R0b20gLmRyb3Bkb3duIC5kcm9wZG93bi1tZW51e3RvcDphdXRvO2JvdHRvbToxMDAlO21hcmdpbi1ib3R0b206MXB4fUBtZWRpYSAobWluLXdpZHRoOjc2OHB4KXsubmF2YmFyLXJpZ2h0IC5kcm9wZG93bi1tZW51e3JpZ2h0OjA7bGVmdDphdXRvfS5uYXZiYXItcmlnaHQgLmRyb3Bkb3duLW1lbnUtbGVmdHtyaWdodDphdXRvO2xlZnQ6MH19LmJ0bi1ncm91cCwuYnRuLWdyb3VwLXZlcnRpY2Fse3Bvc2l0aW9uOnJlbGF0aXZlO2Rpc3BsYXk6aW5saW5lLWJsb2NrO3ZlcnRpY2FsLWFsaWduOm1pZGRsZX0uYnRuLWdyb3VwPi5idG4sLmJ0bi1ncm91cC12ZXJ0aWNhbD4uYnRue3Bvc2l0aW9uOnJlbGF0aXZlO2Zsb2F0OmxlZnR9LmJ0bi1ncm91cD4uYnRuOmhvdmVyLC5idG4tZ3JvdXAtdmVydGljYWw+LmJ0bjpob3ZlciwuYnRuLWdyb3VwPi5idG46Zm9jdXMsLmJ0bi1ncm91cC12ZXJ0aWNhbD4uYnRuOmZvY3VzLC5idG4tZ3JvdXA+LmJ0bjphY3RpdmUsLmJ0bi1ncm91cC12ZXJ0aWNhbD4uYnRuOmFjdGl2ZSwuYnRuLWdyb3VwPi5idG4uYWN0aXZlLC5idG4tZ3JvdXAtdmVydGljYWw+LmJ0bi5hY3RpdmV7ei1pbmRleDoyfS5idG4tZ3JvdXAgLmJ0bisuYnRuLC5idG4tZ3JvdXAgLmJ0bisuYnRuLWdyb3VwLC5idG4tZ3JvdXAgLmJ0bi1ncm91cCsuYnRuLC5idG4tZ3JvdXAgLmJ0bi1ncm91cCsuYnRuLWdyb3Vwe21hcmdpbi1sZWZ0Oi0xcHh9LmJ0bi10b29sYmFye21hcmdpbi1sZWZ0Oi01cHh9LmJ0bi10b29sYmFyIC5idG4tZ3JvdXAsLmJ0bi10b29sYmFyIC5pbnB1dC1ncm91cHtmbG9hdDpsZWZ0fS5idG4tdG9vbGJhcj4uYnRuLC5idG4tdG9vbGJhcj4uYnRuLWdyb3VwLC5idG4tdG9vbGJhcj4uaW5wdXQtZ3JvdXB7bWFyZ2luLWxlZnQ6NXB4fS5idG4tZ3JvdXA+LmJ0bjpub3QoOmZpcnN0LWNoaWxkKTpub3QoOmxhc3QtY2hpbGQpOm5vdCguZHJvcGRvd24tdG9nZ2xlKXtib3JkZXItcmFkaXVzOjB9LmJ0bi1ncm91cD4uYnRuOmZpcnN0LWNoaWxke21hcmdpbi1sZWZ0OjB9LmJ0bi1ncm91cD4uYnRuOmZpcnN0LWNoaWxkOm5vdCg6bGFzdC1jaGlsZCk6bm90KC5kcm9wZG93bi10b2dnbGUpe2JvcmRlci10b3AtcmlnaHQtcmFkaXVzOjA7Ym9yZGVyLWJvdHRvbS1yaWdodC1yYWRpdXM6MH0uYnRuLWdyb3VwPi5idG46bGFzdC1jaGlsZDpub3QoOmZpcnN0LWNoaWxkKSwuYnRuLWdyb3VwPi5kcm9wZG93bi10b2dnbGU6bm90KDpmaXJzdC1jaGlsZCl7Ym9yZGVyLXRvcC1sZWZ0LXJhZGl1czowO2JvcmRlci1ib3R0b20tbGVmdC1yYWRpdXM6MH0uYnRuLWdyb3VwPi5idG4tZ3JvdXB7ZmxvYXQ6bGVmdH0uYnRuLWdyb3VwPi5idG4tZ3JvdXA6bm90KDpmaXJzdC1jaGlsZCk6bm90KDpsYXN0LWNoaWxkKT4uYnRue2JvcmRlci1yYWRpdXM6MH0uYnRuLWdyb3VwPi5idG4tZ3JvdXA6Zmlyc3QtY2hpbGQ+LmJ0bjpsYXN0LWNoaWxkLC5idG4tZ3JvdXA+LmJ0bi1ncm91cDpmaXJzdC1jaGlsZD4uZHJvcGRvd24tdG9nZ2xle2JvcmRlci10b3AtcmlnaHQtcmFkaXVzOjA7Ym9yZGVyLWJvdHRvbS1yaWdodC1yYWRpdXM6MH0uYnRuLWdyb3VwPi5idG4tZ3JvdXA6bGFzdC1jaGlsZD4uYnRuOmZpcnN0LWNoaWxke2JvcmRlci10b3AtbGVmdC1yYWRpdXM6MDtib3JkZXItYm90dG9tLWxlZnQtcmFkaXVzOjB9LmJ0bi1ncm91cCAuZHJvcGRvd24tdG9nZ2xlOmFjdGl2ZSwuYnRuLWdyb3VwLm9wZW4gLmRyb3Bkb3duLXRvZ2dsZXtvdXRsaW5lOjB9LmJ0bi1ncm91cD4uYnRuKy5kcm9wZG93bi10b2dnbGV7cGFkZGluZy1yaWdodDo4cHg7cGFkZGluZy1sZWZ0OjhweH0uYnRuLWdyb3VwPi5idG4tbGcrLmRyb3Bkb3duLXRvZ2dsZXtwYWRkaW5nLXJpZ2h0OjEycHg7cGFkZGluZy1sZWZ0OjEycHh9LmJ0bi1ncm91cC5vcGVuIC5kcm9wZG93bi10b2dnbGV7LXdlYmtpdC1ib3gtc2hhZG93Omluc2V0IDAgM3B4IDVweCByZ2JhKDAsMCwwLC4xMjUpO2JveC1zaGFkb3c6aW5zZXQgMCAzcHggNXB4IHJnYmEoMCwwLDAsLjEyNSl9LmJ0bi1ncm91cC5vcGVuIC5kcm9wZG93bi10b2dnbGUuYnRuLWxpbmt7LXdlYmtpdC1ib3gtc2hhZG93Om5vbmU7Ym94LXNoYWRvdzpub25lfS5idG4gLmNhcmV0e21hcmdpbi1sZWZ0OjB9LmJ0bi1sZyAuY2FyZXR7Ym9yZGVyLXdpZHRoOjVweCA1cHggMDtib3JkZXItYm90dG9tLXdpZHRoOjB9LmRyb3B1cCAuYnRuLWxnIC5jYXJldHtib3JkZXItd2lkdGg6MCA1cHggNXB4fS5idG4tZ3JvdXAtdmVydGljYWw+LmJ0biwuYnRuLWdyb3VwLXZlcnRpY2FsPi5idG4tZ3JvdXAsLmJ0bi1ncm91cC12ZXJ0aWNhbD4uYnRuLWdyb3VwPi5idG57ZGlzcGxheTpibG9jaztmbG9hdDpub25lO3dpZHRoOjEwMCU7bWF4LXdpZHRoOjEwMCV9LmJ0bi1ncm91cC12ZXJ0aWNhbD4uYnRuLWdyb3VwPi5idG57ZmxvYXQ6bm9uZX0uYnRuLWdyb3VwLXZlcnRpY2FsPi5idG4rLmJ0biwuYnRuLWdyb3VwLXZlcnRpY2FsPi5idG4rLmJ0bi1ncm91cCwuYnRuLWdyb3VwLXZlcnRpY2FsPi5idG4tZ3JvdXArLmJ0biwuYnRuLWdyb3VwLXZlcnRpY2FsPi5idG4tZ3JvdXArLmJ0bi1ncm91cHttYXJnaW4tdG9wOi0xcHg7bWFyZ2luLWxlZnQ6MH0uYnRuLWdyb3VwLXZlcnRpY2FsPi5idG46bm90KDpmaXJzdC1jaGlsZCk6bm90KDpsYXN0LWNoaWxkKXtib3JkZXItcmFkaXVzOjB9LmJ0bi1ncm91cC12ZXJ0aWNhbD4uYnRuOmZpcnN0LWNoaWxkOm5vdCg6bGFzdC1jaGlsZCl7Ym9yZGVyLXRvcC1yaWdodC1yYWRpdXM6NHB4O2JvcmRlci1ib3R0b20tcmlnaHQtcmFkaXVzOjA7Ym9yZGVyLWJvdHRvbS1sZWZ0LXJhZGl1czowfS5idG4tZ3JvdXAtdmVydGljYWw+LmJ0bjpsYXN0LWNoaWxkOm5vdCg6Zmlyc3QtY2hpbGQpe2JvcmRlci10b3AtbGVmdC1yYWRpdXM6MDtib3JkZXItdG9wLXJpZ2h0LXJhZGl1czowO2JvcmRlci1ib3R0b20tbGVmdC1yYWRpdXM6NHB4fS5idG4tZ3JvdXAtdmVydGljYWw+LmJ0bi1ncm91cDpub3QoOmZpcnN0LWNoaWxkKTpub3QoOmxhc3QtY2hpbGQpPi5idG57Ym9yZGVyLXJhZGl1czowfS5idG4tZ3JvdXAtdmVydGljYWw+LmJ0bi1ncm91cDpmaXJzdC1jaGlsZDpub3QoOmxhc3QtY2hpbGQpPi5idG46bGFzdC1jaGlsZCwuYnRuLWdyb3VwLXZlcnRpY2FsPi5idG4tZ3JvdXA6Zmlyc3QtY2hpbGQ6bm90KDpsYXN0LWNoaWxkKT4uZHJvcGRvd24tdG9nZ2xle2JvcmRlci1ib3R0b20tcmlnaHQtcmFkaXVzOjA7Ym9yZGVyLWJvdHRvbS1sZWZ0LXJhZGl1czowfS5idG4tZ3JvdXAtdmVydGljYWw+LmJ0bi1ncm91cDpsYXN0LWNoaWxkOm5vdCg6Zmlyc3QtY2hpbGQpPi5idG46Zmlyc3QtY2hpbGR7Ym9yZGVyLXRvcC1sZWZ0LXJhZGl1czowO2JvcmRlci10b3AtcmlnaHQtcmFkaXVzOjB9LmJ0bi1ncm91cC1qdXN0aWZpZWR7ZGlzcGxheTp0YWJsZTt3aWR0aDoxMDAlO3RhYmxlLWxheW91dDpmaXhlZDtib3JkZXItY29sbGFwc2U6c2VwYXJhdGV9LmJ0bi1ncm91cC1qdXN0aWZpZWQ+LmJ0biwuYnRuLWdyb3VwLWp1c3RpZmllZD4uYnRuLWdyb3Vwe2Rpc3BsYXk6dGFibGUtY2VsbDtmbG9hdDpub25lO3dpZHRoOjElfS5idG4tZ3JvdXAtanVzdGlmaWVkPi5idG4tZ3JvdXAgLmJ0bnt3aWR0aDoxMDAlfS5idG4tZ3JvdXAtanVzdGlmaWVkPi5idG4tZ3JvdXAgLmRyb3Bkb3duLW1lbnV7bGVmdDphdXRvfVtkYXRhLXRvZ2dsZT1idXR0b25zXT4uYnRuIGlucHV0W3R5cGU9cmFkaW9dLFtkYXRhLXRvZ2dsZT1idXR0b25zXT4uYnRuLWdyb3VwPi5idG4gaW5wdXRbdHlwZT1yYWRpb10sW2RhdGEtdG9nZ2xlPWJ1dHRvbnNdPi5idG4gaW5wdXRbdHlwZT1jaGVja2JveF0sW2RhdGEtdG9nZ2xlPWJ1dHRvbnNdPi5idG4tZ3JvdXA+LmJ0biBpbnB1dFt0eXBlPWNoZWNrYm94XXtwb3NpdGlvbjphYnNvbHV0ZTtjbGlwOnJlY3QoMCwwLDAsMCk7cG9pbnRlci1ldmVudHM6bm9uZX0uaW5wdXQtZ3JvdXB7cG9zaXRpb246cmVsYXRpdmU7ZGlzcGxheTp0YWJsZTtib3JkZXItY29sbGFwc2U6c2VwYXJhdGV9LmlucHV0LWdyb3VwW2NsYXNzKj1jb2wtXXtmbG9hdDpub25lO3BhZGRpbmctcmlnaHQ6MDtwYWRkaW5nLWxlZnQ6MH0uaW5wdXQtZ3JvdXAgLmZvcm0tY29udHJvbHtwb3NpdGlvbjpyZWxhdGl2ZTt6LWluZGV4OjI7ZmxvYXQ6bGVmdDt3aWR0aDoxMDAlO21hcmdpbi1ib3R0b206MH0uaW5wdXQtZ3JvdXAtbGc+LmZvcm0tY29udHJvbCwuaW5wdXQtZ3JvdXAtbGc+LmlucHV0LWdyb3VwLWFkZG9uLC5pbnB1dC1ncm91cC1sZz4uaW5wdXQtZ3JvdXAtYnRuPi5idG57aGVpZ2h0OjQ2cHg7cGFkZGluZzoxMHB4IDE2cHg7Zm9udC1zaXplOjE4cHg7bGluZS1oZWlnaHQ6MS4zMztib3JkZXItcmFkaXVzOjZweH1zZWxlY3QuaW5wdXQtZ3JvdXAtbGc+LmZvcm0tY29udHJvbCxzZWxlY3QuaW5wdXQtZ3JvdXAtbGc+LmlucHV0LWdyb3VwLWFkZG9uLHNlbGVjdC5pbnB1dC1ncm91cC1sZz4uaW5wdXQtZ3JvdXAtYnRuPi5idG57aGVpZ2h0OjQ2cHg7bGluZS1oZWlnaHQ6NDZweH10ZXh0YXJlYS5pbnB1dC1ncm91cC1sZz4uZm9ybS1jb250cm9sLHRleHRhcmVhLmlucHV0LWdyb3VwLWxnPi5pbnB1dC1ncm91cC1hZGRvbix0ZXh0YXJlYS5pbnB1dC1ncm91cC1sZz4uaW5wdXQtZ3JvdXAtYnRuPi5idG4sc2VsZWN0W211bHRpcGxlXS5pbnB1dC1ncm91cC1sZz4uZm9ybS1jb250cm9sLHNlbGVjdFttdWx0aXBsZV0uaW5wdXQtZ3JvdXAtbGc+LmlucHV0LWdyb3VwLWFkZG9uLHNlbGVjdFttdWx0aXBsZV0uaW5wdXQtZ3JvdXAtbGc+LmlucHV0LWdyb3VwLWJ0bj4uYnRue2hlaWdodDphdXRvfS5pbnB1dC1ncm91cC1zbT4uZm9ybS1jb250cm9sLC5pbnB1dC1ncm91cC1zbT4uaW5wdXQtZ3JvdXAtYWRkb24sLmlucHV0LWdyb3VwLXNtPi5pbnB1dC1ncm91cC1idG4+LmJ0bntoZWlnaHQ6MzBweDtwYWRkaW5nOjVweCAxMHB4O2ZvbnQtc2l6ZToxMnB4O2xpbmUtaGVpZ2h0OjEuNTtib3JkZXItcmFkaXVzOjNweH1zZWxlY3QuaW5wdXQtZ3JvdXAtc20+LmZvcm0tY29udHJvbCxzZWxlY3QuaW5wdXQtZ3JvdXAtc20+LmlucHV0LWdyb3VwLWFkZG9uLHNlbGVjdC5pbnB1dC1ncm91cC1zbT4uaW5wdXQtZ3JvdXAtYnRuPi5idG57aGVpZ2h0OjMwcHg7bGluZS1oZWlnaHQ6MzBweH10ZXh0YXJlYS5pbnB1dC1ncm91cC1zbT4uZm9ybS1jb250cm9sLHRleHRhcmVhLmlucHV0LWdyb3VwLXNtPi5pbnB1dC1ncm91cC1hZGRvbix0ZXh0YXJlYS5pbnB1dC1ncm91cC1zbT4uaW5wdXQtZ3JvdXAtYnRuPi5idG4sc2VsZWN0W211bHRpcGxlXS5pbnB1dC1ncm91cC1zbT4uZm9ybS1jb250cm9sLHNlbGVjdFttdWx0aXBsZV0uaW5wdXQtZ3JvdXAtc20+LmlucHV0LWdyb3VwLWFkZG9uLHNlbGVjdFttdWx0aXBsZV0uaW5wdXQtZ3JvdXAtc20+LmlucHV0LWdyb3VwLWJ0bj4uYnRue2hlaWdodDphdXRvfS5pbnB1dC1ncm91cC1hZGRvbiwuaW5wdXQtZ3JvdXAtYnRuLC5pbnB1dC1ncm91cCAuZm9ybS1jb250cm9se2Rpc3BsYXk6dGFibGUtY2VsbH0uaW5wdXQtZ3JvdXAtYWRkb246bm90KDpmaXJzdC1jaGlsZCk6bm90KDpsYXN0LWNoaWxkKSwuaW5wdXQtZ3JvdXAtYnRuOm5vdCg6Zmlyc3QtY2hpbGQpOm5vdCg6bGFzdC1jaGlsZCksLmlucHV0LWdyb3VwIC5mb3JtLWNvbnRyb2w6bm90KDpmaXJzdC1jaGlsZCk6bm90KDpsYXN0LWNoaWxkKXtib3JkZXItcmFkaXVzOjB9LmlucHV0LWdyb3VwLWFkZG9uLC5pbnB1dC1ncm91cC1idG57d2lkdGg6MSU7d2hpdGUtc3BhY2U6bm93cmFwO3ZlcnRpY2FsLWFsaWduOm1pZGRsZX0uaW5wdXQtZ3JvdXAtYWRkb257cGFkZGluZzo2cHggMTJweDtmb250LXNpemU6MTRweDtmb250LXdlaWdodDo0MDA7bGluZS1oZWlnaHQ6MTtjb2xvcjojNTU1O3RleHQtYWxpZ246Y2VudGVyO2JhY2tncm91bmQtY29sb3I6I2VlZTtib3JkZXI6MXB4IHNvbGlkICNjY2M7Ym9yZGVyLXJhZGl1czo0cHh9LmlucHV0LWdyb3VwLWFkZG9uLmlucHV0LXNte3BhZGRpbmc6NXB4IDEwcHg7Zm9udC1zaXplOjEycHg7Ym9yZGVyLXJhZGl1czozcHh9LmlucHV0LWdyb3VwLWFkZG9uLmlucHV0LWxne3BhZGRpbmc6MTBweCAxNnB4O2ZvbnQtc2l6ZToxOHB4O2JvcmRlci1yYWRpdXM6NnB4fS5pbnB1dC1ncm91cC1hZGRvbiBpbnB1dFt0eXBlPXJhZGlvXSwuaW5wdXQtZ3JvdXAtYWRkb24gaW5wdXRbdHlwZT1jaGVja2JveF17bWFyZ2luLXRvcDowfS5pbnB1dC1ncm91cCAuZm9ybS1jb250cm9sOmZpcnN0LWNoaWxkLC5pbnB1dC1ncm91cC1hZGRvbjpmaXJzdC1jaGlsZCwuaW5wdXQtZ3JvdXAtYnRuOmZpcnN0LWNoaWxkPi5idG4sLmlucHV0LWdyb3VwLWJ0bjpmaXJzdC1jaGlsZD4uYnRuLWdyb3VwPi5idG4sLmlucHV0LWdyb3VwLWJ0bjpmaXJzdC1jaGlsZD4uZHJvcGRvd24tdG9nZ2xlLC5pbnB1dC1ncm91cC1idG46bGFzdC1jaGlsZD4uYnRuOm5vdCg6bGFzdC1jaGlsZCk6bm90KC5kcm9wZG93bi10b2dnbGUpLC5pbnB1dC1ncm91cC1idG46bGFzdC1jaGlsZD4uYnRuLWdyb3VwOm5vdCg6bGFzdC1jaGlsZCk+LmJ0bntib3JkZXItdG9wLXJpZ2h0LXJhZGl1czowO2JvcmRlci1ib3R0b20tcmlnaHQtcmFkaXVzOjB9LmlucHV0LWdyb3VwLWFkZG9uOmZpcnN0LWNoaWxke2JvcmRlci1yaWdodDowfS5pbnB1dC1ncm91cCAuZm9ybS1jb250cm9sOmxhc3QtY2hpbGQsLmlucHV0LWdyb3VwLWFkZG9uOmxhc3QtY2hpbGQsLmlucHV0LWdyb3VwLWJ0bjpsYXN0LWNoaWxkPi5idG4sLmlucHV0LWdyb3VwLWJ0bjpsYXN0LWNoaWxkPi5idG4tZ3JvdXA+LmJ0biwuaW5wdXQtZ3JvdXAtYnRuOmxhc3QtY2hpbGQ+LmRyb3Bkb3duLXRvZ2dsZSwuaW5wdXQtZ3JvdXAtYnRuOmZpcnN0LWNoaWxkPi5idG46bm90KDpmaXJzdC1jaGlsZCksLmlucHV0LWdyb3VwLWJ0bjpmaXJzdC1jaGlsZD4uYnRuLWdyb3VwOm5vdCg6Zmlyc3QtY2hpbGQpPi5idG57Ym9yZGVyLXRvcC1sZWZ0LXJhZGl1czowO2JvcmRlci1ib3R0b20tbGVmdC1yYWRpdXM6MH0uaW5wdXQtZ3JvdXAtYWRkb246bGFzdC1jaGlsZHtib3JkZXItbGVmdDowfS5pbnB1dC1ncm91cC1idG57cG9zaXRpb246cmVsYXRpdmU7Zm9udC1zaXplOjA7d2hpdGUtc3BhY2U6bm93cmFwfS5pbnB1dC1ncm91cC1idG4+LmJ0bntwb3NpdGlvbjpyZWxhdGl2ZX0uaW5wdXQtZ3JvdXAtYnRuPi5idG4rLmJ0bnttYXJnaW4tbGVmdDotMXB4fS5pbnB1dC1ncm91cC1idG4+LmJ0bjpob3ZlciwuaW5wdXQtZ3JvdXAtYnRuPi5idG46Zm9jdXMsLmlucHV0LWdyb3VwLWJ0bj4uYnRuOmFjdGl2ZXt6LWluZGV4OjJ9LmlucHV0LWdyb3VwLWJ0bjpmaXJzdC1jaGlsZD4uYnRuLC5pbnB1dC1ncm91cC1idG46Zmlyc3QtY2hpbGQ+LmJ0bi1ncm91cHttYXJnaW4tcmlnaHQ6LTFweH0uaW5wdXQtZ3JvdXAtYnRuOmxhc3QtY2hpbGQ+LmJ0biwuaW5wdXQtZ3JvdXAtYnRuOmxhc3QtY2hpbGQ+LmJ0bi1ncm91cHttYXJnaW4tbGVmdDotMXB4fS5uYXZ7cGFkZGluZy1sZWZ0OjA7bWFyZ2luLWJvdHRvbTowO2xpc3Qtc3R5bGU6bm9uZX0ubmF2Pmxpe3Bvc2l0aW9uOnJlbGF0aXZlO2Rpc3BsYXk6YmxvY2t9Lm5hdj5saT5he3Bvc2l0aW9uOnJlbGF0aXZlO2Rpc3BsYXk6YmxvY2s7cGFkZGluZzoxMHB4IDE1cHh9Lm5hdj5saT5hOmhvdmVyLC5uYXY+bGk+YTpmb2N1c3t0ZXh0LWRlY29yYXRpb246bm9uZTtiYWNrZ3JvdW5kLWNvbG9yOiNlZWV9Lm5hdj5saS5kaXNhYmxlZD5he2NvbG9yOiM3Nzd9Lm5hdj5saS5kaXNhYmxlZD5hOmhvdmVyLC5uYXY+bGkuZGlzYWJsZWQ+YTpmb2N1c3tjb2xvcjojNzc3O3RleHQtZGVjb3JhdGlvbjpub25lO2N1cnNvcjpub3QtYWxsb3dlZDtiYWNrZ3JvdW5kLWNvbG9yOnRyYW5zcGFyZW50fS5uYXYgLm9wZW4+YSwubmF2IC5vcGVuPmE6aG92ZXIsLm5hdiAub3Blbj5hOmZvY3Vze2JhY2tncm91bmQtY29sb3I6I2VlZTtib3JkZXItY29sb3I6IzMzN2FiN30ubmF2IC5uYXYtZGl2aWRlcntoZWlnaHQ6MXB4O21hcmdpbjo5cHggMDtvdmVyZmxvdzpoaWRkZW47YmFja2dyb3VuZC1jb2xvcjojZTVlNWU1fS5uYXY+bGk+YT5pbWd7bWF4LXdpZHRoOm5vbmV9Lm5hdi10YWJze2JvcmRlci1ib3R0b206MXB4IHNvbGlkICNkZGR9Lm5hdi10YWJzPmxpe2Zsb2F0OmxlZnQ7bWFyZ2luLWJvdHRvbTotMXB4fS5uYXYtdGFicz5saT5he21hcmdpbi1yaWdodDoycHg7bGluZS1oZWlnaHQ6MS40Mjg1NzE0Mztib3JkZXI6MXB4IHNvbGlkIHRyYW5zcGFyZW50O2JvcmRlci1yYWRpdXM6NHB4IDRweCAwIDB9Lm5hdi10YWJzPmxpPmE6aG92ZXJ7Ym9yZGVyLWNvbG9yOiNlZWUgI2VlZSAjZGRkfS5uYXYtdGFicz5saS5hY3RpdmU+YSwubmF2LXRhYnM+bGkuYWN0aXZlPmE6aG92ZXIsLm5hdi10YWJzPmxpLmFjdGl2ZT5hOmZvY3Vze2NvbG9yOiM1NTU7Y3Vyc29yOmRlZmF1bHQ7YmFja2dyb3VuZC1jb2xvcjojZmZmO2JvcmRlcjoxcHggc29saWQgI2RkZDtib3JkZXItYm90dG9tLWNvbG9yOnRyYW5zcGFyZW50fS5uYXYtdGFicy5uYXYtanVzdGlmaWVke3dpZHRoOjEwMCU7Ym9yZGVyLWJvdHRvbTowfS5uYXYtdGFicy5uYXYtanVzdGlmaWVkPmxpe2Zsb2F0Om5vbmV9Lm5hdi10YWJzLm5hdi1qdXN0aWZpZWQ+bGk+YXttYXJnaW4tYm90dG9tOjVweDt0ZXh0LWFsaWduOmNlbnRlcn0ubmF2LXRhYnMubmF2LWp1c3RpZmllZD4uZHJvcGRvd24gLmRyb3Bkb3duLW1lbnV7dG9wOmF1dG87bGVmdDphdXRvfUBtZWRpYSAobWluLXdpZHRoOjc2OHB4KXsubmF2LXRhYnMubmF2LWp1c3RpZmllZD5saXtkaXNwbGF5OnRhYmxlLWNlbGw7d2lkdGg6MSV9Lm5hdi10YWJzLm5hdi1qdXN0aWZpZWQ+bGk+YXttYXJnaW4tYm90dG9tOjB9fS5uYXYtdGFicy5uYXYtanVzdGlmaWVkPmxpPmF7bWFyZ2luLXJpZ2h0OjA7Ym9yZGVyLXJhZGl1czo0cHh9Lm5hdi10YWJzLm5hdi1qdXN0aWZpZWQ+LmFjdGl2ZT5hLC5uYXYtdGFicy5uYXYtanVzdGlmaWVkPi5hY3RpdmU+YTpob3ZlciwubmF2LXRhYnMubmF2LWp1c3RpZmllZD4uYWN0aXZlPmE6Zm9jdXN7Ym9yZGVyOjFweCBzb2xpZCAjZGRkfUBtZWRpYSAobWluLXdpZHRoOjc2OHB4KXsubmF2LXRhYnMubmF2LWp1c3RpZmllZD5saT5he2JvcmRlci1ib3R0b206MXB4IHNvbGlkICNkZGQ7Ym9yZGVyLXJhZGl1czo0cHggNHB4IDAgMH0ubmF2LXRhYnMubmF2LWp1c3RpZmllZD4uYWN0aXZlPmEsLm5hdi10YWJzLm5hdi1qdXN0aWZpZWQ+LmFjdGl2ZT5hOmhvdmVyLC5uYXYtdGFicy5uYXYtanVzdGlmaWVkPi5hY3RpdmU+YTpmb2N1c3tib3JkZXItYm90dG9tLWNvbG9yOiNmZmZ9fS5uYXYtcGlsbHM+bGl7ZmxvYXQ6bGVmdH0ubmF2LXBpbGxzPmxpPmF7Ym9yZGVyLXJhZGl1czo0cHh9Lm5hdi1waWxscz5saStsaXttYXJnaW4tbGVmdDoycHh9Lm5hdi1waWxscz5saS5hY3RpdmU+YSwubmF2LXBpbGxzPmxpLmFjdGl2ZT5hOmhvdmVyLC5uYXYtcGlsbHM+bGkuYWN0aXZlPmE6Zm9jdXN7Y29sb3I6I2ZmZjtiYWNrZ3JvdW5kLWNvbG9yOiMzMzdhYjd9Lm5hdi1zdGFja2VkPmxpe2Zsb2F0Om5vbmV9Lm5hdi1zdGFja2VkPmxpK2xpe21hcmdpbi10b3A6MnB4O21hcmdpbi1sZWZ0OjB9Lm5hdi1qdXN0aWZpZWR7d2lkdGg6MTAwJX0ubmF2LWp1c3RpZmllZD5saXtmbG9hdDpub25lfS5uYXYtanVzdGlmaWVkPmxpPmF7bWFyZ2luLWJvdHRvbTo1cHg7dGV4dC1hbGlnbjpjZW50ZXJ9Lm5hdi1qdXN0aWZpZWQ+LmRyb3Bkb3duIC5kcm9wZG93bi1tZW51e3RvcDphdXRvO2xlZnQ6YXV0b31AbWVkaWEgKG1pbi13aWR0aDo3NjhweCl7Lm5hdi1qdXN0aWZpZWQ+bGl7ZGlzcGxheTp0YWJsZS1jZWxsO3dpZHRoOjElfS5uYXYtanVzdGlmaWVkPmxpPmF7bWFyZ2luLWJvdHRvbTowfX0ubmF2LXRhYnMtanVzdGlmaWVke2JvcmRlci1ib3R0b206MH0ubmF2LXRhYnMtanVzdGlmaWVkPmxpPmF7bWFyZ2luLXJpZ2h0OjA7Ym9yZGVyLXJhZGl1czo0cHh9Lm5hdi10YWJzLWp1c3RpZmllZD4uYWN0aXZlPmEsLm5hdi10YWJzLWp1c3RpZmllZD4uYWN0aXZlPmE6aG92ZXIsLm5hdi10YWJzLWp1c3RpZmllZD4uYWN0aXZlPmE6Zm9jdXN7Ym9yZGVyOjFweCBzb2xpZCAjZGRkfUBtZWRpYSAobWluLXdpZHRoOjc2OHB4KXsubmF2LXRhYnMtanVzdGlmaWVkPmxpPmF7Ym9yZGVyLWJvdHRvbToxcHggc29saWQgI2RkZDtib3JkZXItcmFkaXVzOjRweCA0cHggMCAwfS5uYXYtdGFicy1qdXN0aWZpZWQ+LmFjdGl2ZT5hLC5uYXYtdGFicy1qdXN0aWZpZWQ+LmFjdGl2ZT5hOmhvdmVyLC5uYXYtdGFicy1qdXN0aWZpZWQ+LmFjdGl2ZT5hOmZvY3Vze2JvcmRlci1ib3R0b20tY29sb3I6I2ZmZn19LnRhYi1jb250ZW50Pi50YWItcGFuZXtkaXNwbGF5Om5vbmU7dmlzaWJpbGl0eTpoaWRkZW59LnRhYi1jb250ZW50Pi5hY3RpdmV7ZGlzcGxheTpibG9jazt2aXNpYmlsaXR5OnZpc2libGV9Lm5hdi10YWJzIC5kcm9wZG93bi1tZW51e21hcmdpbi10b3A6LTFweDtib3JkZXItdG9wLWxlZnQtcmFkaXVzOjA7Ym9yZGVyLXRvcC1yaWdodC1yYWRpdXM6MH0ubmF2YmFye3Bvc2l0aW9uOnJlbGF0aXZlO21pbi1oZWlnaHQ6NTBweDttYXJnaW4tYm90dG9tOjIwcHg7Ym9yZGVyOjFweCBzb2xpZCB0cmFuc3BhcmVudH1AbWVkaWEgKG1pbi13aWR0aDo3NjhweCl7Lm5hdmJhcntib3JkZXItcmFkaXVzOjRweH19QG1lZGlhIChtaW4td2lkdGg6NzY4cHgpey5uYXZiYXItaGVhZGVye2Zsb2F0OmxlZnR9fS5uYXZiYXItY29sbGFwc2V7cGFkZGluZy1yaWdodDoxNXB4O3BhZGRpbmctbGVmdDoxNXB4O292ZXJmbG93LXg6dmlzaWJsZTstd2Via2l0LW92ZXJmbG93LXNjcm9sbGluZzp0b3VjaDtib3JkZXItdG9wOjFweCBzb2xpZCB0cmFuc3BhcmVudDstd2Via2l0LWJveC1zaGFkb3c6aW5zZXQgMCAxcHggMCByZ2JhKDI1NSwyNTUsMjU1LC4xKTtib3gtc2hhZG93Omluc2V0IDAgMXB4IDAgcmdiYSgyNTUsMjU1LDI1NSwuMSl9Lm5hdmJhci1jb2xsYXBzZS5pbntvdmVyZmxvdy15OmF1dG99QG1lZGlhIChtaW4td2lkdGg6NzY4cHgpey5uYXZiYXItY29sbGFwc2V7d2lkdGg6YXV0bztib3JkZXItdG9wOjA7LXdlYmtpdC1ib3gtc2hhZG93Om5vbmU7Ym94LXNoYWRvdzpub25lfS5uYXZiYXItY29sbGFwc2UuY29sbGFwc2V7ZGlzcGxheTpibG9jayFpbXBvcnRhbnQ7aGVpZ2h0OmF1dG8haW1wb3J0YW50O3BhZGRpbmctYm90dG9tOjA7b3ZlcmZsb3c6dmlzaWJsZSFpbXBvcnRhbnQ7dmlzaWJpbGl0eTp2aXNpYmxlIWltcG9ydGFudH0ubmF2YmFyLWNvbGxhcHNlLmlue292ZXJmbG93LXk6dmlzaWJsZX0ubmF2YmFyLWZpeGVkLXRvcCAubmF2YmFyLWNvbGxhcHNlLC5uYXZiYXItc3RhdGljLXRvcCAubmF2YmFyLWNvbGxhcHNlLC5uYXZiYXItZml4ZWQtYm90dG9tIC5uYXZiYXItY29sbGFwc2V7cGFkZGluZy1yaWdodDowO3BhZGRpbmctbGVmdDowfX0ubmF2YmFyLWZpeGVkLXRvcCAubmF2YmFyLWNvbGxhcHNlLC5uYXZiYXItZml4ZWQtYm90dG9tIC5uYXZiYXItY29sbGFwc2V7bWF4LWhlaWdodDozNDBweH1AbWVkaWEgKG1heC1kZXZpY2Utd2lkdGg6NDgwcHgpIGFuZCAob3JpZW50YXRpb246bGFuZHNjYXBlKXsubmF2YmFyLWZpeGVkLXRvcCAubmF2YmFyLWNvbGxhcHNlLC5uYXZiYXItZml4ZWQtYm90dG9tIC5uYXZiYXItY29sbGFwc2V7bWF4LWhlaWdodDoyMDBweH19LmNvbnRhaW5lcj4ubmF2YmFyLWhlYWRlciwuY29udGFpbmVyLWZsdWlkPi5uYXZiYXItaGVhZGVyLC5jb250YWluZXI+Lm5hdmJhci1jb2xsYXBzZSwuY29udGFpbmVyLWZsdWlkPi5uYXZiYXItY29sbGFwc2V7bWFyZ2luLXJpZ2h0Oi0xNXB4O21hcmdpbi1sZWZ0Oi0xNXB4fUBtZWRpYSAobWluLXdpZHRoOjc2OHB4KXsuY29udGFpbmVyPi5uYXZiYXItaGVhZGVyLC5jb250YWluZXItZmx1aWQ+Lm5hdmJhci1oZWFkZXIsLmNvbnRhaW5lcj4ubmF2YmFyLWNvbGxhcHNlLC5jb250YWluZXItZmx1aWQ+Lm5hdmJhci1jb2xsYXBzZXttYXJnaW4tcmlnaHQ6MDttYXJnaW4tbGVmdDowfX0ubmF2YmFyLXN0YXRpYy10b3B7ei1pbmRleDoxMDAwO2JvcmRlci13aWR0aDowIDAgMXB4fUBtZWRpYSAobWluLXdpZHRoOjc2OHB4KXsubmF2YmFyLXN0YXRpYy10b3B7Ym9yZGVyLXJhZGl1czowfX0ubmF2YmFyLWZpeGVkLXRvcCwubmF2YmFyLWZpeGVkLWJvdHRvbXtwb3NpdGlvbjpmaXhlZDtyaWdodDowO2xlZnQ6MDt6LWluZGV4OjEwMzB9QG1lZGlhIChtaW4td2lkdGg6NzY4cHgpey5uYXZiYXItZml4ZWQtdG9wLC5uYXZiYXItZml4ZWQtYm90dG9te2JvcmRlci1yYWRpdXM6MH19Lm5hdmJhci1maXhlZC10b3B7dG9wOjA7Ym9yZGVyLXdpZHRoOjAgMCAxcHh9Lm5hdmJhci1maXhlZC1ib3R0b217Ym90dG9tOjA7bWFyZ2luLWJvdHRvbTowO2JvcmRlci13aWR0aDoxcHggMCAwfS5uYXZiYXItYnJhbmR7ZmxvYXQ6bGVmdDtoZWlnaHQ6NTBweDtwYWRkaW5nOjE1cHggMTVweDtmb250LXNpemU6MThweDtsaW5lLWhlaWdodDoyMHB4fS5uYXZiYXItYnJhbmQ6aG92ZXIsLm5hdmJhci1icmFuZDpmb2N1c3t0ZXh0LWRlY29yYXRpb246bm9uZX0ubmF2YmFyLWJyYW5kPmltZ3tkaXNwbGF5OmJsb2NrfUBtZWRpYSAobWluLXdpZHRoOjc2OHB4KXsubmF2YmFyPi5jb250YWluZXIgLm5hdmJhci1icmFuZCwubmF2YmFyPi5jb250YWluZXItZmx1aWQgLm5hdmJhci1icmFuZHttYXJnaW4tbGVmdDotMTVweH19Lm5hdmJhci10b2dnbGV7cG9zaXRpb246cmVsYXRpdmU7ZmxvYXQ6cmlnaHQ7cGFkZGluZzo5cHggMTBweDttYXJnaW4tdG9wOjhweDttYXJnaW4tcmlnaHQ6MTVweDttYXJnaW4tYm90dG9tOjhweDtiYWNrZ3JvdW5kLWNvbG9yOnRyYW5zcGFyZW50O2JhY2tncm91bmQtaW1hZ2U6bm9uZTtib3JkZXI6MXB4IHNvbGlkIHRyYW5zcGFyZW50O2JvcmRlci1yYWRpdXM6NHB4fS5uYXZiYXItdG9nZ2xlOmZvY3Vze291dGxpbmU6MH0ubmF2YmFyLXRvZ2dsZSAuaWNvbi1iYXJ7ZGlzcGxheTpibG9jazt3aWR0aDoyMnB4O2hlaWdodDoycHg7Ym9yZGVyLXJhZGl1czoxcHh9Lm5hdmJhci10b2dnbGUgLmljb24tYmFyKy5pY29uLWJhcnttYXJnaW4tdG9wOjRweH1AbWVkaWEgKG1pbi13aWR0aDo3NjhweCl7Lm5hdmJhci10b2dnbGV7ZGlzcGxheTpub25lfX0ubmF2YmFyLW5hdnttYXJnaW46Ny41cHggLTE1cHh9Lm5hdmJhci1uYXY+bGk+YXtwYWRkaW5nLXRvcDoxMHB4O3BhZGRpbmctYm90dG9tOjEwcHg7bGluZS1oZWlnaHQ6MjBweH1AbWVkaWEgKG1heC13aWR0aDo3NjdweCl7Lm5hdmJhci1uYXYgLm9wZW4gLmRyb3Bkb3duLW1lbnV7cG9zaXRpb246c3RhdGljO2Zsb2F0Om5vbmU7d2lkdGg6YXV0bzttYXJnaW4tdG9wOjA7YmFja2dyb3VuZC1jb2xvcjp0cmFuc3BhcmVudDtib3JkZXI6MDstd2Via2l0LWJveC1zaGFkb3c6bm9uZTtib3gtc2hhZG93Om5vbmV9Lm5hdmJhci1uYXYgLm9wZW4gLmRyb3Bkb3duLW1lbnU+bGk+YSwubmF2YmFyLW5hdiAub3BlbiAuZHJvcGRvd24tbWVudSAuZHJvcGRvd24taGVhZGVye3BhZGRpbmc6NXB4IDE1cHggNXB4IDI1cHh9Lm5hdmJhci1uYXYgLm9wZW4gLmRyb3Bkb3duLW1lbnU+bGk+YXtsaW5lLWhlaWdodDoyMHB4fS5uYXZiYXItbmF2IC5vcGVuIC5kcm9wZG93bi1tZW51PmxpPmE6aG92ZXIsLm5hdmJhci1uYXYgLm9wZW4gLmRyb3Bkb3duLW1lbnU+bGk+YTpmb2N1c3tiYWNrZ3JvdW5kLWltYWdlOm5vbmV9fUBtZWRpYSAobWluLXdpZHRoOjc2OHB4KXsubmF2YmFyLW5hdntmbG9hdDpsZWZ0O21hcmdpbjowfS5uYXZiYXItbmF2Pmxpe2Zsb2F0OmxlZnR9Lm5hdmJhci1uYXY+bGk+YXtwYWRkaW5nLXRvcDoxNXB4O3BhZGRpbmctYm90dG9tOjE1cHh9fS5uYXZiYXItZm9ybXtwYWRkaW5nOjEwcHggMTVweDttYXJnaW4tdG9wOjhweDttYXJnaW4tcmlnaHQ6LTE1cHg7bWFyZ2luLWJvdHRvbTo4cHg7bWFyZ2luLWxlZnQ6LTE1cHg7Ym9yZGVyLXRvcDoxcHggc29saWQgdHJhbnNwYXJlbnQ7Ym9yZGVyLWJvdHRvbToxcHggc29saWQgdHJhbnNwYXJlbnQ7LXdlYmtpdC1ib3gtc2hhZG93Omluc2V0IDAgMXB4IDAgcmdiYSgyNTUsMjU1LDI1NSwuMSksMCAxcHggMCByZ2JhKDI1NSwyNTUsMjU1LC4xKTtib3gtc2hhZG93Omluc2V0IDAgMXB4IDAgcmdiYSgyNTUsMjU1LDI1NSwuMSksMCAxcHggMCByZ2JhKDI1NSwyNTUsMjU1LC4xKX1AbWVkaWEgKG1pbi13aWR0aDo3NjhweCl7Lm5hdmJhci1mb3JtIC5mb3JtLWdyb3Vwe2Rpc3BsYXk6aW5saW5lLWJsb2NrO21hcmdpbi1ib3R0b206MDt2ZXJ0aWNhbC1hbGlnbjptaWRkbGV9Lm5hdmJhci1mb3JtIC5mb3JtLWNvbnRyb2x7ZGlzcGxheTppbmxpbmUtYmxvY2s7d2lkdGg6YXV0bzt2ZXJ0aWNhbC1hbGlnbjptaWRkbGV9Lm5hdmJhci1mb3JtIC5mb3JtLWNvbnRyb2wtc3RhdGlje2Rpc3BsYXk6aW5saW5lLWJsb2NrfS5uYXZiYXItZm9ybSAuaW5wdXQtZ3JvdXB7ZGlzcGxheTppbmxpbmUtdGFibGU7dmVydGljYWwtYWxpZ246bWlkZGxlfS5uYXZiYXItZm9ybSAuaW5wdXQtZ3JvdXAgLmlucHV0LWdyb3VwLWFkZG9uLC5uYXZiYXItZm9ybSAuaW5wdXQtZ3JvdXAgLmlucHV0LWdyb3VwLWJ0biwubmF2YmFyLWZvcm0gLmlucHV0LWdyb3VwIC5mb3JtLWNvbnRyb2x7d2lkdGg6YXV0b30ubmF2YmFyLWZvcm0gLmlucHV0LWdyb3VwPi5mb3JtLWNvbnRyb2x7d2lkdGg6MTAwJX0ubmF2YmFyLWZvcm0gLmNvbnRyb2wtbGFiZWx7bWFyZ2luLWJvdHRvbTowO3ZlcnRpY2FsLWFsaWduOm1pZGRsZX0ubmF2YmFyLWZvcm0gLnJhZGlvLC5uYXZiYXItZm9ybSAuY2hlY2tib3h7ZGlzcGxheTppbmxpbmUtYmxvY2s7bWFyZ2luLXRvcDowO21hcmdpbi1ib3R0b206MDt2ZXJ0aWNhbC1hbGlnbjptaWRkbGV9Lm5hdmJhci1mb3JtIC5yYWRpbyBsYWJlbCwubmF2YmFyLWZvcm0gLmNoZWNrYm94IGxhYmVse3BhZGRpbmctbGVmdDowfS5uYXZiYXItZm9ybSAucmFkaW8gaW5wdXRbdHlwZT1yYWRpb10sLm5hdmJhci1mb3JtIC5jaGVja2JveCBpbnB1dFt0eXBlPWNoZWNrYm94XXtwb3NpdGlvbjpyZWxhdGl2ZTttYXJnaW4tbGVmdDowfS5uYXZiYXItZm9ybSAuaGFzLWZlZWRiYWNrIC5mb3JtLWNvbnRyb2wtZmVlZGJhY2t7dG9wOjB9fUBtZWRpYSAobWF4LXdpZHRoOjc2N3B4KXsubmF2YmFyLWZvcm0gLmZvcm0tZ3JvdXB7bWFyZ2luLWJvdHRvbTo1cHh9Lm5hdmJhci1mb3JtIC5mb3JtLWdyb3VwOmxhc3QtY2hpbGR7bWFyZ2luLWJvdHRvbTowfX1AbWVkaWEgKG1pbi13aWR0aDo3NjhweCl7Lm5hdmJhci1mb3Jte3dpZHRoOmF1dG87cGFkZGluZy10b3A6MDtwYWRkaW5nLWJvdHRvbTowO21hcmdpbi1yaWdodDowO21hcmdpbi1sZWZ0OjA7Ym9yZGVyOjA7LXdlYmtpdC1ib3gtc2hhZG93Om5vbmU7Ym94LXNoYWRvdzpub25lfX0ubmF2YmFyLW5hdj5saT4uZHJvcGRvd24tbWVudXttYXJnaW4tdG9wOjA7Ym9yZGVyLXRvcC1sZWZ0LXJhZGl1czowO2JvcmRlci10b3AtcmlnaHQtcmFkaXVzOjB9Lm5hdmJhci1maXhlZC1ib3R0b20gLm5hdmJhci1uYXY+bGk+LmRyb3Bkb3duLW1lbnV7Ym9yZGVyLXRvcC1sZWZ0LXJhZGl1czo0cHg7Ym9yZGVyLXRvcC1yaWdodC1yYWRpdXM6NHB4O2JvcmRlci1ib3R0b20tcmlnaHQtcmFkaXVzOjA7Ym9yZGVyLWJvdHRvbS1sZWZ0LXJhZGl1czowfS5uYXZiYXItYnRue21hcmdpbi10b3A6OHB4O21hcmdpbi1ib3R0b206OHB4fS5uYXZiYXItYnRuLmJ0bi1zbXttYXJnaW4tdG9wOjEwcHg7bWFyZ2luLWJvdHRvbToxMHB4fS5uYXZiYXItYnRuLmJ0bi14c3ttYXJnaW4tdG9wOjE0cHg7bWFyZ2luLWJvdHRvbToxNHB4fS5uYXZiYXItdGV4dHttYXJnaW4tdG9wOjE1cHg7bWFyZ2luLWJvdHRvbToxNXB4fUBtZWRpYSAobWluLXdpZHRoOjc2OHB4KXsubmF2YmFyLXRleHR7ZmxvYXQ6bGVmdDttYXJnaW4tcmlnaHQ6MTVweDttYXJnaW4tbGVmdDoxNXB4fX1AbWVkaWEgKG1pbi13aWR0aDo3NjhweCl7Lm5hdmJhci1sZWZ0e2Zsb2F0OmxlZnQhaW1wb3J0YW50fS5uYXZiYXItcmlnaHR7ZmxvYXQ6cmlnaHQhaW1wb3J0YW50O21hcmdpbi1yaWdodDotMTVweH0ubmF2YmFyLXJpZ2h0fi5uYXZiYXItcmlnaHR7bWFyZ2luLXJpZ2h0OjB9fS5uYXZiYXItZGVmYXVsdHtiYWNrZ3JvdW5kLWNvbG9yOiNmOGY4Zjg7Ym9yZGVyLWNvbG9yOiNlN2U3ZTd9Lm5hdmJhci1kZWZhdWx0IC5uYXZiYXItYnJhbmR7Y29sb3I6Izc3N30ubmF2YmFyLWRlZmF1bHQgLm5hdmJhci1icmFuZDpob3ZlciwubmF2YmFyLWRlZmF1bHQgLm5hdmJhci1icmFuZDpmb2N1c3tjb2xvcjojNWU1ZTVlO2JhY2tncm91bmQtY29sb3I6dHJhbnNwYXJlbnR9Lm5hdmJhci1kZWZhdWx0IC5uYXZiYXItdGV4dHtjb2xvcjojNzc3fS5uYXZiYXItZGVmYXVsdCAubmF2YmFyLW5hdj5saT5he2NvbG9yOiM3Nzd9Lm5hdmJhci1kZWZhdWx0IC5uYXZiYXItbmF2PmxpPmE6aG92ZXIsLm5hdmJhci1kZWZhdWx0IC5uYXZiYXItbmF2PmxpPmE6Zm9jdXN7Y29sb3I6IzMzMztiYWNrZ3JvdW5kLWNvbG9yOnRyYW5zcGFyZW50fS5uYXZiYXItZGVmYXVsdCAubmF2YmFyLW5hdj4uYWN0aXZlPmEsLm5hdmJhci1kZWZhdWx0IC5uYXZiYXItbmF2Pi5hY3RpdmU+YTpob3ZlciwubmF2YmFyLWRlZmF1bHQgLm5hdmJhci1uYXY+LmFjdGl2ZT5hOmZvY3Vze2NvbG9yOiM1NTU7YmFja2dyb3VuZC1jb2xvcjojZTdlN2U3fS5uYXZiYXItZGVmYXVsdCAubmF2YmFyLW5hdj4uZGlzYWJsZWQ+YSwubmF2YmFyLWRlZmF1bHQgLm5hdmJhci1uYXY+LmRpc2FibGVkPmE6aG92ZXIsLm5hdmJhci1kZWZhdWx0IC5uYXZiYXItbmF2Pi5kaXNhYmxlZD5hOmZvY3Vze2NvbG9yOiNjY2M7YmFja2dyb3VuZC1jb2xvcjp0cmFuc3BhcmVudH0ubmF2YmFyLWRlZmF1bHQgLm5hdmJhci10b2dnbGV7Ym9yZGVyLWNvbG9yOiNkZGR9Lm5hdmJhci1kZWZhdWx0IC5uYXZiYXItdG9nZ2xlOmhvdmVyLC5uYXZiYXItZGVmYXVsdCAubmF2YmFyLXRvZ2dsZTpmb2N1c3tiYWNrZ3JvdW5kLWNvbG9yOiNkZGR9Lm5hdmJhci1kZWZhdWx0IC5uYXZiYXItdG9nZ2xlIC5pY29uLWJhcntiYWNrZ3JvdW5kLWNvbG9yOiM4ODh9Lm5hdmJhci1kZWZhdWx0IC5uYXZiYXItY29sbGFwc2UsLm5hdmJhci1kZWZhdWx0IC5uYXZiYXItZm9ybXtib3JkZXItY29sb3I6I2U3ZTdlN30ubmF2YmFyLWRlZmF1bHQgLm5hdmJhci1uYXY+Lm9wZW4+YSwubmF2YmFyLWRlZmF1bHQgLm5hdmJhci1uYXY+Lm9wZW4+YTpob3ZlciwubmF2YmFyLWRlZmF1bHQgLm5hdmJhci1uYXY+Lm9wZW4+YTpmb2N1c3tjb2xvcjojNTU1O2JhY2tncm91bmQtY29sb3I6I2U3ZTdlN31AbWVkaWEgKG1heC13aWR0aDo3NjdweCl7Lm5hdmJhci1kZWZhdWx0IC5uYXZiYXItbmF2IC5vcGVuIC5kcm9wZG93bi1tZW51PmxpPmF7Y29sb3I6Izc3N30ubmF2YmFyLWRlZmF1bHQgLm5hdmJhci1uYXYgLm9wZW4gLmRyb3Bkb3duLW1lbnU+bGk+YTpob3ZlciwubmF2YmFyLWRlZmF1bHQgLm5hdmJhci1uYXYgLm9wZW4gLmRyb3Bkb3duLW1lbnU+bGk+YTpmb2N1c3tjb2xvcjojMzMzO2JhY2tncm91bmQtY29sb3I6dHJhbnNwYXJlbnR9Lm5hdmJhci1kZWZhdWx0IC5uYXZiYXItbmF2IC5vcGVuIC5kcm9wZG93bi1tZW51Pi5hY3RpdmU+YSwubmF2YmFyLWRlZmF1bHQgLm5hdmJhci1uYXYgLm9wZW4gLmRyb3Bkb3duLW1lbnU+LmFjdGl2ZT5hOmhvdmVyLC5uYXZiYXItZGVmYXVsdCAubmF2YmFyLW5hdiAub3BlbiAuZHJvcGRvd24tbWVudT4uYWN0aXZlPmE6Zm9jdXN7Y29sb3I6IzU1NTtiYWNrZ3JvdW5kLWNvbG9yOiNlN2U3ZTd9Lm5hdmJhci1kZWZhdWx0IC5uYXZiYXItbmF2IC5vcGVuIC5kcm9wZG93bi1tZW51Pi5kaXNhYmxlZD5hLC5uYXZiYXItZGVmYXVsdCAubmF2YmFyLW5hdiAub3BlbiAuZHJvcGRvd24tbWVudT4uZGlzYWJsZWQ+YTpob3ZlciwubmF2YmFyLWRlZmF1bHQgLm5hdmJhci1uYXYgLm9wZW4gLmRyb3Bkb3duLW1lbnU+LmRpc2FibGVkPmE6Zm9jdXN7Y29sb3I6I2NjYztiYWNrZ3JvdW5kLWNvbG9yOnRyYW5zcGFyZW50fX0ubmF2YmFyLWRlZmF1bHQgLm5hdmJhci1saW5re2NvbG9yOiM3Nzd9Lm5hdmJhci1kZWZhdWx0IC5uYXZiYXItbGluazpob3Zlcntjb2xvcjojMzMzfS5uYXZiYXItZGVmYXVsdCAuYnRuLWxpbmt7Y29sb3I6Izc3N30ubmF2YmFyLWRlZmF1bHQgLmJ0bi1saW5rOmhvdmVyLC5uYXZiYXItZGVmYXVsdCAuYnRuLWxpbms6Zm9jdXN7Y29sb3I6IzMzM30ubmF2YmFyLWRlZmF1bHQgLmJ0bi1saW5rW2Rpc2FibGVkXTpob3ZlcixmaWVsZHNldFtkaXNhYmxlZF0gLm5hdmJhci1kZWZhdWx0IC5idG4tbGluazpob3ZlciwubmF2YmFyLWRlZmF1bHQgLmJ0bi1saW5rW2Rpc2FibGVkXTpmb2N1cyxmaWVsZHNldFtkaXNhYmxlZF0gLm5hdmJhci1kZWZhdWx0IC5idG4tbGluazpmb2N1c3tjb2xvcjojY2NjfS5uYXZiYXItaW52ZXJzZXtiYWNrZ3JvdW5kLWNvbG9yOiMyMjI7Ym9yZGVyLWNvbG9yOiMwODA4MDh9Lm5hdmJhci1pbnZlcnNlIC5uYXZiYXItYnJhbmR7Y29sb3I6IzlkOWQ5ZH0ubmF2YmFyLWludmVyc2UgLm5hdmJhci1icmFuZDpob3ZlciwubmF2YmFyLWludmVyc2UgLm5hdmJhci1icmFuZDpmb2N1c3tjb2xvcjojZmZmO2JhY2tncm91bmQtY29sb3I6dHJhbnNwYXJlbnR9Lm5hdmJhci1pbnZlcnNlIC5uYXZiYXItdGV4dHtjb2xvcjojOWQ5ZDlkfS5uYXZiYXItaW52ZXJzZSAubmF2YmFyLW5hdj5saT5he2NvbG9yOiM5ZDlkOWR9Lm5hdmJhci1pbnZlcnNlIC5uYXZiYXItbmF2PmxpPmE6aG92ZXIsLm5hdmJhci1pbnZlcnNlIC5uYXZiYXItbmF2PmxpPmE6Zm9jdXN7Y29sb3I6I2ZmZjtiYWNrZ3JvdW5kLWNvbG9yOnRyYW5zcGFyZW50fS5uYXZiYXItaW52ZXJzZSAubmF2YmFyLW5hdj4uYWN0aXZlPmEsLm5hdmJhci1pbnZlcnNlIC5uYXZiYXItbmF2Pi5hY3RpdmU+YTpob3ZlciwubmF2YmFyLWludmVyc2UgLm5hdmJhci1uYXY+LmFjdGl2ZT5hOmZvY3Vze2NvbG9yOiNmZmY7YmFja2dyb3VuZC1jb2xvcjojMDgwODA4fS5uYXZiYXItaW52ZXJzZSAubmF2YmFyLW5hdj4uZGlzYWJsZWQ+YSwubmF2YmFyLWludmVyc2UgLm5hdmJhci1uYXY+LmRpc2FibGVkPmE6aG92ZXIsLm5hdmJhci1pbnZlcnNlIC5uYXZiYXItbmF2Pi5kaXNhYmxlZD5hOmZvY3Vze2NvbG9yOiM0NDQ7YmFja2dyb3VuZC1jb2xvcjp0cmFuc3BhcmVudH0ubmF2YmFyLWludmVyc2UgLm5hdmJhci10b2dnbGV7Ym9yZGVyLWNvbG9yOiMzMzN9Lm5hdmJhci1pbnZlcnNlIC5uYXZiYXItdG9nZ2xlOmhvdmVyLC5uYXZiYXItaW52ZXJzZSAubmF2YmFyLXRvZ2dsZTpmb2N1c3tiYWNrZ3JvdW5kLWNvbG9yOiMzMzN9Lm5hdmJhci1pbnZlcnNlIC5uYXZiYXItdG9nZ2xlIC5pY29uLWJhcntiYWNrZ3JvdW5kLWNvbG9yOiNmZmZ9Lm5hdmJhci1pbnZlcnNlIC5uYXZiYXItY29sbGFwc2UsLm5hdmJhci1pbnZlcnNlIC5uYXZiYXItZm9ybXtib3JkZXItY29sb3I6IzEwMTAxMH0ubmF2YmFyLWludmVyc2UgLm5hdmJhci1uYXY+Lm9wZW4+YSwubmF2YmFyLWludmVyc2UgLm5hdmJhci1uYXY+Lm9wZW4+YTpob3ZlciwubmF2YmFyLWludmVyc2UgLm5hdmJhci1uYXY+Lm9wZW4+YTpmb2N1c3tjb2xvcjojZmZmO2JhY2tncm91bmQtY29sb3I6IzA4MDgwOH1AbWVkaWEgKG1heC13aWR0aDo3NjdweCl7Lm5hdmJhci1pbnZlcnNlIC5uYXZiYXItbmF2IC5vcGVuIC5kcm9wZG93bi1tZW51Pi5kcm9wZG93bi1oZWFkZXJ7Ym9yZGVyLWNvbG9yOiMwODA4MDh9Lm5hdmJhci1pbnZlcnNlIC5uYXZiYXItbmF2IC5vcGVuIC5kcm9wZG93bi1tZW51IC5kaXZpZGVye2JhY2tncm91bmQtY29sb3I6IzA4MDgwOH0ubmF2YmFyLWludmVyc2UgLm5hdmJhci1uYXYgLm9wZW4gLmRyb3Bkb3duLW1lbnU+bGk+YXtjb2xvcjojOWQ5ZDlkfS5uYXZiYXItaW52ZXJzZSAubmF2YmFyLW5hdiAub3BlbiAuZHJvcGRvd24tbWVudT5saT5hOmhvdmVyLC5uYXZiYXItaW52ZXJzZSAubmF2YmFyLW5hdiAub3BlbiAuZHJvcGRvd24tbWVudT5saT5hOmZvY3Vze2NvbG9yOiNmZmY7YmFja2dyb3VuZC1jb2xvcjp0cmFuc3BhcmVudH0ubmF2YmFyLWludmVyc2UgLm5hdmJhci1uYXYgLm9wZW4gLmRyb3Bkb3duLW1lbnU+LmFjdGl2ZT5hLC5uYXZiYXItaW52ZXJzZSAubmF2YmFyLW5hdiAub3BlbiAuZHJvcGRvd24tbWVudT4uYWN0aXZlPmE6aG92ZXIsLm5hdmJhci1pbnZlcnNlIC5uYXZiYXItbmF2IC5vcGVuIC5kcm9wZG93bi1tZW51Pi5hY3RpdmU+YTpmb2N1c3tjb2xvcjojZmZmO2JhY2tncm91bmQtY29sb3I6IzA4MDgwOH0ubmF2YmFyLWludmVyc2UgLm5hdmJhci1uYXYgLm9wZW4gLmRyb3Bkb3duLW1lbnU+LmRpc2FibGVkPmEsLm5hdmJhci1pbnZlcnNlIC5uYXZiYXItbmF2IC5vcGVuIC5kcm9wZG93bi1tZW51Pi5kaXNhYmxlZD5hOmhvdmVyLC5uYXZiYXItaW52ZXJzZSAubmF2YmFyLW5hdiAub3BlbiAuZHJvcGRvd24tbWVudT4uZGlzYWJsZWQ+YTpmb2N1c3tjb2xvcjojNDQ0O2JhY2tncm91bmQtY29sb3I6dHJhbnNwYXJlbnR9fS5uYXZiYXItaW52ZXJzZSAubmF2YmFyLWxpbmt7Y29sb3I6IzlkOWQ5ZH0ubmF2YmFyLWludmVyc2UgLm5hdmJhci1saW5rOmhvdmVye2NvbG9yOiNmZmZ9Lm5hdmJhci1pbnZlcnNlIC5idG4tbGlua3tjb2xvcjojOWQ5ZDlkfS5uYXZiYXItaW52ZXJzZSAuYnRuLWxpbms6aG92ZXIsLm5hdmJhci1pbnZlcnNlIC5idG4tbGluazpmb2N1c3tjb2xvcjojZmZmfS5uYXZiYXItaW52ZXJzZSAuYnRuLWxpbmtbZGlzYWJsZWRdOmhvdmVyLGZpZWxkc2V0W2Rpc2FibGVkXSAubmF2YmFyLWludmVyc2UgLmJ0bi1saW5rOmhvdmVyLC5uYXZiYXItaW52ZXJzZSAuYnRuLWxpbmtbZGlzYWJsZWRdOmZvY3VzLGZpZWxkc2V0W2Rpc2FibGVkXSAubmF2YmFyLWludmVyc2UgLmJ0bi1saW5rOmZvY3Vze2NvbG9yOiM0NDR9LmJyZWFkY3J1bWJ7cGFkZGluZzo4cHggMTVweDttYXJnaW4tYm90dG9tOjIwcHg7bGlzdC1zdHlsZTpub25lO2JhY2tncm91bmQtY29sb3I6I2Y1ZjVmNTtib3JkZXItcmFkaXVzOjRweH0uYnJlYWRjcnVtYj5saXtkaXNwbGF5OmlubGluZS1ibG9ja30uYnJlYWRjcnVtYj5saStsaTpiZWZvcmV7cGFkZGluZzowIDVweDtjb2xvcjojY2NjO2NvbnRlbnQ6Ii9cMDBhMCJ9LmJyZWFkY3J1bWI+LmFjdGl2ZXtjb2xvcjojNzc3fS5wYWdpbmF0aW9ue2Rpc3BsYXk6aW5saW5lLWJsb2NrO3BhZGRpbmctbGVmdDowO21hcmdpbjoyMHB4IDA7Ym9yZGVyLXJhZGl1czo0cHh9LnBhZ2luYXRpb24+bGl7ZGlzcGxheTppbmxpbmV9LnBhZ2luYXRpb24+bGk+YSwucGFnaW5hdGlvbj5saT5zcGFue3Bvc2l0aW9uOnJlbGF0aXZlO2Zsb2F0OmxlZnQ7cGFkZGluZzo2cHggMTJweDttYXJnaW4tbGVmdDotMXB4O2xpbmUtaGVpZ2h0OjEuNDI4NTcxNDM7Y29sb3I6IzMzN2FiNzt0ZXh0LWRlY29yYXRpb246bm9uZTtiYWNrZ3JvdW5kLWNvbG9yOiNmZmY7Ym9yZGVyOjFweCBzb2xpZCAjZGRkfS5wYWdpbmF0aW9uPmxpOmZpcnN0LWNoaWxkPmEsLnBhZ2luYXRpb24+bGk6Zmlyc3QtY2hpbGQ+c3BhbnttYXJnaW4tbGVmdDowO2JvcmRlci10b3AtbGVmdC1yYWRpdXM6NHB4O2JvcmRlci1ib3R0b20tbGVmdC1yYWRpdXM6NHB4fS5wYWdpbmF0aW9uPmxpOmxhc3QtY2hpbGQ+YSwucGFnaW5hdGlvbj5saTpsYXN0LWNoaWxkPnNwYW57Ym9yZGVyLXRvcC1yaWdodC1yYWRpdXM6NHB4O2JvcmRlci1ib3R0b20tcmlnaHQtcmFkaXVzOjRweH0ucGFnaW5hdGlvbj5saT5hOmhvdmVyLC5wYWdpbmF0aW9uPmxpPnNwYW46aG92ZXIsLnBhZ2luYXRpb24+bGk+YTpmb2N1cywucGFnaW5hdGlvbj5saT5zcGFuOmZvY3Vze2NvbG9yOiMyMzUyN2M7YmFja2dyb3VuZC1jb2xvcjojZWVlO2JvcmRlci1jb2xvcjojZGRkfS5wYWdpbmF0aW9uPi5hY3RpdmU+YSwucGFnaW5hdGlvbj4uYWN0aXZlPnNwYW4sLnBhZ2luYXRpb24+LmFjdGl2ZT5hOmhvdmVyLC5wYWdpbmF0aW9uPi5hY3RpdmU+c3Bhbjpob3ZlciwucGFnaW5hdGlvbj4uYWN0aXZlPmE6Zm9jdXMsLnBhZ2luYXRpb24+LmFjdGl2ZT5zcGFuOmZvY3Vze3otaW5kZXg6Mjtjb2xvcjojZmZmO2N1cnNvcjpkZWZhdWx0O2JhY2tncm91bmQtY29sb3I6IzMzN2FiNztib3JkZXItY29sb3I6IzMzN2FiN30ucGFnaW5hdGlvbj4uZGlzYWJsZWQ+c3BhbiwucGFnaW5hdGlvbj4uZGlzYWJsZWQ+c3Bhbjpob3ZlciwucGFnaW5hdGlvbj4uZGlzYWJsZWQ+c3Bhbjpmb2N1cywucGFnaW5hdGlvbj4uZGlzYWJsZWQ+YSwucGFnaW5hdGlvbj4uZGlzYWJsZWQ+YTpob3ZlciwucGFnaW5hdGlvbj4uZGlzYWJsZWQ+YTpmb2N1c3tjb2xvcjojNzc3O2N1cnNvcjpub3QtYWxsb3dlZDtiYWNrZ3JvdW5kLWNvbG9yOiNmZmY7Ym9yZGVyLWNvbG9yOiNkZGR9LnBhZ2luYXRpb24tbGc+bGk+YSwucGFnaW5hdGlvbi1sZz5saT5zcGFue3BhZGRpbmc6MTBweCAxNnB4O2ZvbnQtc2l6ZToxOHB4fS5wYWdpbmF0aW9uLWxnPmxpOmZpcnN0LWNoaWxkPmEsLnBhZ2luYXRpb24tbGc+bGk6Zmlyc3QtY2hpbGQ+c3Bhbntib3JkZXItdG9wLWxlZnQtcmFkaXVzOjZweDtib3JkZXItYm90dG9tLWxlZnQtcmFkaXVzOjZweH0ucGFnaW5hdGlvbi1sZz5saTpsYXN0LWNoaWxkPmEsLnBhZ2luYXRpb24tbGc+bGk6bGFzdC1jaGlsZD5zcGFue2JvcmRlci10b3AtcmlnaHQtcmFkaXVzOjZweDtib3JkZXItYm90dG9tLXJpZ2h0LXJhZGl1czo2cHh9LnBhZ2luYXRpb24tc20+bGk+YSwucGFnaW5hdGlvbi1zbT5saT5zcGFue3BhZGRpbmc6NXB4IDEwcHg7Zm9udC1zaXplOjEycHh9LnBhZ2luYXRpb24tc20+bGk6Zmlyc3QtY2hpbGQ+YSwucGFnaW5hdGlvbi1zbT5saTpmaXJzdC1jaGlsZD5zcGFue2JvcmRlci10b3AtbGVmdC1yYWRpdXM6M3B4O2JvcmRlci1ib3R0b20tbGVmdC1yYWRpdXM6M3B4fS5wYWdpbmF0aW9uLXNtPmxpOmxhc3QtY2hpbGQ+YSwucGFnaW5hdGlvbi1zbT5saTpsYXN0LWNoaWxkPnNwYW57Ym9yZGVyLXRvcC1yaWdodC1yYWRpdXM6M3B4O2JvcmRlci1ib3R0b20tcmlnaHQtcmFkaXVzOjNweH0ucGFnZXJ7cGFkZGluZy1sZWZ0OjA7bWFyZ2luOjIwcHggMDt0ZXh0LWFsaWduOmNlbnRlcjtsaXN0LXN0eWxlOm5vbmV9LnBhZ2VyIGxpe2Rpc3BsYXk6aW5saW5lfS5wYWdlciBsaT5hLC5wYWdlciBsaT5zcGFue2Rpc3BsYXk6aW5saW5lLWJsb2NrO3BhZGRpbmc6NXB4IDE0cHg7YmFja2dyb3VuZC1jb2xvcjojZmZmO2JvcmRlcjoxcHggc29saWQgI2RkZDtib3JkZXItcmFkaXVzOjE1cHh9LnBhZ2VyIGxpPmE6aG92ZXIsLnBhZ2VyIGxpPmE6Zm9jdXN7dGV4dC1kZWNvcmF0aW9uOm5vbmU7YmFja2dyb3VuZC1jb2xvcjojZWVlfS5wYWdlciAubmV4dD5hLC5wYWdlciAubmV4dD5zcGFue2Zsb2F0OnJpZ2h0fS5wYWdlciAucHJldmlvdXM+YSwucGFnZXIgLnByZXZpb3VzPnNwYW57ZmxvYXQ6bGVmdH0ucGFnZXIgLmRpc2FibGVkPmEsLnBhZ2VyIC5kaXNhYmxlZD5hOmhvdmVyLC5wYWdlciAuZGlzYWJsZWQ+YTpmb2N1cywucGFnZXIgLmRpc2FibGVkPnNwYW57Y29sb3I6Izc3NztjdXJzb3I6bm90LWFsbG93ZWQ7YmFja2dyb3VuZC1jb2xvcjojZmZmfS5sYWJlbHtkaXNwbGF5OmlubGluZTtwYWRkaW5nOi4yZW0gLjZlbSAuM2VtO2ZvbnQtc2l6ZTo3NSU7Zm9udC13ZWlnaHQ6NzAwO2xpbmUtaGVpZ2h0OjE7Y29sb3I6I2ZmZjt0ZXh0LWFsaWduOmNlbnRlcjt3aGl0ZS1zcGFjZTpub3dyYXA7dmVydGljYWwtYWxpZ246YmFzZWxpbmU7Ym9yZGVyLXJhZGl1czouMjVlbX1hLmxhYmVsOmhvdmVyLGEubGFiZWw6Zm9jdXN7Y29sb3I6I2ZmZjt0ZXh0LWRlY29yYXRpb246bm9uZTtjdXJzb3I6cG9pbnRlcn0ubGFiZWw6ZW1wdHl7ZGlzcGxheTpub25lfS5idG4gLmxhYmVse3Bvc2l0aW9uOnJlbGF0aXZlO3RvcDotMXB4fS5sYWJlbC1kZWZhdWx0e2JhY2tncm91bmQtY29sb3I6Izc3N30ubGFiZWwtZGVmYXVsdFtocmVmXTpob3ZlciwubGFiZWwtZGVmYXVsdFtocmVmXTpmb2N1c3tiYWNrZ3JvdW5kLWNvbG9yOiM1ZTVlNWV9LmxhYmVsLXByaW1hcnl7YmFja2dyb3VuZC1jb2xvcjojMzM3YWI3fS5sYWJlbC1wcmltYXJ5W2hyZWZdOmhvdmVyLC5sYWJlbC1wcmltYXJ5W2hyZWZdOmZvY3Vze2JhY2tncm91bmQtY29sb3I6IzI4NjA5MH0ubGFiZWwtc3VjY2Vzc3tiYWNrZ3JvdW5kLWNvbG9yOiM1Y2I4NWN9LmxhYmVsLXN1Y2Nlc3NbaHJlZl06aG92ZXIsLmxhYmVsLXN1Y2Nlc3NbaHJlZl06Zm9jdXN7YmFja2dyb3VuZC1jb2xvcjojNDQ5ZDQ0fS5sYWJlbC1pbmZve2JhY2tncm91bmQtY29sb3I6IzViYzBkZX0ubGFiZWwtaW5mb1tocmVmXTpob3ZlciwubGFiZWwtaW5mb1tocmVmXTpmb2N1c3tiYWNrZ3JvdW5kLWNvbG9yOiMzMWIwZDV9LmxhYmVsLXdhcm5pbmd7YmFja2dyb3VuZC1jb2xvcjojZjBhZDRlfS5sYWJlbC13YXJuaW5nW2hyZWZdOmhvdmVyLC5sYWJlbC13YXJuaW5nW2hyZWZdOmZvY3Vze2JhY2tncm91bmQtY29sb3I6I2VjOTcxZn0ubGFiZWwtZGFuZ2Vye2JhY2tncm91bmQtY29sb3I6I2Q5NTM0Zn0ubGFiZWwtZGFuZ2VyW2hyZWZdOmhvdmVyLC5sYWJlbC1kYW5nZXJbaHJlZl06Zm9jdXN7YmFja2dyb3VuZC1jb2xvcjojYzkzMDJjfS5iYWRnZXtkaXNwbGF5OmlubGluZS1ibG9jazttaW4td2lkdGg6MTBweDtwYWRkaW5nOjNweCA3cHg7Zm9udC1zaXplOjEycHg7Zm9udC13ZWlnaHQ6NzAwO2xpbmUtaGVpZ2h0OjE7Y29sb3I6I2ZmZjt0ZXh0LWFsaWduOmNlbnRlcjt3aGl0ZS1zcGFjZTpub3dyYXA7dmVydGljYWwtYWxpZ246YmFzZWxpbmU7YmFja2dyb3VuZC1jb2xvcjojNzc3O2JvcmRlci1yYWRpdXM6MTBweH0uYmFkZ2U6ZW1wdHl7ZGlzcGxheTpub25lfS5idG4gLmJhZGdle3Bvc2l0aW9uOnJlbGF0aXZlO3RvcDotMXB4fS5idG4teHMgLmJhZGdle3RvcDowO3BhZGRpbmc6MXB4IDVweH1hLmJhZGdlOmhvdmVyLGEuYmFkZ2U6Zm9jdXN7Y29sb3I6I2ZmZjt0ZXh0LWRlY29yYXRpb246bm9uZTtjdXJzb3I6cG9pbnRlcn0ubGlzdC1ncm91cC1pdGVtLmFjdGl2ZT4uYmFkZ2UsLm5hdi1waWxscz4uYWN0aXZlPmE+LmJhZGdle2NvbG9yOiMzMzdhYjc7YmFja2dyb3VuZC1jb2xvcjojZmZmfS5saXN0LWdyb3VwLWl0ZW0+LmJhZGdle2Zsb2F0OnJpZ2h0fS5saXN0LWdyb3VwLWl0ZW0+LmJhZGdlKy5iYWRnZXttYXJnaW4tcmlnaHQ6NXB4fS5uYXYtcGlsbHM+bGk+YT4uYmFkZ2V7bWFyZ2luLWxlZnQ6M3B4fS5qdW1ib3Ryb257cGFkZGluZzozMHB4IDE1cHg7bWFyZ2luLWJvdHRvbTozMHB4O2NvbG9yOmluaGVyaXQ7YmFja2dyb3VuZC1jb2xvcjojZWVlfS5qdW1ib3Ryb24gaDEsLmp1bWJvdHJvbiAuaDF7Y29sb3I6aW5oZXJpdH0uanVtYm90cm9uIHB7bWFyZ2luLWJvdHRvbToxNXB4O2ZvbnQtc2l6ZToyMXB4O2ZvbnQtd2VpZ2h0OjIwMH0uanVtYm90cm9uPmhye2JvcmRlci10b3AtY29sb3I6I2Q1ZDVkNX0uY29udGFpbmVyIC5qdW1ib3Ryb24sLmNvbnRhaW5lci1mbHVpZCAuanVtYm90cm9ue2JvcmRlci1yYWRpdXM6NnB4fS5qdW1ib3Ryb24gLmNvbnRhaW5lcnttYXgtd2lkdGg6MTAwJX1AbWVkaWEgc2NyZWVuIGFuZCAobWluLXdpZHRoOjc2OHB4KXsuanVtYm90cm9ue3BhZGRpbmc6NDhweCAwfS5jb250YWluZXIgLmp1bWJvdHJvbiwuY29udGFpbmVyLWZsdWlkIC5qdW1ib3Ryb257cGFkZGluZy1yaWdodDo2MHB4O3BhZGRpbmctbGVmdDo2MHB4fS5qdW1ib3Ryb24gaDEsLmp1bWJvdHJvbiAuaDF7Zm9udC1zaXplOjYzcHh9fS50aHVtYm5haWx7ZGlzcGxheTpibG9jaztwYWRkaW5nOjRweDttYXJnaW4tYm90dG9tOjIwcHg7bGluZS1oZWlnaHQ6MS40Mjg1NzE0MztiYWNrZ3JvdW5kLWNvbG9yOiNmZmY7Ym9yZGVyOjFweCBzb2xpZCAjZGRkO2JvcmRlci1yYWRpdXM6NHB4Oy13ZWJraXQtdHJhbnNpdGlvbjpib3JkZXIgLjJzIGVhc2UtaW4tb3V0Oy1vLXRyYW5zaXRpb246Ym9yZGVyIC4ycyBlYXNlLWluLW91dDt0cmFuc2l0aW9uOmJvcmRlciAuMnMgZWFzZS1pbi1vdXR9LnRodW1ibmFpbD5pbWcsLnRodW1ibmFpbCBhPmltZ3ttYXJnaW4tcmlnaHQ6YXV0bzttYXJnaW4tbGVmdDphdXRvfWEudGh1bWJuYWlsOmhvdmVyLGEudGh1bWJuYWlsOmZvY3VzLGEudGh1bWJuYWlsLmFjdGl2ZXtib3JkZXItY29sb3I6IzMzN2FiN30udGh1bWJuYWlsIC5jYXB0aW9ue3BhZGRpbmc6OXB4O2NvbG9yOiMzMzN9LmFsZXJ0e3BhZGRpbmc6MTVweDttYXJnaW4tYm90dG9tOjIwcHg7Ym9yZGVyOjFweCBzb2xpZCB0cmFuc3BhcmVudDtib3JkZXItcmFkaXVzOjRweH0uYWxlcnQgaDR7bWFyZ2luLXRvcDowO2NvbG9yOmluaGVyaXR9LmFsZXJ0IC5hbGVydC1saW5re2ZvbnQtd2VpZ2h0OjcwMH0uYWxlcnQ+cCwuYWxlcnQ+dWx7bWFyZ2luLWJvdHRvbTowfS5hbGVydD5wK3B7bWFyZ2luLXRvcDo1cHh9LmFsZXJ0LWRpc21pc3NhYmxlLC5hbGVydC1kaXNtaXNzaWJsZXtwYWRkaW5nLXJpZ2h0OjM1cHh9LmFsZXJ0LWRpc21pc3NhYmxlIC5jbG9zZSwuYWxlcnQtZGlzbWlzc2libGUgLmNsb3Nle3Bvc2l0aW9uOnJlbGF0aXZlO3RvcDotMnB4O3JpZ2h0Oi0yMXB4O2NvbG9yOmluaGVyaXR9LmFsZXJ0LXN1Y2Nlc3N7Y29sb3I6IzNjNzYzZDtiYWNrZ3JvdW5kLWNvbG9yOiNkZmYwZDg7Ym9yZGVyLWNvbG9yOiNkNmU5YzZ9LmFsZXJ0LXN1Y2Nlc3MgaHJ7Ym9yZGVyLXRvcC1jb2xvcjojYzllMmIzfS5hbGVydC1zdWNjZXNzIC5hbGVydC1saW5re2NvbG9yOiMyYjU0MmN9LmFsZXJ0LWluZm97Y29sb3I6IzMxNzA4ZjtiYWNrZ3JvdW5kLWNvbG9yOiNkOWVkZjc7Ym9yZGVyLWNvbG9yOiNiY2U4ZjF9LmFsZXJ0LWluZm8gaHJ7Ym9yZGVyLXRvcC1jb2xvcjojYTZlMWVjfS5hbGVydC1pbmZvIC5hbGVydC1saW5re2NvbG9yOiMyNDUyNjl9LmFsZXJ0LXdhcm5pbmd7Y29sb3I6IzhhNmQzYjtiYWNrZ3JvdW5kLWNvbG9yOiNmY2Y4ZTM7Ym9yZGVyLWNvbG9yOiNmYWViY2N9LmFsZXJ0LXdhcm5pbmcgaHJ7Ym9yZGVyLXRvcC1jb2xvcjojZjdlMWI1fS5hbGVydC13YXJuaW5nIC5hbGVydC1saW5re2NvbG9yOiM2NjUxMmN9LmFsZXJ0LWRhbmdlcntjb2xvcjojYTk0NDQyO2JhY2tncm91bmQtY29sb3I6I2YyZGVkZTtib3JkZXItY29sb3I6I2ViY2NkMX0uYWxlcnQtZGFuZ2VyIGhye2JvcmRlci10b3AtY29sb3I6I2U0YjljMH0uYWxlcnQtZGFuZ2VyIC5hbGVydC1saW5re2NvbG9yOiM4NDM1MzR9QC13ZWJraXQta2V5ZnJhbWVzIHByb2dyZXNzLWJhci1zdHJpcGVze2Zyb217YmFja2dyb3VuZC1wb3NpdGlvbjo0MHB4IDB9dG97YmFja2dyb3VuZC1wb3NpdGlvbjowIDB9fUAtby1rZXlmcmFtZXMgcHJvZ3Jlc3MtYmFyLXN0cmlwZXN7ZnJvbXtiYWNrZ3JvdW5kLXBvc2l0aW9uOjQwcHggMH10b3tiYWNrZ3JvdW5kLXBvc2l0aW9uOjAgMH19QGtleWZyYW1lcyBwcm9ncmVzcy1iYXItc3RyaXBlc3tmcm9te2JhY2tncm91bmQtcG9zaXRpb246NDBweCAwfXRve2JhY2tncm91bmQtcG9zaXRpb246MCAwfX0ucHJvZ3Jlc3N7aGVpZ2h0OjIwcHg7bWFyZ2luLWJvdHRvbToyMHB4O292ZXJmbG93OmhpZGRlbjtiYWNrZ3JvdW5kLWNvbG9yOiNmNWY1ZjU7Ym9yZGVyLXJhZGl1czo0cHg7LXdlYmtpdC1ib3gtc2hhZG93Omluc2V0IDAgMXB4IDJweCByZ2JhKDAsMCwwLC4xKTtib3gtc2hhZG93Omluc2V0IDAgMXB4IDJweCByZ2JhKDAsMCwwLC4xKX0ucHJvZ3Jlc3MtYmFye2Zsb2F0OmxlZnQ7d2lkdGg6MDtoZWlnaHQ6MTAwJTtmb250LXNpemU6MTJweDtsaW5lLWhlaWdodDoyMHB4O2NvbG9yOiNmZmY7dGV4dC1hbGlnbjpjZW50ZXI7YmFja2dyb3VuZC1jb2xvcjojMzM3YWI3Oy13ZWJraXQtYm94LXNoYWRvdzppbnNldCAwIC0xcHggMCByZ2JhKDAsMCwwLC4xNSk7Ym94LXNoYWRvdzppbnNldCAwIC0xcHggMCByZ2JhKDAsMCwwLC4xNSk7LXdlYmtpdC10cmFuc2l0aW9uOndpZHRoIC42cyBlYXNlOy1vLXRyYW5zaXRpb246d2lkdGggLjZzIGVhc2U7dHJhbnNpdGlvbjp3aWR0aCAuNnMgZWFzZX0ucHJvZ3Jlc3Mtc3RyaXBlZCAucHJvZ3Jlc3MtYmFyLC5wcm9ncmVzcy1iYXItc3RyaXBlZHtiYWNrZ3JvdW5kLWltYWdlOi13ZWJraXQtbGluZWFyLWdyYWRpZW50KDQ1ZGVnLHJnYmEoMjU1LDI1NSwyNTUsLjE1KSAyNSUsdHJhbnNwYXJlbnQgMjUlLHRyYW5zcGFyZW50IDUwJSxyZ2JhKDI1NSwyNTUsMjU1LC4xNSkgNTAlLHJnYmEoMjU1LDI1NSwyNTUsLjE1KSA3NSUsdHJhbnNwYXJlbnQgNzUlLHRyYW5zcGFyZW50KTtiYWNrZ3JvdW5kLWltYWdlOi1vLWxpbmVhci1ncmFkaWVudCg0NWRlZyxyZ2JhKDI1NSwyNTUsMjU1LC4xNSkgMjUlLHRyYW5zcGFyZW50IDI1JSx0cmFuc3BhcmVudCA1MCUscmdiYSgyNTUsMjU1LDI1NSwuMTUpIDUwJSxyZ2JhKDI1NSwyNTUsMjU1LC4xNSkgNzUlLHRyYW5zcGFyZW50IDc1JSx0cmFuc3BhcmVudCk7YmFja2dyb3VuZC1pbWFnZTpsaW5lYXItZ3JhZGllbnQoNDVkZWcscmdiYSgyNTUsMjU1LDI1NSwuMTUpIDI1JSx0cmFuc3BhcmVudCAyNSUsdHJhbnNwYXJlbnQgNTAlLHJnYmEoMjU1LDI1NSwyNTUsLjE1KSA1MCUscmdiYSgyNTUsMjU1LDI1NSwuMTUpIDc1JSx0cmFuc3BhcmVudCA3NSUsdHJhbnNwYXJlbnQpOy13ZWJraXQtYmFja2dyb3VuZC1zaXplOjQwcHggNDBweDtiYWNrZ3JvdW5kLXNpemU6NDBweCA0MHB4fS5wcm9ncmVzcy5hY3RpdmUgLnByb2dyZXNzLWJhciwucHJvZ3Jlc3MtYmFyLmFjdGl2ZXstd2Via2l0LWFuaW1hdGlvbjpwcm9ncmVzcy1iYXItc3RyaXBlcyAycyBsaW5lYXIgaW5maW5pdGU7LW8tYW5pbWF0aW9uOnByb2dyZXNzLWJhci1zdHJpcGVzIDJzIGxpbmVhciBpbmZpbml0ZTthbmltYXRpb246cHJvZ3Jlc3MtYmFyLXN0cmlwZXMgMnMgbGluZWFyIGluZmluaXRlfS5wcm9ncmVzcy1iYXItc3VjY2Vzc3tiYWNrZ3JvdW5kLWNvbG9yOiM1Y2I4NWN9LnByb2dyZXNzLXN0cmlwZWQgLnByb2dyZXNzLWJhci1zdWNjZXNze2JhY2tncm91bmQtaW1hZ2U6LXdlYmtpdC1saW5lYXItZ3JhZGllbnQoNDVkZWcscmdiYSgyNTUsMjU1LDI1NSwuMTUpIDI1JSx0cmFuc3BhcmVudCAyNSUsdHJhbnNwYXJlbnQgNTAlLHJnYmEoMjU1LDI1NSwyNTUsLjE1KSA1MCUscmdiYSgyNTUsMjU1LDI1NSwuMTUpIDc1JSx0cmFuc3BhcmVudCA3NSUsdHJhbnNwYXJlbnQpO2JhY2tncm91bmQtaW1hZ2U6LW8tbGluZWFyLWdyYWRpZW50KDQ1ZGVnLHJnYmEoMjU1LDI1NSwyNTUsLjE1KSAyNSUsdHJhbnNwYXJlbnQgMjUlLHRyYW5zcGFyZW50IDUwJSxyZ2JhKDI1NSwyNTUsMjU1LC4xNSkgNTAlLHJnYmEoMjU1LDI1NSwyNTUsLjE1KSA3NSUsdHJhbnNwYXJlbnQgNzUlLHRyYW5zcGFyZW50KTtiYWNrZ3JvdW5kLWltYWdlOmxpbmVhci1ncmFkaWVudCg0NWRlZyxyZ2JhKDI1NSwyNTUsMjU1LC4xNSkgMjUlLHRyYW5zcGFyZW50IDI1JSx0cmFuc3BhcmVudCA1MCUscmdiYSgyNTUsMjU1LDI1NSwuMTUpIDUwJSxyZ2JhKDI1NSwyNTUsMjU1LC4xNSkgNzUlLHRyYW5zcGFyZW50IDc1JSx0cmFuc3BhcmVudCl9LnByb2dyZXNzLWJhci1pbmZve2JhY2tncm91bmQtY29sb3I6IzViYzBkZX0ucHJvZ3Jlc3Mtc3RyaXBlZCAucHJvZ3Jlc3MtYmFyLWluZm97YmFja2dyb3VuZC1pbWFnZTotd2Via2l0LWxpbmVhci1ncmFkaWVudCg0NWRlZyxyZ2JhKDI1NSwyNTUsMjU1LC4xNSkgMjUlLHRyYW5zcGFyZW50IDI1JSx0cmFuc3BhcmVudCA1MCUscmdiYSgyNTUsMjU1LDI1NSwuMTUpIDUwJSxyZ2JhKDI1NSwyNTUsMjU1LC4xNSkgNzUlLHRyYW5zcGFyZW50IDc1JSx0cmFuc3BhcmVudCk7YmFja2dyb3VuZC1pbWFnZTotby1saW5lYXItZ3JhZGllbnQoNDVkZWcscmdiYSgyNTUsMjU1LDI1NSwuMTUpIDI1JSx0cmFuc3BhcmVudCAyNSUsdHJhbnNwYXJlbnQgNTAlLHJnYmEoMjU1LDI1NSwyNTUsLjE1KSA1MCUscmdiYSgyNTUsMjU1LDI1NSwuMTUpIDc1JSx0cmFuc3BhcmVudCA3NSUsdHJhbnNwYXJlbnQpO2JhY2tncm91bmQtaW1hZ2U6bGluZWFyLWdyYWRpZW50KDQ1ZGVnLHJnYmEoMjU1LDI1NSwyNTUsLjE1KSAyNSUsdHJhbnNwYXJlbnQgMjUlLHRyYW5zcGFyZW50IDUwJSxyZ2JhKDI1NSwyNTUsMjU1LC4xNSkgNTAlLHJnYmEoMjU1LDI1NSwyNTUsLjE1KSA3NSUsdHJhbnNwYXJlbnQgNzUlLHRyYW5zcGFyZW50KX0ucHJvZ3Jlc3MtYmFyLXdhcm5pbmd7YmFja2dyb3VuZC1jb2xvcjojZjBhZDRlfS5wcm9ncmVzcy1zdHJpcGVkIC5wcm9ncmVzcy1iYXItd2FybmluZ3tiYWNrZ3JvdW5kLWltYWdlOi13ZWJraXQtbGluZWFyLWdyYWRpZW50KDQ1ZGVnLHJnYmEoMjU1LDI1NSwyNTUsLjE1KSAyNSUsdHJhbnNwYXJlbnQgMjUlLHRyYW5zcGFyZW50IDUwJSxyZ2JhKDI1NSwyNTUsMjU1LC4xNSkgNTAlLHJnYmEoMjU1LDI1NSwyNTUsLjE1KSA3NSUsdHJhbnNwYXJlbnQgNzUlLHRyYW5zcGFyZW50KTtiYWNrZ3JvdW5kLWltYWdlOi1vLWxpbmVhci1ncmFkaWVudCg0NWRlZyxyZ2JhKDI1NSwyNTUsMjU1LC4xNSkgMjUlLHRyYW5zcGFyZW50IDI1JSx0cmFuc3BhcmVudCA1MCUscmdiYSgyNTUsMjU1LDI1NSwuMTUpIDUwJSxyZ2JhKDI1NSwyNTUsMjU1LC4xNSkgNzUlLHRyYW5zcGFyZW50IDc1JSx0cmFuc3BhcmVudCk7YmFja2dyb3VuZC1pbWFnZTpsaW5lYXItZ3JhZGllbnQoNDVkZWcscmdiYSgyNTUsMjU1LDI1NSwuMTUpIDI1JSx0cmFuc3BhcmVudCAyNSUsdHJhbnNwYXJlbnQgNTAlLHJnYmEoMjU1LDI1NSwyNTUsLjE1KSA1MCUscmdiYSgyNTUsMjU1LDI1NSwuMTUpIDc1JSx0cmFuc3BhcmVudCA3NSUsdHJhbnNwYXJlbnQpfS5wcm9ncmVzcy1iYXItZGFuZ2Vye2JhY2tncm91bmQtY29sb3I6I2Q5NTM0Zn0ucHJvZ3Jlc3Mtc3RyaXBlZCAucHJvZ3Jlc3MtYmFyLWRhbmdlcntiYWNrZ3JvdW5kLWltYWdlOi13ZWJraXQtbGluZWFyLWdyYWRpZW50KDQ1ZGVnLHJnYmEoMjU1LDI1NSwyNTUsLjE1KSAyNSUsdHJhbnNwYXJlbnQgMjUlLHRyYW5zcGFyZW50IDUwJSxyZ2JhKDI1NSwyNTUsMjU1LC4xNSkgNTAlLHJnYmEoMjU1LDI1NSwyNTUsLjE1KSA3NSUsdHJhbnNwYXJlbnQgNzUlLHRyYW5zcGFyZW50KTtiYWNrZ3JvdW5kLWltYWdlOi1vLWxpbmVhci1ncmFkaWVudCg0NWRlZyxyZ2JhKDI1NSwyNTUsMjU1LC4xNSkgMjUlLHRyYW5zcGFyZW50IDI1JSx0cmFuc3BhcmVudCA1MCUscmdiYSgyNTUsMjU1LDI1NSwuMTUpIDUwJSxyZ2JhKDI1NSwyNTUsMjU1LC4xNSkgNzUlLHRyYW5zcGFyZW50IDc1JSx0cmFuc3BhcmVudCk7YmFja2dyb3VuZC1pbWFnZTpsaW5lYXItZ3JhZGllbnQoNDVkZWcscmdiYSgyNTUsMjU1LDI1NSwuMTUpIDI1JSx0cmFuc3BhcmVudCAyNSUsdHJhbnNwYXJlbnQgNTAlLHJnYmEoMjU1LDI1NSwyNTUsLjE1KSA1MCUscmdiYSgyNTUsMjU1LDI1NSwuMTUpIDc1JSx0cmFuc3BhcmVudCA3NSUsdHJhbnNwYXJlbnQpfS5tZWRpYXttYXJnaW4tdG9wOjE1cHh9Lm1lZGlhOmZpcnN0LWNoaWxke21hcmdpbi10b3A6MH0ubWVkaWEtcmlnaHQsLm1lZGlhPi5wdWxsLXJpZ2h0e3BhZGRpbmctbGVmdDoxMHB4fS5tZWRpYS1sZWZ0LC5tZWRpYT4ucHVsbC1sZWZ0e3BhZGRpbmctcmlnaHQ6MTBweH0ubWVkaWEtbGVmdCwubWVkaWEtcmlnaHQsLm1lZGlhLWJvZHl7ZGlzcGxheTp0YWJsZS1jZWxsO3ZlcnRpY2FsLWFsaWduOnRvcH0ubWVkaWEtbWlkZGxle3ZlcnRpY2FsLWFsaWduOm1pZGRsZX0ubWVkaWEtYm90dG9te3ZlcnRpY2FsLWFsaWduOmJvdHRvbX0ubWVkaWEtaGVhZGluZ3ttYXJnaW4tdG9wOjA7bWFyZ2luLWJvdHRvbTo1cHh9Lm1lZGlhLWxpc3R7cGFkZGluZy1sZWZ0OjA7bGlzdC1zdHlsZTpub25lfS5saXN0LWdyb3Vwe3BhZGRpbmctbGVmdDowO21hcmdpbi1ib3R0b206MjBweH0ubGlzdC1ncm91cC1pdGVte3Bvc2l0aW9uOnJlbGF0aXZlO2Rpc3BsYXk6YmxvY2s7cGFkZGluZzoxMHB4IDE1cHg7bWFyZ2luLWJvdHRvbTotMXB4O2JhY2tncm91bmQtY29sb3I6I2ZmZjtib3JkZXI6MXB4IHNvbGlkICNkZGR9Lmxpc3QtZ3JvdXAtaXRlbTpmaXJzdC1jaGlsZHtib3JkZXItdG9wLWxlZnQtcmFkaXVzOjRweDtib3JkZXItdG9wLXJpZ2h0LXJhZGl1czo0cHh9Lmxpc3QtZ3JvdXAtaXRlbTpsYXN0LWNoaWxke21hcmdpbi1ib3R0b206MDtib3JkZXItYm90dG9tLXJpZ2h0LXJhZGl1czo0cHg7Ym9yZGVyLWJvdHRvbS1sZWZ0LXJhZGl1czo0cHh9YS5saXN0LWdyb3VwLWl0ZW17Y29sb3I6IzU1NX1hLmxpc3QtZ3JvdXAtaXRlbSAubGlzdC1ncm91cC1pdGVtLWhlYWRpbmd7Y29sb3I6IzMzM31hLmxpc3QtZ3JvdXAtaXRlbTpob3ZlcixhLmxpc3QtZ3JvdXAtaXRlbTpmb2N1c3tjb2xvcjojNTU1O3RleHQtZGVjb3JhdGlvbjpub25lO2JhY2tncm91bmQtY29sb3I6I2Y1ZjVmNX0ubGlzdC1ncm91cC1pdGVtLmRpc2FibGVkLC5saXN0LWdyb3VwLWl0ZW0uZGlzYWJsZWQ6aG92ZXIsLmxpc3QtZ3JvdXAtaXRlbS5kaXNhYmxlZDpmb2N1c3tjb2xvcjojNzc3O2N1cnNvcjpub3QtYWxsb3dlZDtiYWNrZ3JvdW5kLWNvbG9yOiNlZWV9Lmxpc3QtZ3JvdXAtaXRlbS5kaXNhYmxlZCAubGlzdC1ncm91cC1pdGVtLWhlYWRpbmcsLmxpc3QtZ3JvdXAtaXRlbS5kaXNhYmxlZDpob3ZlciAubGlzdC1ncm91cC1pdGVtLWhlYWRpbmcsLmxpc3QtZ3JvdXAtaXRlbS5kaXNhYmxlZDpmb2N1cyAubGlzdC1ncm91cC1pdGVtLWhlYWRpbmd7Y29sb3I6aW5oZXJpdH0ubGlzdC1ncm91cC1pdGVtLmRpc2FibGVkIC5saXN0LWdyb3VwLWl0ZW0tdGV4dCwubGlzdC1ncm91cC1pdGVtLmRpc2FibGVkOmhvdmVyIC5saXN0LWdyb3VwLWl0ZW0tdGV4dCwubGlzdC1ncm91cC1pdGVtLmRpc2FibGVkOmZvY3VzIC5saXN0LWdyb3VwLWl0ZW0tdGV4dHtjb2xvcjojNzc3fS5saXN0LWdyb3VwLWl0ZW0uYWN0aXZlLC5saXN0LWdyb3VwLWl0ZW0uYWN0aXZlOmhvdmVyLC5saXN0LWdyb3VwLWl0ZW0uYWN0aXZlOmZvY3Vze3otaW5kZXg6Mjtjb2xvcjojZmZmO2JhY2tncm91bmQtY29sb3I6IzMzN2FiNztib3JkZXItY29sb3I6IzMzN2FiN30ubGlzdC1ncm91cC1pdGVtLmFjdGl2ZSAubGlzdC1ncm91cC1pdGVtLWhlYWRpbmcsLmxpc3QtZ3JvdXAtaXRlbS5hY3RpdmU6aG92ZXIgLmxpc3QtZ3JvdXAtaXRlbS1oZWFkaW5nLC5saXN0LWdyb3VwLWl0ZW0uYWN0aXZlOmZvY3VzIC5saXN0LWdyb3VwLWl0ZW0taGVhZGluZywubGlzdC1ncm91cC1pdGVtLmFjdGl2ZSAubGlzdC1ncm91cC1pdGVtLWhlYWRpbmc+c21hbGwsLmxpc3QtZ3JvdXAtaXRlbS5hY3RpdmU6aG92ZXIgLmxpc3QtZ3JvdXAtaXRlbS1oZWFkaW5nPnNtYWxsLC5saXN0LWdyb3VwLWl0ZW0uYWN0aXZlOmZvY3VzIC5saXN0LWdyb3VwLWl0ZW0taGVhZGluZz5zbWFsbCwubGlzdC1ncm91cC1pdGVtLmFjdGl2ZSAubGlzdC1ncm91cC1pdGVtLWhlYWRpbmc+LnNtYWxsLC5saXN0LWdyb3VwLWl0ZW0uYWN0aXZlOmhvdmVyIC5saXN0LWdyb3VwLWl0ZW0taGVhZGluZz4uc21hbGwsLmxpc3QtZ3JvdXAtaXRlbS5hY3RpdmU6Zm9jdXMgLmxpc3QtZ3JvdXAtaXRlbS1oZWFkaW5nPi5zbWFsbHtjb2xvcjppbmhlcml0fS5saXN0LWdyb3VwLWl0ZW0uYWN0aXZlIC5saXN0LWdyb3VwLWl0ZW0tdGV4dCwubGlzdC1ncm91cC1pdGVtLmFjdGl2ZTpob3ZlciAubGlzdC1ncm91cC1pdGVtLXRleHQsLmxpc3QtZ3JvdXAtaXRlbS5hY3RpdmU6Zm9jdXMgLmxpc3QtZ3JvdXAtaXRlbS10ZXh0e2NvbG9yOiNjN2RkZWZ9Lmxpc3QtZ3JvdXAtaXRlbS1zdWNjZXNze2NvbG9yOiMzYzc2M2Q7YmFja2dyb3VuZC1jb2xvcjojZGZmMGQ4fWEubGlzdC1ncm91cC1pdGVtLXN1Y2Nlc3N7Y29sb3I6IzNjNzYzZH1hLmxpc3QtZ3JvdXAtaXRlbS1zdWNjZXNzIC5saXN0LWdyb3VwLWl0ZW0taGVhZGluZ3tjb2xvcjppbmhlcml0fWEubGlzdC1ncm91cC1pdGVtLXN1Y2Nlc3M6aG92ZXIsYS5saXN0LWdyb3VwLWl0ZW0tc3VjY2Vzczpmb2N1c3tjb2xvcjojM2M3NjNkO2JhY2tncm91bmQtY29sb3I6I2QwZTljNn1hLmxpc3QtZ3JvdXAtaXRlbS1zdWNjZXNzLmFjdGl2ZSxhLmxpc3QtZ3JvdXAtaXRlbS1zdWNjZXNzLmFjdGl2ZTpob3ZlcixhLmxpc3QtZ3JvdXAtaXRlbS1zdWNjZXNzLmFjdGl2ZTpmb2N1c3tjb2xvcjojZmZmO2JhY2tncm91bmQtY29sb3I6IzNjNzYzZDtib3JkZXItY29sb3I6IzNjNzYzZH0ubGlzdC1ncm91cC1pdGVtLWluZm97Y29sb3I6IzMxNzA4ZjtiYWNrZ3JvdW5kLWNvbG9yOiNkOWVkZjd9YS5saXN0LWdyb3VwLWl0ZW0taW5mb3tjb2xvcjojMzE3MDhmfWEubGlzdC1ncm91cC1pdGVtLWluZm8gLmxpc3QtZ3JvdXAtaXRlbS1oZWFkaW5ne2NvbG9yOmluaGVyaXR9YS5saXN0LWdyb3VwLWl0ZW0taW5mbzpob3ZlcixhLmxpc3QtZ3JvdXAtaXRlbS1pbmZvOmZvY3Vze2NvbG9yOiMzMTcwOGY7YmFja2dyb3VuZC1jb2xvcjojYzRlM2YzfWEubGlzdC1ncm91cC1pdGVtLWluZm8uYWN0aXZlLGEubGlzdC1ncm91cC1pdGVtLWluZm8uYWN0aXZlOmhvdmVyLGEubGlzdC1ncm91cC1pdGVtLWluZm8uYWN0aXZlOmZvY3Vze2NvbG9yOiNmZmY7YmFja2dyb3VuZC1jb2xvcjojMzE3MDhmO2JvcmRlci1jb2xvcjojMzE3MDhmfS5saXN0LWdyb3VwLWl0ZW0td2FybmluZ3tjb2xvcjojOGE2ZDNiO2JhY2tncm91bmQtY29sb3I6I2ZjZjhlM31hLmxpc3QtZ3JvdXAtaXRlbS13YXJuaW5ne2NvbG9yOiM4YTZkM2J9YS5saXN0LWdyb3VwLWl0ZW0td2FybmluZyAubGlzdC1ncm91cC1pdGVtLWhlYWRpbmd7Y29sb3I6aW5oZXJpdH1hLmxpc3QtZ3JvdXAtaXRlbS13YXJuaW5nOmhvdmVyLGEubGlzdC1ncm91cC1pdGVtLXdhcm5pbmc6Zm9jdXN7Y29sb3I6IzhhNmQzYjtiYWNrZ3JvdW5kLWNvbG9yOiNmYWYyY2N9YS5saXN0LWdyb3VwLWl0ZW0td2FybmluZy5hY3RpdmUsYS5saXN0LWdyb3VwLWl0ZW0td2FybmluZy5hY3RpdmU6aG92ZXIsYS5saXN0LWdyb3VwLWl0ZW0td2FybmluZy5hY3RpdmU6Zm9jdXN7Y29sb3I6I2ZmZjtiYWNrZ3JvdW5kLWNvbG9yOiM4YTZkM2I7Ym9yZGVyLWNvbG9yOiM4YTZkM2J9Lmxpc3QtZ3JvdXAtaXRlbS1kYW5nZXJ7Y29sb3I6I2E5NDQ0MjtiYWNrZ3JvdW5kLWNvbG9yOiNmMmRlZGV9YS5saXN0LWdyb3VwLWl0ZW0tZGFuZ2Vye2NvbG9yOiNhOTQ0NDJ9YS5saXN0LWdyb3VwLWl0ZW0tZGFuZ2VyIC5saXN0LWdyb3VwLWl0ZW0taGVhZGluZ3tjb2xvcjppbmhlcml0fWEubGlzdC1ncm91cC1pdGVtLWRhbmdlcjpob3ZlcixhLmxpc3QtZ3JvdXAtaXRlbS1kYW5nZXI6Zm9jdXN7Y29sb3I6I2E5NDQ0MjtiYWNrZ3JvdW5kLWNvbG9yOiNlYmNjY2N9YS5saXN0LWdyb3VwLWl0ZW0tZGFuZ2VyLmFjdGl2ZSxhLmxpc3QtZ3JvdXAtaXRlbS1kYW5nZXIuYWN0aXZlOmhvdmVyLGEubGlzdC1ncm91cC1pdGVtLWRhbmdlci5hY3RpdmU6Zm9jdXN7Y29sb3I6I2ZmZjtiYWNrZ3JvdW5kLWNvbG9yOiNhOTQ0NDI7Ym9yZGVyLWNvbG9yOiNhOTQ0NDJ9Lmxpc3QtZ3JvdXAtaXRlbS1oZWFkaW5ne21hcmdpbi10b3A6MDttYXJnaW4tYm90dG9tOjVweH0ubGlzdC1ncm91cC1pdGVtLXRleHR7bWFyZ2luLWJvdHRvbTowO2xpbmUtaGVpZ2h0OjEuM30ucGFuZWx7bWFyZ2luLWJvdHRvbToyMHB4O2JhY2tncm91bmQtY29sb3I6I2ZmZjtib3JkZXI6MXB4IHNvbGlkIHRyYW5zcGFyZW50O2JvcmRlci1yYWRpdXM6NHB4Oy13ZWJraXQtYm94LXNoYWRvdzowIDFweCAxcHggcmdiYSgwLDAsMCwuMDUpO2JveC1zaGFkb3c6MCAxcHggMXB4IHJnYmEoMCwwLDAsLjA1KX0ucGFuZWwtYm9keXtwYWRkaW5nOjE1cHh9LnBhbmVsLWhlYWRpbmd7cGFkZGluZzoxMHB4IDE1cHg7Ym9yZGVyLWJvdHRvbToxcHggc29saWQgdHJhbnNwYXJlbnQ7Ym9yZGVyLXRvcC1sZWZ0LXJhZGl1czozcHg7Ym9yZGVyLXRvcC1yaWdodC1yYWRpdXM6M3B4fS5wYW5lbC1oZWFkaW5nPi5kcm9wZG93biAuZHJvcGRvd24tdG9nZ2xle2NvbG9yOmluaGVyaXR9LnBhbmVsLXRpdGxle21hcmdpbi10b3A6MDttYXJnaW4tYm90dG9tOjA7Zm9udC1zaXplOjE2cHg7Y29sb3I6aW5oZXJpdH0ucGFuZWwtdGl0bGU+YXtjb2xvcjppbmhlcml0fS5wYW5lbC1mb290ZXJ7cGFkZGluZzoxMHB4IDE1cHg7YmFja2dyb3VuZC1jb2xvcjojZjVmNWY1O2JvcmRlci10b3A6MXB4IHNvbGlkICNkZGQ7Ym9yZGVyLWJvdHRvbS1yaWdodC1yYWRpdXM6M3B4O2JvcmRlci1ib3R0b20tbGVmdC1yYWRpdXM6M3B4fS5wYW5lbD4ubGlzdC1ncm91cCwucGFuZWw+LnBhbmVsLWNvbGxhcHNlPi5saXN0LWdyb3Vwe21hcmdpbi1ib3R0b206MH0ucGFuZWw+Lmxpc3QtZ3JvdXAgLmxpc3QtZ3JvdXAtaXRlbSwucGFuZWw+LnBhbmVsLWNvbGxhcHNlPi5saXN0LWdyb3VwIC5saXN0LWdyb3VwLWl0ZW17Ym9yZGVyLXdpZHRoOjFweCAwO2JvcmRlci1yYWRpdXM6MH0ucGFuZWw+Lmxpc3QtZ3JvdXA6Zmlyc3QtY2hpbGQgLmxpc3QtZ3JvdXAtaXRlbTpmaXJzdC1jaGlsZCwucGFuZWw+LnBhbmVsLWNvbGxhcHNlPi5saXN0LWdyb3VwOmZpcnN0LWNoaWxkIC5saXN0LWdyb3VwLWl0ZW06Zmlyc3QtY2hpbGR7Ym9yZGVyLXRvcDowO2JvcmRlci10b3AtbGVmdC1yYWRpdXM6M3B4O2JvcmRlci10b3AtcmlnaHQtcmFkaXVzOjNweH0ucGFuZWw+Lmxpc3QtZ3JvdXA6bGFzdC1jaGlsZCAubGlzdC1ncm91cC1pdGVtOmxhc3QtY2hpbGQsLnBhbmVsPi5wYW5lbC1jb2xsYXBzZT4ubGlzdC1ncm91cDpsYXN0LWNoaWxkIC5saXN0LWdyb3VwLWl0ZW06bGFzdC1jaGlsZHtib3JkZXItYm90dG9tOjA7Ym9yZGVyLWJvdHRvbS1yaWdodC1yYWRpdXM6M3B4O2JvcmRlci1ib3R0b20tbGVmdC1yYWRpdXM6M3B4fS5wYW5lbC1oZWFkaW5nKy5saXN0LWdyb3VwIC5saXN0LWdyb3VwLWl0ZW06Zmlyc3QtY2hpbGR7Ym9yZGVyLXRvcC13aWR0aDowfS5saXN0LWdyb3VwKy5wYW5lbC1mb290ZXJ7Ym9yZGVyLXRvcC13aWR0aDowfS5wYW5lbD4udGFibGUsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlPi50YWJsZSwucGFuZWw+LnBhbmVsLWNvbGxhcHNlPi50YWJsZXttYXJnaW4tYm90dG9tOjB9LnBhbmVsPi50YWJsZSBjYXB0aW9uLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZT4udGFibGUgY2FwdGlvbiwucGFuZWw+LnBhbmVsLWNvbGxhcHNlPi50YWJsZSBjYXB0aW9ue3BhZGRpbmctcmlnaHQ6MTVweDtwYWRkaW5nLWxlZnQ6MTVweH0ucGFuZWw+LnRhYmxlOmZpcnN0LWNoaWxkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZTpmaXJzdC1jaGlsZD4udGFibGU6Zmlyc3QtY2hpbGR7Ym9yZGVyLXRvcC1sZWZ0LXJhZGl1czozcHg7Ym9yZGVyLXRvcC1yaWdodC1yYWRpdXM6M3B4fS5wYW5lbD4udGFibGU6Zmlyc3QtY2hpbGQ+dGhlYWQ6Zmlyc3QtY2hpbGQ+dHI6Zmlyc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlOmZpcnN0LWNoaWxkPi50YWJsZTpmaXJzdC1jaGlsZD50aGVhZDpmaXJzdC1jaGlsZD50cjpmaXJzdC1jaGlsZCwucGFuZWw+LnRhYmxlOmZpcnN0LWNoaWxkPnRib2R5OmZpcnN0LWNoaWxkPnRyOmZpcnN0LWNoaWxkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZTpmaXJzdC1jaGlsZD4udGFibGU6Zmlyc3QtY2hpbGQ+dGJvZHk6Zmlyc3QtY2hpbGQ+dHI6Zmlyc3QtY2hpbGR7Ym9yZGVyLXRvcC1sZWZ0LXJhZGl1czozcHg7Ym9yZGVyLXRvcC1yaWdodC1yYWRpdXM6M3B4fS5wYW5lbD4udGFibGU6Zmlyc3QtY2hpbGQ+dGhlYWQ6Zmlyc3QtY2hpbGQ+dHI6Zmlyc3QtY2hpbGQgdGQ6Zmlyc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlOmZpcnN0LWNoaWxkPi50YWJsZTpmaXJzdC1jaGlsZD50aGVhZDpmaXJzdC1jaGlsZD50cjpmaXJzdC1jaGlsZCB0ZDpmaXJzdC1jaGlsZCwucGFuZWw+LnRhYmxlOmZpcnN0LWNoaWxkPnRib2R5OmZpcnN0LWNoaWxkPnRyOmZpcnN0LWNoaWxkIHRkOmZpcnN0LWNoaWxkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZTpmaXJzdC1jaGlsZD4udGFibGU6Zmlyc3QtY2hpbGQ+dGJvZHk6Zmlyc3QtY2hpbGQ+dHI6Zmlyc3QtY2hpbGQgdGQ6Zmlyc3QtY2hpbGQsLnBhbmVsPi50YWJsZTpmaXJzdC1jaGlsZD50aGVhZDpmaXJzdC1jaGlsZD50cjpmaXJzdC1jaGlsZCB0aDpmaXJzdC1jaGlsZCwucGFuZWw+LnRhYmxlLXJlc3BvbnNpdmU6Zmlyc3QtY2hpbGQ+LnRhYmxlOmZpcnN0LWNoaWxkPnRoZWFkOmZpcnN0LWNoaWxkPnRyOmZpcnN0LWNoaWxkIHRoOmZpcnN0LWNoaWxkLC5wYW5lbD4udGFibGU6Zmlyc3QtY2hpbGQ+dGJvZHk6Zmlyc3QtY2hpbGQ+dHI6Zmlyc3QtY2hpbGQgdGg6Zmlyc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlOmZpcnN0LWNoaWxkPi50YWJsZTpmaXJzdC1jaGlsZD50Ym9keTpmaXJzdC1jaGlsZD50cjpmaXJzdC1jaGlsZCB0aDpmaXJzdC1jaGlsZHtib3JkZXItdG9wLWxlZnQtcmFkaXVzOjNweH0ucGFuZWw+LnRhYmxlOmZpcnN0LWNoaWxkPnRoZWFkOmZpcnN0LWNoaWxkPnRyOmZpcnN0LWNoaWxkIHRkOmxhc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlOmZpcnN0LWNoaWxkPi50YWJsZTpmaXJzdC1jaGlsZD50aGVhZDpmaXJzdC1jaGlsZD50cjpmaXJzdC1jaGlsZCB0ZDpsYXN0LWNoaWxkLC5wYW5lbD4udGFibGU6Zmlyc3QtY2hpbGQ+dGJvZHk6Zmlyc3QtY2hpbGQ+dHI6Zmlyc3QtY2hpbGQgdGQ6bGFzdC1jaGlsZCwucGFuZWw+LnRhYmxlLXJlc3BvbnNpdmU6Zmlyc3QtY2hpbGQ+LnRhYmxlOmZpcnN0LWNoaWxkPnRib2R5OmZpcnN0LWNoaWxkPnRyOmZpcnN0LWNoaWxkIHRkOmxhc3QtY2hpbGQsLnBhbmVsPi50YWJsZTpmaXJzdC1jaGlsZD50aGVhZDpmaXJzdC1jaGlsZD50cjpmaXJzdC1jaGlsZCB0aDpsYXN0LWNoaWxkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZTpmaXJzdC1jaGlsZD4udGFibGU6Zmlyc3QtY2hpbGQ+dGhlYWQ6Zmlyc3QtY2hpbGQ+dHI6Zmlyc3QtY2hpbGQgdGg6bGFzdC1jaGlsZCwucGFuZWw+LnRhYmxlOmZpcnN0LWNoaWxkPnRib2R5OmZpcnN0LWNoaWxkPnRyOmZpcnN0LWNoaWxkIHRoOmxhc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlOmZpcnN0LWNoaWxkPi50YWJsZTpmaXJzdC1jaGlsZD50Ym9keTpmaXJzdC1jaGlsZD50cjpmaXJzdC1jaGlsZCB0aDpsYXN0LWNoaWxke2JvcmRlci10b3AtcmlnaHQtcmFkaXVzOjNweH0ucGFuZWw+LnRhYmxlOmxhc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlOmxhc3QtY2hpbGQ+LnRhYmxlOmxhc3QtY2hpbGR7Ym9yZGVyLWJvdHRvbS1yaWdodC1yYWRpdXM6M3B4O2JvcmRlci1ib3R0b20tbGVmdC1yYWRpdXM6M3B4fS5wYW5lbD4udGFibGU6bGFzdC1jaGlsZD50Ym9keTpsYXN0LWNoaWxkPnRyOmxhc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlOmxhc3QtY2hpbGQ+LnRhYmxlOmxhc3QtY2hpbGQ+dGJvZHk6bGFzdC1jaGlsZD50cjpsYXN0LWNoaWxkLC5wYW5lbD4udGFibGU6bGFzdC1jaGlsZD50Zm9vdDpsYXN0LWNoaWxkPnRyOmxhc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlOmxhc3QtY2hpbGQ+LnRhYmxlOmxhc3QtY2hpbGQ+dGZvb3Q6bGFzdC1jaGlsZD50cjpsYXN0LWNoaWxke2JvcmRlci1ib3R0b20tcmlnaHQtcmFkaXVzOjNweDtib3JkZXItYm90dG9tLWxlZnQtcmFkaXVzOjNweH0ucGFuZWw+LnRhYmxlOmxhc3QtY2hpbGQ+dGJvZHk6bGFzdC1jaGlsZD50cjpsYXN0LWNoaWxkIHRkOmZpcnN0LWNoaWxkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZTpsYXN0LWNoaWxkPi50YWJsZTpsYXN0LWNoaWxkPnRib2R5Omxhc3QtY2hpbGQ+dHI6bGFzdC1jaGlsZCB0ZDpmaXJzdC1jaGlsZCwucGFuZWw+LnRhYmxlOmxhc3QtY2hpbGQ+dGZvb3Q6bGFzdC1jaGlsZD50cjpsYXN0LWNoaWxkIHRkOmZpcnN0LWNoaWxkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZTpsYXN0LWNoaWxkPi50YWJsZTpsYXN0LWNoaWxkPnRmb290Omxhc3QtY2hpbGQ+dHI6bGFzdC1jaGlsZCB0ZDpmaXJzdC1jaGlsZCwucGFuZWw+LnRhYmxlOmxhc3QtY2hpbGQ+dGJvZHk6bGFzdC1jaGlsZD50cjpsYXN0LWNoaWxkIHRoOmZpcnN0LWNoaWxkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZTpsYXN0LWNoaWxkPi50YWJsZTpsYXN0LWNoaWxkPnRib2R5Omxhc3QtY2hpbGQ+dHI6bGFzdC1jaGlsZCB0aDpmaXJzdC1jaGlsZCwucGFuZWw+LnRhYmxlOmxhc3QtY2hpbGQ+dGZvb3Q6bGFzdC1jaGlsZD50cjpsYXN0LWNoaWxkIHRoOmZpcnN0LWNoaWxkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZTpsYXN0LWNoaWxkPi50YWJsZTpsYXN0LWNoaWxkPnRmb290Omxhc3QtY2hpbGQ+dHI6bGFzdC1jaGlsZCB0aDpmaXJzdC1jaGlsZHtib3JkZXItYm90dG9tLWxlZnQtcmFkaXVzOjNweH0ucGFuZWw+LnRhYmxlOmxhc3QtY2hpbGQ+dGJvZHk6bGFzdC1jaGlsZD50cjpsYXN0LWNoaWxkIHRkOmxhc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlOmxhc3QtY2hpbGQ+LnRhYmxlOmxhc3QtY2hpbGQ+dGJvZHk6bGFzdC1jaGlsZD50cjpsYXN0LWNoaWxkIHRkOmxhc3QtY2hpbGQsLnBhbmVsPi50YWJsZTpsYXN0LWNoaWxkPnRmb290Omxhc3QtY2hpbGQ+dHI6bGFzdC1jaGlsZCB0ZDpsYXN0LWNoaWxkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZTpsYXN0LWNoaWxkPi50YWJsZTpsYXN0LWNoaWxkPnRmb290Omxhc3QtY2hpbGQ+dHI6bGFzdC1jaGlsZCB0ZDpsYXN0LWNoaWxkLC5wYW5lbD4udGFibGU6bGFzdC1jaGlsZD50Ym9keTpsYXN0LWNoaWxkPnRyOmxhc3QtY2hpbGQgdGg6bGFzdC1jaGlsZCwucGFuZWw+LnRhYmxlLXJlc3BvbnNpdmU6bGFzdC1jaGlsZD4udGFibGU6bGFzdC1jaGlsZD50Ym9keTpsYXN0LWNoaWxkPnRyOmxhc3QtY2hpbGQgdGg6bGFzdC1jaGlsZCwucGFuZWw+LnRhYmxlOmxhc3QtY2hpbGQ+dGZvb3Q6bGFzdC1jaGlsZD50cjpsYXN0LWNoaWxkIHRoOmxhc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlOmxhc3QtY2hpbGQ+LnRhYmxlOmxhc3QtY2hpbGQ+dGZvb3Q6bGFzdC1jaGlsZD50cjpsYXN0LWNoaWxkIHRoOmxhc3QtY2hpbGR7Ym9yZGVyLWJvdHRvbS1yaWdodC1yYWRpdXM6M3B4fS5wYW5lbD4ucGFuZWwtYm9keSsudGFibGUsLnBhbmVsPi5wYW5lbC1ib2R5Ky50YWJsZS1yZXNwb25zaXZlLC5wYW5lbD4udGFibGUrLnBhbmVsLWJvZHksLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlKy5wYW5lbC1ib2R5e2JvcmRlci10b3A6MXB4IHNvbGlkICNkZGR9LnBhbmVsPi50YWJsZT50Ym9keTpmaXJzdC1jaGlsZD50cjpmaXJzdC1jaGlsZCB0aCwucGFuZWw+LnRhYmxlPnRib2R5OmZpcnN0LWNoaWxkPnRyOmZpcnN0LWNoaWxkIHRke2JvcmRlci10b3A6MH0ucGFuZWw+LnRhYmxlLWJvcmRlcmVkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZT4udGFibGUtYm9yZGVyZWR7Ym9yZGVyOjB9LnBhbmVsPi50YWJsZS1ib3JkZXJlZD50aGVhZD50cj50aDpmaXJzdC1jaGlsZCwucGFuZWw+LnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRoZWFkPnRyPnRoOmZpcnN0LWNoaWxkLC5wYW5lbD4udGFibGUtYm9yZGVyZWQ+dGJvZHk+dHI+dGg6Zmlyc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlPi50YWJsZS1ib3JkZXJlZD50Ym9keT50cj50aDpmaXJzdC1jaGlsZCwucGFuZWw+LnRhYmxlLWJvcmRlcmVkPnRmb290PnRyPnRoOmZpcnN0LWNoaWxkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZT4udGFibGUtYm9yZGVyZWQ+dGZvb3Q+dHI+dGg6Zmlyc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1ib3JkZXJlZD50aGVhZD50cj50ZDpmaXJzdC1jaGlsZCwucGFuZWw+LnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRoZWFkPnRyPnRkOmZpcnN0LWNoaWxkLC5wYW5lbD4udGFibGUtYm9yZGVyZWQ+dGJvZHk+dHI+dGQ6Zmlyc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlPi50YWJsZS1ib3JkZXJlZD50Ym9keT50cj50ZDpmaXJzdC1jaGlsZCwucGFuZWw+LnRhYmxlLWJvcmRlcmVkPnRmb290PnRyPnRkOmZpcnN0LWNoaWxkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZT4udGFibGUtYm9yZGVyZWQ+dGZvb3Q+dHI+dGQ6Zmlyc3QtY2hpbGR7Ym9yZGVyLWxlZnQ6MH0ucGFuZWw+LnRhYmxlLWJvcmRlcmVkPnRoZWFkPnRyPnRoOmxhc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlPi50YWJsZS1ib3JkZXJlZD50aGVhZD50cj50aDpsYXN0LWNoaWxkLC5wYW5lbD4udGFibGUtYm9yZGVyZWQ+dGJvZHk+dHI+dGg6bGFzdC1jaGlsZCwucGFuZWw+LnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRib2R5PnRyPnRoOmxhc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1ib3JkZXJlZD50Zm9vdD50cj50aDpsYXN0LWNoaWxkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZT4udGFibGUtYm9yZGVyZWQ+dGZvb3Q+dHI+dGg6bGFzdC1jaGlsZCwucGFuZWw+LnRhYmxlLWJvcmRlcmVkPnRoZWFkPnRyPnRkOmxhc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlPi50YWJsZS1ib3JkZXJlZD50aGVhZD50cj50ZDpsYXN0LWNoaWxkLC5wYW5lbD4udGFibGUtYm9yZGVyZWQ+dGJvZHk+dHI+dGQ6bGFzdC1jaGlsZCwucGFuZWw+LnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRib2R5PnRyPnRkOmxhc3QtY2hpbGQsLnBhbmVsPi50YWJsZS1ib3JkZXJlZD50Zm9vdD50cj50ZDpsYXN0LWNoaWxkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZT4udGFibGUtYm9yZGVyZWQ+dGZvb3Q+dHI+dGQ6bGFzdC1jaGlsZHtib3JkZXItcmlnaHQ6MH0ucGFuZWw+LnRhYmxlLWJvcmRlcmVkPnRoZWFkPnRyOmZpcnN0LWNoaWxkPnRkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZT4udGFibGUtYm9yZGVyZWQ+dGhlYWQ+dHI6Zmlyc3QtY2hpbGQ+dGQsLnBhbmVsPi50YWJsZS1ib3JkZXJlZD50Ym9keT50cjpmaXJzdC1jaGlsZD50ZCwucGFuZWw+LnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRib2R5PnRyOmZpcnN0LWNoaWxkPnRkLC5wYW5lbD4udGFibGUtYm9yZGVyZWQ+dGhlYWQ+dHI6Zmlyc3QtY2hpbGQ+dGgsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlPi50YWJsZS1ib3JkZXJlZD50aGVhZD50cjpmaXJzdC1jaGlsZD50aCwucGFuZWw+LnRhYmxlLWJvcmRlcmVkPnRib2R5PnRyOmZpcnN0LWNoaWxkPnRoLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZT4udGFibGUtYm9yZGVyZWQ+dGJvZHk+dHI6Zmlyc3QtY2hpbGQ+dGh7Ym9yZGVyLWJvdHRvbTowfS5wYW5lbD4udGFibGUtYm9yZGVyZWQ+dGJvZHk+dHI6bGFzdC1jaGlsZD50ZCwucGFuZWw+LnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRib2R5PnRyOmxhc3QtY2hpbGQ+dGQsLnBhbmVsPi50YWJsZS1ib3JkZXJlZD50Zm9vdD50cjpsYXN0LWNoaWxkPnRkLC5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZT4udGFibGUtYm9yZGVyZWQ+dGZvb3Q+dHI6bGFzdC1jaGlsZD50ZCwucGFuZWw+LnRhYmxlLWJvcmRlcmVkPnRib2R5PnRyOmxhc3QtY2hpbGQ+dGgsLnBhbmVsPi50YWJsZS1yZXNwb25zaXZlPi50YWJsZS1ib3JkZXJlZD50Ym9keT50cjpsYXN0LWNoaWxkPnRoLC5wYW5lbD4udGFibGUtYm9yZGVyZWQ+dGZvb3Q+dHI6bGFzdC1jaGlsZD50aCwucGFuZWw+LnRhYmxlLXJlc3BvbnNpdmU+LnRhYmxlLWJvcmRlcmVkPnRmb290PnRyOmxhc3QtY2hpbGQ+dGh7Ym9yZGVyLWJvdHRvbTowfS5wYW5lbD4udGFibGUtcmVzcG9uc2l2ZXttYXJnaW4tYm90dG9tOjA7Ym9yZGVyOjB9LnBhbmVsLWdyb3Vwe21hcmdpbi1ib3R0b206MjBweH0ucGFuZWwtZ3JvdXAgLnBhbmVse21hcmdpbi1ib3R0b206MDtib3JkZXItcmFkaXVzOjRweH0ucGFuZWwtZ3JvdXAgLnBhbmVsKy5wYW5lbHttYXJnaW4tdG9wOjVweH0ucGFuZWwtZ3JvdXAgLnBhbmVsLWhlYWRpbmd7Ym9yZGVyLWJvdHRvbTowfS5wYW5lbC1ncm91cCAucGFuZWwtaGVhZGluZysucGFuZWwtY29sbGFwc2U+LnBhbmVsLWJvZHksLnBhbmVsLWdyb3VwIC5wYW5lbC1oZWFkaW5nKy5wYW5lbC1jb2xsYXBzZT4ubGlzdC1ncm91cHtib3JkZXItdG9wOjFweCBzb2xpZCAjZGRkfS5wYW5lbC1ncm91cCAucGFuZWwtZm9vdGVye2JvcmRlci10b3A6MH0ucGFuZWwtZ3JvdXAgLnBhbmVsLWZvb3RlcisucGFuZWwtY29sbGFwc2UgLnBhbmVsLWJvZHl7Ym9yZGVyLWJvdHRvbToxcHggc29saWQgI2RkZH0ucGFuZWwtZGVmYXVsdHtib3JkZXItY29sb3I6I2RkZH0ucGFuZWwtZGVmYXVsdD4ucGFuZWwtaGVhZGluZ3tjb2xvcjojMzMzO2JhY2tncm91bmQtY29sb3I6I2Y1ZjVmNTtib3JkZXItY29sb3I6I2RkZH0ucGFuZWwtZGVmYXVsdD4ucGFuZWwtaGVhZGluZysucGFuZWwtY29sbGFwc2U+LnBhbmVsLWJvZHl7Ym9yZGVyLXRvcC1jb2xvcjojZGRkfS5wYW5lbC1kZWZhdWx0Pi5wYW5lbC1oZWFkaW5nIC5iYWRnZXtjb2xvcjojZjVmNWY1O2JhY2tncm91bmQtY29sb3I6IzMzM30ucGFuZWwtZGVmYXVsdD4ucGFuZWwtZm9vdGVyKy5wYW5lbC1jb2xsYXBzZT4ucGFuZWwtYm9keXtib3JkZXItYm90dG9tLWNvbG9yOiNkZGR9LnBhbmVsLXByaW1hcnl7Ym9yZGVyLWNvbG9yOiMzMzdhYjd9LnBhbmVsLXByaW1hcnk+LnBhbmVsLWhlYWRpbmd7Y29sb3I6I2ZmZjtiYWNrZ3JvdW5kLWNvbG9yOiMzMzdhYjc7Ym9yZGVyLWNvbG9yOiMzMzdhYjd9LnBhbmVsLXByaW1hcnk+LnBhbmVsLWhlYWRpbmcrLnBhbmVsLWNvbGxhcHNlPi5wYW5lbC1ib2R5e2JvcmRlci10b3AtY29sb3I6IzMzN2FiN30ucGFuZWwtcHJpbWFyeT4ucGFuZWwtaGVhZGluZyAuYmFkZ2V7Y29sb3I6IzMzN2FiNztiYWNrZ3JvdW5kLWNvbG9yOiNmZmZ9LnBhbmVsLXByaW1hcnk+LnBhbmVsLWZvb3RlcisucGFuZWwtY29sbGFwc2U+LnBhbmVsLWJvZHl7Ym9yZGVyLWJvdHRvbS1jb2xvcjojMzM3YWI3fS5wYW5lbC1zdWNjZXNze2JvcmRlci1jb2xvcjojZDZlOWM2fS5wYW5lbC1zdWNjZXNzPi5wYW5lbC1oZWFkaW5ne2NvbG9yOiMzYzc2M2Q7YmFja2dyb3VuZC1jb2xvcjojZGZmMGQ4O2JvcmRlci1jb2xvcjojZDZlOWM2fS5wYW5lbC1zdWNjZXNzPi5wYW5lbC1oZWFkaW5nKy5wYW5lbC1jb2xsYXBzZT4ucGFuZWwtYm9keXtib3JkZXItdG9wLWNvbG9yOiNkNmU5YzZ9LnBhbmVsLXN1Y2Nlc3M+LnBhbmVsLWhlYWRpbmcgLmJhZGdle2NvbG9yOiNkZmYwZDg7YmFja2dyb3VuZC1jb2xvcjojM2M3NjNkfS5wYW5lbC1zdWNjZXNzPi5wYW5lbC1mb290ZXIrLnBhbmVsLWNvbGxhcHNlPi5wYW5lbC1ib2R5e2JvcmRlci1ib3R0b20tY29sb3I6I2Q2ZTljNn0ucGFuZWwtaW5mb3tib3JkZXItY29sb3I6I2JjZThmMX0ucGFuZWwtaW5mbz4ucGFuZWwtaGVhZGluZ3tjb2xvcjojMzE3MDhmO2JhY2tncm91bmQtY29sb3I6I2Q5ZWRmNztib3JkZXItY29sb3I6I2JjZThmMX0ucGFuZWwtaW5mbz4ucGFuZWwtaGVhZGluZysucGFuZWwtY29sbGFwc2U+LnBhbmVsLWJvZHl7Ym9yZGVyLXRvcC1jb2xvcjojYmNlOGYxfS5wYW5lbC1pbmZvPi5wYW5lbC1oZWFkaW5nIC5iYWRnZXtjb2xvcjojZDllZGY3O2JhY2tncm91bmQtY29sb3I6IzMxNzA4Zn0ucGFuZWwtaW5mbz4ucGFuZWwtZm9vdGVyKy5wYW5lbC1jb2xsYXBzZT4ucGFuZWwtYm9keXtib3JkZXItYm90dG9tLWNvbG9yOiNiY2U4ZjF9LnBhbmVsLXdhcm5pbmd7Ym9yZGVyLWNvbG9yOiNmYWViY2N9LnBhbmVsLXdhcm5pbmc+LnBhbmVsLWhlYWRpbmd7Y29sb3I6IzhhNmQzYjtiYWNrZ3JvdW5kLWNvbG9yOiNmY2Y4ZTM7Ym9yZGVyLWNvbG9yOiNmYWViY2N9LnBhbmVsLXdhcm5pbmc+LnBhbmVsLWhlYWRpbmcrLnBhbmVsLWNvbGxhcHNlPi5wYW5lbC1ib2R5e2JvcmRlci10b3AtY29sb3I6I2ZhZWJjY30ucGFuZWwtd2FybmluZz4ucGFuZWwtaGVhZGluZyAuYmFkZ2V7Y29sb3I6I2ZjZjhlMztiYWNrZ3JvdW5kLWNvbG9yOiM4YTZkM2J9LnBhbmVsLXdhcm5pbmc+LnBhbmVsLWZvb3RlcisucGFuZWwtY29sbGFwc2U+LnBhbmVsLWJvZHl7Ym9yZGVyLWJvdHRvbS1jb2xvcjojZmFlYmNjfS5wYW5lbC1kYW5nZXJ7Ym9yZGVyLWNvbG9yOiNlYmNjZDF9LnBhbmVsLWRhbmdlcj4ucGFuZWwtaGVhZGluZ3tjb2xvcjojYTk0NDQyO2JhY2tncm91bmQtY29sb3I6I2YyZGVkZTtib3JkZXItY29sb3I6I2ViY2NkMX0ucGFuZWwtZGFuZ2VyPi5wYW5lbC1oZWFkaW5nKy5wYW5lbC1jb2xsYXBzZT4ucGFuZWwtYm9keXtib3JkZXItdG9wLWNvbG9yOiNlYmNjZDF9LnBhbmVsLWRhbmdlcj4ucGFuZWwtaGVhZGluZyAuYmFkZ2V7Y29sb3I6I2YyZGVkZTtiYWNrZ3JvdW5kLWNvbG9yOiNhOTQ0NDJ9LnBhbmVsLWRhbmdlcj4ucGFuZWwtZm9vdGVyKy5wYW5lbC1jb2xsYXBzZT4ucGFuZWwtYm9keXtib3JkZXItYm90dG9tLWNvbG9yOiNlYmNjZDF9LmVtYmVkLXJlc3BvbnNpdmV7cG9zaXRpb246cmVsYXRpdmU7ZGlzcGxheTpibG9jaztoZWlnaHQ6MDtwYWRkaW5nOjA7b3ZlcmZsb3c6aGlkZGVufS5lbWJlZC1yZXNwb25zaXZlIC5lbWJlZC1yZXNwb25zaXZlLWl0ZW0sLmVtYmVkLXJlc3BvbnNpdmUgaWZyYW1lLC5lbWJlZC1yZXNwb25zaXZlIGVtYmVkLC5lbWJlZC1yZXNwb25zaXZlIG9iamVjdCwuZW1iZWQtcmVzcG9uc2l2ZSB2aWRlb3twb3NpdGlvbjphYnNvbHV0ZTt0b3A6MDtib3R0b206MDtsZWZ0OjA7d2lkdGg6MTAwJTtoZWlnaHQ6MTAwJTtib3JkZXI6MH0uZW1iZWQtcmVzcG9uc2l2ZS5lbWJlZC1yZXNwb25zaXZlLTE2Ynk5e3BhZGRpbmctYm90dG9tOjU2LjI1JX0uZW1iZWQtcmVzcG9uc2l2ZS5lbWJlZC1yZXNwb25zaXZlLTRieTN7cGFkZGluZy1ib3R0b206NzUlfS53ZWxse21pbi1oZWlnaHQ6MjBweDtwYWRkaW5nOjE5cHg7bWFyZ2luLWJvdHRvbToyMHB4O2JhY2tncm91bmQtY29sb3I6I2Y1ZjVmNTtib3JkZXI6MXB4IHNvbGlkICNlM2UzZTM7Ym9yZGVyLXJhZGl1czo0cHg7LXdlYmtpdC1ib3gtc2hhZG93Omluc2V0IDAgMXB4IDFweCByZ2JhKDAsMCwwLC4wNSk7Ym94LXNoYWRvdzppbnNldCAwIDFweCAxcHggcmdiYSgwLDAsMCwuMDUpfS53ZWxsIGJsb2NrcXVvdGV7Ym9yZGVyLWNvbG9yOiNkZGQ7Ym9yZGVyLWNvbG9yOnJnYmEoMCwwLDAsLjE1KX0ud2VsbC1sZ3twYWRkaW5nOjI0cHg7Ym9yZGVyLXJhZGl1czo2cHh9LndlbGwtc217cGFkZGluZzo5cHg7Ym9yZGVyLXJhZGl1czozcHh9LmNsb3Nle2Zsb2F0OnJpZ2h0O2ZvbnQtc2l6ZToyMXB4O2ZvbnQtd2VpZ2h0OjcwMDtsaW5lLWhlaWdodDoxO2NvbG9yOiMwMDA7dGV4dC1zaGFkb3c6MCAxcHggMCAjZmZmO2ZpbHRlcjphbHBoYShvcGFjaXR5PTIwKTtvcGFjaXR5Oi4yfS5jbG9zZTpob3ZlciwuY2xvc2U6Zm9jdXN7Y29sb3I6IzAwMDt0ZXh0LWRlY29yYXRpb246bm9uZTtjdXJzb3I6cG9pbnRlcjtmaWx0ZXI6YWxwaGEob3BhY2l0eT01MCk7b3BhY2l0eTouNX1idXR0b24uY2xvc2V7LXdlYmtpdC1hcHBlYXJhbmNlOm5vbmU7cGFkZGluZzowO2N1cnNvcjpwb2ludGVyO2JhY2tncm91bmQ6MCAwO2JvcmRlcjowfS5tb2RhbC1vcGVue292ZXJmbG93OmhpZGRlbn0ubW9kYWx7cG9zaXRpb246Zml4ZWQ7dG9wOjA7cmlnaHQ6MDtib3R0b206MDtsZWZ0OjA7ei1pbmRleDoxMDQwO2Rpc3BsYXk6bm9uZTtvdmVyZmxvdzpoaWRkZW47LXdlYmtpdC1vdmVyZmxvdy1zY3JvbGxpbmc6dG91Y2g7b3V0bGluZTowfS5tb2RhbC5mYWRlIC5tb2RhbC1kaWFsb2d7LXdlYmtpdC10cmFuc2l0aW9uOi13ZWJraXQtdHJhbnNmb3JtIC4zcyBlYXNlLW91dDstby10cmFuc2l0aW9uOi1vLXRyYW5zZm9ybSAuM3MgZWFzZS1vdXQ7dHJhbnNpdGlvbjp0cmFuc2Zvcm0gLjNzIGVhc2Utb3V0Oy13ZWJraXQtdHJhbnNmb3JtOnRyYW5zbGF0ZSgwLC0yNSUpOy1tcy10cmFuc2Zvcm06dHJhbnNsYXRlKDAsLTI1JSk7LW8tdHJhbnNmb3JtOnRyYW5zbGF0ZSgwLC0yNSUpO3RyYW5zZm9ybTp0cmFuc2xhdGUoMCwtMjUlKX0ubW9kYWwuaW4gLm1vZGFsLWRpYWxvZ3std2Via2l0LXRyYW5zZm9ybTp0cmFuc2xhdGUoMCwwKTstbXMtdHJhbnNmb3JtOnRyYW5zbGF0ZSgwLDApOy1vLXRyYW5zZm9ybTp0cmFuc2xhdGUoMCwwKTt0cmFuc2Zvcm06dHJhbnNsYXRlKDAsMCl9Lm1vZGFsLW9wZW4gLm1vZGFse292ZXJmbG93LXg6aGlkZGVuO292ZXJmbG93LXk6YXV0b30ubW9kYWwtZGlhbG9ne3Bvc2l0aW9uOnJlbGF0aXZlO3dpZHRoOmF1dG87bWFyZ2luOjEwcHh9Lm1vZGFsLWNvbnRlbnR7cG9zaXRpb246cmVsYXRpdmU7YmFja2dyb3VuZC1jb2xvcjojZmZmOy13ZWJraXQtYmFja2dyb3VuZC1jbGlwOnBhZGRpbmctYm94O2JhY2tncm91bmQtY2xpcDpwYWRkaW5nLWJveDtib3JkZXI6MXB4IHNvbGlkICM5OTk7Ym9yZGVyOjFweCBzb2xpZCByZ2JhKDAsMCwwLC4yKTtib3JkZXItcmFkaXVzOjZweDtvdXRsaW5lOjA7LXdlYmtpdC1ib3gtc2hhZG93OjAgM3B4IDlweCByZ2JhKDAsMCwwLC41KTtib3gtc2hhZG93OjAgM3B4IDlweCByZ2JhKDAsMCwwLC41KX0ubW9kYWwtYmFja2Ryb3B7cG9zaXRpb246YWJzb2x1dGU7dG9wOjA7cmlnaHQ6MDtsZWZ0OjA7YmFja2dyb3VuZC1jb2xvcjojMDAwfS5tb2RhbC1iYWNrZHJvcC5mYWRle2ZpbHRlcjphbHBoYShvcGFjaXR5PTApO29wYWNpdHk6MH0ubW9kYWwtYmFja2Ryb3AuaW57ZmlsdGVyOmFscGhhKG9wYWNpdHk9NTApO29wYWNpdHk6LjV9Lm1vZGFsLWhlYWRlcnttaW4taGVpZ2h0OjE2LjQzcHg7cGFkZGluZzoxNXB4O2JvcmRlci1ib3R0b206MXB4IHNvbGlkICNlNWU1ZTV9Lm1vZGFsLWhlYWRlciAuY2xvc2V7bWFyZ2luLXRvcDotMnB4fS5tb2RhbC10aXRsZXttYXJnaW46MDtsaW5lLWhlaWdodDoxLjQyODU3MTQzfS5tb2RhbC1ib2R5e3Bvc2l0aW9uOnJlbGF0aXZlO3BhZGRpbmc6MTVweH0ubW9kYWwtZm9vdGVye3BhZGRpbmc6MTVweDt0ZXh0LWFsaWduOnJpZ2h0O2JvcmRlci10b3A6MXB4IHNvbGlkICNlNWU1ZTV9Lm1vZGFsLWZvb3RlciAuYnRuKy5idG57bWFyZ2luLWJvdHRvbTowO21hcmdpbi1sZWZ0OjVweH0ubW9kYWwtZm9vdGVyIC5idG4tZ3JvdXAgLmJ0bisuYnRue21hcmdpbi1sZWZ0Oi0xcHh9Lm1vZGFsLWZvb3RlciAuYnRuLWJsb2NrKy5idG4tYmxvY2t7bWFyZ2luLWxlZnQ6MH0ubW9kYWwtc2Nyb2xsYmFyLW1lYXN1cmV7cG9zaXRpb246YWJzb2x1dGU7dG9wOi05OTk5cHg7d2lkdGg6NTBweDtoZWlnaHQ6NTBweDtvdmVyZmxvdzpzY3JvbGx9QG1lZGlhIChtaW4td2lkdGg6NzY4cHgpey5tb2RhbC1kaWFsb2d7d2lkdGg6NjAwcHg7bWFyZ2luOjMwcHggYXV0b30ubW9kYWwtY29udGVudHstd2Via2l0LWJveC1zaGFkb3c6MCA1cHggMTVweCByZ2JhKDAsMCwwLC41KTtib3gtc2hhZG93OjAgNXB4IDE1cHggcmdiYSgwLDAsMCwuNSl9Lm1vZGFsLXNte3dpZHRoOjMwMHB4fX1AbWVkaWEgKG1pbi13aWR0aDo5OTJweCl7Lm1vZGFsLWxne3dpZHRoOjkwMHB4fX0udG9vbHRpcHtwb3NpdGlvbjphYnNvbHV0ZTt6LWluZGV4OjEwNzA7ZGlzcGxheTpibG9jaztmb250LWZhbWlseToiSGVsdmV0aWNhIE5ldWUiLEhlbHZldGljYSxBcmlhbCxzYW5zLXNlcmlmO2ZvbnQtc2l6ZToxMnB4O2ZvbnQtd2VpZ2h0OjQwMDtsaW5lLWhlaWdodDoxLjQ7dmlzaWJpbGl0eTp2aXNpYmxlO2ZpbHRlcjphbHBoYShvcGFjaXR5PTApO29wYWNpdHk6MH0udG9vbHRpcC5pbntmaWx0ZXI6YWxwaGEob3BhY2l0eT05MCk7b3BhY2l0eTouOX0udG9vbHRpcC50b3B7cGFkZGluZzo1cHggMDttYXJnaW4tdG9wOi0zcHh9LnRvb2x0aXAucmlnaHR7cGFkZGluZzowIDVweDttYXJnaW4tbGVmdDozcHh9LnRvb2x0aXAuYm90dG9te3BhZGRpbmc6NXB4IDA7bWFyZ2luLXRvcDozcHh9LnRvb2x0aXAubGVmdHtwYWRkaW5nOjAgNXB4O21hcmdpbi1sZWZ0Oi0zcHh9LnRvb2x0aXAtaW5uZXJ7bWF4LXdpZHRoOjIwMHB4O3BhZGRpbmc6M3B4IDhweDtjb2xvcjojZmZmO3RleHQtYWxpZ246Y2VudGVyO3RleHQtZGVjb3JhdGlvbjpub25lO2JhY2tncm91bmQtY29sb3I6IzAwMDtib3JkZXItcmFkaXVzOjRweH0udG9vbHRpcC1hcnJvd3twb3NpdGlvbjphYnNvbHV0ZTt3aWR0aDowO2hlaWdodDowO2JvcmRlci1jb2xvcjp0cmFuc3BhcmVudDtib3JkZXItc3R5bGU6c29saWR9LnRvb2x0aXAudG9wIC50b29sdGlwLWFycm93e2JvdHRvbTowO2xlZnQ6NTAlO21hcmdpbi1sZWZ0Oi01cHg7Ym9yZGVyLXdpZHRoOjVweCA1cHggMDtib3JkZXItdG9wLWNvbG9yOiMwMDB9LnRvb2x0aXAudG9wLWxlZnQgLnRvb2x0aXAtYXJyb3d7cmlnaHQ6NXB4O2JvdHRvbTowO21hcmdpbi1ib3R0b206LTVweDtib3JkZXItd2lkdGg6NXB4IDVweCAwO2JvcmRlci10b3AtY29sb3I6IzAwMH0udG9vbHRpcC50b3AtcmlnaHQgLnRvb2x0aXAtYXJyb3d7Ym90dG9tOjA7bGVmdDo1cHg7bWFyZ2luLWJvdHRvbTotNXB4O2JvcmRlci13aWR0aDo1cHggNXB4IDA7Ym9yZGVyLXRvcC1jb2xvcjojMDAwfS50b29sdGlwLnJpZ2h0IC50b29sdGlwLWFycm93e3RvcDo1MCU7bGVmdDowO21hcmdpbi10b3A6LTVweDtib3JkZXItd2lkdGg6NXB4IDVweCA1cHggMDtib3JkZXItcmlnaHQtY29sb3I6IzAwMH0udG9vbHRpcC5sZWZ0IC50b29sdGlwLWFycm93e3RvcDo1MCU7cmlnaHQ6MDttYXJnaW4tdG9wOi01cHg7Ym9yZGVyLXdpZHRoOjVweCAwIDVweCA1cHg7Ym9yZGVyLWxlZnQtY29sb3I6IzAwMH0udG9vbHRpcC5ib3R0b20gLnRvb2x0aXAtYXJyb3d7dG9wOjA7bGVmdDo1MCU7bWFyZ2luLWxlZnQ6LTVweDtib3JkZXItd2lkdGg6MCA1cHggNXB4O2JvcmRlci1ib3R0b20tY29sb3I6IzAwMH0udG9vbHRpcC5ib3R0b20tbGVmdCAudG9vbHRpcC1hcnJvd3t0b3A6MDtyaWdodDo1cHg7bWFyZ2luLXRvcDotNXB4O2JvcmRlci13aWR0aDowIDVweCA1cHg7Ym9yZGVyLWJvdHRvbS1jb2xvcjojMDAwfS50b29sdGlwLmJvdHRvbS1yaWdodCAudG9vbHRpcC1hcnJvd3t0b3A6MDtsZWZ0OjVweDttYXJnaW4tdG9wOi01cHg7Ym9yZGVyLXdpZHRoOjAgNXB4IDVweDtib3JkZXItYm90dG9tLWNvbG9yOiMwMDB9LnBvcG92ZXJ7cG9zaXRpb246YWJzb2x1dGU7dG9wOjA7bGVmdDowO3otaW5kZXg6MTA2MDtkaXNwbGF5Om5vbmU7bWF4LXdpZHRoOjI3NnB4O3BhZGRpbmc6MXB4O2ZvbnQtZmFtaWx5OiJIZWx2ZXRpY2EgTmV1ZSIsSGVsdmV0aWNhLEFyaWFsLHNhbnMtc2VyaWY7Zm9udC1zaXplOjE0cHg7Zm9udC13ZWlnaHQ6NDAwO2xpbmUtaGVpZ2h0OjEuNDI4NTcxNDM7dGV4dC1hbGlnbjpsZWZ0O3doaXRlLXNwYWNlOm5vcm1hbDtiYWNrZ3JvdW5kLWNvbG9yOiNmZmY7LXdlYmtpdC1iYWNrZ3JvdW5kLWNsaXA6cGFkZGluZy1ib3g7YmFja2dyb3VuZC1jbGlwOnBhZGRpbmctYm94O2JvcmRlcjoxcHggc29saWQgI2NjYztib3JkZXI6MXB4IHNvbGlkIHJnYmEoMCwwLDAsLjIpO2JvcmRlci1yYWRpdXM6NnB4Oy13ZWJraXQtYm94LXNoYWRvdzowIDVweCAxMHB4IHJnYmEoMCwwLDAsLjIpO2JveC1zaGFkb3c6MCA1cHggMTBweCByZ2JhKDAsMCwwLC4yKX0ucG9wb3Zlci50b3B7bWFyZ2luLXRvcDotMTBweH0ucG9wb3Zlci5yaWdodHttYXJnaW4tbGVmdDoxMHB4fS5wb3BvdmVyLmJvdHRvbXttYXJnaW4tdG9wOjEwcHh9LnBvcG92ZXIubGVmdHttYXJnaW4tbGVmdDotMTBweH0ucG9wb3Zlci10aXRsZXtwYWRkaW5nOjhweCAxNHB4O21hcmdpbjowO2ZvbnQtc2l6ZToxNHB4O2JhY2tncm91bmQtY29sb3I6I2Y3ZjdmNztib3JkZXItYm90dG9tOjFweCBzb2xpZCAjZWJlYmViO2JvcmRlci1yYWRpdXM6NXB4IDVweCAwIDB9LnBvcG92ZXItY29udGVudHtwYWRkaW5nOjlweCAxNHB4fS5wb3BvdmVyPi5hcnJvdywucG9wb3Zlcj4uYXJyb3c6YWZ0ZXJ7cG9zaXRpb246YWJzb2x1dGU7ZGlzcGxheTpibG9jazt3aWR0aDowO2hlaWdodDowO2JvcmRlci1jb2xvcjp0cmFuc3BhcmVudDtib3JkZXItc3R5bGU6c29saWR9LnBvcG92ZXI+LmFycm93e2JvcmRlci13aWR0aDoxMXB4fS5wb3BvdmVyPi5hcnJvdzphZnRlcntjb250ZW50OiIiO2JvcmRlci13aWR0aDoxMHB4fS5wb3BvdmVyLnRvcD4uYXJyb3d7Ym90dG9tOi0xMXB4O2xlZnQ6NTAlO21hcmdpbi1sZWZ0Oi0xMXB4O2JvcmRlci10b3AtY29sb3I6Izk5OTtib3JkZXItdG9wLWNvbG9yOnJnYmEoMCwwLDAsLjI1KTtib3JkZXItYm90dG9tLXdpZHRoOjB9LnBvcG92ZXIudG9wPi5hcnJvdzphZnRlcntib3R0b206MXB4O21hcmdpbi1sZWZ0Oi0xMHB4O2NvbnRlbnQ6IiAiO2JvcmRlci10b3AtY29sb3I6I2ZmZjtib3JkZXItYm90dG9tLXdpZHRoOjB9LnBvcG92ZXIucmlnaHQ+LmFycm93e3RvcDo1MCU7bGVmdDotMTFweDttYXJnaW4tdG9wOi0xMXB4O2JvcmRlci1yaWdodC1jb2xvcjojOTk5O2JvcmRlci1yaWdodC1jb2xvcjpyZ2JhKDAsMCwwLC4yNSk7Ym9yZGVyLWxlZnQtd2lkdGg6MH0ucG9wb3Zlci5yaWdodD4uYXJyb3c6YWZ0ZXJ7Ym90dG9tOi0xMHB4O2xlZnQ6MXB4O2NvbnRlbnQ6IiAiO2JvcmRlci1yaWdodC1jb2xvcjojZmZmO2JvcmRlci1sZWZ0LXdpZHRoOjB9LnBvcG92ZXIuYm90dG9tPi5hcnJvd3t0b3A6LTExcHg7bGVmdDo1MCU7bWFyZ2luLWxlZnQ6LTExcHg7Ym9yZGVyLXRvcC13aWR0aDowO2JvcmRlci1ib3R0b20tY29sb3I6Izk5OTtib3JkZXItYm90dG9tLWNvbG9yOnJnYmEoMCwwLDAsLjI1KX0ucG9wb3Zlci5ib3R0b20+LmFycm93OmFmdGVye3RvcDoxcHg7bWFyZ2luLWxlZnQ6LTEwcHg7Y29udGVudDoiICI7Ym9yZGVyLXRvcC13aWR0aDowO2JvcmRlci1ib3R0b20tY29sb3I6I2ZmZn0ucG9wb3Zlci5sZWZ0Pi5hcnJvd3t0b3A6NTAlO3JpZ2h0Oi0xMXB4O21hcmdpbi10b3A6LTExcHg7Ym9yZGVyLXJpZ2h0LXdpZHRoOjA7Ym9yZGVyLWxlZnQtY29sb3I6Izk5OTtib3JkZXItbGVmdC1jb2xvcjpyZ2JhKDAsMCwwLC4yNSl9LnBvcG92ZXIubGVmdD4uYXJyb3c6YWZ0ZXJ7cmlnaHQ6MXB4O2JvdHRvbTotMTBweDtjb250ZW50OiIgIjtib3JkZXItcmlnaHQtd2lkdGg6MDtib3JkZXItbGVmdC1jb2xvcjojZmZmfS5jYXJvdXNlbHtwb3NpdGlvbjpyZWxhdGl2ZX0uY2Fyb3VzZWwtaW5uZXJ7cG9zaXRpb246cmVsYXRpdmU7d2lkdGg6MTAwJTtvdmVyZmxvdzpoaWRkZW59LmNhcm91c2VsLWlubmVyPi5pdGVte3Bvc2l0aW9uOnJlbGF0aXZlO2Rpc3BsYXk6bm9uZTstd2Via2l0LXRyYW5zaXRpb246LjZzIGVhc2UtaW4tb3V0IGxlZnQ7LW8tdHJhbnNpdGlvbjouNnMgZWFzZS1pbi1vdXQgbGVmdDt0cmFuc2l0aW9uOi42cyBlYXNlLWluLW91dCBsZWZ0fS5jYXJvdXNlbC1pbm5lcj4uaXRlbT5pbWcsLmNhcm91c2VsLWlubmVyPi5pdGVtPmE+aW1ne2xpbmUtaGVpZ2h0OjF9QG1lZGlhIGFsbCBhbmQgKHRyYW5zZm9ybS0zZCksKC13ZWJraXQtdHJhbnNmb3JtLTNkKXsuY2Fyb3VzZWwtaW5uZXI+Lml0ZW17LXdlYmtpdC10cmFuc2l0aW9uOi13ZWJraXQtdHJhbnNmb3JtIC42cyBlYXNlLWluLW91dDstby10cmFuc2l0aW9uOi1vLXRyYW5zZm9ybSAuNnMgZWFzZS1pbi1vdXQ7dHJhbnNpdGlvbjp0cmFuc2Zvcm0gLjZzIGVhc2UtaW4tb3V0Oy13ZWJraXQtYmFja2ZhY2UtdmlzaWJpbGl0eTpoaWRkZW47YmFja2ZhY2UtdmlzaWJpbGl0eTpoaWRkZW47LXdlYmtpdC1wZXJzcGVjdGl2ZToxMDAwO3BlcnNwZWN0aXZlOjEwMDB9LmNhcm91c2VsLWlubmVyPi5pdGVtLm5leHQsLmNhcm91c2VsLWlubmVyPi5pdGVtLmFjdGl2ZS5yaWdodHtsZWZ0OjA7LXdlYmtpdC10cmFuc2Zvcm06dHJhbnNsYXRlM2QoMTAwJSwwLDApO3RyYW5zZm9ybTp0cmFuc2xhdGUzZCgxMDAlLDAsMCl9LmNhcm91c2VsLWlubmVyPi5pdGVtLnByZXYsLmNhcm91c2VsLWlubmVyPi5pdGVtLmFjdGl2ZS5sZWZ0e2xlZnQ6MDstd2Via2l0LXRyYW5zZm9ybTp0cmFuc2xhdGUzZCgtMTAwJSwwLDApO3RyYW5zZm9ybTp0cmFuc2xhdGUzZCgtMTAwJSwwLDApfS5jYXJvdXNlbC1pbm5lcj4uaXRlbS5uZXh0LmxlZnQsLmNhcm91c2VsLWlubmVyPi5pdGVtLnByZXYucmlnaHQsLmNhcm91c2VsLWlubmVyPi5pdGVtLmFjdGl2ZXtsZWZ0OjA7LXdlYmtpdC10cmFuc2Zvcm06dHJhbnNsYXRlM2QoMCwwLDApO3RyYW5zZm9ybTp0cmFuc2xhdGUzZCgwLDAsMCl9fS5jYXJvdXNlbC1pbm5lcj4uYWN0aXZlLC5jYXJvdXNlbC1pbm5lcj4ubmV4dCwuY2Fyb3VzZWwtaW5uZXI+LnByZXZ7ZGlzcGxheTpibG9ja30uY2Fyb3VzZWwtaW5uZXI+LmFjdGl2ZXtsZWZ0OjB9LmNhcm91c2VsLWlubmVyPi5uZXh0LC5jYXJvdXNlbC1pbm5lcj4ucHJldntwb3NpdGlvbjphYnNvbHV0ZTt0b3A6MDt3aWR0aDoxMDAlfS5jYXJvdXNlbC1pbm5lcj4ubmV4dHtsZWZ0OjEwMCV9LmNhcm91c2VsLWlubmVyPi5wcmV2e2xlZnQ6LTEwMCV9LmNhcm91c2VsLWlubmVyPi5uZXh0LmxlZnQsLmNhcm91c2VsLWlubmVyPi5wcmV2LnJpZ2h0e2xlZnQ6MH0uY2Fyb3VzZWwtaW5uZXI+LmFjdGl2ZS5sZWZ0e2xlZnQ6LTEwMCV9LmNhcm91c2VsLWlubmVyPi5hY3RpdmUucmlnaHR7bGVmdDoxMDAlfS5jYXJvdXNlbC1jb250cm9se3Bvc2l0aW9uOmFic29sdXRlO3RvcDowO2JvdHRvbTowO2xlZnQ6MDt3aWR0aDoxNSU7Zm9udC1zaXplOjIwcHg7Y29sb3I6I2ZmZjt0ZXh0LWFsaWduOmNlbnRlcjt0ZXh0LXNoYWRvdzowIDFweCAycHggcmdiYSgwLDAsMCwuNik7ZmlsdGVyOmFscGhhKG9wYWNpdHk9NTApO29wYWNpdHk6LjV9LmNhcm91c2VsLWNvbnRyb2wubGVmdHtiYWNrZ3JvdW5kLWltYWdlOi13ZWJraXQtbGluZWFyLWdyYWRpZW50KGxlZnQscmdiYSgwLDAsMCwuNSkgMCxyZ2JhKDAsMCwwLC4wMDAxKSAxMDAlKTtiYWNrZ3JvdW5kLWltYWdlOi1vLWxpbmVhci1ncmFkaWVudChsZWZ0LHJnYmEoMCwwLDAsLjUpIDAscmdiYSgwLDAsMCwuMDAwMSkgMTAwJSk7YmFja2dyb3VuZC1pbWFnZTotd2Via2l0LWdyYWRpZW50KGxpbmVhcixsZWZ0IHRvcCxyaWdodCB0b3AsZnJvbShyZ2JhKDAsMCwwLC41KSksdG8ocmdiYSgwLDAsMCwuMDAwMSkpKTtiYWNrZ3JvdW5kLWltYWdlOmxpbmVhci1ncmFkaWVudCh0byByaWdodCxyZ2JhKDAsMCwwLC41KSAwLHJnYmEoMCwwLDAsLjAwMDEpIDEwMCUpO2ZpbHRlcjpwcm9naWQ6RFhJbWFnZVRyYW5zZm9ybS5NaWNyb3NvZnQuZ3JhZGllbnQoc3RhcnRDb2xvcnN0cj0nIzgwMDAwMDAwJywgZW5kQ29sb3JzdHI9JyMwMDAwMDAwMCcsIEdyYWRpZW50VHlwZT0xKTtiYWNrZ3JvdW5kLXJlcGVhdDpyZXBlYXQteH0uY2Fyb3VzZWwtY29udHJvbC5yaWdodHtyaWdodDowO2xlZnQ6YXV0bztiYWNrZ3JvdW5kLWltYWdlOi13ZWJraXQtbGluZWFyLWdyYWRpZW50KGxlZnQscmdiYSgwLDAsMCwuMDAwMSkgMCxyZ2JhKDAsMCwwLC41KSAxMDAlKTtiYWNrZ3JvdW5kLWltYWdlOi1vLWxpbmVhci1ncmFkaWVudChsZWZ0LHJnYmEoMCwwLDAsLjAwMDEpIDAscmdiYSgwLDAsMCwuNSkgMTAwJSk7YmFja2dyb3VuZC1pbWFnZTotd2Via2l0LWdyYWRpZW50KGxpbmVhcixsZWZ0IHRvcCxyaWdodCB0b3AsZnJvbShyZ2JhKDAsMCwwLC4wMDAxKSksdG8ocmdiYSgwLDAsMCwuNSkpKTtiYWNrZ3JvdW5kLWltYWdlOmxpbmVhci1ncmFkaWVudCh0byByaWdodCxyZ2JhKDAsMCwwLC4wMDAxKSAwLHJnYmEoMCwwLDAsLjUpIDEwMCUpO2ZpbHRlcjpwcm9naWQ6RFhJbWFnZVRyYW5zZm9ybS5NaWNyb3NvZnQuZ3JhZGllbnQoc3RhcnRDb2xvcnN0cj0nIzAwMDAwMDAwJywgZW5kQ29sb3JzdHI9JyM4MDAwMDAwMCcsIEdyYWRpZW50VHlwZT0xKTtiYWNrZ3JvdW5kLXJlcGVhdDpyZXBlYXQteH0uY2Fyb3VzZWwtY29udHJvbDpob3ZlciwuY2Fyb3VzZWwtY29udHJvbDpmb2N1c3tjb2xvcjojZmZmO3RleHQtZGVjb3JhdGlvbjpub25lO2ZpbHRlcjphbHBoYShvcGFjaXR5PTkwKTtvdXRsaW5lOjA7b3BhY2l0eTouOX0uY2Fyb3VzZWwtY29udHJvbCAuaWNvbi1wcmV2LC5jYXJvdXNlbC1jb250cm9sIC5pY29uLW5leHQsLmNhcm91c2VsLWNvbnRyb2wgLmdseXBoaWNvbi1jaGV2cm9uLWxlZnQsLmNhcm91c2VsLWNvbnRyb2wgLmdseXBoaWNvbi1jaGV2cm9uLXJpZ2h0e3Bvc2l0aW9uOmFic29sdXRlO3RvcDo1MCU7ei1pbmRleDo1O2Rpc3BsYXk6aW5saW5lLWJsb2NrfS5jYXJvdXNlbC1jb250cm9sIC5pY29uLXByZXYsLmNhcm91c2VsLWNvbnRyb2wgLmdseXBoaWNvbi1jaGV2cm9uLWxlZnR7bGVmdDo1MCU7bWFyZ2luLWxlZnQ6LTEwcHh9LmNhcm91c2VsLWNvbnRyb2wgLmljb24tbmV4dCwuY2Fyb3VzZWwtY29udHJvbCAuZ2x5cGhpY29uLWNoZXZyb24tcmlnaHR7cmlnaHQ6NTAlO21hcmdpbi1yaWdodDotMTBweH0uY2Fyb3VzZWwtY29udHJvbCAuaWNvbi1wcmV2LC5jYXJvdXNlbC1jb250cm9sIC5pY29uLW5leHR7d2lkdGg6MjBweDtoZWlnaHQ6MjBweDttYXJnaW4tdG9wOi0xMHB4O2ZvbnQtZmFtaWx5OnNlcmlmfS5jYXJvdXNlbC1jb250cm9sIC5pY29uLXByZXY6YmVmb3Jle2NvbnRlbnQ6J1wyMDM5J30uY2Fyb3VzZWwtY29udHJvbCAuaWNvbi1uZXh0OmJlZm9yZXtjb250ZW50OidcMjAzYSd9LmNhcm91c2VsLWluZGljYXRvcnN7cG9zaXRpb246YWJzb2x1dGU7Ym90dG9tOjEwcHg7bGVmdDo1MCU7ei1pbmRleDoxNTt3aWR0aDo2MCU7cGFkZGluZy1sZWZ0OjA7bWFyZ2luLWxlZnQ6LTMwJTt0ZXh0LWFsaWduOmNlbnRlcjtsaXN0LXN0eWxlOm5vbmV9LmNhcm91c2VsLWluZGljYXRvcnMgbGl7ZGlzcGxheTppbmxpbmUtYmxvY2s7d2lkdGg6MTBweDtoZWlnaHQ6MTBweDttYXJnaW46MXB4O3RleHQtaW5kZW50Oi05OTlweDtjdXJzb3I6cG9pbnRlcjtiYWNrZ3JvdW5kLWNvbG9yOiMwMDAgXDk7YmFja2dyb3VuZC1jb2xvcjpyZ2JhKDAsMCwwLDApO2JvcmRlcjoxcHggc29saWQgI2ZmZjtib3JkZXItcmFkaXVzOjEwcHh9LmNhcm91c2VsLWluZGljYXRvcnMgLmFjdGl2ZXt3aWR0aDoxMnB4O2hlaWdodDoxMnB4O21hcmdpbjowO2JhY2tncm91bmQtY29sb3I6I2ZmZn0uY2Fyb3VzZWwtY2FwdGlvbntwb3NpdGlvbjphYnNvbHV0ZTtyaWdodDoxNSU7Ym90dG9tOjIwcHg7bGVmdDoxNSU7ei1pbmRleDoxMDtwYWRkaW5nLXRvcDoyMHB4O3BhZGRpbmctYm90dG9tOjIwcHg7Y29sb3I6I2ZmZjt0ZXh0LWFsaWduOmNlbnRlcjt0ZXh0LXNoYWRvdzowIDFweCAycHggcmdiYSgwLDAsMCwuNil9LmNhcm91c2VsLWNhcHRpb24gLmJ0bnt0ZXh0LXNoYWRvdzpub25lfUBtZWRpYSBzY3JlZW4gYW5kIChtaW4td2lkdGg6NzY4cHgpey5jYXJvdXNlbC1jb250cm9sIC5nbHlwaGljb24tY2hldnJvbi1sZWZ0LC5jYXJvdXNlbC1jb250cm9sIC5nbHlwaGljb24tY2hldnJvbi1yaWdodCwuY2Fyb3VzZWwtY29udHJvbCAuaWNvbi1wcmV2LC5jYXJvdXNlbC1jb250cm9sIC5pY29uLW5leHR7d2lkdGg6MzBweDtoZWlnaHQ6MzBweDttYXJnaW4tdG9wOi0xNXB4O2ZvbnQtc2l6ZTozMHB4fS5jYXJvdXNlbC1jb250cm9sIC5nbHlwaGljb24tY2hldnJvbi1sZWZ0LC5jYXJvdXNlbC1jb250cm9sIC5pY29uLXByZXZ7bWFyZ2luLWxlZnQ6LTE1cHh9LmNhcm91c2VsLWNvbnRyb2wgLmdseXBoaWNvbi1jaGV2cm9uLXJpZ2h0LC5jYXJvdXNlbC1jb250cm9sIC5pY29uLW5leHR7bWFyZ2luLXJpZ2h0Oi0xNXB4fS5jYXJvdXNlbC1jYXB0aW9ue3JpZ2h0OjIwJTtsZWZ0OjIwJTtwYWRkaW5nLWJvdHRvbTozMHB4fS5jYXJvdXNlbC1pbmRpY2F0b3Jze2JvdHRvbToyMHB4fX0uY2xlYXJmaXg6YmVmb3JlLC5jbGVhcmZpeDphZnRlciwuZGwtaG9yaXpvbnRhbCBkZDpiZWZvcmUsLmRsLWhvcml6b250YWwgZGQ6YWZ0ZXIsLmNvbnRhaW5lcjpiZWZvcmUsLmNvbnRhaW5lcjphZnRlciwuY29udGFpbmVyLWZsdWlkOmJlZm9yZSwuY29udGFpbmVyLWZsdWlkOmFmdGVyLC5yb3c6YmVmb3JlLC5yb3c6YWZ0ZXIsLmZvcm0taG9yaXpvbnRhbCAuZm9ybS1ncm91cDpiZWZvcmUsLmZvcm0taG9yaXpvbnRhbCAuZm9ybS1ncm91cDphZnRlciwuYnRuLXRvb2xiYXI6YmVmb3JlLC5idG4tdG9vbGJhcjphZnRlciwuYnRuLWdyb3VwLXZlcnRpY2FsPi5idG4tZ3JvdXA6YmVmb3JlLC5idG4tZ3JvdXAtdmVydGljYWw+LmJ0bi1ncm91cDphZnRlciwubmF2OmJlZm9yZSwubmF2OmFmdGVyLC5uYXZiYXI6YmVmb3JlLC5uYXZiYXI6YWZ0ZXIsLm5hdmJhci1oZWFkZXI6YmVmb3JlLC5uYXZiYXItaGVhZGVyOmFmdGVyLC5uYXZiYXItY29sbGFwc2U6YmVmb3JlLC5uYXZiYXItY29sbGFwc2U6YWZ0ZXIsLnBhZ2VyOmJlZm9yZSwucGFnZXI6YWZ0ZXIsLnBhbmVsLWJvZHk6YmVmb3JlLC5wYW5lbC1ib2R5OmFmdGVyLC5tb2RhbC1mb290ZXI6YmVmb3JlLC5tb2RhbC1mb290ZXI6YWZ0ZXJ7ZGlzcGxheTp0YWJsZTtjb250ZW50OiIgIn0uY2xlYXJmaXg6YWZ0ZXIsLmRsLWhvcml6b250YWwgZGQ6YWZ0ZXIsLmNvbnRhaW5lcjphZnRlciwuY29udGFpbmVyLWZsdWlkOmFmdGVyLC5yb3c6YWZ0ZXIsLmZvcm0taG9yaXpvbnRhbCAuZm9ybS1ncm91cDphZnRlciwuYnRuLXRvb2xiYXI6YWZ0ZXIsLmJ0bi1ncm91cC12ZXJ0aWNhbD4uYnRuLWdyb3VwOmFmdGVyLC5uYXY6YWZ0ZXIsLm5hdmJhcjphZnRlciwubmF2YmFyLWhlYWRlcjphZnRlciwubmF2YmFyLWNvbGxhcHNlOmFmdGVyLC5wYWdlcjphZnRlciwucGFuZWwtYm9keTphZnRlciwubW9kYWwtZm9vdGVyOmFmdGVye2NsZWFyOmJvdGh9LmNlbnRlci1ibG9ja3tkaXNwbGF5OmJsb2NrO21hcmdpbi1yaWdodDphdXRvO21hcmdpbi1sZWZ0OmF1dG99LnB1bGwtcmlnaHR7ZmxvYXQ6cmlnaHQhaW1wb3J0YW50fS5wdWxsLWxlZnR7ZmxvYXQ6bGVmdCFpbXBvcnRhbnR9LmhpZGV7ZGlzcGxheTpub25lIWltcG9ydGFudH0uc2hvd3tkaXNwbGF5OmJsb2NrIWltcG9ydGFudH0uaW52aXNpYmxle3Zpc2liaWxpdHk6aGlkZGVufS50ZXh0LWhpZGV7Zm9udDowLzAgYTtjb2xvcjp0cmFuc3BhcmVudDt0ZXh0LXNoYWRvdzpub25lO2JhY2tncm91bmQtY29sb3I6dHJhbnNwYXJlbnQ7Ym9yZGVyOjB9LmhpZGRlbntkaXNwbGF5Om5vbmUhaW1wb3J0YW50O3Zpc2liaWxpdHk6aGlkZGVuIWltcG9ydGFudH0uYWZmaXh7cG9zaXRpb246Zml4ZWR9QC1tcy12aWV3cG9ydHt3aWR0aDpkZXZpY2Utd2lkdGh9LnZpc2libGUteHMsLnZpc2libGUtc20sLnZpc2libGUtbWQsLnZpc2libGUtbGd7ZGlzcGxheTpub25lIWltcG9ydGFudH0udmlzaWJsZS14cy1ibG9jaywudmlzaWJsZS14cy1pbmxpbmUsLnZpc2libGUteHMtaW5saW5lLWJsb2NrLC52aXNpYmxlLXNtLWJsb2NrLC52aXNpYmxlLXNtLWlubGluZSwudmlzaWJsZS1zbS1pbmxpbmUtYmxvY2ssLnZpc2libGUtbWQtYmxvY2ssLnZpc2libGUtbWQtaW5saW5lLC52aXNpYmxlLW1kLWlubGluZS1ibG9jaywudmlzaWJsZS1sZy1ibG9jaywudmlzaWJsZS1sZy1pbmxpbmUsLnZpc2libGUtbGctaW5saW5lLWJsb2Nre2Rpc3BsYXk6bm9uZSFpbXBvcnRhbnR9QG1lZGlhIChtYXgtd2lkdGg6NzY3cHgpey52aXNpYmxlLXhze2Rpc3BsYXk6YmxvY2shaW1wb3J0YW50fXRhYmxlLnZpc2libGUteHN7ZGlzcGxheTp0YWJsZX10ci52aXNpYmxlLXhze2Rpc3BsYXk6dGFibGUtcm93IWltcG9ydGFudH10aC52aXNpYmxlLXhzLHRkLnZpc2libGUteHN7ZGlzcGxheTp0YWJsZS1jZWxsIWltcG9ydGFudH19QG1lZGlhIChtYXgtd2lkdGg6NzY3cHgpey52aXNpYmxlLXhzLWJsb2Nre2Rpc3BsYXk6YmxvY2shaW1wb3J0YW50fX1AbWVkaWEgKG1heC13aWR0aDo3NjdweCl7LnZpc2libGUteHMtaW5saW5le2Rpc3BsYXk6aW5saW5lIWltcG9ydGFudH19QG1lZGlhIChtYXgtd2lkdGg6NzY3cHgpey52aXNpYmxlLXhzLWlubGluZS1ibG9ja3tkaXNwbGF5OmlubGluZS1ibG9jayFpbXBvcnRhbnR9fUBtZWRpYSAobWluLXdpZHRoOjc2OHB4KSBhbmQgKG1heC13aWR0aDo5OTFweCl7LnZpc2libGUtc217ZGlzcGxheTpibG9jayFpbXBvcnRhbnR9dGFibGUudmlzaWJsZS1zbXtkaXNwbGF5OnRhYmxlfXRyLnZpc2libGUtc217ZGlzcGxheTp0YWJsZS1yb3chaW1wb3J0YW50fXRoLnZpc2libGUtc20sdGQudmlzaWJsZS1zbXtkaXNwbGF5OnRhYmxlLWNlbGwhaW1wb3J0YW50fX1AbWVkaWEgKG1pbi13aWR0aDo3NjhweCkgYW5kIChtYXgtd2lkdGg6OTkxcHgpey52aXNpYmxlLXNtLWJsb2Nre2Rpc3BsYXk6YmxvY2shaW1wb3J0YW50fX1AbWVkaWEgKG1pbi13aWR0aDo3NjhweCkgYW5kIChtYXgtd2lkdGg6OTkxcHgpey52aXNpYmxlLXNtLWlubGluZXtkaXNwbGF5OmlubGluZSFpbXBvcnRhbnR9fUBtZWRpYSAobWluLXdpZHRoOjc2OHB4KSBhbmQgKG1heC13aWR0aDo5OTFweCl7LnZpc2libGUtc20taW5saW5lLWJsb2Nre2Rpc3BsYXk6aW5saW5lLWJsb2NrIWltcG9ydGFudH19QG1lZGlhIChtaW4td2lkdGg6OTkycHgpIGFuZCAobWF4LXdpZHRoOjExOTlweCl7LnZpc2libGUtbWR7ZGlzcGxheTpibG9jayFpbXBvcnRhbnR9dGFibGUudmlzaWJsZS1tZHtkaXNwbGF5OnRhYmxlfXRyLnZpc2libGUtbWR7ZGlzcGxheTp0YWJsZS1yb3chaW1wb3J0YW50fXRoLnZpc2libGUtbWQsdGQudmlzaWJsZS1tZHtkaXNwbGF5OnRhYmxlLWNlbGwhaW1wb3J0YW50fX1AbWVkaWEgKG1pbi13aWR0aDo5OTJweCkgYW5kIChtYXgtd2lkdGg6MTE5OXB4KXsudmlzaWJsZS1tZC1ibG9ja3tkaXNwbGF5OmJsb2NrIWltcG9ydGFudH19QG1lZGlhIChtaW4td2lkdGg6OTkycHgpIGFuZCAobWF4LXdpZHRoOjExOTlweCl7LnZpc2libGUtbWQtaW5saW5le2Rpc3BsYXk6aW5saW5lIWltcG9ydGFudH19QG1lZGlhIChtaW4td2lkdGg6OTkycHgpIGFuZCAobWF4LXdpZHRoOjExOTlweCl7LnZpc2libGUtbWQtaW5saW5lLWJsb2Nre2Rpc3BsYXk6aW5saW5lLWJsb2NrIWltcG9ydGFudH19QG1lZGlhIChtaW4td2lkdGg6MTIwMHB4KXsudmlzaWJsZS1sZ3tkaXNwbGF5OmJsb2NrIWltcG9ydGFudH10YWJsZS52aXNpYmxlLWxne2Rpc3BsYXk6dGFibGV9dHIudmlzaWJsZS1sZ3tkaXNwbGF5OnRhYmxlLXJvdyFpbXBvcnRhbnR9dGgudmlzaWJsZS1sZyx0ZC52aXNpYmxlLWxne2Rpc3BsYXk6dGFibGUtY2VsbCFpbXBvcnRhbnR9fUBtZWRpYSAobWluLXdpZHRoOjEyMDBweCl7LnZpc2libGUtbGctYmxvY2t7ZGlzcGxheTpibG9jayFpbXBvcnRhbnR9fUBtZWRpYSAobWluLXdpZHRoOjEyMDBweCl7LnZpc2libGUtbGctaW5saW5le2Rpc3BsYXk6aW5saW5lIWltcG9ydGFudH19QG1lZGlhIChtaW4td2lkdGg6MTIwMHB4KXsudmlzaWJsZS1sZy1pbmxpbmUtYmxvY2t7ZGlzcGxheTppbmxpbmUtYmxvY2shaW1wb3J0YW50fX1AbWVkaWEgKG1heC13aWR0aDo3NjdweCl7LmhpZGRlbi14c3tkaXNwbGF5Om5vbmUhaW1wb3J0YW50fX1AbWVkaWEgKG1pbi13aWR0aDo3NjhweCkgYW5kIChtYXgtd2lkdGg6OTkxcHgpey5oaWRkZW4tc217ZGlzcGxheTpub25lIWltcG9ydGFudH19QG1lZGlhIChtaW4td2lkdGg6OTkycHgpIGFuZCAobWF4LXdpZHRoOjExOTlweCl7LmhpZGRlbi1tZHtkaXNwbGF5Om5vbmUhaW1wb3J0YW50fX1AbWVkaWEgKG1pbi13aWR0aDoxMjAwcHgpey5oaWRkZW4tbGd7ZGlzcGxheTpub25lIWltcG9ydGFudH19LnZpc2libGUtcHJpbnR7ZGlzcGxheTpub25lIWltcG9ydGFudH1AbWVkaWEgcHJpbnR7LnZpc2libGUtcHJpbnR7ZGlzcGxheTpibG9jayFpbXBvcnRhbnR9dGFibGUudmlzaWJsZS1wcmludHtkaXNwbGF5OnRhYmxlfXRyLnZpc2libGUtcHJpbnR7ZGlzcGxheTp0YWJsZS1yb3chaW1wb3J0YW50fXRoLnZpc2libGUtcHJpbnQsdGQudmlzaWJsZS1wcmludHtkaXNwbGF5OnRhYmxlLWNlbGwhaW1wb3J0YW50fX0udmlzaWJsZS1wcmludC1ibG9ja3tkaXNwbGF5Om5vbmUhaW1wb3J0YW50fUBtZWRpYSBwcmludHsudmlzaWJsZS1wcmludC1ibG9ja3tkaXNwbGF5OmJsb2NrIWltcG9ydGFudH19LnZpc2libGUtcHJpbnQtaW5saW5le2Rpc3BsYXk6bm9uZSFpbXBvcnRhbnR9QG1lZGlhIHByaW50ey52aXNpYmxlLXByaW50LWlubGluZXtkaXNwbGF5OmlubGluZSFpbXBvcnRhbnR9fS52aXNpYmxlLXByaW50LWlubGluZS1ibG9ja3tkaXNwbGF5Om5vbmUhaW1wb3J0YW50fUBtZWRpYSBwcmludHsudmlzaWJsZS1wcmludC1pbmxpbmUtYmxvY2t7ZGlzcGxheTppbmxpbmUtYmxvY2shaW1wb3J0YW50fX1AbWVkaWEgcHJpbnR7LmhpZGRlbi1wcmludHtkaXNwbGF5Om5vbmUhaW1wb3J0YW50fX0=";
	
	}
	public class jquery_1_12_4_min_js
	{
		public static readonly string TextContent = ((Func<string>)(() =>
		{
			byte[] Result = null;
			{
				var ZipMemmory = new System.IO.MemoryStream(System.Convert.FromBase64String("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"));
				var DezippedMemory = new System.IO.MemoryStream();
				using (var Dezip = new System.IO.Compression.DeflateStream(ZipMemmory, System.IO.Compression.CompressionMode.Decompress))
				{
				Dezip.CopyTo(DezippedMemory);
				}
				Result = DezippedMemory.ToArray();
			}

			return System.Text.Encoding.UTF8.GetString(Result);
		}))();

	
	}
	public class TextInput_balloon_css
	{
		public static readonly string Url ="data:image/gif;base64,LmJhbGxvb24gewogICAgZGlzcGxheTogaW5saW5lLWJsb2NrOwogICAgd2lkdGg6IDIxNXB4OwogICAgcGFkZGluZzogMTBweCAwIDEwcHggMTVweDsKICAgIGZvbnQtZmFtaWx5OiAiT3BlbiBTYW5zIiwgc2FuczsKICAgIGZvbnQtd2VpZ2h0OiA0MDA7CiAgICBjb2xvcjogIzM3N0Q2QTsKICAgIGJhY2tncm91bmQ6ICNlZmVmZWY7CiAgICBib3JkZXI6IDA7CiAgICBib3JkZXItcmFkaXVzOiAzcHg7CiAgICBvdXRsaW5lOiAwOwogICAgdGV4dC1pbmRlbnQ6IDYwcHg7CiAgICB0cmFuc2l0aW9uOiBhbGwgLjNzIGVhc2UtaW4tb3V0Owp9CgogICAgLmJhbGxvb246Oi13ZWJraXQtaW5wdXQtcGxhY2Vob2xkZXIgewogICAgICAgIGNvbG9yOiAjZWZlZmVmOwogICAgICAgIHRleHQtaW5kZW50OiAwOwogICAgICAgIGZvbnQtd2VpZ2h0OiAzMDA7CiAgICB9CgogICAgLmJhbGxvb24gKyBsYWJlbCB7CiAgICAgICAgZGlzcGxheTogaW5saW5lLWJsb2NrOwogICAgICAgIHBvc2l0aW9uOiBhYnNvbHV0ZTsKICAgICAgICB0b3A6IDhweDsKICAgICAgICBsZWZ0OiAwOwogICAgICAgIGJvdHRvbTogOHB4OwogICAgICAgIHBhZGRpbmc6IDVweCAxNXB4OwogICAgICAgIGNvbG9yOiAjMDMyNDI5OwogICAgICAgIGZvbnQtc2l6ZTogMTFweDsKICAgICAgICBmb250LXdlaWdodDogNzAwOwogICAgICAgIHRleHQtdHJhbnNmb3JtOiB1cHBlcmNhc2U7CiAgICAgICAgdGV4dC1zaGFkb3c6IDAgMXB4IDAgcmdiYSgxOSwgNzQsIDcwLCAwKTsKICAgICAgICB0cmFuc2l0aW9uOiBhbGwgLjNzIGVhc2UtaW4tb3V0OwogICAgICAgIGJvcmRlci1yYWRpdXM6IDNweDsKICAgICAgICBiYWNrZ3JvdW5kOiByZ2JhKDEyMiwgMTg0LCAxNDcsIDApOwogICAgfQoKICAgICAgICAuYmFsbG9vbiArIGxhYmVsOmFmdGVyIHsKICAgICAgICAgICAgcG9zaXRpb246IGFic29sdXRlOwogICAgICAgICAgICBjb250ZW50OiAiIjsKICAgICAgICAgICAgd2lkdGg6IDA7CiAgICAgICAgICAgIGhlaWdodDogMDsKICAgICAgICAgICAgdG9wOiAxMDAlOwogICAgICAgICAgICBsZWZ0OiA1MCU7CiAgICAgICAgICAgIG1hcmdpbi1sZWZ0OiAtM3B4OwogICAgICAgICAgICBib3JkZXItbGVmdDogM3B4IHNvbGlkIHRyYW5zcGFyZW50OwogICAgICAgICAgICBib3JkZXItcmlnaHQ6IDNweCBzb2xpZCB0cmFuc3BhcmVudDsKICAgICAgICAgICAgYm9yZGVyLXRvcDogM3B4IHNvbGlkIHJnYmEoMTIyLCAxODQsIDE0NywgMCk7CiAgICAgICAgICAgIHRyYW5zaXRpb246IGFsbCAuM3MgZWFzZS1pbi1vdXQ7CiAgICAgICAgfQoKICAgIC5iYWxsb29uOmZvY3VzLAogICAgLmJhbGxvb246YWN0aXZlIHsKICAgICAgICBjb2xvcjogIzM3N0Q2QTsKICAgICAgICB0ZXh0LWluZGVudDogMDsKICAgICAgICBiYWNrZ3JvdW5kOiAjZmZmOwogICAgfQoKICAgICAgICAuYmFsbG9vbjpmb2N1czo6LXdlYmtpdC1pbnB1dC1wbGFjZWhvbGRlciwKICAgICAgICAuYmFsbG9vbjphY3RpdmU6Oi13ZWJraXQtaW5wdXQtcGxhY2Vob2xkZXIgewogICAgICAgICAgICBjb2xvcjogI2FhYTsKICAgICAgICB9CgogICAgICAgIC5iYWxsb29uOmZvY3VzICsgbGFiZWwsCiAgICAgICAgLmJhbGxvb246YWN0aXZlICsgbGFiZWwgewogICAgICAgICAgICBjb2xvcjogI2ZmZjsKICAgICAgICAgICAgdGV4dC1zaGFkb3c6IDAgMXB4IDAgcmdiYSgxOSwgNzQsIDcwLCAwLjQpOwogICAgICAgICAgICBiYWNrZ3JvdW5kOiAjN2FiODkzOwogICAgICAgICAgICB0cmFuc2Zvcm06IHRyYW5zbGF0ZVkoLTQwcHgpOwogICAgICAgIH0KCiAgICAgICAgICAgIC5iYWxsb29uOmZvY3VzICsgbGFiZWw6YWZ0ZXIsCiAgICAgICAgICAgIC5iYWxsb29uOmFjdGl2ZSArIGxhYmVsOmFmdGVyIHsKICAgICAgICAgICAgICAgIGJvcmRlci10b3A6IDRweCBzb2xpZCAjN2FiODkzOwogICAgICAgICAgICB9Cg==";
	
	}
	public class TextInput_Container_css
	{
		public static readonly string Url ="data:image/gif;base64,LlRleHRJbnB1dF9Db250YWluZXIgew0KICAgIHBvc2l0aW9uOiByZWxhdGl2ZTsNCiAgICBtYXJnaW46IDMwcHggMTBweDsNCiAgICBkaXNwbGF5OiBpbmxpbmUtYmxvY2s7DQp9DQo=";
	
	}
	public class w3_css
	{
		public static readonly string Url ="data:image/gif;base64,77u/LyogVzMuQ1NTIDQuMTMgSnVuZSAyMDE5IGJ5IEphbiBFZ2lsIGFuZCBCb3JnZSBSZWZzbmVzICovDQpodG1se2JveC1zaXppbmc6Ym9yZGVyLWJveH0qLCo6YmVmb3JlLCo6YWZ0ZXJ7Ym94LXNpemluZzppbmhlcml0fQ0KLyogRXh0cmFjdCBmcm9tIG5vcm1hbGl6ZS5jc3MgYnkgTmljb2xhcyBHYWxsYWdoZXIgYW5kIEpvbmF0aGFuIE5lYWwgZ2l0LmlvL25vcm1hbGl6ZSAqLw0KaHRtbHstbXMtdGV4dC1zaXplLWFkanVzdDoxMDAlOy13ZWJraXQtdGV4dC1zaXplLWFkanVzdDoxMDAlfWJvZHl7bWFyZ2luOjB9DQphcnRpY2xlLGFzaWRlLGRldGFpbHMsZmlnY2FwdGlvbixmaWd1cmUsZm9vdGVyLGhlYWRlcixtYWluLG1lbnUsbmF2LHNlY3Rpb257ZGlzcGxheTpibG9ja31zdW1tYXJ5e2Rpc3BsYXk6bGlzdC1pdGVtfQ0KYXVkaW8sY2FudmFzLHByb2dyZXNzLHZpZGVve2Rpc3BsYXk6aW5saW5lLWJsb2NrfXByb2dyZXNze3ZlcnRpY2FsLWFsaWduOmJhc2VsaW5lfQ0KYXVkaW86bm90KFtjb250cm9sc10pe2Rpc3BsYXk6bm9uZTtoZWlnaHQ6MH1baGlkZGVuXSx0ZW1wbGF0ZXtkaXNwbGF5Om5vbmV9DQphe2JhY2tncm91bmQtY29sb3I6dHJhbnNwYXJlbnR9YTphY3RpdmUsYTpob3ZlcntvdXRsaW5lLXdpZHRoOjB9DQphYmJyW3RpdGxlXXtib3JkZXItYm90dG9tOm5vbmU7dGV4dC1kZWNvcmF0aW9uOnVuZGVybGluZTt0ZXh0LWRlY29yYXRpb246dW5kZXJsaW5lIGRvdHRlZH0NCmIsc3Ryb25ne2ZvbnQtd2VpZ2h0OmJvbGRlcn1kZm57Zm9udC1zdHlsZTppdGFsaWN9bWFya3tiYWNrZ3JvdW5kOiNmZjA7Y29sb3I6IzAwMH0NCnNtYWxse2ZvbnQtc2l6ZTo4MCV9c3ViLHN1cHtmb250LXNpemU6NzUlO2xpbmUtaGVpZ2h0OjA7cG9zaXRpb246cmVsYXRpdmU7dmVydGljYWwtYWxpZ246YmFzZWxpbmV9DQpzdWJ7Ym90dG9tOi0wLjI1ZW19c3Vwe3RvcDotMC41ZW19ZmlndXJle21hcmdpbjoxZW0gNDBweH1pbWd7Ym9yZGVyLXN0eWxlOm5vbmV9DQpjb2RlLGtiZCxwcmUsc2FtcHtmb250LWZhbWlseTptb25vc3BhY2UsbW9ub3NwYWNlO2ZvbnQtc2l6ZToxZW19aHJ7Ym94LXNpemluZzpjb250ZW50LWJveDtoZWlnaHQ6MDtvdmVyZmxvdzp2aXNpYmxlfQ0KYnV0dG9uLGlucHV0LHNlbGVjdCx0ZXh0YXJlYSxvcHRncm91cHtmb250OmluaGVyaXQ7bWFyZ2luOjB9b3B0Z3JvdXB7Zm9udC13ZWlnaHQ6Ym9sZH0NCmJ1dHRvbixpbnB1dHtvdmVyZmxvdzp2aXNpYmxlfWJ1dHRvbixzZWxlY3R7dGV4dC10cmFuc2Zvcm06bm9uZX0NCmJ1dHRvbixbdHlwZT1idXR0b25dLFt0eXBlPXJlc2V0XSxbdHlwZT1zdWJtaXRdey13ZWJraXQtYXBwZWFyYW5jZTpidXR0b259DQpidXR0b246Oi1tb3otZm9jdXMtaW5uZXIsW3R5cGU9YnV0dG9uXTo6LW1vei1mb2N1cy1pbm5lcixbdHlwZT1yZXNldF06Oi1tb3otZm9jdXMtaW5uZXIsW3R5cGU9c3VibWl0XTo6LW1vei1mb2N1cy1pbm5lcntib3JkZXItc3R5bGU6bm9uZTtwYWRkaW5nOjB9DQpidXR0b246LW1vei1mb2N1c3JpbmcsW3R5cGU9YnV0dG9uXTotbW96LWZvY3VzcmluZyxbdHlwZT1yZXNldF06LW1vei1mb2N1c3JpbmcsW3R5cGU9c3VibWl0XTotbW96LWZvY3VzcmluZ3tvdXRsaW5lOjFweCBkb3R0ZWQgQnV0dG9uVGV4dH0NCmZpZWxkc2V0e2JvcmRlcjoxcHggc29saWQgI2MwYzBjMDttYXJnaW46MCAycHg7cGFkZGluZzouMzVlbSAuNjI1ZW0gLjc1ZW19DQpsZWdlbmR7Y29sb3I6aW5oZXJpdDtkaXNwbGF5OnRhYmxlO21heC13aWR0aDoxMDAlO3BhZGRpbmc6MDt3aGl0ZS1zcGFjZTpub3JtYWx9dGV4dGFyZWF7b3ZlcmZsb3c6YXV0b30NClt0eXBlPWNoZWNrYm94XSxbdHlwZT1yYWRpb117cGFkZGluZzowfQ0KW3R5cGU9bnVtYmVyXTo6LXdlYmtpdC1pbm5lci1zcGluLWJ1dHRvbixbdHlwZT1udW1iZXJdOjotd2Via2l0LW91dGVyLXNwaW4tYnV0dG9ue2hlaWdodDphdXRvfQ0KW3R5cGU9c2VhcmNoXXstd2Via2l0LWFwcGVhcmFuY2U6dGV4dGZpZWxkO291dGxpbmUtb2Zmc2V0Oi0ycHh9DQpbdHlwZT1zZWFyY2hdOjotd2Via2l0LXNlYXJjaC1kZWNvcmF0aW9uey13ZWJraXQtYXBwZWFyYW5jZTpub25lfQ0KOjotd2Via2l0LWZpbGUtdXBsb2FkLWJ1dHRvbnstd2Via2l0LWFwcGVhcmFuY2U6YnV0dG9uO2ZvbnQ6aW5oZXJpdH0NCi8qIEVuZCBleHRyYWN0ICovDQpodG1sLGJvZHl7Zm9udC1mYW1pbHk6VmVyZGFuYSxzYW5zLXNlcmlmO2ZvbnQtc2l6ZToxNXB4O2xpbmUtaGVpZ2h0OjEuNX1odG1se292ZXJmbG93LXg6aGlkZGVufQ0KaDF7Zm9udC1zaXplOjM2cHh9aDJ7Zm9udC1zaXplOjMwcHh9aDN7Zm9udC1zaXplOjI0cHh9aDR7Zm9udC1zaXplOjIwcHh9aDV7Zm9udC1zaXplOjE4cHh9aDZ7Zm9udC1zaXplOjE2cHh9LnczLXNlcmlme2ZvbnQtZmFtaWx5OnNlcmlmfQ0KaDEsaDIsaDMsaDQsaDUsaDZ7Zm9udC1mYW1pbHk6IlNlZ29lIFVJIixBcmlhbCxzYW5zLXNlcmlmO2ZvbnQtd2VpZ2h0OjQwMDttYXJnaW46MTBweCAwfS53My13aWRle2xldHRlci1zcGFjaW5nOjRweH0NCmhye2JvcmRlcjowO2JvcmRlci10b3A6MXB4IHNvbGlkICNlZWU7bWFyZ2luOjIwcHggMH0NCi53My1pbWFnZXttYXgtd2lkdGg6MTAwJTtoZWlnaHQ6YXV0b31pbWd7dmVydGljYWwtYWxpZ246bWlkZGxlfWF7Y29sb3I6aW5oZXJpdH0NCi53My10YWJsZSwudzMtdGFibGUtYWxse2JvcmRlci1jb2xsYXBzZTpjb2xsYXBzZTtib3JkZXItc3BhY2luZzowO3dpZHRoOjEwMCU7ZGlzcGxheTp0YWJsZX0udzMtdGFibGUtYWxse2JvcmRlcjoxcHggc29saWQgI2NjY30NCi53My1ib3JkZXJlZCB0ciwudzMtdGFibGUtYWxsIHRye2JvcmRlci1ib3R0b206MXB4IHNvbGlkICNkZGR9LnczLXN0cmlwZWQgdGJvZHkgdHI6bnRoLWNoaWxkKGV2ZW4pe2JhY2tncm91bmQtY29sb3I6I2YxZjFmMX0NCi53My10YWJsZS1hbGwgdHI6bnRoLWNoaWxkKG9kZCl7YmFja2dyb3VuZC1jb2xvcjojZmZmfS53My10YWJsZS1hbGwgdHI6bnRoLWNoaWxkKGV2ZW4pe2JhY2tncm91bmQtY29sb3I6I2YxZjFmMX0NCi53My1ob3ZlcmFibGUgdGJvZHkgdHI6aG92ZXIsLnczLXVsLnczLWhvdmVyYWJsZSBsaTpob3ZlcntiYWNrZ3JvdW5kLWNvbG9yOiNjY2N9LnczLWNlbnRlcmVkIHRyIHRoLC53My1jZW50ZXJlZCB0ciB0ZHt0ZXh0LWFsaWduOmNlbnRlcn0NCi53My10YWJsZSB0ZCwudzMtdGFibGUgdGgsLnczLXRhYmxlLWFsbCB0ZCwudzMtdGFibGUtYWxsIHRoe3BhZGRpbmc6OHB4IDhweDtkaXNwbGF5OnRhYmxlLWNlbGw7dGV4dC1hbGlnbjpsZWZ0O3ZlcnRpY2FsLWFsaWduOnRvcH0NCi53My10YWJsZSB0aDpmaXJzdC1jaGlsZCwudzMtdGFibGUgdGQ6Zmlyc3QtY2hpbGQsLnczLXRhYmxlLWFsbCB0aDpmaXJzdC1jaGlsZCwudzMtdGFibGUtYWxsIHRkOmZpcnN0LWNoaWxke3BhZGRpbmctbGVmdDoxNnB4fQ0KLnczLWJ0biwudzMtYnV0dG9ue2JvcmRlcjpub25lO2Rpc3BsYXk6aW5saW5lLWJsb2NrO3BhZGRpbmc6OHB4IDE2cHg7dmVydGljYWwtYWxpZ246bWlkZGxlO292ZXJmbG93OmhpZGRlbjt0ZXh0LWRlY29yYXRpb246bm9uZTtjb2xvcjppbmhlcml0O2JhY2tncm91bmQtY29sb3I6aW5oZXJpdDt0ZXh0LWFsaWduOmNlbnRlcjtjdXJzb3I6cG9pbnRlcjt3aGl0ZS1zcGFjZTpub3dyYXB9DQoudzMtYnRuOmhvdmVye2JveC1zaGFkb3c6MCA4cHggMTZweCAwIHJnYmEoMCwwLDAsMC4yKSwwIDZweCAyMHB4IDAgcmdiYSgwLDAsMCwwLjE5KX0NCi53My1idG4sLnczLWJ1dHRvbnstd2Via2l0LXRvdWNoLWNhbGxvdXQ6bm9uZTstd2Via2l0LXVzZXItc2VsZWN0Om5vbmU7LWtodG1sLXVzZXItc2VsZWN0Om5vbmU7LW1vei11c2VyLXNlbGVjdDpub25lOy1tcy11c2VyLXNlbGVjdDpub25lO3VzZXItc2VsZWN0Om5vbmV9ICAgDQoudzMtZGlzYWJsZWQsLnczLWJ0bjpkaXNhYmxlZCwudzMtYnV0dG9uOmRpc2FibGVke2N1cnNvcjpub3QtYWxsb3dlZDtvcGFjaXR5OjAuM30udzMtZGlzYWJsZWQgKiw6ZGlzYWJsZWQgKntwb2ludGVyLWV2ZW50czpub25lfQ0KLnczLWJ0bi53My1kaXNhYmxlZDpob3ZlciwudzMtYnRuOmRpc2FibGVkOmhvdmVye2JveC1zaGFkb3c6bm9uZX0NCi53My1iYWRnZSwudzMtdGFne2JhY2tncm91bmQtY29sb3I6IzAwMDtjb2xvcjojZmZmO2Rpc3BsYXk6aW5saW5lLWJsb2NrO3BhZGRpbmctbGVmdDo4cHg7cGFkZGluZy1yaWdodDo4cHg7dGV4dC1hbGlnbjpjZW50ZXJ9LnczLWJhZGdle2JvcmRlci1yYWRpdXM6NTAlfQ0KLnczLXVse2xpc3Qtc3R5bGUtdHlwZTpub25lO3BhZGRpbmc6MDttYXJnaW46MH0udzMtdWwgbGl7cGFkZGluZzo4cHggMTZweDtib3JkZXItYm90dG9tOjFweCBzb2xpZCAjZGRkfS53My11bCBsaTpsYXN0LWNoaWxke2JvcmRlci1ib3R0b206bm9uZX0NCi53My10b29sdGlwLC53My1kaXNwbGF5LWNvbnRhaW5lcntwb3NpdGlvbjpyZWxhdGl2ZX0udzMtdG9vbHRpcCAudzMtdGV4dHtkaXNwbGF5Om5vbmV9LnczLXRvb2x0aXA6aG92ZXIgLnczLXRleHR7ZGlzcGxheTppbmxpbmUtYmxvY2t9DQoudzMtcmlwcGxlOmFjdGl2ZXtvcGFjaXR5OjAuNX0udzMtcmlwcGxle3RyYW5zaXRpb246b3BhY2l0eSAwc30NCi53My1pbnB1dHtwYWRkaW5nOjhweDtkaXNwbGF5OmJsb2NrO2JvcmRlcjpub25lO2JvcmRlci1ib3R0b206MXB4IHNvbGlkICNjY2M7d2lkdGg6MTAwJX0NCi53My1zZWxlY3R7cGFkZGluZzo5cHggMDt3aWR0aDoxMDAlO2JvcmRlcjpub25lO2JvcmRlci1ib3R0b206MXB4IHNvbGlkICNjY2N9DQoudzMtZHJvcGRvd24tY2xpY2ssLnczLWRyb3Bkb3duLWhvdmVye3Bvc2l0aW9uOnJlbGF0aXZlO2Rpc3BsYXk6aW5saW5lLWJsb2NrO2N1cnNvcjpwb2ludGVyfQ0KLnczLWRyb3Bkb3duLWhvdmVyOmhvdmVyIC53My1kcm9wZG93bi1jb250ZW50e2Rpc3BsYXk6YmxvY2t9DQoudzMtZHJvcGRvd24taG92ZXI6Zmlyc3QtY2hpbGQsLnczLWRyb3Bkb3duLWNsaWNrOmhvdmVye2JhY2tncm91bmQtY29sb3I6I2NjYztjb2xvcjojMDAwfQ0KLnczLWRyb3Bkb3duLWhvdmVyOmhvdmVyID4gLnczLWJ1dHRvbjpmaXJzdC1jaGlsZCwudzMtZHJvcGRvd24tY2xpY2s6aG92ZXIgPiAudzMtYnV0dG9uOmZpcnN0LWNoaWxke2JhY2tncm91bmQtY29sb3I6I2NjYztjb2xvcjojMDAwfQ0KLnczLWRyb3Bkb3duLWNvbnRlbnR7Y3Vyc29yOmF1dG87Y29sb3I6IzAwMDtiYWNrZ3JvdW5kLWNvbG9yOiNmZmY7ZGlzcGxheTpub25lO3Bvc2l0aW9uOmFic29sdXRlO21pbi13aWR0aDoxNjBweDttYXJnaW46MDtwYWRkaW5nOjA7ei1pbmRleDoxfQ0KLnczLWNoZWNrLC53My1yYWRpb3t3aWR0aDoyNHB4O2hlaWdodDoyNHB4O3Bvc2l0aW9uOnJlbGF0aXZlO3RvcDo2cHh9DQoudzMtc2lkZWJhcntoZWlnaHQ6MTAwJTt3aWR0aDoyMDBweDtiYWNrZ3JvdW5kLWNvbG9yOiNmZmY7cG9zaXRpb246Zml4ZWQhaW1wb3J0YW50O3otaW5kZXg6MTtvdmVyZmxvdzphdXRvfQ0KLnczLWJhci1ibG9jayAudzMtZHJvcGRvd24taG92ZXIsLnczLWJhci1ibG9jayAudzMtZHJvcGRvd24tY2xpY2t7d2lkdGg6MTAwJX0NCi53My1iYXItYmxvY2sgLnczLWRyb3Bkb3duLWhvdmVyIC53My1kcm9wZG93bi1jb250ZW50LC53My1iYXItYmxvY2sgLnczLWRyb3Bkb3duLWNsaWNrIC53My1kcm9wZG93bi1jb250ZW50e21pbi13aWR0aDoxMDAlfQ0KLnczLWJhci1ibG9jayAudzMtZHJvcGRvd24taG92ZXIgLnczLWJ1dHRvbiwudzMtYmFyLWJsb2NrIC53My1kcm9wZG93bi1jbGljayAudzMtYnV0dG9ue3dpZHRoOjEwMCU7dGV4dC1hbGlnbjpsZWZ0O3BhZGRpbmc6OHB4IDE2cHh9DQoudzMtbWFpbiwjbWFpbnt0cmFuc2l0aW9uOm1hcmdpbi1sZWZ0IC40c30NCi53My1tb2RhbHt6LWluZGV4OjM7ZGlzcGxheTpub25lO3BhZGRpbmctdG9wOjEwMHB4O3Bvc2l0aW9uOmZpeGVkO2xlZnQ6MDt0b3A6MDt3aWR0aDoxMDAlO2hlaWdodDoxMDAlO292ZXJmbG93OmF1dG87YmFja2dyb3VuZC1jb2xvcjpyZ2IoMCwwLDApO2JhY2tncm91bmQtY29sb3I6cmdiYSgwLDAsMCwwLjQpfQ0KLnczLW1vZGFsLWNvbnRlbnR7bWFyZ2luOmF1dG87YmFja2dyb3VuZC1jb2xvcjojZmZmO3Bvc2l0aW9uOnJlbGF0aXZlO3BhZGRpbmc6MDtvdXRsaW5lOjA7d2lkdGg6NjAwcHh9DQoudzMtYmFye3dpZHRoOjEwMCU7b3ZlcmZsb3c6aGlkZGVufS53My1jZW50ZXIgLnczLWJhcntkaXNwbGF5OmlubGluZS1ibG9jazt3aWR0aDphdXRvfQ0KLnczLWJhciAudzMtYmFyLWl0ZW17cGFkZGluZzo4cHggMTZweDtmbG9hdDpsZWZ0O3dpZHRoOmF1dG87Ym9yZGVyOm5vbmU7ZGlzcGxheTpibG9jaztvdXRsaW5lOjB9DQoudzMtYmFyIC53My1kcm9wZG93bi1ob3ZlciwudzMtYmFyIC53My1kcm9wZG93bi1jbGlja3twb3NpdGlvbjpzdGF0aWM7ZmxvYXQ6bGVmdH0NCi53My1iYXIgLnczLWJ1dHRvbnt3aGl0ZS1zcGFjZTpub3JtYWx9DQoudzMtYmFyLWJsb2NrIC53My1iYXItaXRlbXt3aWR0aDoxMDAlO2Rpc3BsYXk6YmxvY2s7cGFkZGluZzo4cHggMTZweDt0ZXh0LWFsaWduOmxlZnQ7Ym9yZGVyOm5vbmU7d2hpdGUtc3BhY2U6bm9ybWFsO2Zsb2F0Om5vbmU7b3V0bGluZTowfQ0KLnczLWJhci1ibG9jay53My1jZW50ZXIgLnczLWJhci1pdGVte3RleHQtYWxpZ246Y2VudGVyfS53My1ibG9ja3tkaXNwbGF5OmJsb2NrO3dpZHRoOjEwMCV9DQoudzMtcmVzcG9uc2l2ZXtkaXNwbGF5OmJsb2NrO292ZXJmbG93LXg6YXV0b30NCi53My1jb250YWluZXI6YWZ0ZXIsLnczLWNvbnRhaW5lcjpiZWZvcmUsLnczLXBhbmVsOmFmdGVyLC53My1wYW5lbDpiZWZvcmUsLnczLXJvdzphZnRlciwudzMtcm93OmJlZm9yZSwudzMtcm93LXBhZGRpbmc6YWZ0ZXIsLnczLXJvdy1wYWRkaW5nOmJlZm9yZSwNCi53My1jZWxsLXJvdzpiZWZvcmUsLnczLWNlbGwtcm93OmFmdGVyLC53My1jbGVhcjphZnRlciwudzMtY2xlYXI6YmVmb3JlLC53My1iYXI6YmVmb3JlLC53My1iYXI6YWZ0ZXJ7Y29udGVudDoiIjtkaXNwbGF5OnRhYmxlO2NsZWFyOmJvdGh9DQoudzMtY29sLC53My1oYWxmLC53My10aGlyZCwudzMtdHdvdGhpcmQsLnczLXRocmVlcXVhcnRlciwudzMtcXVhcnRlcntmbG9hdDpsZWZ0O3dpZHRoOjEwMCV9DQoudzMtY29sLnMxe3dpZHRoOjguMzMzMzMlfS53My1jb2wuczJ7d2lkdGg6MTYuNjY2NjYlfS53My1jb2wuczN7d2lkdGg6MjQuOTk5OTklfS53My1jb2wuczR7d2lkdGg6MzMuMzMzMzMlfQ0KLnczLWNvbC5zNXt3aWR0aDo0MS42NjY2NiV9LnczLWNvbC5zNnt3aWR0aDo0OS45OTk5OSV9LnczLWNvbC5zN3t3aWR0aDo1OC4zMzMzMyV9LnczLWNvbC5zOHt3aWR0aDo2Ni42NjY2NiV9DQoudzMtY29sLnM5e3dpZHRoOjc0Ljk5OTk5JX0udzMtY29sLnMxMHt3aWR0aDo4My4zMzMzMyV9LnczLWNvbC5zMTF7d2lkdGg6OTEuNjY2NjYlfS53My1jb2wuczEye3dpZHRoOjk5Ljk5OTk5JX0NCkBtZWRpYSAobWluLXdpZHRoOjYwMXB4KXsudzMtY29sLm0xe3dpZHRoOjguMzMzMzMlfS53My1jb2wubTJ7d2lkdGg6MTYuNjY2NjYlfS53My1jb2wubTMsLnczLXF1YXJ0ZXJ7d2lkdGg6MjQuOTk5OTklfS53My1jb2wubTQsLnczLXRoaXJke3dpZHRoOjMzLjMzMzMzJX0NCi53My1jb2wubTV7d2lkdGg6NDEuNjY2NjYlfS53My1jb2wubTYsLnczLWhhbGZ7d2lkdGg6NDkuOTk5OTklfS53My1jb2wubTd7d2lkdGg6NTguMzMzMzMlfS53My1jb2wubTgsLnczLXR3b3RoaXJke3dpZHRoOjY2LjY2NjY2JX0NCi53My1jb2wubTksLnczLXRocmVlcXVhcnRlcnt3aWR0aDo3NC45OTk5OSV9LnczLWNvbC5tMTB7d2lkdGg6ODMuMzMzMzMlfS53My1jb2wubTExe3dpZHRoOjkxLjY2NjY2JX0udzMtY29sLm0xMnt3aWR0aDo5OS45OTk5OSV9fQ0KQG1lZGlhIChtaW4td2lkdGg6OTkzcHgpey53My1jb2wubDF7d2lkdGg6OC4zMzMzMyV9LnczLWNvbC5sMnt3aWR0aDoxNi42NjY2NiV9LnczLWNvbC5sM3t3aWR0aDoyNC45OTk5OSV9LnczLWNvbC5sNHt3aWR0aDozMy4zMzMzMyV9DQoudzMtY29sLmw1e3dpZHRoOjQxLjY2NjY2JX0udzMtY29sLmw2e3dpZHRoOjQ5Ljk5OTk5JX0udzMtY29sLmw3e3dpZHRoOjU4LjMzMzMzJX0udzMtY29sLmw4e3dpZHRoOjY2LjY2NjY2JX0NCi53My1jb2wubDl7d2lkdGg6NzQuOTk5OTklfS53My1jb2wubDEwe3dpZHRoOjgzLjMzMzMzJX0udzMtY29sLmwxMXt3aWR0aDo5MS42NjY2NiV9LnczLWNvbC5sMTJ7d2lkdGg6OTkuOTk5OTklfX0NCi53My1yZXN0e292ZXJmbG93OmhpZGRlbn0udzMtc3RyZXRjaHttYXJnaW4tbGVmdDotMTZweDttYXJnaW4tcmlnaHQ6LTE2cHh9DQoudzMtY29udGVudCwudzMtYXV0b3ttYXJnaW4tbGVmdDphdXRvO21hcmdpbi1yaWdodDphdXRvfS53My1jb250ZW50e21heC13aWR0aDo5ODBweH0udzMtYXV0b3ttYXgtd2lkdGg6MTE0MHB4fQ0KLnczLWNlbGwtcm93e2Rpc3BsYXk6dGFibGU7d2lkdGg6MTAwJX0udzMtY2VsbHtkaXNwbGF5OnRhYmxlLWNlbGx9DQoudzMtY2VsbC10b3B7dmVydGljYWwtYWxpZ246dG9wfS53My1jZWxsLW1pZGRsZXt2ZXJ0aWNhbC1hbGlnbjptaWRkbGV9LnczLWNlbGwtYm90dG9te3ZlcnRpY2FsLWFsaWduOmJvdHRvbX0NCi53My1oaWRle2Rpc3BsYXk6bm9uZSFpbXBvcnRhbnR9LnczLXNob3ctYmxvY2ssLnczLXNob3d7ZGlzcGxheTpibG9jayFpbXBvcnRhbnR9LnczLXNob3ctaW5saW5lLWJsb2Nre2Rpc3BsYXk6aW5saW5lLWJsb2NrIWltcG9ydGFudH0NCkBtZWRpYSAobWF4LXdpZHRoOjEyMDVweCl7LnczLWF1dG97bWF4LXdpZHRoOjk1JX19DQpAbWVkaWEgKG1heC13aWR0aDo2MDBweCl7LnczLW1vZGFsLWNvbnRlbnR7bWFyZ2luOjAgMTBweDt3aWR0aDphdXRvIWltcG9ydGFudH0udzMtbW9kYWx7cGFkZGluZy10b3A6MzBweH0NCi53My1kcm9wZG93bi1ob3Zlci53My1tb2JpbGUgLnczLWRyb3Bkb3duLWNvbnRlbnQsLnczLWRyb3Bkb3duLWNsaWNrLnczLW1vYmlsZSAudzMtZHJvcGRvd24tY29udGVudHtwb3NpdGlvbjpyZWxhdGl2ZX0JDQoudzMtaGlkZS1zbWFsbHtkaXNwbGF5Om5vbmUhaW1wb3J0YW50fS53My1tb2JpbGV7ZGlzcGxheTpibG9jazt3aWR0aDoxMDAlIWltcG9ydGFudH0udzMtYmFyLWl0ZW0udzMtbW9iaWxlLC53My1kcm9wZG93bi1ob3Zlci53My1tb2JpbGUsLnczLWRyb3Bkb3duLWNsaWNrLnczLW1vYmlsZXt0ZXh0LWFsaWduOmNlbnRlcn0NCi53My1kcm9wZG93bi1ob3Zlci53My1tb2JpbGUsLnczLWRyb3Bkb3duLWhvdmVyLnczLW1vYmlsZSAudzMtYnRuLC53My1kcm9wZG93bi1ob3Zlci53My1tb2JpbGUgLnczLWJ1dHRvbiwudzMtZHJvcGRvd24tY2xpY2sudzMtbW9iaWxlLC53My1kcm9wZG93bi1jbGljay53My1tb2JpbGUgLnczLWJ0biwudzMtZHJvcGRvd24tY2xpY2sudzMtbW9iaWxlIC53My1idXR0b257d2lkdGg6MTAwJX19DQpAbWVkaWEgKG1heC13aWR0aDo3NjhweCl7LnczLW1vZGFsLWNvbnRlbnR7d2lkdGg6NTAwcHh9LnczLW1vZGFse3BhZGRpbmctdG9wOjUwcHh9fQ0KQG1lZGlhIChtaW4td2lkdGg6OTkzcHgpey53My1tb2RhbC1jb250ZW50e3dpZHRoOjkwMHB4fS53My1oaWRlLWxhcmdle2Rpc3BsYXk6bm9uZSFpbXBvcnRhbnR9LnczLXNpZGViYXIudzMtY29sbGFwc2V7ZGlzcGxheTpibG9jayFpbXBvcnRhbnR9fQ0KQG1lZGlhIChtYXgtd2lkdGg6OTkycHgpIGFuZCAobWluLXdpZHRoOjYwMXB4KXsudzMtaGlkZS1tZWRpdW17ZGlzcGxheTpub25lIWltcG9ydGFudH19DQpAbWVkaWEgKG1heC13aWR0aDo5OTJweCl7LnczLXNpZGViYXIudzMtY29sbGFwc2V7ZGlzcGxheTpub25lfS53My1tYWlue21hcmdpbi1sZWZ0OjAhaW1wb3J0YW50O21hcmdpbi1yaWdodDowIWltcG9ydGFudH0udzMtYXV0b3ttYXgtd2lkdGg6MTAwJX19DQoudzMtdG9wLC53My1ib3R0b217cG9zaXRpb246Zml4ZWQ7d2lkdGg6MTAwJTt6LWluZGV4OjF9LnczLXRvcHt0b3A6MH0udzMtYm90dG9te2JvdHRvbTowfQ0KLnczLW92ZXJsYXl7cG9zaXRpb246Zml4ZWQ7ZGlzcGxheTpub25lO3dpZHRoOjEwMCU7aGVpZ2h0OjEwMCU7dG9wOjA7bGVmdDowO3JpZ2h0OjA7Ym90dG9tOjA7YmFja2dyb3VuZC1jb2xvcjpyZ2JhKDAsMCwwLDAuNSk7ei1pbmRleDoyfQ0KLnczLWRpc3BsYXktdG9wbGVmdHtwb3NpdGlvbjphYnNvbHV0ZTtsZWZ0OjA7dG9wOjB9LnczLWRpc3BsYXktdG9wcmlnaHR7cG9zaXRpb246YWJzb2x1dGU7cmlnaHQ6MDt0b3A6MH0NCi53My1kaXNwbGF5LWJvdHRvbWxlZnR7cG9zaXRpb246YWJzb2x1dGU7bGVmdDowO2JvdHRvbTowfS53My1kaXNwbGF5LWJvdHRvbXJpZ2h0e3Bvc2l0aW9uOmFic29sdXRlO3JpZ2h0OjA7Ym90dG9tOjB9DQoudzMtZGlzcGxheS1taWRkbGV7cG9zaXRpb246YWJzb2x1dGU7dG9wOjUwJTtsZWZ0OjUwJTt0cmFuc2Zvcm06dHJhbnNsYXRlKC01MCUsLTUwJSk7LW1zLXRyYW5zZm9ybTp0cmFuc2xhdGUoLTUwJSwtNTAlKX0NCi53My1kaXNwbGF5LWxlZnR7cG9zaXRpb246YWJzb2x1dGU7dG9wOjUwJTtsZWZ0OjAlO3RyYW5zZm9ybTp0cmFuc2xhdGUoMCUsLTUwJSk7LW1zLXRyYW5zZm9ybTp0cmFuc2xhdGUoLTAlLC01MCUpfQ0KLnczLWRpc3BsYXktcmlnaHR7cG9zaXRpb246YWJzb2x1dGU7dG9wOjUwJTtyaWdodDowJTt0cmFuc2Zvcm06dHJhbnNsYXRlKDAlLC01MCUpOy1tcy10cmFuc2Zvcm06dHJhbnNsYXRlKDAlLC01MCUpfQ0KLnczLWRpc3BsYXktdG9wbWlkZGxle3Bvc2l0aW9uOmFic29sdXRlO2xlZnQ6NTAlO3RvcDowO3RyYW5zZm9ybTp0cmFuc2xhdGUoLTUwJSwwJSk7LW1zLXRyYW5zZm9ybTp0cmFuc2xhdGUoLTUwJSwwJSl9DQoudzMtZGlzcGxheS1ib3R0b21taWRkbGV7cG9zaXRpb246YWJzb2x1dGU7bGVmdDo1MCU7Ym90dG9tOjA7dHJhbnNmb3JtOnRyYW5zbGF0ZSgtNTAlLDAlKTstbXMtdHJhbnNmb3JtOnRyYW5zbGF0ZSgtNTAlLDAlKX0NCi53My1kaXNwbGF5LWNvbnRhaW5lcjpob3ZlciAudzMtZGlzcGxheS1ob3ZlcntkaXNwbGF5OmJsb2NrfS53My1kaXNwbGF5LWNvbnRhaW5lcjpob3ZlciBzcGFuLnczLWRpc3BsYXktaG92ZXJ7ZGlzcGxheTppbmxpbmUtYmxvY2t9LnczLWRpc3BsYXktaG92ZXJ7ZGlzcGxheTpub25lfQ0KLnczLWRpc3BsYXktcG9zaXRpb257cG9zaXRpb246YWJzb2x1dGV9DQoudzMtY2lyY2xle2JvcmRlci1yYWRpdXM6NTAlfQ0KLnczLXJvdW5kLXNtYWxse2JvcmRlci1yYWRpdXM6MnB4fS53My1yb3VuZCwudzMtcm91bmQtbWVkaXVte2JvcmRlci1yYWRpdXM6NHB4fS53My1yb3VuZC1sYXJnZXtib3JkZXItcmFkaXVzOjhweH0udzMtcm91bmQteGxhcmdle2JvcmRlci1yYWRpdXM6MTZweH0udzMtcm91bmQteHhsYXJnZXtib3JkZXItcmFkaXVzOjMycHh9DQoudzMtcm93LXBhZGRpbmcsLnczLXJvdy1wYWRkaW5nPi53My1oYWxmLC53My1yb3ctcGFkZGluZz4udzMtdGhpcmQsLnczLXJvdy1wYWRkaW5nPi53My10d290aGlyZCwudzMtcm93LXBhZGRpbmc+LnczLXRocmVlcXVhcnRlciwudzMtcm93LXBhZGRpbmc+LnczLXF1YXJ0ZXIsLnczLXJvdy1wYWRkaW5nPi53My1jb2x7cGFkZGluZzowIDhweH0NCi53My1jb250YWluZXIsLnczLXBhbmVse3BhZGRpbmc6MC4wMWVtIDE2cHh9LnczLXBhbmVse21hcmdpbi10b3A6MTZweDttYXJnaW4tYm90dG9tOjE2cHh9DQoudzMtY29kZSwudzMtY29kZXNwYW57Zm9udC1mYW1pbHk6Q29uc29sYXMsImNvdXJpZXIgbmV3Ijtmb250LXNpemU6MTZweH0NCi53My1jb2Rle3dpZHRoOmF1dG87YmFja2dyb3VuZC1jb2xvcjojZmZmO3BhZGRpbmc6OHB4IDEycHg7Ym9yZGVyLWxlZnQ6NHB4IHNvbGlkICM0Q0FGNTA7d29yZC13cmFwOmJyZWFrLXdvcmR9DQoudzMtY29kZXNwYW57Y29sb3I6Y3JpbXNvbjtiYWNrZ3JvdW5kLWNvbG9yOiNmMWYxZjE7cGFkZGluZy1sZWZ0OjRweDtwYWRkaW5nLXJpZ2h0OjRweDtmb250LXNpemU6MTEwJX0NCi53My1jYXJkLC53My1jYXJkLTJ7Ym94LXNoYWRvdzowIDJweCA1cHggMCByZ2JhKDAsMCwwLDAuMTYpLDAgMnB4IDEwcHggMCByZ2JhKDAsMCwwLDAuMTIpfQ0KLnczLWNhcmQtNCwudzMtaG92ZXItc2hhZG93OmhvdmVye2JveC1zaGFkb3c6MCA0cHggMTBweCAwIHJnYmEoMCwwLDAsMC4yKSwwIDRweCAyMHB4IDAgcmdiYSgwLDAsMCwwLjE5KX0NCi53My1zcGlue2FuaW1hdGlvbjp3My1zcGluIDJzIGluZmluaXRlIGxpbmVhcn1Aa2V5ZnJhbWVzIHczLXNwaW57MCV7dHJhbnNmb3JtOnJvdGF0ZSgwZGVnKX0xMDAle3RyYW5zZm9ybTpyb3RhdGUoMzU5ZGVnKX19DQoudzMtYW5pbWF0ZS1mYWRpbmd7YW5pbWF0aW9uOmZhZGluZyAxMHMgaW5maW5pdGV9QGtleWZyYW1lcyBmYWRpbmd7MCV7b3BhY2l0eTowfTUwJXtvcGFjaXR5OjF9MTAwJXtvcGFjaXR5OjB9fQ0KLnczLWFuaW1hdGUtb3BhY2l0eXthbmltYXRpb246b3BhYyAwLjhzfUBrZXlmcmFtZXMgb3BhY3tmcm9te29wYWNpdHk6MH0gdG97b3BhY2l0eToxfX0NCi53My1hbmltYXRlLXRvcHtwb3NpdGlvbjpyZWxhdGl2ZTthbmltYXRpb246YW5pbWF0ZXRvcCAwLjRzfUBrZXlmcmFtZXMgYW5pbWF0ZXRvcHtmcm9te3RvcDotMzAwcHg7b3BhY2l0eTowfSB0b3t0b3A6MDtvcGFjaXR5OjF9fQ0KLnczLWFuaW1hdGUtbGVmdHtwb3NpdGlvbjpyZWxhdGl2ZTthbmltYXRpb246YW5pbWF0ZWxlZnQgMC40c31Aa2V5ZnJhbWVzIGFuaW1hdGVsZWZ0e2Zyb217bGVmdDotMzAwcHg7b3BhY2l0eTowfSB0b3tsZWZ0OjA7b3BhY2l0eToxfX0NCi53My1hbmltYXRlLXJpZ2h0e3Bvc2l0aW9uOnJlbGF0aXZlO2FuaW1hdGlvbjphbmltYXRlcmlnaHQgMC40c31Aa2V5ZnJhbWVzIGFuaW1hdGVyaWdodHtmcm9te3JpZ2h0Oi0zMDBweDtvcGFjaXR5OjB9IHRve3JpZ2h0OjA7b3BhY2l0eToxfX0NCi53My1hbmltYXRlLWJvdHRvbXtwb3NpdGlvbjpyZWxhdGl2ZTthbmltYXRpb246YW5pbWF0ZWJvdHRvbSAwLjRzfUBrZXlmcmFtZXMgYW5pbWF0ZWJvdHRvbXtmcm9te2JvdHRvbTotMzAwcHg7b3BhY2l0eTowfSB0b3tib3R0b206MDtvcGFjaXR5OjF9fQ0KLnczLWFuaW1hdGUtem9vbSB7YW5pbWF0aW9uOmFuaW1hdGV6b29tIDAuNnN9QGtleWZyYW1lcyBhbmltYXRlem9vbXtmcm9te3RyYW5zZm9ybTpzY2FsZSgwKX0gdG97dHJhbnNmb3JtOnNjYWxlKDEpfX0NCi53My1hbmltYXRlLWlucHV0e3RyYW5zaXRpb246d2lkdGggMC40cyBlYXNlLWluLW91dH0udzMtYW5pbWF0ZS1pbnB1dDpmb2N1c3t3aWR0aDoxMDAlIWltcG9ydGFudH0NCi53My1vcGFjaXR5LC53My1ob3Zlci1vcGFjaXR5OmhvdmVye29wYWNpdHk6MC42MH0udzMtb3BhY2l0eS1vZmYsLnczLWhvdmVyLW9wYWNpdHktb2ZmOmhvdmVye29wYWNpdHk6MX0NCi53My1vcGFjaXR5LW1heHtvcGFjaXR5OjAuMjV9LnczLW9wYWNpdHktbWlue29wYWNpdHk6MC43NX0NCi53My1ncmV5c2NhbGUtbWF4LC53My1ncmF5c2NhbGUtbWF4LC53My1ob3Zlci1ncmV5c2NhbGU6aG92ZXIsLnczLWhvdmVyLWdyYXlzY2FsZTpob3ZlcntmaWx0ZXI6Z3JheXNjYWxlKDEwMCUpfQ0KLnczLWdyZXlzY2FsZSwudzMtZ3JheXNjYWxle2ZpbHRlcjpncmF5c2NhbGUoNzUlKX0udzMtZ3JleXNjYWxlLW1pbiwudzMtZ3JheXNjYWxlLW1pbntmaWx0ZXI6Z3JheXNjYWxlKDUwJSl9DQoudzMtc2VwaWF7ZmlsdGVyOnNlcGlhKDc1JSl9LnczLXNlcGlhLW1heCwudzMtaG92ZXItc2VwaWE6aG92ZXJ7ZmlsdGVyOnNlcGlhKDEwMCUpfS53My1zZXBpYS1taW57ZmlsdGVyOnNlcGlhKDUwJSl9DQoudzMtdGlueXtmb250LXNpemU6MTBweCFpbXBvcnRhbnR9LnczLXNtYWxse2ZvbnQtc2l6ZToxMnB4IWltcG9ydGFudH0udzMtbWVkaXVte2ZvbnQtc2l6ZToxNXB4IWltcG9ydGFudH0udzMtbGFyZ2V7Zm9udC1zaXplOjE4cHghaW1wb3J0YW50fQ0KLnczLXhsYXJnZXtmb250LXNpemU6MjRweCFpbXBvcnRhbnR9LnczLXh4bGFyZ2V7Zm9udC1zaXplOjM2cHghaW1wb3J0YW50fS53My14eHhsYXJnZXtmb250LXNpemU6NDhweCFpbXBvcnRhbnR9LnczLWp1bWJve2ZvbnQtc2l6ZTo2NHB4IWltcG9ydGFudH0NCi53My1sZWZ0LWFsaWdue3RleHQtYWxpZ246bGVmdCFpbXBvcnRhbnR9LnczLXJpZ2h0LWFsaWdue3RleHQtYWxpZ246cmlnaHQhaW1wb3J0YW50fS53My1qdXN0aWZ5e3RleHQtYWxpZ246anVzdGlmeSFpbXBvcnRhbnR9LnczLWNlbnRlcnt0ZXh0LWFsaWduOmNlbnRlciFpbXBvcnRhbnR9DQoudzMtYm9yZGVyLTB7Ym9yZGVyOjAhaW1wb3J0YW50fS53My1ib3JkZXJ7Ym9yZGVyOjFweCBzb2xpZCAjY2NjIWltcG9ydGFudH0NCi53My1ib3JkZXItdG9we2JvcmRlci10b3A6MXB4IHNvbGlkICNjY2MhaW1wb3J0YW50fS53My1ib3JkZXItYm90dG9te2JvcmRlci1ib3R0b206MXB4IHNvbGlkICNjY2MhaW1wb3J0YW50fQ0KLnczLWJvcmRlci1sZWZ0e2JvcmRlci1sZWZ0OjFweCBzb2xpZCAjY2NjIWltcG9ydGFudH0udzMtYm9yZGVyLXJpZ2h0e2JvcmRlci1yaWdodDoxcHggc29saWQgI2NjYyFpbXBvcnRhbnR9DQoudzMtdG9wYmFye2JvcmRlci10b3A6NnB4IHNvbGlkICNjY2MhaW1wb3J0YW50fS53My1ib3R0b21iYXJ7Ym9yZGVyLWJvdHRvbTo2cHggc29saWQgI2NjYyFpbXBvcnRhbnR9DQoudzMtbGVmdGJhcntib3JkZXItbGVmdDo2cHggc29saWQgI2NjYyFpbXBvcnRhbnR9LnczLXJpZ2h0YmFye2JvcmRlci1yaWdodDo2cHggc29saWQgI2NjYyFpbXBvcnRhbnR9DQoudzMtc2VjdGlvbiwudzMtY29kZXttYXJnaW4tdG9wOjE2cHghaW1wb3J0YW50O21hcmdpbi1ib3R0b206MTZweCFpbXBvcnRhbnR9DQoudzMtbWFyZ2lue21hcmdpbjoxNnB4IWltcG9ydGFudH0udzMtbWFyZ2luLXRvcHttYXJnaW4tdG9wOjE2cHghaW1wb3J0YW50fS53My1tYXJnaW4tYm90dG9te21hcmdpbi1ib3R0b206MTZweCFpbXBvcnRhbnR9DQoudzMtbWFyZ2luLWxlZnR7bWFyZ2luLWxlZnQ6MTZweCFpbXBvcnRhbnR9LnczLW1hcmdpbi1yaWdodHttYXJnaW4tcmlnaHQ6MTZweCFpbXBvcnRhbnR9DQoudzMtcGFkZGluZy1zbWFsbHtwYWRkaW5nOjRweCA4cHghaW1wb3J0YW50fS53My1wYWRkaW5ne3BhZGRpbmc6OHB4IDE2cHghaW1wb3J0YW50fS53My1wYWRkaW5nLWxhcmdle3BhZGRpbmc6MTJweCAyNHB4IWltcG9ydGFudH0NCi53My1wYWRkaW5nLTE2e3BhZGRpbmctdG9wOjE2cHghaW1wb3J0YW50O3BhZGRpbmctYm90dG9tOjE2cHghaW1wb3J0YW50fS53My1wYWRkaW5nLTI0e3BhZGRpbmctdG9wOjI0cHghaW1wb3J0YW50O3BhZGRpbmctYm90dG9tOjI0cHghaW1wb3J0YW50fQ0KLnczLXBhZGRpbmctMzJ7cGFkZGluZy10b3A6MzJweCFpbXBvcnRhbnQ7cGFkZGluZy1ib3R0b206MzJweCFpbXBvcnRhbnR9LnczLXBhZGRpbmctNDh7cGFkZGluZy10b3A6NDhweCFpbXBvcnRhbnQ7cGFkZGluZy1ib3R0b206NDhweCFpbXBvcnRhbnR9DQoudzMtcGFkZGluZy02NHtwYWRkaW5nLXRvcDo2NHB4IWltcG9ydGFudDtwYWRkaW5nLWJvdHRvbTo2NHB4IWltcG9ydGFudH0NCi53My1sZWZ0e2Zsb2F0OmxlZnQhaW1wb3J0YW50fS53My1yaWdodHtmbG9hdDpyaWdodCFpbXBvcnRhbnR9DQoudzMtYnV0dG9uOmhvdmVye2NvbG9yOiMwMDAhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6I2NjYyFpbXBvcnRhbnR9DQoudzMtdHJhbnNwYXJlbnQsLnczLWhvdmVyLW5vbmU6aG92ZXJ7YmFja2dyb3VuZC1jb2xvcjp0cmFuc3BhcmVudCFpbXBvcnRhbnR9DQoudzMtaG92ZXItbm9uZTpob3Zlcntib3gtc2hhZG93Om5vbmUhaW1wb3J0YW50fQ0KLyogQ29sb3JzICovDQoudzMtYW1iZXIsLnczLWhvdmVyLWFtYmVyOmhvdmVye2NvbG9yOiMwMDAhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6I2ZmYzEwNyFpbXBvcnRhbnR9DQoudzMtYXF1YSwudzMtaG92ZXItYXF1YTpob3Zlcntjb2xvcjojMDAwIWltcG9ydGFudDtiYWNrZ3JvdW5kLWNvbG9yOiMwMGZmZmYhaW1wb3J0YW50fQ0KLnczLWJsdWUsLnczLWhvdmVyLWJsdWU6aG92ZXJ7Y29sb3I6I2ZmZiFpbXBvcnRhbnQ7YmFja2dyb3VuZC1jb2xvcjojMjE5NkYzIWltcG9ydGFudH0NCi53My1saWdodC1ibHVlLC53My1ob3Zlci1saWdodC1ibHVlOmhvdmVye2NvbG9yOiMwMDAhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6Izg3Q0VFQiFpbXBvcnRhbnR9DQoudzMtYnJvd24sLnczLWhvdmVyLWJyb3duOmhvdmVye2NvbG9yOiNmZmYhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6Izc5NTU0OCFpbXBvcnRhbnR9DQoudzMtY3lhbiwudzMtaG92ZXItY3lhbjpob3Zlcntjb2xvcjojMDAwIWltcG9ydGFudDtiYWNrZ3JvdW5kLWNvbG9yOiMwMGJjZDQhaW1wb3J0YW50fQ0KLnczLWJsdWUtZ3JleSwudzMtaG92ZXItYmx1ZS1ncmV5OmhvdmVyLC53My1ibHVlLWdyYXksLnczLWhvdmVyLWJsdWUtZ3JheTpob3Zlcntjb2xvcjojZmZmIWltcG9ydGFudDtiYWNrZ3JvdW5kLWNvbG9yOiM2MDdkOGIhaW1wb3J0YW50fQ0KLnczLWdyZWVuLC53My1ob3Zlci1ncmVlbjpob3Zlcntjb2xvcjojZmZmIWltcG9ydGFudDtiYWNrZ3JvdW5kLWNvbG9yOiM0Q0FGNTAhaW1wb3J0YW50fQ0KLnczLWxpZ2h0LWdyZWVuLC53My1ob3Zlci1saWdodC1ncmVlbjpob3Zlcntjb2xvcjojMDAwIWltcG9ydGFudDtiYWNrZ3JvdW5kLWNvbG9yOiM4YmMzNGEhaW1wb3J0YW50fQ0KLnczLWluZGlnbywudzMtaG92ZXItaW5kaWdvOmhvdmVye2NvbG9yOiNmZmYhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6IzNmNTFiNSFpbXBvcnRhbnR9DQoudzMta2hha2ksLnczLWhvdmVyLWtoYWtpOmhvdmVye2NvbG9yOiMwMDAhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6I2YwZTY4YyFpbXBvcnRhbnR9DQoudzMtbGltZSwudzMtaG92ZXItbGltZTpob3Zlcntjb2xvcjojMDAwIWltcG9ydGFudDtiYWNrZ3JvdW5kLWNvbG9yOiNjZGRjMzkhaW1wb3J0YW50fQ0KLnczLW9yYW5nZSwudzMtaG92ZXItb3JhbmdlOmhvdmVye2NvbG9yOiMwMDAhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6I2ZmOTgwMCFpbXBvcnRhbnR9DQoudzMtZGVlcC1vcmFuZ2UsLnczLWhvdmVyLWRlZXAtb3JhbmdlOmhvdmVye2NvbG9yOiNmZmYhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6I2ZmNTcyMiFpbXBvcnRhbnR9DQoudzMtcGluaywudzMtaG92ZXItcGluazpob3Zlcntjb2xvcjojZmZmIWltcG9ydGFudDtiYWNrZ3JvdW5kLWNvbG9yOiNlOTFlNjMhaW1wb3J0YW50fQ0KLnczLXB1cnBsZSwudzMtaG92ZXItcHVycGxlOmhvdmVye2NvbG9yOiNmZmYhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6IzljMjdiMCFpbXBvcnRhbnR9DQoudzMtZGVlcC1wdXJwbGUsLnczLWhvdmVyLWRlZXAtcHVycGxlOmhvdmVye2NvbG9yOiNmZmYhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6IzY3M2FiNyFpbXBvcnRhbnR9DQoudzMtcmVkLC53My1ob3Zlci1yZWQ6aG92ZXJ7Y29sb3I6I2ZmZiFpbXBvcnRhbnQ7YmFja2dyb3VuZC1jb2xvcjojZjQ0MzM2IWltcG9ydGFudH0NCi53My1zYW5kLC53My1ob3Zlci1zYW5kOmhvdmVye2NvbG9yOiMwMDAhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6I2ZkZjVlNiFpbXBvcnRhbnR9DQoudzMtdGVhbCwudzMtaG92ZXItdGVhbDpob3Zlcntjb2xvcjojZmZmIWltcG9ydGFudDtiYWNrZ3JvdW5kLWNvbG9yOiMwMDk2ODghaW1wb3J0YW50fQ0KLnczLXllbGxvdywudzMtaG92ZXIteWVsbG93OmhvdmVye2NvbG9yOiMwMDAhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6I2ZmZWIzYiFpbXBvcnRhbnR9DQoudzMtd2hpdGUsLnczLWhvdmVyLXdoaXRlOmhvdmVye2NvbG9yOiMwMDAhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6I2ZmZiFpbXBvcnRhbnR9DQoudzMtYmxhY2ssLnczLWhvdmVyLWJsYWNrOmhvdmVye2NvbG9yOiNmZmYhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6IzAwMCFpbXBvcnRhbnR9DQoudzMtZ3JleSwudzMtaG92ZXItZ3JleTpob3ZlciwudzMtZ3JheSwudzMtaG92ZXItZ3JheTpob3Zlcntjb2xvcjojMDAwIWltcG9ydGFudDtiYWNrZ3JvdW5kLWNvbG9yOiM5ZTllOWUhaW1wb3J0YW50fQ0KLnczLWxpZ2h0LWdyZXksLnczLWhvdmVyLWxpZ2h0LWdyZXk6aG92ZXIsLnczLWxpZ2h0LWdyYXksLnczLWhvdmVyLWxpZ2h0LWdyYXk6aG92ZXJ7Y29sb3I6IzAwMCFpbXBvcnRhbnQ7YmFja2dyb3VuZC1jb2xvcjojZjFmMWYxIWltcG9ydGFudH0NCi53My1kYXJrLWdyZXksLnczLWhvdmVyLWRhcmstZ3JleTpob3ZlciwudzMtZGFyay1ncmF5LC53My1ob3Zlci1kYXJrLWdyYXk6aG92ZXJ7Y29sb3I6I2ZmZiFpbXBvcnRhbnQ7YmFja2dyb3VuZC1jb2xvcjojNjE2MTYxIWltcG9ydGFudH0NCi53My1wYWxlLXJlZCwudzMtaG92ZXItcGFsZS1yZWQ6aG92ZXJ7Y29sb3I6IzAwMCFpbXBvcnRhbnQ7YmFja2dyb3VuZC1jb2xvcjojZmZkZGRkIWltcG9ydGFudH0NCi53My1wYWxlLWdyZWVuLC53My1ob3Zlci1wYWxlLWdyZWVuOmhvdmVye2NvbG9yOiMwMDAhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6I2RkZmZkZCFpbXBvcnRhbnR9DQoudzMtcGFsZS15ZWxsb3csLnczLWhvdmVyLXBhbGUteWVsbG93OmhvdmVye2NvbG9yOiMwMDAhaW1wb3J0YW50O2JhY2tncm91bmQtY29sb3I6I2ZmZmZjYyFpbXBvcnRhbnR9DQoudzMtcGFsZS1ibHVlLC53My1ob3Zlci1wYWxlLWJsdWU6aG92ZXJ7Y29sb3I6IzAwMCFpbXBvcnRhbnQ7YmFja2dyb3VuZC1jb2xvcjojZGRmZmZmIWltcG9ydGFudH0NCi53My10ZXh0LWFtYmVyLC53My1ob3Zlci10ZXh0LWFtYmVyOmhvdmVye2NvbG9yOiNmZmMxMDchaW1wb3J0YW50fQ0KLnczLXRleHQtYXF1YSwudzMtaG92ZXItdGV4dC1hcXVhOmhvdmVye2NvbG9yOiMwMGZmZmYhaW1wb3J0YW50fQ0KLnczLXRleHQtYmx1ZSwudzMtaG92ZXItdGV4dC1ibHVlOmhvdmVye2NvbG9yOiMyMTk2RjMhaW1wb3J0YW50fQ0KLnczLXRleHQtbGlnaHQtYmx1ZSwudzMtaG92ZXItdGV4dC1saWdodC1ibHVlOmhvdmVye2NvbG9yOiM4N0NFRUIhaW1wb3J0YW50fQ0KLnczLXRleHQtYnJvd24sLnczLWhvdmVyLXRleHQtYnJvd246aG92ZXJ7Y29sb3I6Izc5NTU0OCFpbXBvcnRhbnR9DQoudzMtdGV4dC1jeWFuLC53My1ob3Zlci10ZXh0LWN5YW46aG92ZXJ7Y29sb3I6IzAwYmNkNCFpbXBvcnRhbnR9DQoudzMtdGV4dC1ibHVlLWdyZXksLnczLWhvdmVyLXRleHQtYmx1ZS1ncmV5OmhvdmVyLC53My10ZXh0LWJsdWUtZ3JheSwudzMtaG92ZXItdGV4dC1ibHVlLWdyYXk6aG92ZXJ7Y29sb3I6IzYwN2Q4YiFpbXBvcnRhbnR9DQoudzMtdGV4dC1ncmVlbiwudzMtaG92ZXItdGV4dC1ncmVlbjpob3Zlcntjb2xvcjojNENBRjUwIWltcG9ydGFudH0NCi53My10ZXh0LWxpZ2h0LWdyZWVuLC53My1ob3Zlci10ZXh0LWxpZ2h0LWdyZWVuOmhvdmVye2NvbG9yOiM4YmMzNGEhaW1wb3J0YW50fQ0KLnczLXRleHQtaW5kaWdvLC53My1ob3Zlci10ZXh0LWluZGlnbzpob3Zlcntjb2xvcjojM2Y1MWI1IWltcG9ydGFudH0NCi53My10ZXh0LWtoYWtpLC53My1ob3Zlci10ZXh0LWtoYWtpOmhvdmVye2NvbG9yOiNiNGFhNTAhaW1wb3J0YW50fQ0KLnczLXRleHQtbGltZSwudzMtaG92ZXItdGV4dC1saW1lOmhvdmVye2NvbG9yOiNjZGRjMzkhaW1wb3J0YW50fQ0KLnczLXRleHQtb3JhbmdlLC53My1ob3Zlci10ZXh0LW9yYW5nZTpob3Zlcntjb2xvcjojZmY5ODAwIWltcG9ydGFudH0NCi53My10ZXh0LWRlZXAtb3JhbmdlLC53My1ob3Zlci10ZXh0LWRlZXAtb3JhbmdlOmhvdmVye2NvbG9yOiNmZjU3MjIhaW1wb3J0YW50fQ0KLnczLXRleHQtcGluaywudzMtaG92ZXItdGV4dC1waW5rOmhvdmVye2NvbG9yOiNlOTFlNjMhaW1wb3J0YW50fQ0KLnczLXRleHQtcHVycGxlLC53My1ob3Zlci10ZXh0LXB1cnBsZTpob3Zlcntjb2xvcjojOWMyN2IwIWltcG9ydGFudH0NCi53My10ZXh0LWRlZXAtcHVycGxlLC53My1ob3Zlci10ZXh0LWRlZXAtcHVycGxlOmhvdmVye2NvbG9yOiM2NzNhYjchaW1wb3J0YW50fQ0KLnczLXRleHQtcmVkLC53My1ob3Zlci10ZXh0LXJlZDpob3Zlcntjb2xvcjojZjQ0MzM2IWltcG9ydGFudH0NCi53My10ZXh0LXNhbmQsLnczLWhvdmVyLXRleHQtc2FuZDpob3Zlcntjb2xvcjojZmRmNWU2IWltcG9ydGFudH0NCi53My10ZXh0LXRlYWwsLnczLWhvdmVyLXRleHQtdGVhbDpob3Zlcntjb2xvcjojMDA5Njg4IWltcG9ydGFudH0NCi53My10ZXh0LXllbGxvdywudzMtaG92ZXItdGV4dC15ZWxsb3c6aG92ZXJ7Y29sb3I6I2QyYmUwZSFpbXBvcnRhbnR9DQoudzMtdGV4dC13aGl0ZSwudzMtaG92ZXItdGV4dC13aGl0ZTpob3Zlcntjb2xvcjojZmZmIWltcG9ydGFudH0NCi53My10ZXh0LWJsYWNrLC53My1ob3Zlci10ZXh0LWJsYWNrOmhvdmVye2NvbG9yOiMwMDAhaW1wb3J0YW50fQ0KLnczLXRleHQtZ3JleSwudzMtaG92ZXItdGV4dC1ncmV5OmhvdmVyLC53My10ZXh0LWdyYXksLnczLWhvdmVyLXRleHQtZ3JheTpob3Zlcntjb2xvcjojNzU3NTc1IWltcG9ydGFudH0NCi53My10ZXh0LWxpZ2h0LWdyZXksLnczLWhvdmVyLXRleHQtbGlnaHQtZ3JleTpob3ZlciwudzMtdGV4dC1saWdodC1ncmF5LC53My1ob3Zlci10ZXh0LWxpZ2h0LWdyYXk6aG92ZXJ7Y29sb3I6I2YxZjFmMSFpbXBvcnRhbnR9DQoudzMtdGV4dC1kYXJrLWdyZXksLnczLWhvdmVyLXRleHQtZGFyay1ncmV5OmhvdmVyLC53My10ZXh0LWRhcmstZ3JheSwudzMtaG92ZXItdGV4dC1kYXJrLWdyYXk6aG92ZXJ7Y29sb3I6IzNhM2EzYSFpbXBvcnRhbnR9DQoudzMtYm9yZGVyLWFtYmVyLC53My1ob3Zlci1ib3JkZXItYW1iZXI6aG92ZXJ7Ym9yZGVyLWNvbG9yOiNmZmMxMDchaW1wb3J0YW50fQ0KLnczLWJvcmRlci1hcXVhLC53My1ob3Zlci1ib3JkZXItYXF1YTpob3Zlcntib3JkZXItY29sb3I6IzAwZmZmZiFpbXBvcnRhbnR9DQoudzMtYm9yZGVyLWJsdWUsLnczLWhvdmVyLWJvcmRlci1ibHVlOmhvdmVye2JvcmRlci1jb2xvcjojMjE5NkYzIWltcG9ydGFudH0NCi53My1ib3JkZXItbGlnaHQtYmx1ZSwudzMtaG92ZXItYm9yZGVyLWxpZ2h0LWJsdWU6aG92ZXJ7Ym9yZGVyLWNvbG9yOiM4N0NFRUIhaW1wb3J0YW50fQ0KLnczLWJvcmRlci1icm93biwudzMtaG92ZXItYm9yZGVyLWJyb3duOmhvdmVye2JvcmRlci1jb2xvcjojNzk1NTQ4IWltcG9ydGFudH0NCi53My1ib3JkZXItY3lhbiwudzMtaG92ZXItYm9yZGVyLWN5YW46aG92ZXJ7Ym9yZGVyLWNvbG9yOiMwMGJjZDQhaW1wb3J0YW50fQ0KLnczLWJvcmRlci1ibHVlLWdyZXksLnczLWhvdmVyLWJvcmRlci1ibHVlLWdyZXk6aG92ZXIsLnczLWJvcmRlci1ibHVlLWdyYXksLnczLWhvdmVyLWJvcmRlci1ibHVlLWdyYXk6aG92ZXJ7Ym9yZGVyLWNvbG9yOiM2MDdkOGIhaW1wb3J0YW50fQ0KLnczLWJvcmRlci1ncmVlbiwudzMtaG92ZXItYm9yZGVyLWdyZWVuOmhvdmVye2JvcmRlci1jb2xvcjojNENBRjUwIWltcG9ydGFudH0NCi53My1ib3JkZXItbGlnaHQtZ3JlZW4sLnczLWhvdmVyLWJvcmRlci1saWdodC1ncmVlbjpob3Zlcntib3JkZXItY29sb3I6IzhiYzM0YSFpbXBvcnRhbnR9DQoudzMtYm9yZGVyLWluZGlnbywudzMtaG92ZXItYm9yZGVyLWluZGlnbzpob3Zlcntib3JkZXItY29sb3I6IzNmNTFiNSFpbXBvcnRhbnR9DQoudzMtYm9yZGVyLWtoYWtpLC53My1ob3Zlci1ib3JkZXIta2hha2k6aG92ZXJ7Ym9yZGVyLWNvbG9yOiNmMGU2OGMhaW1wb3J0YW50fQ0KLnczLWJvcmRlci1saW1lLC53My1ob3Zlci1ib3JkZXItbGltZTpob3Zlcntib3JkZXItY29sb3I6I2NkZGMzOSFpbXBvcnRhbnR9DQoudzMtYm9yZGVyLW9yYW5nZSwudzMtaG92ZXItYm9yZGVyLW9yYW5nZTpob3Zlcntib3JkZXItY29sb3I6I2ZmOTgwMCFpbXBvcnRhbnR9DQoudzMtYm9yZGVyLWRlZXAtb3JhbmdlLC53My1ob3Zlci1ib3JkZXItZGVlcC1vcmFuZ2U6aG92ZXJ7Ym9yZGVyLWNvbG9yOiNmZjU3MjIhaW1wb3J0YW50fQ0KLnczLWJvcmRlci1waW5rLC53My1ob3Zlci1ib3JkZXItcGluazpob3Zlcntib3JkZXItY29sb3I6I2U5MWU2MyFpbXBvcnRhbnR9DQoudzMtYm9yZGVyLXB1cnBsZSwudzMtaG92ZXItYm9yZGVyLXB1cnBsZTpob3Zlcntib3JkZXItY29sb3I6IzljMjdiMCFpbXBvcnRhbnR9DQoudzMtYm9yZGVyLWRlZXAtcHVycGxlLC53My1ob3Zlci1ib3JkZXItZGVlcC1wdXJwbGU6aG92ZXJ7Ym9yZGVyLWNvbG9yOiM2NzNhYjchaW1wb3J0YW50fQ0KLnczLWJvcmRlci1yZWQsLnczLWhvdmVyLWJvcmRlci1yZWQ6aG92ZXJ7Ym9yZGVyLWNvbG9yOiNmNDQzMzYhaW1wb3J0YW50fQ0KLnczLWJvcmRlci1zYW5kLC53My1ob3Zlci1ib3JkZXItc2FuZDpob3Zlcntib3JkZXItY29sb3I6I2ZkZjVlNiFpbXBvcnRhbnR9DQoudzMtYm9yZGVyLXRlYWwsLnczLWhvdmVyLWJvcmRlci10ZWFsOmhvdmVye2JvcmRlci1jb2xvcjojMDA5Njg4IWltcG9ydGFudH0NCi53My1ib3JkZXIteWVsbG93LC53My1ob3Zlci1ib3JkZXIteWVsbG93OmhvdmVye2JvcmRlci1jb2xvcjojZmZlYjNiIWltcG9ydGFudH0NCi53My1ib3JkZXItd2hpdGUsLnczLWhvdmVyLWJvcmRlci13aGl0ZTpob3Zlcntib3JkZXItY29sb3I6I2ZmZiFpbXBvcnRhbnR9DQoudzMtYm9yZGVyLWJsYWNrLC53My1ob3Zlci1ib3JkZXItYmxhY2s6aG92ZXJ7Ym9yZGVyLWNvbG9yOiMwMDAhaW1wb3J0YW50fQ0KLnczLWJvcmRlci1ncmV5LC53My1ob3Zlci1ib3JkZXItZ3JleTpob3ZlciwudzMtYm9yZGVyLWdyYXksLnczLWhvdmVyLWJvcmRlci1ncmF5OmhvdmVye2JvcmRlci1jb2xvcjojOWU5ZTllIWltcG9ydGFudH0NCi53My1ib3JkZXItbGlnaHQtZ3JleSwudzMtaG92ZXItYm9yZGVyLWxpZ2h0LWdyZXk6aG92ZXIsLnczLWJvcmRlci1saWdodC1ncmF5LC53My1ob3Zlci1ib3JkZXItbGlnaHQtZ3JheTpob3Zlcntib3JkZXItY29sb3I6I2YxZjFmMSFpbXBvcnRhbnR9DQoudzMtYm9yZGVyLWRhcmstZ3JleSwudzMtaG92ZXItYm9yZGVyLWRhcmstZ3JleTpob3ZlciwudzMtYm9yZGVyLWRhcmstZ3JheSwudzMtaG92ZXItYm9yZGVyLWRhcmstZ3JheTpob3Zlcntib3JkZXItY29sb3I6IzYxNjE2MSFpbXBvcnRhbnR9DQoudzMtYm9yZGVyLXBhbGUtcmVkLC53My1ob3Zlci1ib3JkZXItcGFsZS1yZWQ6aG92ZXJ7Ym9yZGVyLWNvbG9yOiNmZmU3ZTchaW1wb3J0YW50fS53My1ib3JkZXItcGFsZS1ncmVlbiwudzMtaG92ZXItYm9yZGVyLXBhbGUtZ3JlZW46aG92ZXJ7Ym9yZGVyLWNvbG9yOiNlN2ZmZTchaW1wb3J0YW50fQ0KLnczLWJvcmRlci1wYWxlLXllbGxvdywudzMtaG92ZXItYm9yZGVyLXBhbGUteWVsbG93OmhvdmVye2JvcmRlci1jb2xvcjojZmZmZmNjIWltcG9ydGFudH0udzMtYm9yZGVyLXBhbGUtYmx1ZSwudzMtaG92ZXItYm9yZGVyLXBhbGUtYmx1ZTpob3Zlcntib3JkZXItY29sb3I6I2U3ZmZmZiFpbXBvcnRhbnR9";
	
	}
	
}
}

