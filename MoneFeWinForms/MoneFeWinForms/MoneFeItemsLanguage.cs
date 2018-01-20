using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MoneFeWinForms
{
    class MoneFeItemsLanguage
    {
        private const string _ruPath = @"lang\ru\";
        static private string _currentPath;

        public MoneFeItemsLanguage()
        {
        }

        static private List<string> Categories { get; set; }
        static private List<string> AppInterface { get; set; }

        static private bool CheckLang(Languages lang)
        {
            if (lang == Languages.RU)
            {
                _currentPath = _ruPath;
                return true;
            }
            else
                return false;
        }

        static public Dictionary<string, string> LoadCategories(Languages lang = Languages.EN)
        {
            if (CheckLang(lang) && File.Exists(_currentPath + "categories.txt") && File.ReadAllLines(_ruPath + "categories.txt").Length == 12)
                Categories = File.ReadLines(_currentPath + "categories.txt").ToList();
            else
                CategoryDefaultValues();
            return getCategories();
        }

        static public Dictionary<string, string> LoadAppInterface(Languages lang = Languages.EN)
        {
            if (CheckLang(lang) && File.Exists(_currentPath + "interface.txt") && File.ReadAllLines(_ruPath + "interface.txt").Length == 46)
                AppInterface = File.ReadLines(_currentPath + "interface.txt").ToList();
            else
                AppInterfaceDefaultValues();
            return getAppInterface();
        }

        static private void CategoryDefaultValues()
        {
            Categories = new List<string>()
            {
                "Car", "Clothes", "Eating out", "Entertainment", "Food", "Gifts",
                "Communications", "Health", "House", "Sports", "Taxi", "Transport"
            };
        }

        static private void AppInterfaceDefaultValues()
        {
            AppInterface = new List<string>()
            {
                "File", "Language", "English", "Russian", "Exit", "Are you sure you want to exit?",
                "Income","Outcome", "Category", "Add to category:", "Add", "Add new account", "Account",
                "Currency", "Add note", "Balance", "Account name", "Period", "Year", "Month", "Week",
                "Day", "Date", "Save", "Edit", "Delete", "Cancel", "Succes", "Account successfully edited!",
                "Account successfully deleted!", "Account balance increased", "Added new account", "Summ",
                "Comment", "Export to CSV", "Change rate", "Get actual rate", "Rate", "Rate changed!", "Spent",
                "Added", "New account successfully added!", "Failed to load data!", "Error", "Sum can not be 0!",
                "Account name can not be empty!"
            };
        }

        static private Dictionary<string, string> getCategories()
        {
            int i = 0;
            return new Dictionary<string, string>()
                {
                    
                    { "cars", Categories[i++] }, { "clothes", Categories[i++] }, { "eating_out", Categories[i++] },
                    { "entertainment", Categories[i++] }, { "food", Categories[i++] }, { "gifts", Categories[i++] },
                    { "communications", Categories[i++] }, { "health", Categories[i++] }, { "house", Categories[i++] },
                    { "sports", Categories[i++] }, { "taxi", Categories[i++] }, { "transport", Categories[i++] }
                };
        }

        static private Dictionary<string, string> getAppInterface()
        {
            int i = 0;
            return new Dictionary<string, string>()
                {
                    { "file", AppInterface[i++] }, { "language", AppInterface[i++] }, { "lang_english", AppInterface[i++] },
                    { "lang_russian", AppInterface[i++] }, { "exit", AppInterface[i++] }, { "exit_warning", AppInterface[i++] },
                    { "income", AppInterface[i++] }, { "outcome", AppInterface[i++] },{ "category", AppInterface[i++] },
                    { "addToCategory", AppInterface[i++] },{ "add", AppInterface[i++] },{ "addNewAccount", AppInterface[i++] },
                    { "account", AppInterface[i++] },{ "currency", AppInterface[i++] },{ "addNote", AppInterface[i++] },
                    { "balance", AppInterface[i++] },{ "accountName", AppInterface[i++] }, { "chooseDate", AppInterface[i++] },
                    { "year", AppInterface[i++] },{ "month", AppInterface[i++] },{ "week", AppInterface[i++] },
                    { "day", AppInterface[i++] },{ "date", AppInterface[i++] }, { "save", AppInterface[i++] },
                    { "edit", AppInterface[i++] },{ "delete", AppInterface[i++] },{ "cancel", AppInterface[i++] },
                    { "successOperation", AppInterface[i++] },{ "accountEdited", AppInterface[i++] },{ "accountDeleted", AppInterface[i++] },
                    { "balanceIncrease", AppInterface[i++] },{ "newAccountAdd", AppInterface[i++] },{ "summ", AppInterface[i++] },
                    { "comment", AppInterface[i++] },{ "exportToCSV", AppInterface[i++] },{ "changeRate", AppInterface[i++] },
                    { "getActualRate", AppInterface[i++] }, { "rate", AppInterface[i++] }, { "rateChanged", AppInterface[i++] },
                    {"spent", AppInterface[i++]}, {"added", AppInterface[i++]}, {"accountAdded", AppInterface[i++]},
                    {"loadDataFailed", AppInterface[i++]},  {"error", AppInterface[i++]}, {"sumError", AppInterface[i++]},
                    {"emptyAccNameWarning", AppInterface[i++] }
                };
        }
    }
}

