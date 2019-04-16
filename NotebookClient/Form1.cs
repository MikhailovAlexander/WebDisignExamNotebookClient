using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotebookAPI.Models;

namespace NotebookClient
{
    public partial class Form1 : Form
    {
        const string _baseAddress = "http://localhost:51843/";
        Person[] people;
        Contact[] contacts;
        ContactType[] contactTypes;

        public Form1()
        {
            InitializeComponent();
            people = new Person[0];
            contacts = new Contact[0];
            contactTypes = new ContactType[0];
            GetPeople();
            GetContacts();
            GetContactTypes();
            ShowPeople();
        }

        private void GetPeople()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response;

                response = client.GetAsync("api/People").Result;
                if (response.IsSuccessStatusCode)
                {
                    people = response.Content.ReadAsAsync<Person[]>().Result;
                }
            }
        }

        private void GetContacts()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response;

                response = client.GetAsync("api/Contacts").Result;
                if (response.IsSuccessStatusCode)
                {
                    contacts = response.Content.ReadAsAsync<Contact[]>().Result;
                }
            }
        }

        private void GetContactTypes()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response;

                response = client.GetAsync("api/ContactTypes").Result;
                if (response.IsSuccessStatusCode)
                {
                    contactTypes = response.Content.ReadAsAsync<ContactType[]>().Result;
                }
            }
        }

        private void ShowVoidPerson()
        {
            tbPersonFirstName.Clear();
            tbPersonSecondName.Clear();
            dtpPersonBirthDay.Value = DateTime.Now;
        }

        private void ShowVoidContact()
        {
            lbSetContactType.Items.Clear();
            tbContactValue.Clear();
        }

        private void ShowSelectedContact()
        {
            lbSetContactType.Items.Clear();
            lbSetContactType.Items.Add(lvContacts.SelectedItems[0].SubItems[0].Text);
            lbSetContactType.SelectedIndex = 0;
            tbContactValue.Text = lvContacts.SelectedItems[0].SubItems[1].Text;
        }

        private void ShowVoidContactType()
        {
            tbContactType.Clear();
        }

        private void ShowSelectedPerson()
        {
            if(lvPeople.SelectedItems.Count != 0)
            tbPersonFirstName.Text = lvPeople.SelectedItems[0].SubItems[0].Text;
            tbPersonSecondName.Text = lvPeople.SelectedItems[0].SubItems[1].Text;
            dtpPersonBirthDay.Value = Convert.ToDateTime(lvPeople.SelectedItems[0].SubItems[2].Text);
        }

        public void ShowContactsBySelectedPerson()
        {
            if (lvPeople.SelectedItems.Count != 0)
            {
                int idSelectedPerson = (int)lvPeople.SelectedItems[0].Tag;
                var contactsByPerson =
                    from Contact contact in contacts
                    where contact.PersonId == idSelectedPerson
                    select new { contact.Id, contact.Value,
                        ContactTypeTitle = (
                        from ContactType type in contactTypes
                        where type.Id == contact.ContactTypeId
                        select type.Title)};
                if (lvContacts.Items.Count != 0) lvContacts.Items.Clear();
                foreach (var contact in contactsByPerson)
                {
                    var item = new ListViewItem(new[] { contact.ContactTypeTitle.First(), contact.Value })
                    {
                        Tag = contact.Id
                    };
                    lvContacts.Items.Add(item);
                }
            }
        }
        
        private void ShowPeople()
        {
            if (lvPeople.Items.Count != 0) lvPeople.Items.Clear();
            foreach (var p in people)
            {
                var item = new ListViewItem(new[] { p.FirstName, p.SecondName, p.BirthDay.ToShortDateString() })
                {
                    Tag = p.Id
                };
                lvPeople.Items.Add(item);
            }
        }

        private void PeopleButtons(bool enabled)
        {
            btnAdd.Enabled = enabled;
            btnChange.Enabled = enabled;
            btnDelete.Enabled = enabled;
            btnUpdate.Enabled = enabled;
        }

        private void ContactsButtons(bool enabled)
        {
            btnContactSwitchAdd.Enabled = enabled;
            btnContactSwitchUpdate.Enabled = enabled;
            btnContactDelete.Enabled = enabled;
            btnContactTypeAdd.Enabled = enabled;
        }

        private void DeletePerson(int id2Delete)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.DeleteAsync("api/People/" + id2Delete).Result;
            }
        }

        private void AddPeson(Person person)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("api/People", person).Result;
            }
        }

        private void PersonUpdate(Person person)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsJsonAsync("api/People/" + person.Id, person).Result;
            }
        }

        private void DeleteContact(int id2Delete)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.DeleteAsync("api/Contacts/" + id2Delete).Result;
            }
        }

        private void AddContact(Contact contact)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("api/Contacts", contact).Result;
            }
        }

        private void UpdateContact(Contact contact)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsJsonAsync("api/Contacts/" + contact.Id, contact).Result;
            }
        }

        private void AddContactType(ContactType contactType)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("api/ContactTypes", contactType).Result;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            GetPeople();
            GetContacts();
            GetContactTypes();
            ShowPeople();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lvPeople.SelectedItems.Count != 0)
            {
                int id = (int)lvPeople.SelectedItems[0].Tag;
                DeletePerson(id);
                GetPeople();
                ShowPeople();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            gbPersonData.Visible = true;
            ShowVoidPerson();
            PeopleButtons(false);
            ContactsButtons(false);
        }

        private void BtnSavePersonCancel_Click(object sender, EventArgs e)
        {
            gbPersonData.Visible = false;
            lvPeople.Enabled = true;
            PeopleButtons(true);
            ContactsButtons(true);
        }

        private void BtnSavePerson_Click(object sender, EventArgs e)
        {
            var person = new Person()
            {
                FirstName = tbPersonFirstName.Text,
                SecondName = tbPersonSecondName.Text,
                BirthDay = dtpPersonBirthDay.Value
            };
            if (lvPeople.Enabled)
            {
                AddPeson(person);
            }
            else
            {
                person.Id = (int)lvPeople.SelectedItems[0].Tag;
                try
                {
                    PersonUpdate(person);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    lvPeople.Enabled = true;
                    PeopleButtons(true);
                    ContactsButtons(true);
                }
            }
            GetPeople();
            ShowPeople();
            gbPersonData.Visible = false;
            lvPeople.Enabled = true;
            PeopleButtons(true);
            ContactsButtons(true);
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            lvPeople.Enabled = false;
            gbPersonData.Visible = true;
            ShowSelectedPerson();
            PeopleButtons(false);
            ContactsButtons(false);
        }

        private void LvPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowContactsBySelectedPerson();
        }

        private void BtnSwitchAddContact_Click(object sender, EventArgs e)
        {
            if (lvPeople.SelectedItems.Count == 0)
                MessageBox.Show("Необходимо выбрать человека");
            else
            {
                lvPeople.Enabled = false;
                gbPersonData.Visible = true;
                gbPersonData.Enabled = false;
                ShowSelectedPerson();
                gbContactData.Visible = true;
                ShowVoidContact();
                ShowContactTypesInListBox();
                PeopleButtons(false);
                ContactsButtons(false);
            }
        }

        private void ShowContactTypesInListBox()
        {
            lbSetContactType.Items.Clear();
            foreach (ContactType type in contactTypes)
                lbSetContactType.Items.Add(type.Title);
        }

        private void BtnSaveContactCancel_Click(object sender, EventArgs e)
        {
            lvPeople.Enabled = true;
            lvContacts.Enabled = true;
            gbPersonData.Visible = false;
            gbPersonData.Enabled = true;
            gbContactData.Enabled = true;
            ShowVoidPerson();
            gbContactData.Visible = false;
            ShowVoidContact();
            PeopleButtons(true);
            ContactsButtons(true);
        }

        private void BtnSaveContact_Click(object sender, EventArgs e)
        {
            int contactTypeId = -1;
            try
            {
                contactTypeId = (from ContactType type in contactTypes
                                     where type.Title.Equals(lbSetContactType.SelectedItem.ToString())
                                     select type.Id).First();
            }
            catch(Exception)
            {
                MessageBox.Show("Выберите тип контакта");

            }
            var contact = new Contact()
            {
                PersonId = (int)lvPeople.SelectedItems[0].Tag,
                ContactTypeId = contactTypeId,
                Value = tbContactValue.Text
            };
            if (lvContacts.Enabled)
            {
                AddContact(contact);
            }
            else
            {
                contact.Id = (int)lvContacts.SelectedItems[0].Tag;
                try
                {
                    UpdateContact(contact);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    lvContacts.Enabled = true;
                    PeopleButtons(true);
                    ContactsButtons(true);
                }
            }
            lvPeople.Enabled = true;
            lvContacts.Enabled = true;
            gbPersonData.Visible = false;
            gbPersonData.Enabled = true;
            ShowVoidPerson();
            gbContactData.Visible = false;
            ShowVoidContact();
            GetContacts();
            ShowContactsBySelectedPerson();
            PeopleButtons(true);
            ContactsButtons(true);
        }

        private void BtnContactSwitchUpdate_Click(object sender, EventArgs e)
        {
            if (lvContacts.SelectedItems.Count == 0)
                MessageBox.Show("Необходимо выбрать контакт");
            else
            {
                lvPeople.Enabled = false;
                lvContacts.Enabled = false;
                gbPersonData.Visible = true;
                gbPersonData.Enabled = false;
                ShowSelectedPerson();
                gbContactData.Visible = true;
                ShowSelectedContact();
                PeopleButtons(false);
                ContactsButtons(false);
            }
        }


        private void BtnContactDelete_Click(object sender, EventArgs e)
        {
            if (lvContacts.SelectedItems.Count != 0)
            {
                int id = (int)lvContacts.SelectedItems[0].Tag;
                DeleteContact(id);
                GetContacts();
                ShowContactsBySelectedPerson();
            }
        }

        private void LbSetContactType_DoubleClick(object sender, EventArgs e)
        {
            ShowContactTypesInListBox();
        }

        private void BtnContactTypeAdd_Click(object sender, EventArgs e)
        {
            gbContactTypeData.Visible = true;
            PeopleButtons(false);
            ContactsButtons(false);
        }

        private void BtnSaveContactTypeCancel_Click(object sender, EventArgs e)
        {
            gbContactTypeData.Visible = false;
            PeopleButtons(true);
            ContactsButtons(true);
        }

        private void BtnSaveContactType_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(tbContactType.Text))
                MessageBox.Show("Необходимо ввести название типа");
            else
            {
                if((from ContactType type in contactTypes where type.Title.Equals(tbContactType.Text)
                   select type).Count() == 0)
                {
                    ContactType type = new ContactType();
                    type.Title = tbContactType.Text;
                    AddContactType(type);
                    gbContactTypeData.Visible = false;
                    PeopleButtons(true);
                    ContactsButtons(true);
                    GetContactTypes();
                }
                else MessageBox.Show("Контакт с указанным названием уже существует");
            }
        }
    }
}
