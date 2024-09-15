namespace PdfNox.App
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        int count = 0;

        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void OnCountClicked(object sender, RoutedEventArgs e)
            => txtCount.Text = $"Current count: {count++}";
    }
}
