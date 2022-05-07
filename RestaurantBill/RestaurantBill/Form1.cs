namespace RestaurantBill
{
    public partial class Form1 : Form
    {
        private static decimal subtotal = 0.00M;
        private static decimal tax;
        private static decimal total;

        private Dictionary<string, decimal> prices = new Dictionary<string, decimal>();
        public Form1()
        {
            InitializeComponent();
            prices.Add("", 0.00M);
            //Adds all the appetizers to the prices dictionary
            prices.Add("Buffalo Wings ($5.95)", 5.95M);
            prices.Add("Buffalo Fingers ($6.95)", 6.95M);
            prices.Add("Potato Skins ($8.95)", 8.95M);
            prices.Add("Nachos ($8.95)", 8.95M);
            prices.Add("Mushroom Caps ($10.95)", 10.95M);
            prices.Add("Shrimp Cocktail ($12.95)", 12.95M);
            prices.Add("Chips and Salsa ($6.95)", 6.95M);

            //Adds all the main courses to the prices dictionary
            prices.Add("Seafood Alfredo ($15.95)", 15.95M);
            prices.Add("Chicken Alfredo ($13.95)", 13.95M);
            prices.Add("Chicken Picatta ($13.95)", 13.95M);
            prices.Add("Turkey Club ($11.95)", 11.95M);
            prices.Add("Lobster Pie ($19.95)", 19.95M);
            prices.Add("Prime Rib ($20.95)", 20.95M);
            prices.Add("Shrimp Scampi ($18.95)", 18.95M);
            prices.Add("Turkey Dinner ($13.95)", 13.95M);
            prices.Add("Stuffed Chicken ($14.95)", 14.95M);

            //Adds all the desserts to the prices dictionary
            prices.Add("Apple Pie ($5.95)", 5.95M);
            prices.Add("Sundae ($3.95)", 3.95M);
            prices.Add("Carrot Cake ($5.95)", 5.95M);
            prices.Add("Mud Pie ($4.95)", 4.95M);
            prices.Add("Apple Crisp ($5.95)", 5.95M);

            //Adds all the beverage to the prices dictionary
            prices.Add("Soda ($1.95)", 1.95M);
            prices.Add("Tea ($1.50)", 1.50M);
            prices.Add("Coffee ($1.25)", 1.25M);
            prices.Add("Mineral Water ($2.95)", 2.95M);
            prices.Add("Juice ($2.50)", 2.50M);
            prices.Add("Milk ($1.50)", 1.50M);

            SubtotalTextBox.Text = String.Format("{0:C}", subtotal);
            TaxTextBox.Text = String.Format("{0:C}", tax);
            TotalTextBox.Text = String.Format("{0:C}", total);
        }

        private void CalculateTotal()
        {
            string appetizer = AppetizerComboBox.Text;
            string mainCourse = MainCourseComboBox.Text;
            string dessert = DessertComboBox.Text;
            string beverage = BeverageComboBox.Text;
           
            subtotal = prices[appetizer] + prices[mainCourse] + prices[dessert] + prices[beverage];
            tax = subtotal * 0.05M;
            total = subtotal + tax;
            
            
            SubtotalTextBox.Text = String.Format("{0:C}", subtotal);
            TaxTextBox.Text = String.Format("{0:C}", tax);
            TotalTextBox.Text = String.Format("{0:C}", total);
        }
        private void AppetizerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void MainCourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void DessertComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void BeverageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void ClearBillButton_Click(object sender, EventArgs e)
        {
            AppetizerComboBox.Text = "";
            MainCourseComboBox.Text = "";
            DessertComboBox.Text = "";
            BeverageComboBox.Text = "";
            CalculateTotal();
        }
    }
}