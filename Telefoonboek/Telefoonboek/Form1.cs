namespace Telefoonboek
{
    public partial class Form1 : Form
    { 
        private List<String> persons = new List<string>() { "Harry Willems", "Frits Joosten", "Karin Rozen", "Joost de Groot" };
        private List<String> searchResults = new List<string>();

        private List<Person> classedPersons = new List<Person>()    {   
                                                                        new Person("Harry", "Willems", new DateTime(2001, 02, 07), "0682371302", "harrywillems@gmail.com"),
                                                                        new Person("Frits", "Joosten", new DateTime(1997, 07, 21), "0612398212", "frits.joosten@kpnplanet.nl"),
                                                                        new Person("Karin", "Rozen", new DateTime(1967, 10, 31), "0698203477", "krozen1@hotmail.com"),
                                                                        new Person("Joost", "de Groot", new DateTime(2004, 03, 11), "0692384445", "halloikheetjoost@gmail.com")
                                                                    };
        private List<Person> classedSearchResults = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------
        //THIS IS ALL TAB 1 -------------------------------------------------------
        //-------------------------------------------------------------------------

        //BUTTONS || methods are ran when the associated button is clicked

        //checks if the name of a person is already in the ListBox. 
        //if this is not the case, a string with the name of the person is added to the listBox.
        private void showPersonButton_Click(object sender, EventArgs e)
        {
            
            foreach (String s in persons)
            {
                if (!listBox1.Items.Contains(s))
                {
                    listBox1.Items.Add(s);
                }
            }
        }


        //clears the ListBox.
        private void clearPersonButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }


        //first adds a string with a name to the List with strings.
        //then adds that same string to the ListBox.
        //lastly, clears the textbox that contains the name of the added person.
        private void addPerson_Click(object sender, EventArgs e)
        {
            persons.Add(addPersonBox1.Text);
            listBox1.Items.Add(addPersonBox1.Text);
            addPersonBox1.Clear();
        }


        //TEXTBOXES

        //method to display different items in the ListBox depending on if they exist in the List with strings.
        private void searchBox1_TextChanged(object sender, EventArgs e)
        {
            //firstly clears both the List containing search results and the ListBox to ensure
            //no wrong results can be displayed.
            searchResults.Clear();
            listBox1.Items.Clear();


            //check to see if the SearchBox is empty or not.
            //if the SearchBox is empty, every existing string in the List with strings is re-added to the ListBox.
            if (!string.IsNullOrEmpty(searchBox1.Text))
            {
                //the names of the persons are first converted to all lowercase, making the results non-case-sensitive.
                foreach (String s in persons)
                {
                    String tempName = s.ToLowerInvariant();

                    //if any results are found in the List with strings, those results are added to a List with search results.
                    if (tempName.StartsWith(searchBox1.Text))
                    {
                        searchResults.Add(s);
                    }
                }
                
                //each result in the List with search results is now added to the ListBox.
                foreach (String s in searchResults)
                {
                    listBox1.Items.Add(s);
                }
            }

            //like stated above, if the search box is empty, all existing strings in the List with strings are re-added to the ListBox.
            else
            {
                foreach (String s in persons)
                {
                    if (!listBox1.Items.Contains(s))
                    {
                        listBox1.Items.Add(s);
                    }
                }
            }
        }
        //currently does nothing
        private void addPersonBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //LISTBOX

        //currently does nothing
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //-------------------------------------------------------------------------
        //THIS IS ALL TAB 2 -------------------------------------------------------
        //-------------------------------------------------------------------------

        //BUTTONS

        //when the associated button is clicked, for every Person that 1. exists in the List with Persons and 2. has an
        //"isInList" boolean with a value of false, the ShowPersonInListView method is called.
        private void showClassedPersonButton_Click(object sender, EventArgs e)
        {
            foreach (Person p in classedPersons)
            {
                if (!p.isInList)
                {
                    ShowPersonInListView(p, listView1);
                }
            }
        }

        //when the associated button is clicked, the RemovePersonFromListView method is called.
        private void clearClassedPersonButton_Click(object sender, EventArgs e)
        {
            RemovePersonFromListView(listView1, classedPersons);
        }


        //when the associated button is clicked, this method first checks if none of the required textboxes are empty.
        private void addClassedPerson_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(classedPersonName.Text) &&
                !String.IsNullOrEmpty(classedPersonSurname.Text) &&
                !String.IsNullOrEmpty(classedPersonMailAddress.Text) &&
                !String.IsNullOrEmpty(classedPersonPhoneNumber.Text)
                )
            {
                //if none of these textboxes are empty, a new Person is made with the values stored in those textboxes.
                Person p = new Person   (  
                                            classedPersonName.Text, 
                                            classedPersonSurname.Text, 
                                            dateOfBirthClassed.Value, 
                                            classedPersonPhoneNumber.Text, 
                                            classedPersonMailAddress.Text
                                        );
                //after a new Person is made, a string array with the values from that Person is also made to add the 
                //values stored in that Person to the ListView.
                String[] personDetails =    { 
                                                Convert.ToString(p.id),
                                                p.name, 
                                                p.surname, 
                                                Convert.ToString(p.dateOfBirth),
                                                p.phoneNumber,
                                                p.mailAddress                                              
                                            };

                //here, the following happens:
                //1. a new ListViewItem is made.
                //2. the newly made Person is added to the List with Persons called classedPersons.
                //3. the newly made ListViewItem is added to the ListView.
                //4. the boolean isInList belonging to that newly made Person is set to true.
                ListViewItem lvi = new ListViewItem(personDetails);
                classedPersons.Add(p);
                listView1.Items.Add(lvi);
                p.isInList = true;

                //all the textboxes where a user could fill in the details of a new Person are then cleared to their original
                //values. in this case, that means the textboxes return to empty.
                classedPersonName.ResetText();
                classedPersonSurname.ResetText();
                dateOfBirthClassed.ResetText();
                classedPersonPhoneNumber.ResetText();
                classedPersonMailAddress.ResetText();
            }
        }

        //when the associated button is clicked, if an item is selected the findPerson method is ran with the Person's ID
        //as an argument. that ID is first converted from a string to an int. the found Person is then removed from the
        //List with Persons. 
        //then, the selected item is removed from the ListView.
        private void removeCPerson_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            { 
                classedPersons.Remove(findPerson(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text)));
                listView1.SelectedItems[0].Remove();
            }
        }

        //when the associated button is clicked, if an item is selected, the findPerson method is ran with the
        //Person's ID as an argument. from this point, the found Person is referenced in selectedPerson.
        private void editSelectedButton_Click(object sender, EventArgs e)
        { 
            if (listView1.SelectedItems.Count > 0) {
                Person selectedPerson = findPerson(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                //this is a really simple check to make one button do two things depending on the button's text.
                if (editSelectedButton.Text == "Edit Selected")
                {
                    //if the button's text is "Edit Selected", the ListView will first be disabled.
                    //then, the button's text is changed to "Save Selected".
                    //the textboxes that are usually used to type text to use as attributes for a new person are now
                    //filled with the attributes of the already existing person.
                    listView1.Enabled = false;
                    editSelectedButton.Text = "Save Selected";
                    classedPersonName.Text = selectedPerson.name;
                    classedPersonSurname.Text = selectedPerson.surname;
                    dateOfBirthClassed.Value = Convert.ToDateTime(Convert.ToString(selectedPerson.dateOfBirth));
                    classedPersonMailAddress.Text = selectedPerson.mailAddress;
                    classedPersonPhoneNumber.Text = selectedPerson.phoneNumber;
                }
                else if (editSelectedButton.Text == "Save Selected")
                {
                    //if the button's text is "Save Selected", the attributes of the person referenced in selectedPerson
                    //are changed to whatever is currently in those textboxes.                      
                    selectedPerson.name = classedPersonName.Text;
                    selectedPerson.surname = classedPersonSurname.Text;
                    selectedPerson.dateOfBirth = DateOnly.FromDateTime(dateOfBirthClassed.Value);
                    selectedPerson.mailAddress = classedPersonMailAddress.Text;
                    selectedPerson.phoneNumber = classedPersonPhoneNumber.Text;

                    //the strings in the ListView will be updated to reflect the current values stored in the
                    //Person referenced by SelectedPerson.
                    listView1.SelectedItems[0].SubItems[1].Text = selectedPerson.name;
                    listView1.SelectedItems[0].SubItems[2].Text = selectedPerson.surname;
                    listView1.SelectedItems[0].SubItems[3].Text = Convert.ToString(selectedPerson.dateOfBirth);
                    listView1.SelectedItems[0].SubItems[4].Text = selectedPerson.mailAddress;
                    listView1.SelectedItems[0].SubItems[5].Text = selectedPerson.phoneNumber;

                    //the text in the textboxes will be reset to their original values. in this case, that means the
                    //textboxes will be empty.
                    classedPersonName.ResetText();
                    classedPersonSurname.ResetText();
                    dateOfBirthClassed.ResetText();
                    classedPersonPhoneNumber.ResetText();
                    classedPersonMailAddress.ResetText();

                    //lastly, the text of the button is set to "Edit Selected" and the ListView is re-enabled.
                    editSelectedButton.Text = "Edit Selected";
                    listView1.Enabled = true;
                } 
                //this only exists to ensure the program won't behave in an unexpected way if the button contains different text.
                else
                {
                    editSelectedButton.Text = "Edit Selected";

                    classedPersonName.ResetText();
                    classedPersonSurname.ResetText();
                    dateOfBirthClassed.ResetText();
                    classedPersonPhoneNumber.ResetText();
                    classedPersonMailAddress.ResetText();

                    listView1.Enabled = true;
                }
            }
        }


        //TEXTBOXES

        //this searchbox functions in a way to include every single matching ListViewItem that contains the searched string.
        private void searchBox2_TextChanged(object sender, EventArgs e)
        {
            //just like before, the ListView is cleared of any ListViewItems currently in there.
            String s = searchBox2.Text;
            listView1.Items.Clear();

            //the same check from earlier is performed: is the textbox empty or not?
            //if the textbox is empty, every single ListViewItem is re-added to the ListView.
            if (!string.IsNullOrEmpty(searchBox2.Text))
            {
                foreach (Person p in classedPersons)
                {
                    //each Person in classedPersons has their isInList boolean set to false.
                    //then, for each attribute (except ID) a user has, this if will check if any attribute has a value
                    //that corresponds with what is in the textbox.
                    //every Person that has any corresponding attribute will then be re-added to the ListView.
                    p.isInList = false;
                    if (p.name.ToLowerInvariant().Contains(s) || p.surname.ToLowerInvariant().Contains(s) || Convert.ToString(p.dateOfBirth).Contains(s)  || p.mailAddress.ToLowerInvariant().Contains(s) || p.phoneNumber.ToLowerInvariant().Contains(s))
                    {
                        ShowPersonInListView(p, listView1);
                    }
                }
            } 
            else
            {
                //if the textbox is empty, all Persons in classedPersons will be re-added to the ListView.
                foreach (Person p in classedPersons)
                {
                    ShowPersonInListView(p, listView1);
                }
            }
        }

        //this currently does nothing.
        private void classedPersonName_TextChanged(object sender, EventArgs e)
        {

        }

        //this currently does nothing.
        private void classedPersonSurname_TextChanged(object sender, EventArgs e)
        {

        }

        //this currently does nothing.
        private void dateOfBirthClassed_ValueChanged(object sender, EventArgs e)
        {

        }

        //this currently does nothing.
        private void classedPersonPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        //this currently does nothing.
        private void classedPersonMailAddress_TextChanged(object sender, EventArgs e)
        {

        }


        //LISTVIEW

        //this currently does nothing.
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //GENERAL FUNCTIONS

        //this method is called whenever a Person has to be added to a ListView.
        public void ShowPersonInListView(Person p, ListView lv)
        {
            //a string array containing all values of a Persons's attributes. this is then used to create a ListViewItem.
            //this ListViewItem is then used to add those values to the ListView. isInList for the Person in question is
            //then set to true.
            String[] personDetails = { Convert.ToString(p.id), p.name, p.surname, Convert.ToString(p.dateOfBirth), p.mailAddress, p.phoneNumber };
            ListViewItem lvi = new ListViewItem(personDetails);
            lv.Items.Add(lvi);
            p.isInList = true;
        }

        //this method is used to remove all ListViewItems from a given ListView. then, for all Persons in a list of Persons,
        //the boolean isInList is set to false.
        public void RemovePersonFromListView(ListView lv, List<Person> lp)
        {
            lv.Items.Clear();

            foreach (Person p in lp)
            {
                p.isInList = false;
            }
        }

        //this method uses a lambda function to find a Person and, if a Person with that ID exists, return a
        //reference to that Person. 
        public Person findPerson(int personID)
        {
            if(classedPersons.Find(p => p.id == personID) != null)
            {
                return classedPersons.Find(p => p.id == personID);
            }
            else
            {
                return null;
            }
        }
    }
}