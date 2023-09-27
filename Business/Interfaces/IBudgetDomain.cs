namespace Business.Interfaces;

public interface IBudgetDomain
{
    Task InsertBudgetData();
    Task ShowAllBudgetData();
    Task GetBudgetData(int id);
}