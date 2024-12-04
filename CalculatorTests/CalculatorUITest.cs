using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlaUI.Core;
using FlaUI.UIA3;
using System.Threading.Tasks;
using FlaUI.Core.AutomationElements;

namespace CalculatorTests
{
    internal class CalculatorUITest
    {
        [Test]
        public void AdditionTest()
        {
            using (var app = Application.Launch(@"C:\Users\pe04uhp\Desktop\calculatorApp\CalculatorApp\bin\Debug\net8.0-windows\CalculatorApp.exe"))
            {
                var automation = new UIA3Automation();
                var mainWindow = app.GetMainWindow(automation);

                // Interagir avec les boutons et le champ de résultat
                var button2 = mainWindow.FindFirstDescendant(cf => cf.ByText("2")).AsButton();
                var buttonAdd = mainWindow.FindFirstDescendant(cf => cf.ByText("+")).AsButton();
                var button3 = mainWindow.FindFirstDescendant(cf => cf.ByText("3")).AsButton();
                var buttonEquals = mainWindow.FindFirstDescendant(cf => cf.ByText("=")).AsButton();
                var resultField = mainWindow.FindFirstDescendant(cf => cf.ByAutomationId("txtResult")).AsTextBox();

                // Effectuer l'opération 2 + 3
                button2.Click();
                Thread.Sleep(1000);
                buttonAdd.Click();
                Thread.Sleep(1000);
                button3.Click();
                Thread.Sleep(1000);
                buttonEquals.Click();

                // Vérifier le résultat
                Assert.That(resultField.Text, Is.EqualTo("5"), "Addition of 2 and 3 should return 5.");

            }
        }

    }
}
