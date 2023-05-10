using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParse
{
	public class Program
	{
		static void Main(string[] args)
		{
			ReadCsvFile();
			//Reading Csv. file.

			Console.ReadKey();
			//Obtains the next character or function key pressed by the user. The pressed key is displayed in the console window.
		}

		private static void ReadCsvFile()
		{
			var csvFileDescription = new CsvFileDescription
			{
				FirstLineHasColumnNames = true,
				IgnoreUnknownColumns= true,
				SeparatorChar= ',',
				UseFieldIndexForReadingData = true,
			};
			//Creating a "style" for the file.

			var csvContext = new CsvContext();
			var cryptos = csvContext.Read<Transactions>("crypto_transactions_record_20230331_133059.csv", csvFileDescription);

			foreach(var transaction in cryptos )
			{
				Console.WriteLine($"{transaction.TimeStamp} | {transaction.TransactionDescription} | {transaction.Currency} | " +
					$"{transaction.Amount} | {transaction.TransactionKind}");
			}
		}
	}
}
