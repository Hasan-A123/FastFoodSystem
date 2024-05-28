using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace FastFoodSystem
{
    public partial class OrderForm : Form
    {

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
         
            textBoxTotalCost.Enabled = false;
        }

        private void buttonCalculateCost_Click(object sender, EventArgs e)
        {

            double Burgers = 0.00;
            double Pizzas = 0.00;
            double Desserts = 0.00;
            double Drinks = 0.00;
            double Total = 0.00;
            
             textBoxTotalCost.Enabled = true;
            

            if (checkBoxCheeseBurger.Checked == true)
                Burgers += 5.00;
            if (checkBoxChickenBurger.Checked == true)
                Burgers += 5.00;
            if (checkBoxFishBurger.Checked == true)
                Burgers += 5.00;
            if (checkBoxHamburger.Checked == true)
                Burgers += 5.00;
            if (checkBoxVeggieBurger.Checked == true)
                Burgers += 5.00;



            if (checkBoxMargheritaPizza.Checked == true)
                Pizzas += 10.00;
            if (checkBoxPepperoniPizza.Checked == true)
                Pizzas += 10.00;
            if (checkBoxVeggiePizza.Checked == true)
                Pizzas += 10.00;
            if (checkBoxMeatFeastPizza.Checked == true)
                Pizzas += 10.00;


            if (checkBoxChocolateCake.Checked == true)
                Desserts += 4.00;
            if (checkBoxRedVelvetCake.Checked == true)
                Desserts += 4.00;
            if (checkBoxCookie.Checked == true)
                Desserts += 4.00;
            if (checkBoxDonut.Checked == true)
                Desserts += 4.00;
            if (checkBoxBrownie.Checked == true)
                Desserts += 4.00;


            if (checkBoxCocaCola.Checked == true)
                Drinks += 2.00;
            if (checkBoxPepsi.Checked == true)
                Drinks += 2.00;
            if (checkBoxWater.Checked == true)
                Drinks += 2.00;
            if (checkBoxOrangeJuice.Checked == true)
                Drinks += 2.00;
            if (checkBoxMilkshake.Checked == true)
                Drinks += 2.00;


            Total = Burgers + Pizzas + Desserts + Drinks;

            textBoxTotalCost.Text = Total.ToString();
            MessageBox.Show("Your Total is: " + Total.ToString("c2") + "\nThank You For Your Purchase", "THANK YOU");



        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            textBoxOrderNumber.Text = "";
            dateTimePicker.Value = DateTime.Now;
            textBoxTotalCost.Text = "";
            textBoxTotalCost.Enabled = false;
        }

        private void buttonMainForm_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }
    }
}