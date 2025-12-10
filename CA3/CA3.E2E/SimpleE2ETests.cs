using Microsoft.Playwright;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CA3.E2E
{
    [TestClass]
    public class SimpleE2ETests
    {
        private const string BaseUrl = "https://victorious-dune-062508d03.3.azurestaticapps.net/";

        [TestMethod]
        public async Task Home_Should_Show_League_Cards()
        {
            using var pw = await Playwright.CreateAsync();
            await using var browser = await pw.Chromium.LaunchAsync(new() { Headless = true });

            var page = await browser.NewPageAsync();
            await page.GotoAsync(BaseUrl);

            // WAIT for Blazor WASM to fully load
            await page.WaitForSelectorAsync("text=Choose a League");

            // Validate cards exist
            await page.WaitForSelectorAsync("text=Bundesliga");
            await page.WaitForSelectorAsync("text=Champions League");
            await page.WaitForSelectorAsync("text=League Tables");
        }

        [TestMethod]
        public async Task Home_Click_Bundesliga_Should_Navigate()
        {
            using var pw = await Playwright.CreateAsync();
            await using var browser = await pw.Chromium.LaunchAsync(new() { Headless = true });

            var page = await browser.NewPageAsync();
            await page.GotoAsync(BaseUrl);

            await page.WaitForSelectorAsync("text=Bundesliga");

            // Click Bundesliga card
            await page.ClickAsync("text=Bundesliga");

            // Wait for matches page title (no API required)
            await page.WaitForSelectorAsync("h3");

            StringAssert.Contains(page.Url, "/matches/bl1");
        }

        [TestMethod]
        public async Task Home_Click_ChampionsLeague_Should_Navigate()
        {
            using var pw = await Playwright.CreateAsync();
            await using var browser = await pw.Chromium.LaunchAsync(new() { Headless = true });

            var page = await browser.NewPageAsync();
            await page.GotoAsync(BaseUrl);

            
            await page.WaitForSelectorAsync("text=Champions League");

            // Click card
            await page.ClickAsync("text=Champions League");

            // Page has an <h3> title
            await page.WaitForSelectorAsync("h3");

            // URL check
            StringAssert.Contains(page.Url, "/champions-league");
        }

        [TestMethod]
        public async Task Home_Click_LeagueTables_Should_Navigate()
        {
            using var pw = await Playwright.CreateAsync();
            await using var browser = await pw.Chromium.LaunchAsync(new() { Headless = true });

            var page = await browser.NewPageAsync();
            await page.GotoAsync(BaseUrl);

            await page.WaitForSelectorAsync("text=League Tables");
            await page.ClickAsync("text=League Tables");

            // The League Table page always has a table + h3
            await page.WaitForSelectorAsync("h3");
            await page.WaitForSelectorAsync("table");

            StringAssert.Contains(page.Url, "/league-table");
        }

    }
}
