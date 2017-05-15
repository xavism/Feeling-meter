# Feeling Meter

> Vue.js + NetCore Project to make a Feelings Meter
> Vue.js is used for the Frontend part and NETCore for the API

## Project Overview

![Screenshot](Frontend-Vue.js/src/assets/screenshots/Layout.png)

## Build Setup

### Backend Setup

> Database information is located in the appsettings.json (Backend)

> Data to Change: serverName, username, password in the AzureDB connectionString.

```bash
dotnet restore

dotnet build

dotnet run
```

### Frontend setup:

> Change the APIUrl located in src/data/routesDev.js (in Dev environment). To change the environment, select a different import in the service 'JobService'.

``` bash
# install dependencies
npm install

# serve with hot reload at localhost:8080
npm run dev

# build for production with minification
npm run build

# build for production and view the bundle analyzer report
npm run build --report
```
