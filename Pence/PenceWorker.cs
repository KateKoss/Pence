using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pence
{
    class PenceWorker
    {
        private int[] penceArray;
        private  int amountOfPennyForExchange;
        public PenceWorker(int amountOfPennyForExchange, int[] penceArray)
        {
            this.amountOfPennyForExchange = amountOfPennyForExchange;
            this.penceArray = penceArray;
        }
        public int findCombinationsOfExchange()
        {
            return countingCombinations(amountOfPennyForExchange, penceArray.Length);
        }
        public int countingCombinations(int amount, int coinType)
        {
            if (amount == 0)
                return 1;
            if (amount < 0 || coinType == 0)
                return 0;
            else
                return countingCombinations(amount, coinType - 1) + countingCombinations(amount - coinValue(coinType), coinType);
        }

        public int coinValue(int coinType)  // 1 < coinType < penceArray.Length
        {
            return penceArray[coinType - 1];
        }
    }
}
