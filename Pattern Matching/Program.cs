using System;


class Program
{
    static void Main()
    {
        string bankRecords = """
            DEPOSIT,10000,Initial balance
            DEPOSIT,500,Regular deposit
            WITHDRAWAL,1000,Rent
            DEPOSIT,2000,Freelance payment
            WITHDRAWAL,300,Groceries
            """;

        double currentBalance = 0.0;

        foreach (var transaction in TransactionRecords(bankRecords))
        {
            double change = transaction switch
            {
                (TransactionType.Deposit, var amount) => amount,
                (TransactionType.Withdrawal, var amount) => -amount,
                _ => 0.0
            };

            currentBalance += change;

            Console.WriteLine(
                $"{transaction.type}: Amount = {transaction.amount}, " +
                $"Change = {change}, Balance = {currentBalance}"
            );
        }

        Console.WriteLine($"Final balance: {currentBalance}");
    }

    static IEnumerable<(TransactionType type, double amount)>
        TransactionRecords(string inputText)
    {
        var reader = new StringReader(inputText);
        string? line;

        while ((line = reader.ReadLine()) is not null)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            string[] parts = line.Split(',');

            if (parts.Length < 2)
            {
                yield return (TransactionType.Invalid, 0.0);
                continue;
            }

            string type = parts[0].Trim();

            if (!double.TryParse(parts[1].Trim(), out double amount))
            {
                yield return (TransactionType.Invalid, 0.0);
                continue;
            }

            if (type.Equals(
                "DEPOSIT", StringComparison.OrdinalIgnoreCase))
            {
                yield return (TransactionType.Deposit, amount);
            }
            else if (type.Equals(
                "WITHDRAWAL", StringComparison.OrdinalIgnoreCase))
            {
                yield return (TransactionType.Withdrawal, amount);
            }
            else
            {
                yield return (TransactionType.Invalid, 0.0);
            }
        }
    }
}

public enum TransactionType
{
    Deposit,
    Withdrawal,
    Invalid
}