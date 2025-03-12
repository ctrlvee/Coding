using Spectre.Console;
using CodingLogger.Coding.Controllers;
using static CodingLogger.Coding.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace CodingLogger.Coding; 

internal class UserInterface {

    private DatabaseController _databaseController = new();
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