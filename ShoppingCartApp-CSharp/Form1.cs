namespace ShoppingCartApp_CSharp
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> products = new Dictionary<string, double>();
        double total = 0;
        public Form1()
        {
            InitializeComponent();
            LoadProducts();
        }

        void LoadProducts()
        {
            products.Add("Laptop", 15000);
            products.Add("Mouse", 300);
            products.Add("Keyboard", 800);
            products.Add("Headphones", 1200);

            cmbProducts.Items.AddRange(products.Keys.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem == null)
                return;

            string product = cmbProducts.SelectedItem.ToString();
            double price = products[product];

            lstCart.Items.Add($"{product} - ${price}");
            total += price;

            lblTotal.Text = "Total: $" + total;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstCart.Items.Clear();
            total = 0;
            lblTotal.Text = "Total: $0";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Preguntar confirmación antes de cerrar
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de querer salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close(); // Cierra el formulario principal
            }
        }
    }
}
