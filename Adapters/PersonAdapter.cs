using ItemListView.Adapters;
using ItemListView.EventArgs;
using ItemsListViewTestApp.Entities;
using ItemsListViewTestApp.UserControls;
using System.Collections.Generic;
using System.Drawing;

namespace ItemsListViewTestApp.Adapters
{
    public class PersonAdapter : ListAdapter<PersonControl, Person>
    {
        public PersonAdapter(List<Person> items, PersonControlHeader header) : base(items, header)
        {
        }

        public override PersonControl Draw(PersonControl control, Person item)
        {
            control.PName = item.Name;
            control.Cnic = item.CNIC;

            return control;
        }
    }
}
