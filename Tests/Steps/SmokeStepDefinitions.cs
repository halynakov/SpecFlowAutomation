using Final_Task.Base;
using Final_Task.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Tests.Steps
{
    [Binding]
    public class SmokeStepDefinitions
    {

        [Given(@"User opens Amazon page")]
        public void OpenMainPage()
        {
            HomePage.Instance.OpenHomePage();
        }

        [When(@"User makes search by product name '([^']*)'")]
        public void MakeSearchByName(string name)
        {
            HomePage.Instance.EnterSearchInputButton(name);
            HomePage.Instance.ClickSearchButton();
        }

        [Then(@"User checks that the first item in the list has name '([^']*)'")]
        public void CheckTheFirstItem(string expected_name)
        {
            Assert.AreEqual(expected_name, SearchResultsPage.Instance.GetFirstSearchResult());
        }
        [Given(@"User clicks on '([^']*)' section")]
        public void ClickOnItemSection(string section)
        {
            HomePage.Instance.ClickSectionButton();
        }

        [Given(@"User goes to '([^']*)' product page")]
        public void GoToProductPage(string item)
        {
            ProductsSectionPage.Instance.ClickItemButton();
        }

        [When(@"User adds product to the cart")]
        public void AddProductToTheCart()
        {
            ItemPage.Instance.AddToCart();
        }

        [Then(@"Number of items in the cart is '([^']*)'")]
        public void CheckNumberOfItemsInCart(string expected_amount)
        {
            Assert.That(ItemPage.Instance.GetAmountOfItemsInCart() == expected_amount);
        }
        [Given(@"User clicks on Location button")]
        public void ClickOnLocationButton()
        {
            HomePage.Instance.ClickLocationButton();
        }

        [When(@"User changes location to '([^']*)' country")]
        public void ChangeLocationToCountry(string country)
        {
            HomePage.Instance.ChangeLocationButton();
            HomePage.Instance.ClickDoneButton();
        }

        [Then(@"Location changes to '([^']*)' country")]
        public void CheckLocationChanges(string new_country)
        {
            Assert.IsTrue(HomePage.Instance.GetLocation() == new_country);
        }


        [Then(@"Section is translated into '([^']*)'")]
        public void CheckPageIsTranslated(string expected_section)
        {
            Assert.That(HomePage.Instance.GetSectionName(), Is.EqualTo(expected_section));
        }
        [Given(@"User hovers on Language button")]
        public void HoversOnLanguageButton()
        {
            HomePage.Instance.HoverLanguageButton();
        }

        [When(@"User changes language to '([^']*)'")]
        public void ChangeLanguageTo(string language)
        {
            HomePage.Instance.ClickLanguageButton();
        }
        [Given(@"User clicks on '([^']*)' category")]
        public void ClickOnCategory(string category)
        {
            HomePage.Instance.ClickOnCategory();
        }

        [When(@"User does filtering by '([^']*)' brand")]
        public void FilteringByBrand(string brand)
        {
            ProductsCategoryPage.Instance.FilteringByBrand();
        }

        [Then(@"Brand products are displayed on '([^']*)' page")]
        public void CheckThenBrandProductsAreDisplayed(string brand)
        {
            Assert.IsTrue(FilteringResultsPage.Instance.GetProductName().Contains(brand));
        }

        [Given(@"User clicks on All dropdown menu")]
        public void ClickDropdownMenu()
        {
            HomePage.Instance.ClickDropdownMenu();
        }

        [Given(@"User clicks SignIn button")]
        public void ClickSignInButton()
        {
            HomePage.Instance.ClickSignInButton();
        }

        [When(@"User leaves all fields empty")]
        public void ClickContinueButton()
        {
            SignInPage.Instance.ClickContinueButton();
        }

        [Then(@"Entry is denied by warning")]
        public void CheckEntryIsDenied()
        {
            Assert.IsTrue(SignInPage.Instance.GetMessage().Contains("Enter"));
        }
        [When(@"User clicks on '([^']*)' section")]
        public void ClickOnSection(string headsets)
        {
            HomePage.Instance.ClickSectionButton();
        }

        [Then(@"Page with the '([^']*)' title is opened")]
        public void CheckPageIsOpened(string expected_title)
        {
            Assert.AreEqual(expected_title, ProductsSectionPage.Instance.GetSectionName());
        }

        [When(@"User goes to the cart")]
        public void GoToTheCart()
        {
            ItemPage.Instance.GoToTheCart();
        }

        [When(@"User increases quantity of goods")]
        public void IncreaseQuantityOfGoods()
        {
            CartPage.Instance.ClickOnQtyButton();
            CartPage.Instance.ChangeAmountOfGoods();
        }

        [Then(@"The order price in the cart is '([^']*)'")]
        public void CheckOrderPrice(string expected_price)
        {
            Assert.That(CartPage.Instance.GetActualCart(), Is.EqualTo(expected_price));
        }

        [Given(@"User adds product to the cart")]
        public void AddProductsToTheCart()
        {
            ItemPage.Instance.AddToCart();
        }

        [When(@"User click on '([^']*)' button")]
        public void ClickOnDeleteButton(string delete)
        {
            CartPage.Instance.ClickOnDeleteButton();
        }

        [Then(@"Cart is empty")]
        public void CheckThatTheCartIsEmpty()
        {
            Assert.IsTrue(CartPage.Instance.GetTitle().Contains("Cart is empty"));
        }

        [When(@"User enters minimal price as '([^']*)'")]
        public void EnterMinPrice(string min_price)
        {
            ProductsSectionPage.Instance.EnterMinPrice(min_price);
        }

        [When(@"User enters maximal price as '([^']*)'")]
        public void EnterMaxPrice(string max_price)
        {
            ProductsSectionPage.Instance.EnterMaxPrice(max_price);
        }

        [When(@"User clicks on '([^']*)' button")]
        public void ClickOnGoButton(string go)
        {
            ProductsSectionPage.Instance.ClickOnGoButton();
        }

        [Then(@"The item price is between '([^']*)' and '([^']*)'")]
        public void CheckFilteringByPrice(string min, string max)
        {
            Assert.That(FilteringResultsPage.Instance.GetProductPrice(), Is.GreaterThanOrEqualTo(min));
        }


        [AfterTestRun]
        public static void AfterTestRun()
        {   
            DriverManager.QuitDriver();
        }
    }
}
