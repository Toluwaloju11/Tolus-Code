using Dec2018MSTestFramework.ComponentHelper;
using Dec2018MSTestFramework.Settings;
using OpenQA.Selenium;

namespace Dec2018MSTestFramework.Pages
{
    public class MacPage
    {
        public MacPage()
        {
        }
        #region WebElements

        private readonly By _sortByOption = By.Id("input-sort"); 
        private readonly By _sortByRange = By.Id("input-limit");
        private readonly By _addToCart = By.CssSelector("#content > div:nth-child(3) > div > div > div:nth-child(2) > div.button-group > button:nth-child(1) > span");
        private readonly By _shoppingCartButton = By.Id("cart-total");
        #endregion

        #region Actions
        public void SelectMacByOption()
        {
            DropDownHelper.SelectElementByIndex(_sortByOption,3);

        }
        public void DisplayLimit()
        {

            DropDownHelper.SelectElementByIndex(_sortByRange, 3);
        }
        public void AddToShoppingCart()
        {

            ButtonHelper.ClickButton(_addToCart);
        }
        public void ShoppingCart()
        {

            ButtonHelper.ClickButton(_shoppingCartButton);
        }
        #endregion

        public MacPage AddItemsToBasket()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetWebsite());
            SelectMacByOption();
            DisplayLimit();
            AddItemsToBasket();
            ShoppingCart();
            return new MacPage();
        }
        #region Navigation

        #endregion
    }
}