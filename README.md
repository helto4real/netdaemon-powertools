# This is the dev setup for NetDaemon

Use this repository as template when developing apps for NetDaemon. Please note that NetDaemon is still under development.

## Getting started

1. Make new repository with this repo as template
2. RENAME `_deamon_config.json` to `daemon_config.json`. Edit the daemon_config.json file to provide details about how to connect to Home Assistant. You will need a long lived token, ip, port.
3. Run dotnet restore in the terminal
4. Add and edit your apps in the apps folder. There are a few code-snippets you can use.
5. Copy the edited apps to the folder `netdaemon/apps` under your Hass.io config folder. Even more easy is to use HACS to deploy your APP to Home Assistant
6. Install the Hass.io add-on by adding the `https://github.com/helto4real/hassio-add-ons` to the add-on store and install NetDaemon
7. Run the add-on and check the log that your new apps is intitialized

For detailed information about netdaemon please see [https://net-daemon.github.io/netdaemon/](https://net-daemon.github.io/netdaemon/).

## Read this if you are going to deploy apps through HACKS

Each app should have it´s own subfolder under the `apps` folder. So rename the `HelloWorld` folder and `HelloWorld.cs` and `HelloWorld.yaml` according to your app. The class name should also be renamed to the same unique app name. We also recommend using namespaces and fully qualified names like the sample included in the template.

<a href="https://www.buymeacoffee.com/ij1qXRM6E" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: auto !important;width: auto !important;" ></a>

## Attribution

ICON: Attribution: [chris](https://commons.wikimedia.org/wiki/User:Chrkl) 論
