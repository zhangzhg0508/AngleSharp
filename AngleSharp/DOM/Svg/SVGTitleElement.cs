﻿namespace AngleSharp.DOM.Svg
{
    /// <summary>
    /// Represents the title element of the SVG DOM.
    /// </summary>
    sealed class SVGTitleElement : SVGElement, ISvgTitleElement
    {
        internal SVGTitleElement()
            : base(Tags.Title, NodeFlags.HtmlTip | NodeFlags.Special | NodeFlags.Scoped)
        {
        }
    }
}
