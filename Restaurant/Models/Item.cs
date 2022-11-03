using Restaurant.ViewModels.Base;

namespace Restaurant.Models
{
    public class Item : BaseModel
    {
        private string id;
        private string name;
        private decimal price;
        private bool active;

        public string ID
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(id));
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged(nameof(price));
            }
        }

        public bool Active
        {
            get { return active; }
            set
            {
                active = value;
                OnPropertyChanged(nameof(active));
            }
        }

    }
}
