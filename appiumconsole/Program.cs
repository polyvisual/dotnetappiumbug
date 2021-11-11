using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;

namespace appiumconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
            browserstackOptions.Add("userName", "matthorrocks1");
            browserstackOptions.Add("accessKey", "q5x7pRjTZaGWxsU4SA5Wa");
            browserstackOptions.Add("debug", "false");
            browserstackOptions.Add("local", "false");
            browserstackOptions.Add("timezone", "GMT");
            browserstackOptions.Add("appiumVersion", "5.0.0");
            browserstackOptions.Add("autoWebview", "true");
            browserstackOptions.Add("buildName", "dev");
            browserstackOptions.Add("sessionName", "scsd");
            AppiumOptions capabilities = new AppiumOptions();
            capabilities.AddAdditionalAppiumOption("DeviceName", "Samsung Galaxy S9");
            capabilities.AddAdditionalAppiumOption("sessionName", "dev");
            capabilities.AddAdditionalAppiumOption("PlatformVersion", "8.0");
            capabilities.AddAdditionalAppiumOption("Application", "NetwealthAppApk");
            capabilities.AddAdditionalAppiumOption("bstack:options", browserstackOptions);

            AppiumDriver MobileAppDriver = new AndroidDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub"), capabilities, TimeSpan.FromSeconds(120));
        }
    }
}
