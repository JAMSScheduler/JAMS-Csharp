
 // Get the JAMS Server
 Server svr = Server.GetServer("localhost");
 // Define search criteria
 List<HistorySelection> criteria = new List<HistorySelection>();
 criteria.Add(new HistorySelection(HistorySelectionField.JobName, ComparisonOperator.Like, "CRM*"));
 // Query History
 ICollection<History> historyResult = History.Find(criteria, DateTime.Today, DateTime.Now, true, true, true, true, true, true, true, true, true, HistorySearchOptions.None, svr);
