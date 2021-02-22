using System;
using System.Windows;

namespace T03_Reflection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// This property will be instantiated AT RUNTIME with a SampleClass instance
        /// </summary>
        public object Sample { get; set; }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnActivator_Click(object sender, RoutedEventArgs e)
        {
            //TODO: use activator to create an instance of SampleClass at runtime, and store it in the Sample object property (see above)


            txtOutput.Text = "> Sample instance has been activated.\n";
        }

        private void btnMethod_Click(object sender, RoutedEventArgs e)
        {
            if (Sample == null) return;

            String result = ""; //TODO: execute method WITHOUT a parameter

            txtOutput.Text += $"> Result of method call: {result}\n";
        }

        private void btnMethodParam_Click(object sender, RoutedEventArgs e)
        {
            if (Sample == null) return;

            String result = ""; //TODO: execute method WITH a parameter

            txtOutput.Text += $"> Result of method call: {result}\n";
        }

        private void btnChangePrivate_Click(object sender, RoutedEventArgs e)
        {
            if (Sample == null) return;
                      
            String original = ""; //TODO: try to get private field value         
            txtOutput.Text += $"> Original value of _everSoPrivate: {original}\n";

            String newValue =  "This string is way too long and should not have gotten into this field anyhow!";
            //TODO: try put newValue in the private field 


            String updated = "";  //TODO: try to get private field value back out; has it changed?
            txtOutput.Text += $"> New value of _everSoPrivate: {updated}\n";
        }
    }
}
