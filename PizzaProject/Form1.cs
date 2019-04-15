using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Rouni_Gorgees_Lab10_Ex1
{
    /// <summary>
    /// Class used for Global Pizza shop application
    /// </summary>
    public partial class Form1 : Form
    {
        // declare and initialize variables
        private double smallPizzaPizza = 5.99;
        private double mediumPizzaPizza = 6.99;
        private double largePizzaPizza = 7.99;

        private double smallDominos = 5.59;
        private double mediumDominos = 6.59;
        private double largeDominos = 7.59;

        private double smallPizzaHut = 5.39;
        private double mediumPizzaHut = 6.39;
        private double largePizzaHut = 7.39;

        private double Total = 0;
        private double price = 0;
        private double collectedPrice = 0;
        private double tax = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateInformationButton_Click(object sender, EventArgs e)
        {
            if (orderNumberTextBox.Text == string.Empty)
                MessageBox.Show("Please enter order number");
            else if (customerNameTextBox.Text == string.Empty)
                MessageBox.Show("Please enter customer name");
            else if (phoneNumberTextBox.Text == string.Empty)
                MessageBox.Show("Please enter phone number");
            else if (deliveryAddressTextBox.Text == string.Empty)
                MessageBox.Show("Please enter delivery address");
            else
            {
                ordersSummaryTextBox.Text = "Order Number: " + orderNumberTextBox.Text + Environment.NewLine;
                ordersSummaryTextBox.Text += "Customer Name: " + customerNameTextBox.Text + Environment.NewLine;
                ordersSummaryTextBox.Text += "Phone Number: " + phoneNumberTextBox.Text + Environment.NewLine;
                ordersSummaryTextBox.Text += "Delivery Address: " + deliveryAddressTextBox.Text + Environment.NewLine;
            }

            Regex phoneNumpattern = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");

            if ((phoneNumpattern.IsMatch(phoneNumberTextBox.Text)))
            {
                return;
            }
            else
            {
                MessageBox.Show("Please enter a valid phone number");
            }
        }

        /// <summary>
        /// Method that checked is the order number is Number not string or any characer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            // create tString variabe to store orderNumber text box input
            string tString = orderNumberTextBox.Text;

            // remove the space from the input
            if (tString.Trim() == "") return;

            // using for loop to check each character if the input
            // it is digit
            for (int i = 0; i < tString.Length; i++)
            {
                // checking the input
                if (!char.IsNumber(tString[i]))
                {
                    // if the input is not number display message box 
                    // and ask user to enter a valid number
                    MessageBox.Show("Please enter a valid number");
                    // clear orderNumberTextBox
                    orderNumberTextBox.Text = "";
                    return;
                }
            }
        }

        /// <summary>
        /// Method that checks if the CustomerName input is string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // store customer name input textbox in customerName variable
            string customerName = customerNameTextBox.Text;

            // declare variable
            int value;

            // checking if the input is number
            if (int.TryParse(customerName, out value))
            {
                // display message if the input is number
                // and ask the user to enter a valid name
                MessageBox.Show("Please enter a valid name");

                // clear customerNameTextBox
                customerNameTextBox.Text = string.Empty;
            }
        }

        /// <summary>
        /// Method that allows the user to celect the Pizza Shop from the combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PizzaShopComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // using try catch statement
            try
            {
                // using if statement to check if the list box contain any items 
                // and checking specifically if the itemsListBox contain one of Pizza Shop items
                if (!(itemsListBox.Items.Contains(pizzaShopComboBox.SelectedItem)) && itemsListBox.Items.Count <= 1)

                    // insert pizza Shop selected item to the first index of itemsListBox
                    itemsListBox.Items.Insert(0, pizzaShopComboBox.SelectedItem);
                // remove all the items of Pizza shop from the list
                else
                {
                    itemsListBox.Items.Remove("Pizza Pizza");
                    itemsListBox.Items.Remove("Dominos");
                    itemsListBox.Items.Remove("Pizza Hut");
                    // insert pizza shop selected item to the first index of itemsListBox
                    itemsListBox.Items.Insert(0, pizzaShopComboBox.SelectedItem);
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Method that determine ComboBox items index change
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void PizzaTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {   // checking if the itemsLixBox that display selected item from combobox dosn't
                // contain shop type items and and the number of items are less than or equal 1
                if (!(itemsListBox.Items.Contains(pizzaTypeComboBox.SelectedItem)) && itemsListBox.Items.Count <= 1)
                    // insert selected item from pizza type to the itemsListBox
                    itemsListBox.Items.Insert(1, pizzaTypeComboBox.SelectedItem);
                // remove pizza type items from itemsListBox 
                else
                {
                    itemsListBox.Items.Remove("Small");
                    itemsListBox.Items.Remove("Medium");
                    itemsListBox.Items.Remove("Large");
                    // insert selected item from pizza type to the itemsListBox
                    itemsListBox.Items.Insert(1, pizzaShopComboBox.SelectedItem);
                }

            } // catch if the pizza type is selected before  pizza shope
              // we cant determine pizza type unless we have pizza shope selected
            catch (ArgumentOutOfRangeException)
            {
                // show me for the user and ask the user to 
                // seleted pizza shop first 
                MessageBox.Show("Selected Pizza Shop First");
                // reset pizzaTypeComboBox
                pizzaTypeComboBox.ResetText();
            }
            // calling method comboBoxchange
            ComboBoxChange();
        }

        /// <summary>
        /// method the determine if the Pepperoni checkbox is checked or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PepperoniCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // useing if statement to check if pizza shop combox box is selected
            // and pizza type is selected too. otherwise message will display to inform the user
            if (pizzaShopComboBox.SelectedIndex > -1 && pizzaTypeComboBox.SelectedIndex > -1)
            {
                // declare and initialize variabe peeperonPrice
                double pepperonPrice = 0;
                // checking if the checkbox is checked
                if (pepperoniCheckBox.Checked == true)
                {
                    // set pepperonPrice to 0.49
                    pepperonPrice = 0.49;
                    // remove Pepperoni from the itemsLixBox if previously 
                    // was added and adding it again
                    itemsListBox.Items.Remove("Pepperoni: $" + pepperonPrice);
                    itemsListBox.Items.Add("Pepperoni: $" + pepperonPrice);
                }
                // if the checkbox is not checked
                else if (pepperoniCheckBox.Checked == false)
                {
                    // take out 0.49 from pepperonPrice if the checkbox is unchecked
                    pepperonPrice -= 0.49;
                    // finedind the index for Pepperoni item in itemsListBox
                    // to be removed
                    int index = itemsListBox.FindString("Pepperoni");

                    // using try catch to catch if the index is outof range
                    try
                    {
                        // remove peppernoi item from itemsListBox at the specific index
                        itemsListBox.Items.RemoveAt(index);
                    } // catch the exception
                    catch (ArgumentOutOfRangeException)
                    {

                    }
                }

                // adding pepperonPrice to the total
                Total += pepperonPrice;
            }
            else
            {
                // display message for the user if the pepperoni check
                // box is selected before Pizza shop and Pizza type
                MessageBox.Show("Select Pizza shop and Pizza type First");
                // uncked peeperoniCheckBox
                pepperoniCheckBox.Checked = false;
            }

            // calling method ComboBoxChange()
            ComboBoxChange();
        }

        /// <summary>
        /// Method the determine if the ham check box is checked or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HamCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // checking if the pizza shop and pizza type are selected 
            if (pizzaShopComboBox.SelectedIndex > -1 && pizzaTypeComboBox.SelectedIndex > -1)
            {
                // declare and initialize humPrice
                double humPrice = 0;
                // if hamCheckBox is checked
                if (hamCheckBox.Checked)
                {
                    // set humPrice to 0.49
                    humPrice = 0.49;
                    // remove Ham from itemsListBox if it was found 
                    // previously in the list and adding it again
                    itemsListBox.Items.Remove("Ham: $" + humPrice);
                    itemsListBox.Items.Add("Ham: $" + humPrice);

                }
                // if the hamCheckBox is not checked
                else if (hamCheckBox.Checked == false)
                {
                    // set humPrice to its previous price which is 0
                    humPrice -= 0.49;
                    // finding the index of Ham in itemsListBox to be removed
                    int index = itemsListBox.FindString("Ham");

                    // using try catch if the index is outOf ragne
                    try
                    {
                        // remove the item under a specific index
                        itemsListBox.Items.RemoveAt(index);
                    }
                    // catching the exception
                    catch (ArgumentOutOfRangeException)
                    {

                    }
                }

                // and humPrice to the total
                Total += humPrice;
            }
            else
            {
                // if hamCheckBox is selected before Pizza shop and Pizza type
                // this message will appear
                MessageBox.Show("Select Pizza shop and Pizza type First");
                hamCheckBox.Checked = false;
            }

            // calling method ComboBoxChange()
            ComboBoxChange();
        }
        /// <summary>
        /// method that determin if the SausageCheckBox is checked or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SausageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // checking if the pizza shop and pizza type are selected first
            if (pizzaShopComboBox.SelectedIndex > -1 && pizzaTypeComboBox.SelectedIndex > -1)
            {
                // declare and initialize suasagePrice to zero
                double sausagePrice = 0;

                // if the checkbox is checked
                if (sausageCheckBox.Checked)
                {
                    // set sauagePrice to 0.49
                    sausagePrice = 0.49;
                    // remove Sausage from itemsListBox if is found and 
                    // adding the item again to the listbox
                    itemsListBox.Items.Remove("Sausage: $" + sausagePrice);
                    itemsListBox.Items.Add("Sausage: $" + sausagePrice);
                }
                // if checkBox is not checked
                else if (sausageCheckBox.Checked == false)
                {
                    // set price to 0
                    sausagePrice -= 0.49;
                    // determing the index of the item in the listBox 
                    // to be remove
                    int index = itemsListBox.FindString("Sausage");

                    // using try catch for the index if it is out of the range
                    try
                    {
                        // remove the item at the specific index
                        itemsListBox.Items.RemoveAt(index);
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                    }
                }

                // adding sauagePrice to the Total
                Total += sausagePrice;
            }
            else
            {
                // display the message if the checkbox is selected 
                // before Pizza shop and Pizza type
                MessageBox.Show("Select Pizza shop and Pizza type First");

                // set the checkbox to unchecked
                sausageCheckBox.Checked = false;
            }
            // calling method ComboBoxChange()
            ComboBoxChange();
        }

        /// <summary>
        /// Method that determine if the MushroomsCheckBox is checked or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MushroomsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // determining if the pizza shop and pizza type are selected
            if (pizzaShopComboBox.SelectedIndex > -1 && pizzaTypeComboBox.SelectedIndex > -1)
            {
                // declare and initializing mushroomsPrice to zero
                double mushroomsPrice = 0;
                // if the checkbox is checked
                if (mushroomsCheckBox.Checked)
                {
                    // set mushroomsPrice to 0.49
                    mushroomsPrice = 0.49;
                    // remove Mushrooms from the itemsListBox and adding it again
                    // to make sure that no more than one item of the same type 
                    // should be in the ListBox
                    itemsListBox.Items.Remove("Mushrooms: $" + mushroomsPrice);
                    itemsListBox.Items.Add("Mushrooms: $" + mushroomsPrice);

                }
                // if the mushroomsCheckBox is not checked
                else if (mushroomsCheckBox.Checked == false)
                {
                    // set mushroomsPrice to zero
                    mushroomsPrice -= 0.49;
                    // search for the Mushrooms in the ListBox and remove it
                    int index = itemsListBox.FindString("Mushrooms");

                    // catching index if it is out of the range
                    try
                    {
                        // remove the item at the specific index
                        itemsListBox.Items.RemoveAt(index);
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                    }
                }

                // add mushroomsPrice to the Total
                Total += mushroomsPrice;
            }
            else
            {
                // if the MushroomsCheckBox is checked before selecting
                // Pizza shop and Pizza type the message will appear
                MessageBox.Show("Select Pizza shop and Pizza type First");
                // set checkBox to the false(unchecked)
                mushroomsCheckBox.Checked = false;
            }

            // calling method ComboBoxChange()
            ComboBoxChange();
        }

        /// <summary>
        /// Method that determing if the pineappleChackBox is checked or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PineappleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // determin if the pizza shop and pizza type are selected first
            if (pizzaShopComboBox.SelectedIndex > -1 && pizzaTypeComboBox.SelectedIndex > -1)
            {
                // initialize pineapplePrice to 0
                double pineapplePrice = 0;

                // if the checkbox is checked
                if (pineappleCheckBox.Checked)
                {
                    // set the pineapplePrice to 0.49
                    pineapplePrice = 0.49;
                    // remove Pineapple if it occurse more than one time in the listBox
                    itemsListBox.Items.Remove("Pineapple: $" + pineapplePrice);
                    itemsListBox.Items.Add("Pineapple: $" + pineapplePrice);
                }
                // if the checkbox is unchecked
                else if (pineappleCheckBox.Checked == false)
                {
                    // set pineapplePrice to 0
                    pineapplePrice -= 0.49;
                    // search for Pineapple index in the list to be removed
                    int index = itemsListBox.FindString("Pineapple");

                    // catch the index if it is out of the range
                    try
                    {
                        // remove the item at specific index from the listBox
                        itemsListBox.Items.RemoveAt(index);
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                    }
                }

                // adding pineapplePrice to the Total
                Total += pineapplePrice;
            }
            else
            {
                // display message if the checkbox is checked before 
                // selecting Pizza Shop and Pizza type
                MessageBox.Show("Select Pizza shop and Pizza type First");

                // set checkbox to false(unchecked)
                pineappleCheckBox.Checked = false;
            }

            // calling method ComboBoxChange()
            ComboBoxChange();
        }

        /// <summary>
        /// Method that determines if the PeppersCheckBox is checked or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PeppersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // determining if the pizza shop and pizza type are selected first
            if (pizzaShopComboBox.SelectedIndex > -1 && pizzaTypeComboBox.SelectedIndex > -1)
            {
                // initialize  peppersPrice to 0
                double peppersPrice = 0;

                // if the checkbox is set to true(checked)
                if (peppersCheckBox.Checked)
                {
                    // set peppersPrcie to 0.49
                    peppersPrice = 0.49;

                    // remove Peppers item from the listBox if the item
                    // appears more than one time
                    itemsListBox.Items.Remove("Peppers: $" + peppersPrice);
                    itemsListBox.Items.Add("Peppers: $" + peppersPrice);
                }
                // if the checkeBox is set to the false(unchecked)
                else if (peppersCheckBox.Checked == false)
                {
                    // set the peppersPrice to 0
                    peppersPrice -= 0.49;
                    // search for the index of the item and remove it from the 
                    // list box
                    int index = itemsListBox.FindString("Peppers");

                    // try catch for the index that is out of the range
                    try
                    {
                        // remove the item at the specific index
                        itemsListBox.Items.RemoveAt(index);
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                    }
                }

                // adding peppersPrice to the Total
                Total += peppersPrice;
            }
            else
            {
                // display the message if the checkbox is checked before
                // selecting Pizza shop and Pizza type
                MessageBox.Show("Select Pizza shop and Pizza type First");

                // set the checkbox to false(unchecked)
                peppersCheckBox.Checked = false;
            }

            // calling method ComboBoxChange()
            ComboBoxChange();
        }

        /// <summary>
        /// Method that determines if the OlivesCheckBox is checked or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OlivesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // checking if the pizza shop and pizza type are selected first
            if (pizzaShopComboBox.SelectedIndex > -1 && pizzaTypeComboBox.SelectedIndex > -1)
            {
                // initialize olivesPrice to 0
                double olivesPrice = 0;

                // if the checkbox is checked
                if (olivesCheckBox.Checked)
                {
                    // set olivesPrice to 0.49
                    olivesPrice = 0.49;
                    // remove Olives item from the listBox if it appears more
                    // than on time
                    itemsListBox.Items.Remove("Olives: $" + olivesPrice);
                    itemsListBox.Items.Add("Olives: $" + olivesPrice);
                }

                // if the checkbox is unchecked
                else if (olivesCheckBox.Checked == false)
                {
                    // set olivesPrice to 0
                    olivesPrice -= 0.49;
                    // finding the index of the Olives to be removed from the
                    // list box
                    int index = itemsListBox.FindString("Olives");

                    // try catch for the index that is out of range
                    try
                    {
                        // remove the item from that listbox at the determined index
                        itemsListBox.Items.RemoveAt(index);
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                    }
                }

                // adding olivesPrice to the Total
                Total += olivesPrice;
            }
            else
            {
                // display message if the checkbox is checked before
                // selecteding pizza shop and pizza type
                MessageBox.Show("Select Pizza shop and Pizza type First");

                // set checkbox to false to be unchecked
                olivesCheckBox.Checked = false;
            }

            // calling method ComboBoxChange()
            ComboBoxChange();
        }

        /// <summary>
        /// Method that determines if the Oninons CheckBox is checked or unchecked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // determining if the pizza shop and pizza type are selected first
            if (pizzaShopComboBox.SelectedIndex > -1 && pizzaTypeComboBox.SelectedIndex > -1)
            {
                // initialize the onionsPrice to 0
                double onionsPrice = 0;

                // if the checkbox is checked
                if (onionsCheckBox.Checked)
                {
                    // set onionsPrice to 0.49
                    onionsPrice = 0.49;
                    // remove Onions item from the listBox if it appears
                    // more than one time
                    itemsListBox.Items.Remove("Onions: $" + onionsPrice);
                    itemsListBox.Items.Add("Onions: $" + onionsPrice);
                }

                // if the checkbox is unchecked
                else if (onionsCheckBox.Checked == false)
                {
                    // set the onionsPrice to 0
                    onionsPrice -= 0.49;
                    // searching for the index of item Onions to be removed
                    // from the listbox
                    int index = itemsListBox.FindString("Onions");

                    // using Try catch
                    try
                    {
                        // remove Onions from the ListBox at the determined index
                        itemsListBox.Items.RemoveAt(index);
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                    }
                }

                // adding onionsPrice to the Total
                Total += onionsPrice;
            }
            else
            {
                // display message if the checkbox is checked before
                // selecing pizza shop and pizza type
                MessageBox.Show("Select Pizza shop and Pizza type First");
                // set checkbox to false
                onionsCheckBox.Checked = false;
            }

            // calling Method ComboBoxChange()
            ComboBoxChange();
        }

        /// <summary>
        /// Method that determines if the CheeseCheckbox is checked or unchecked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheeseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // determining if the pizza shop and pizza type are selected first
            if (pizzaShopComboBox.SelectedIndex > -1 && pizzaTypeComboBox.SelectedIndex > -1)
            {
                // initialize cheesePrice to 0
                double cheesePrice = 0;

                // if the checkbox is checked
                if (cheeseCheckBox.Checked)
                {
                    // set cheesePrice to 0.49
                    cheesePrice = 0.49;
                    // remove the item that appears more than one time
                    // from the list box
                    itemsListBox.Items.Remove("Cheese: $" + cheesePrice);
                    itemsListBox.Items.Add("Cheese: $" + cheesePrice);
                }
                // if the checkbox is unchecked
                else if (cheeseCheckBox.Checked == false)
                {
                    // set the cheesePrice to 0
                    cheesePrice -= 0.49;

                    // searching for the index that Cheese
                    // has in the listBox
                    int index = itemsListBox.FindString("Cheese");

                    // using try catch for the index out or range
                    try
                    {
                        // remove the item from the list at a specific index
                        itemsListBox.Items.RemoveAt(index);
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                    }
                }

                // adding cheesePrice to the Total
                Total += cheesePrice;
            }
            else
            {
                // display message if the checkbox is checked before
                // selecting pizza shop and pizza type
                MessageBox.Show("Select Pizza shop and Pizza type First");

                // set checkbox to false
                cheeseCheckBox.Checked = false;
            }

            // calling method ComboBoxChange
            ComboBoxChange();
        }

        /// <summary>
        /// Method that place the order and display it in the listBox and textBox (summary)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            // checking if the textBoxes are empty
            if (orderNumberTextBox.Text == string.Empty)
                MessageBox.Show("Please enter order number");
            else if (customerNameTextBox.Text == string.Empty)
                MessageBox.Show("Please enter customer name");
            else if (phoneNumberTextBox.Text == string.Empty)
                MessageBox.Show("Please enter phone number");
            else if (deliveryAddressTextBox.Text == string.Empty)
                MessageBox.Show("Please enter delivery address");
            else
            {
                // calcuate the total price or the order
                // with added tax to the final total
                tax = collectedPrice * 0.13;
                // display the total to totalTextBox
                totalTextBox.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "Grand Total: {0,66:C2}", collectedPrice + tax);
            }

            // display the summry of the order in the Order Summary textBox
            ordersSummaryTextBox.Text = "Order Number: " + orderNumberTextBox.Text + Environment.NewLine;
            ordersSummaryTextBox.Text += "Customer Name: " + customerNameTextBox.Text + Environment.NewLine;
            ordersSummaryTextBox.Text += "Phone Number: " + phoneNumberTextBox.Text + Environment.NewLine;
            ordersSummaryTextBox.Text += "Delivery Address: " + deliveryAddressTextBox.Text + Environment.NewLine;
            ordersSummaryTextBox.Text += "Pizza Shop: " + pizzaShopComboBox.Text + Environment.NewLine;
            ordersSummaryTextBox.Text += "Pizza Type: " + pizzaTypeComboBox.Text + Environment.NewLine;
            ordersSummaryTextBox.Text += "---Toppings---" + Environment.NewLine;
            if (pepperoniCheckBox.Checked)
                ordersSummaryTextBox.Text += " Pepperoni" + Environment.NewLine;
            if (hamCheckBox.Checked)
                ordersSummaryTextBox.Text += " Ham" + Environment.NewLine;
            if (sausageCheckBox.Checked)
                ordersSummaryTextBox.Text += " Sausage" + Environment.NewLine;
            if (mushroomsCheckBox.Checked)
                ordersSummaryTextBox.Text += " Mushrooms" + Environment.NewLine;
            if (pineappleCheckBox.Checked)
                ordersSummaryTextBox.Text += " Pineapple" + Environment.NewLine;
            if (peppersCheckBox.Checked)
                ordersSummaryTextBox.Text += " Peppers" + Environment.NewLine;
            if (olivesCheckBox.Checked)
                ordersSummaryTextBox.Text += " Olives" + Environment.NewLine;
            if (onionsCheckBox.Checked)
                ordersSummaryTextBox.Text += " Onions" + Environment.NewLine;
            if (cheeseCheckBox.Checked)
                ordersSummaryTextBox.Text += " Cheese" + Environment.NewLine;

            ordersSummaryTextBox.Text += "Total Price: " + String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", collectedPrice + tax) + Environment.NewLine;
        }

        /// <summary>
        /// Method the clear the orderSummary portion and textBox for the Customer information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearInformationButton_Click(object sender, EventArgs e)
        {
            // set the textBoxes to empty string
            orderNumberTextBox.Text = string.Empty;
            customerNameTextBox.Text = string.Empty;
            phoneNumberTextBox.Text = string.Empty;
            deliveryAddressTextBox.Text = string.Empty;
            ordersSummaryTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Method the clear Pizza order portion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            // reset the comboboxes
            pizzaShopComboBox.ResetText();
            pizzaTypeComboBox.ResetText();

            // clear itemsListBox
            itemsListBox.Items.Clear();
            // set itemPrice to 0
            itemPrice.Text = "$0.00";

            // set Grand total to 0
            totalTextBox.Text = String.Format("Grand Total: {0,66:C2}", "$0.00");

            // uncheck all the checkbox and setting them to false
            peppersCheckBox.Checked = false;
            pepperoniCheckBox.Checked = false;
            hamCheckBox.Checked = false;
            sausageCheckBox.Checked = false;
            mushroomsCheckBox.Checked = false;
            pineappleCheckBox.Checked = false;
            peppersCheckBox.Checked = false;
            olivesCheckBox.Checked = false;
            onionsCheckBox.Checked = false;
            cheeseCheckBox.Checked = false;
        }

        /// <summary>
        /// method works when the form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // seting totalTetBox text 
            totalTextBox.Text = String.Format("Grand Total: {0,66:C2}", "$0.00");
        }

        /// <summary>
        /// Method that exit the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // exiting the form
            Application.Exit();
        }

        /// <summary>
        /// Method that clear all the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearAllOrders_Click(object sender, EventArgs e)
        {
            // set textboxes to empty string
            orderNumberTextBox.Text = string.Empty;
            customerNameTextBox.Text = string.Empty;
            phoneNumberTextBox.Text = string.Empty;
            deliveryAddressTextBox.Text = string.Empty;
            ordersSummaryTextBox.Text = string.Empty;

            // clearing comboboxes
            pizzaShopComboBox.ResetText();
            pizzaTypeComboBox.ResetText();

            // clearing the itemsListbox
            itemsListBox.Items.Clear();

            // set itemPrice text ot 0
            itemPrice.Text = "$0.00";

            // seting totalTextBox to 0
            totalTextBox.Text = String.Format("Grand Total: {0,66:C2}", "$0.00");

            // unchecking checkboxes and  seting them to false
            peppersCheckBox.Checked = false;
            pepperoniCheckBox.Checked = false;
            hamCheckBox.Checked = false;
            sausageCheckBox.Checked = false;
            mushroomsCheckBox.Checked = false;
            pineappleCheckBox.Checked = false;
            peppersCheckBox.Checked = false;
            olivesCheckBox.Checked = false;
            onionsCheckBox.Checked = false;
            cheeseCheckBox.Checked = false;
        }

        /// <summary>
        /// Method that determing the change in the boths comboBoxes and determing the price 
        /// depending of the pizza shop and pizza type
        /// </summary>
        public void ComboBoxChange()
        {
            try
            {
                if (pizzaShopComboBox.SelectedItem.Equals("Pizza Pizza"))
                {
                    if (pizzaTypeComboBox.SelectedItem.Equals("Small"))
                        price = smallPizzaPizza;
                    else if (pizzaTypeComboBox.SelectedItem.Equals("Medium"))
                        price = mediumPizzaPizza;
                    else if (pizzaTypeComboBox.SelectedItem.Equals("Large"))
                        price = largePizzaPizza;
                }

                else if (pizzaShopComboBox.SelectedItem.Equals("Dominos"))
                {
                    if (pizzaTypeComboBox.SelectedItem.Equals("Small"))
                        price = smallDominos;
                    else if (pizzaTypeComboBox.SelectedItem.Equals("Medium"))
                        price = mediumDominos;
                    else if (pizzaTypeComboBox.SelectedItem.Equals("Large"))
                        price = largeDominos;
                }

                if (pizzaShopComboBox.SelectedItem.Equals("Pizza Hut"))
                {
                    if (pizzaTypeComboBox.SelectedItem.Equals("Small"))
                        price = smallPizzaHut;
                    else if (pizzaTypeComboBox.SelectedItem.Equals("Medium"))
                        price = mediumPizzaHut;
                    else if (pizzaTypeComboBox.SelectedItem.Equals("Large"))
                        price = largePizzaHut;
                }
                collectedPrice = price + Total;
                itemPrice.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", collectedPrice);
            }
            catch (Exception)
            {

            }
        }
    }
}
