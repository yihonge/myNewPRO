using Microsoft.Web.WebView2.Core;
using HtmlAgilityPack;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace myNewPRO
{

    public partial class Form1 : Form
    {
        public TreeNode TN;
        public static HttpClient Client;
        public Form1()
        {
            InitializeComponent();
            webView21.NavigationStarting += EnsureHttps;
            InitializeAsync();
            TN = treeView1.Nodes.Add("根节点");
        }
        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            //e.NewWindow = webView22.CoreWebView2;
            //在第二个webview2上面打开这个新窗口
            webView21.Source = new Uri(e.Uri.ToString());
            e.Handled = true;//禁止弹窗

        }

        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                webView21.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
                args.Cancel = true;
            }
        }
        async void InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.WebMessageReceived += UpdateAddressBar;
            webView21.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
            //await webView21.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
            //await webView21.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener(\'message\', event => alert(event.data));");
        }

        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            toolStripTextBox1.Text = uri;
            webView21.CoreWebView2.PostWebMessageAsString(uri);
        }
        private void webGo(string _url)
        {
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate(_url);
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webGo(toolStripTextBox1.Text);
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                
            }
        }

        


       
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
