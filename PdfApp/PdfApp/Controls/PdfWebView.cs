namespace PdfApp.Controls
{
    using Xamarin.Forms;

    public class PdfWebView : WebView
    {
        /// <summary>
        /// The URI property
        /// </summary>
        public static readonly BindableProperty UriProperty =
            BindableProperty.Create("Uri", typeof(string), typeof(PdfWebView), default(string));

        /// <summary>
        /// Gets or sets the URI.
        /// </summary>
        public string Uri
        {
            get => (string)this.GetValue(UriProperty);
            set => this.SetValue(UriProperty, value);
        }
    }
}
