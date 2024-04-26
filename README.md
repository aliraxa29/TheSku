<h1 align="center">
  The Sku
  <br>
</h1>

<h4 align="center">An Elegant Accounts & Inventory Management System built with .NET 8 using Windows Forms with EF-Core.</h4>

<!-- <p align="center">
  <a href="https://badge.fury.io/js/electron-markdownify">
    <img src="https://badge.fury.io/js/electron-markdownify.svg"
         alt="Gitter">
  </a>
  <a href="https://gitter.im/amitmerchant1990/electron-markdownify"><img src="https://badges.gitter.im/amitmerchant1990/electron-markdownify.svg"></a>
  <a href="https://saythanks.io/to/bullredeyes@gmail.com">
      <img src="https://img.shields.io/badge/SayThanks.io-%E2%98%BC-1EAEDB.svg">
  </a>
  <a href="https://www.paypal.me/AmitMerchant">
    <img src="https://img.shields.io/badge/$-donate-ff69b4.svg?maxAge=2592000&amp;style=flat">
  </a>
</p> -->

<p align="center">
  <a href="#key-features">Key Features</a> •
  <a href="#how-to-use">How To Use</a> •
  <a href="#license">License</a>
</p>

## Key Features

### Accounting
  * Payment Entry
  * Journal Entry
  * General Ledger
  * Chart Of Accounts
  * Accounts Receivable
  * Accounts Payable
  * Company
  * Accounts Settings
  * Finance Book
  * Payment Term
  * Sales Invoice
  * Purchase Invoice
  * Customer
  * Payment Request
  * Payment Reconciliation
  * Supplier
  * Cost Centers
  * & Much More

### Stock Management
  * Item
  * Item Group
  * Supplier Group
  * Stock Ledger
  * Stock Reconciliation (Stock Adjustment)
  * Item Price
  * Price List
  * **POS Terminal**
  * & Much More

## How To Use

To clone and run this application, you'll need [Git](https://git-scm.com) installed on your computer. From your command line:

```bash
# Clone this repository
$ git clone https://github.com/aliraxa29/TheSku.git

# Go into the repository
$ cd TheSku

# Change the configuration in App.config file like connectionstring.
    <connectionStrings>
        <add name="ConString" connectionString="Server=localhost;Database=thesku;user=root;Password=aliraxa229;Port=3307;" />
    </connectionStrings>

# Create migrations or use existing migrations of the application. For creating, use this command
$ dotnet ef add migrations InitialCreate --project TheSku

# For using existing, use this command
$ dotnet ef database update --project TheSku
```

After that, just build the project to get executeables for the development.

> **Note**
> This application uses **MariaDB** or **MySql** as backend server. So be sure, you have installed one of them.

## Support

<a href="https://www.buymeacoffee.com/aliraxa29" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/purple_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>

<p>Or</p> 

<a href="https://patreon.com/aliraxa">
	<img src="https://c5.patreon.com/external/logo/become_a_patron_button@2x.png" width="160">
</a>

## License

MIT

---

> YouTube [@codingwithraxa](https://www.youtube.com/@codingwithraxa) &nbsp;&middot;&nbsp;


