using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParse
{
	[Serializable]
	public class Transactions
	{
		[CsvColumn(Name = "Timestamp" , FieldIndex = 1, OutputFormat = "dd-mm-yyyy hh:mm:ss")]
		public DateTime TimeStamp { get; set; }

		[CsvColumn(Name = "Transaction Description", FieldIndex = 2)]
		public string TransactionDescription { get; set; }

		[CsvColumn(Name = "Currency", FieldIndex = 3)]
		public string Currency { get; set; }

		[CsvColumn(Name = "Amount", FieldIndex = 4, OutputFormat = "C")]
		public float Amount { get; set; }

		[CsvColumn(Name = "Transaction Kind", FieldIndex = 5)]
		public string TransactionKind { get; set; }
	}
}
