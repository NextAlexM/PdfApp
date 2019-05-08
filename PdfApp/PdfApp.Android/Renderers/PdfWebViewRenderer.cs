using PdfApp.Controls;
using PdfApp.Droid.Renderers;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(PdfWebView), typeof(PdfWebViewRenderer))]
namespace PdfApp.Droid.Renderers
{
    using Android.Content;
    using Android.Webkit;
    using Controls;
    using System.Net;
    using Xamarin.Forms.Platform.Android;

    public class PdfWebViewRenderer : ViewRenderer<PdfWebView, WebView>
    {
        private Context context;

        /// <summary>
        /// Initialises a new instance of the <see cref="PdfWebViewRenderer"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public PdfWebViewRenderer(Context context) : base(context)
        {
            this.context = context;
            WebView.SetWebContentsDebuggingEnabled(true);
        }

        /// <summary>
        /// Called when the element is changed
        /// </summary>
        /// <param name="e">The <see cref="ElementChangedEventArgs{TElement}"/> instance containing the event data.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<PdfWebView> e)
        {
            base.OnElementChanged(e);

            if (this.Control == null)
            {
                var webView = new Android.Webkit.WebView(this.context);

                webView.Settings.JavaScriptEnabled = true;
                webView.Settings.AllowFileAccess = true;
                webView.Settings.DomStorageEnabled = true;
                webView.Settings.AllowFileAccessFromFileURLs = true;
                webView.Settings.AllowUniversalAccessFromFileURLs = true;
                webView.SetWebChromeClient(new WebChromeClient());

                this.SetNativeControl(webView);
            }

            if (e.NewElement != null)
            {
                var url = string.Format("file:///android_asset/pdfjs/web/viewer.html?file={0}", string.Format("file:///android_asset/Content/{0}", WebUtility.UrlEncode(Element.Uri)));
                Control.LoadUrl(url);
            }
        }
    }
}