using FlashCards.Application.Reports.GetAverageScorePerMonth;
using Spectre.Console;

namespace FlashCards.ConsoleUI.Views;

public class AverageScorePerMonthView
{
    public void Render(List<GetAverageScorePerMonthResponse> reports, int year)
    {
        var table = new Table()
                        .RoundedBorder()
                        .BorderColor(Color.Blue)
                        .ShowRowSeparators();

        table.AddColumn("Stack Name", col => col.NoWrap().LeftAligned());
        table.AddColumn("Jan", col => col.Width(5).Centered());
        table.AddColumn("Feb", col => col.Width(5).Centered());
        table.AddColumn("Mar", col => col.Width(5).Centered());
        table.AddColumn("Apr", col => col.Width(5).Centered());
        table.AddColumn("May", col => col.Width(5).Centered());
        table.AddColumn("Jun", col => col.Width(5).Centered());
        table.AddColumn("Jul", col => col.Width(5).Centered());
        table.AddColumn("Aug", col => col.Width(5).Centered());
        table.AddColumn("Sep", col => col.Width(5).Centered());
        table.AddColumn("Oct", col => col.Width(5).Centered());
        table.AddColumn("Nov", col => col.Width(5).Centered());
        table.AddColumn("Dec", col => col.Width(5).Centered());
        table.AddColumn("Annual");
        table.Title = new TableTitle($"Average Score By Month for Year: {year}");


        foreach (var report in reports)
        {
            table.AddRow(report.StackName,
            report.January.ToString("f1"),
            report.February.ToString("f1"),
            report.March.ToString("f1"),
            report.April.ToString("f1"),
            report.May.ToString("f1"),
            report.June.ToString("f1"),
            report.July.ToString("f1"),
            report.August.ToString("f1"),
            report.September.ToString("f1"),
            report.October.ToString("f1"),
            report.November.ToString("f1"),
            report.December.ToString("f1"),
            AnnualSum(report));
        }

        AnsiConsole.Write(table);

        Console.WriteLine();
    }

    private string AnnualSum(GetAverageScorePerMonthResponse report)
    {
        return ((double)(report.January + report.February + report.March + report.April + report.May + report.June + report.July
                + report.August + report.September + report.October + report.November + report.December) / 12).ToString("f1");
    }
}
