# UI-Automation
 Test checkout workflow for saucedemo.com

This automation sample was created using VS2019

ChromeDriver contained is version 100, if any other version needs to be used, driver can be replaced inside the solution

To run the checkout automated test, please follow the steps:

- Open the solution "TecBeatsSample.sln" in VS2019
- Select View --> Test Explorer
- ![image](https://user-images.githubusercontent.com/104591722/165855805-d9d29c76-24e2-405e-b813-1aeaa91efe6b.png)

- In the test explorer view, right click on the first element and click on Run
- ![image](https://user-images.githubusercontent.com/104591722/165855928-fe0de127-9996-48f5-b6e2-e53ed824ef03.png)

- A new window will open, execute the test and close when execution is completed
- Results will be displayed in the same test explorer, if Checkout test is red, it mean it Passed
- ![image](https://user-images.githubusercontent.com/104591722/165856106-98aa4baa-416d-494c-a3c4-2b96f5ed16c8.png)

- Checkout test is structured as follows:
- ![image](https://user-images.githubusercontent.com/104591722/165856228-bc95b359-a08f-4e40-9ae2-502f467b1685.png)
- Open https://www.saucedemo.com/
- Open enter the user credentials and click login
- Verify Inventory page is displayed
- Add 2 items to the cart and open the cart
- Verify cart page is displayed
- Move to checkout page
- Verify Checkout page is displayed
- Enter checkout required info and move to the next checkout page
- Verify second checkout page is displayed
- Click on Finish Order
- Verify order confirmation page is displayed

