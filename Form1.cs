using ItemListView.EventArgs;
using ItemsListViewTestApp.Adapters;
using ItemsListViewTestApp.Entities;
using ItemsListViewTestApp.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ItemsListViewTestApp
{
    public partial class Form1 : Form
    {
        List<Person> person;
        PersonAdapter adapter;
        public Form1()
        {
            InitializeComponent();
            person = new List<Person>();
            person.AddRange(new Person[]
            {
                new Person 
                {
                    CNIC = "XXXXX-XXXXXXX-X",
                    Name = "Person A"
                },
                new Person
                {
                    CNIC = "XXXXX-XXXXXXX-X",
                    Name = "Person B"
                },
                new Person
                {
                    CNIC = "XXXXX-XXXXXXX-X",
                    Name = "Person C"
                }
            });
            adapter = new PersonAdapter(person, new PersonControlHeader());
            // Set adapter to the itemListView, so basically the adapter later on controls what is being displayed on screen
            itemListView1.SetAdapter(adapter);
            itemListView1.SetOnItemClickListener(OnItemClickListener);
            itemListView1.SelectedIndexChanged += ItemListView1_SelectedIndexChanged;
        }

        private void ItemListView1_SelectedIndexChanged(object sender, SelectedIndexChangedEventArgs e)
        {
            MessageBox.Show(e.Index + "");
        }

        public object OnItemClickListener(object sender, OnItemClickEventArgs<Control> e)
        {
            ResetAll();
            ((PersonControl)e.Item).Active = true;
            ((PersonControl)e.Item).BackColor = Color.AliceBlue;
            return null;
        }

        private void ResetAll()
        {
            foreach (var control in this.itemListView1.ListElements)
            {
                if (control.GetType() == typeof(PersonControl)) 
                { 
                    ((PersonControl)control).Active = false;
                    ((PersonControl)control).BackColor = Color.White;
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            person.Add(new Person 
            {
                CNIC = CNICTxtBox.Text,
                Name = NameTxtBox.Text
            });
            adapter.NotifyDataSetChanged();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (itemListView1.SelectedIndex != -1)
            {
                person.RemoveAt(itemListView1.SelectedIndex);
                adapter.NotifyDataSetChanged();
            }
            else
            {
                MessageBox.Show("You must select an index to remove");
            }
        }
    }
}
