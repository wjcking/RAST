using System.ComponentModel;
using System.Windows.Forms;

    public partial class webview : WebBrowser
    {

        public webview()
        {
            InitializeComponent();
			
        }
  
        public webview(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
