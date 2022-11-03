namespace Restaurant.ViewModels
{
    public class ViewModelLocator
    {
        public ItemViewModel ItemViewModel
        {
            get { return IocKernel.Get<ItemViewModel>(); }
        }
    }
}
