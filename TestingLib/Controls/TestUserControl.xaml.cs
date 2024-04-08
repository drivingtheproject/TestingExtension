using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace TestingLib.Controls
{
    public sealed partial class TestUserControl : UserControl
    {
        public TestUserControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty LogMessageProperty = DependencyProperty.Register("LogMessage", typeof(string), typeof(TestUserControl), new PropertyMetadata(""));
        public string LogMessage
        {
            get => (string)GetValue(LogMessageProperty);
            set => SetValue(LogMessageProperty, value);
        }
    }
}
