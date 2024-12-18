using Behavioral_Observer;
/*
 * OBSERVER PATTERN
 * otherwise
 * PUBLISHER/SUBSCRIBER PATTER *PUBSUB PATTERN*
 * In naive format there are violations of solid principle
 * SingleResponsability, the class datasource storing data and manage the dependents observer objects
 * OpenClose principle, for every new observer object you need to modify datasource class
 * 
 * Datasource clas manage the values
 * List of observers is manage by Subject class
 * 
 * CAN BE USED WITH MEDIATOR
 */


//NAIVE SOLUTION
DataSource_NAIVE source = new DataSource_NAIVE();
TotalSheet_NAIVE totalSheet = new TotalSheet_NAIVE();
BarChar_NAIVE barChar = new BarChar_NAIVE();
source.AddDependent(barChar);
source.AddDependent(totalSheet);
source.SetValues([5, 7, 8, 2]);
source.SetValues([1,2,3]);

Console.WriteLine("***********************");
Console.WriteLine("");

//OBSERVER PATTERN SOLUTION
DataSource dataSource = new DataSource();
TotalSheet sheet = new TotalSheet(dataSource);
BarChar barC = new BarChar(dataSource);
dataSource.AddObserver(barC);
dataSource.AddObserver(sheet);

dataSource.SetValues([5, 7, 8, 2]);
dataSource.SetValues([1, 2, 3]);