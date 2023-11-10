using OOP3;

internal class Program
{
    private static void Main(string[] args)
    {
        ICreditManager housingCreditManager = new HousingCreditManager();
        ICreditManager vehicleLonCreditManager = new VehicleLoanCreditManager();
        ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();

        ILoggerService databaseLoggerService = new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();

        ApplicationManager applicationManager = new ApplicationManager();
        applicationManager.ToApply(TradesmanLoanCreditManager(), new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() });


        List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCreditManager, vehicleLonCreditManager };
    }
}