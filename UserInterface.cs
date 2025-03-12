using Spectre.Console;
using CodingLogger.Coding.Controllers;
using static CodingLogger.Coding.Enums;

namespace CodingLogger.Coding; 

internal class UserInterface {

    internal void MainMenu() {
        Console.Clear();
        while (true) {
            var actionChoice = AnsiConsole.Prompt(
                new SelectionPrompt<MenuAction>()
                .Title("What do you want to do next?")
                .AddChoices(Enum.GetValues<MenuAction>()));

            switch(actionChoice) {
                case MenuAction.ViewItem:
                    ViewItems();
                    break;
                case MenuAction.AddItem:
                    AddItem();
                    break;
                case MenuAction.DeleteItem:
                    DeleteItem();
                    break;

            }
        }
    }

    private void ViewItems() {

    }

    private void AddItem() {

    }

    private void DeleteItem() {

    }

}