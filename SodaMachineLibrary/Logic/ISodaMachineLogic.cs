using SodaMachineLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachineLibrary.Logic
{
    public interface ISodaMachineLogic
    {
        List<SodaModel> ListTypesOfSoda();
        // Takes in an amount and returns the total deposited so far
        decimal MoneyInserted(decimal monetaryAmount);
        // Get overal price for sodas - all sodas are the same price
        decimal GetSodaPrice();
        // SodaModel (or null), List<Coin> Change, string ErrorMessage ---- tupel return
        (SodaModel soda, List<CoinModel> change, string errorMessage) RequestSoda(SodaModel soda);
        void IssueFullRefund();
        decimal GetMoneyInsertedTotal();
        void AddToSodaInventory(List<SodaModel> sodas);
        List<SodaModel> GetSodaInventory();
        decimal EmptyMoneyFromMachine();
        List<CoinModel> GetCoinInventory();
        void AddToCoinInventory(List<CoinModel> coins);
        decimal GetCurrentIncome();
        decimal GetTotalIncome();
    }
}
