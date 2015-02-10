using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MVCView.Infrastructure
{
    public class DebugDataView : IView
    {
        public void Render(ViewContext viewContext, TextWriter writer)
        {
            Write(writer, "---ROUTING DATA---");
            foreach (string key in viewContext.RouteData.Values.Keys)
            {
                Write(writer, "Key: {0}, Value: {1}", key, viewContext.RouteData.Values[key]);
            }

            Write(writer, "---VIEW DATA---");
            foreach (string key in viewContext.ViewData.Keys)
            {
                Write(writer, "Key: {0}, Value: {1}", key, viewContext.ViewData[key]);
            }

        }

        private void Write(TextWriter writer, string template, params object[] values)
        {
            writer.Write(string.Format(template, values) + "<p/>");
        }
    }
}