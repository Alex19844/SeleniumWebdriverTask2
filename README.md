# Selenium WebdDiver. Task2

Practical Task for Selenium WebDriver using NUnit framework.

## What should be done

For this practical task, Selenium WebDriver and any preferred by you unit test framework (NUnit, MSTest or xUnit) should be used. Basic WebDriver features as browser interactions,
capabilities and features browser specifics, explicit and implicit waits should be used.  Read website URL from config file as a property. Enlarge the window. Use basic commands that can be executed
on an element (at least click, sendKeys, clear). The solution should contain only one class with several test methods. The following locators MUST be used at least once:

1. ID locator
2. Name locator
3. ClassName locator
4. TagName locator
5. LinkText locator
6. PartialLinkText locator
7. CSS locator (if possible, use pseudo-classes)
8. XPath locator (Relative path)
9. XPath locator with any operator
10. XPath locator with axes

## Task Description
## Task #2. Validate global search works as expected

• Create a Chrome instance.
• Navigate to https://www.epam.com/
• Find a magnifier icon and click on it
• Find a search string and put there “BLOCKCHAIN”/”Cloud”/”Automation” (use as a parameter for a test)
• Click “Find” button
• Validate that all links in a list contain a word “BLOCKCHAIN”/”Cloud”/”Automation” in the text. LINQ should be used. 
• Close the browser

## Evaluation criteria (pass rate – 70%)

• Here’s the list of actions which result in reduction of overall mark for a completed task:
• Any of the tasks is not completed (-50%)
• Less than 3 types of locators are used (-10%)
• Locator is not relative, not readable and/or not descriptive (-2% per each)
• Either explicit and implicit waiters are not used (-5%)
• Browser is not properly closed both on success and on failure (-10%)
• Logical issues/not optimal approach (-10%)
• Code smells (naming convention, typos) (-1% per issue) 
• OOP principles violations (-3% per issue)
• Code duplication is found (-3% per issue)
• Thread.Sleep() is used for waiting (-10%)
• Commit log is not following git commit message best practices and/or repository contains binaries and/or local data. (-10%)

 ## Task Implementation

 The "SeleniumWebdriverTask2" project has been created. SeleniumTests.cs file has been added for tests. Config.runsettings file has been added for website URL property.
 
 All functionality is implemented.

 Note: Not all "BLOCKCHAIN" search links contain the word "BLOCKCHAIN" in the title or short description. 
