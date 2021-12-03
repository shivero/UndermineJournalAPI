# Undermine Journal WoW Auction House Web API .NET Core

.NET Core Web API that leverage Newswire public MySQL Database provided by Undermine Journal. Newswire Database provide live auction house data for World of Warcraft via Blizzard API. 

This project aims get data directly from Newswire DB via Entity Framework Core and make it available through REST API endpoints, which then will be consumed by [React Next.js App](https://github.com/shivero/React-Undermine-Journal-App-Next.js).

**As of 21 November 2021 Newswire public database has been discountined, so host newswire.theunderminejournal.com is not available anymore**

## :rocket: Getting started
Open `UndermineJournalAPI.sln` in Visual Studio, run & build project. Host address is `http://localhost:44913`.
By default browser page will not start automatically on project run - if you want to alter this behaviour, right click project, select properties => Debug and check "Launch Browser" option)

## :wrench: Configuration
1. API allows request from http://localhost:3000 (url of React Next.js App) by enabling cors policy defined in `Startup.cs` via **ApiCorsPolicy**
2. Swagger API docs page are *disabled* by default
3. Database models are mapped to Data Models with Automapper mappings
4. Database context has been automatically created from newsstand schema
## API Structure
Endpoints are available throught structure: {host}/api/[controller]/{actioname} ex. `https://localhost:44913/api/items/getitems?searchPhrase=burning`

- RealmController/
    - `GetRealms((string query, string region)` - /get-realm/ - lists all realms found by query in specifiec region. 
- ItemController/
    - `GetItems(string searchPhrase)` - /get-items/ - return all items found by name search query
    - `GetItemHistoryDaily(int itemId, int realmId)` - /daily-history/ - return list of auction house data (prices) in each day


## :memo: License
This project is licensed under MIT license.
