using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture5Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Joshua Saetern
    /// Lecture 5 Notes
    /// Computer Programming II
    /// 04.26.2024
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Create an instance of amazon order
            AmazonOrder order1 = new AmazonOrder("123478", "Joshua Saetern", .1m);

            //Add 3 products
            order1.Products.Add(new Product("Eternal Sunshine of a Spotless Mind", "Michelle Gondry", 10, 14.00m));
            order1.Products.Add(new Product("El Dorado", "Howard Hawks", 10, 17.00m));
            order1.Products.Add(new Product("Robocop", "Paul Verrhoven", 10, 13.00m));

            richTxtBoxDisplay.Text = "";
            foreach (Product product in order1.Products)
            {
                richTxtBoxDisplay.Text += $"\nTitle: {product.Title}, \n Director: {product.Director}";
            }

            MessageBox.Show(order1.TotalPrice().ToString("c"));

            //Write code to calculate the products
            //Display final price with single method call


            //ProductExample();
        }

        public void ProductExample()
        {
            Product charlesMovie = new Product("El Darado", "Howard Hawks");

            charlesMovie.Title = "Mallrats";
            //MessageBox.Show(charlesMovie.Title);

            try
            {
                charlesMovie.Price = -5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    } //Class

}//Namespace