﻿using System;
using System.Runtime.InteropServices.JavaScript;

namespace WebAssembly.Browser.DOM
{

    [Export("HTMLParamElement", typeof(JSObject))]
    public sealed class HTMLParamElement : HTMLElement, IHTMLParamElement
    {
        internal HTMLParamElement(JSObject handle) : base(handle) { }

        //public HTMLParamElement() { }
        [Export("name")]
        public string Name { get => GetProperty<string>("name"); set => SetProperty<string>("name", value); }
        [Export("type")]
        public string Type { get => GetProperty<string>("type"); set => SetProperty<string>("type", value); }
        [Export("value")]
        public string NodeValue { get => GetProperty<string>("value"); set => SetProperty<string>("value", value); }
        [Export("valueType")]
        public string NodeValueType { get => GetProperty<string>("valueType"); set => SetProperty<string>("valueType", value); }
    }
}