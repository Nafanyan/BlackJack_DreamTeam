int[,] DistributionOfCard(int[,] playerCards, int[] deckCards)
{
    for (int i = 0; i < playerCards.GetLength(0); i++)
    {
        playerCards[i,0] = deckCards[i];
        deckCards[i] = 0;
    }
    return playerCards;
}
void PrintCard(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (result[i,j] != 0)
            {
                Console.Write($"{result[i,j]} ");
            } 
        }
        Console.WriteLine();
    }
}

int [,] GiveMeCard (int[,] resultTables, int[] sourceCard)
{
    int numberCard = 0;
    int numberCardPlayer = 1;
    for ( int i = 0; i < resultTables.GetLength(0); i++)
    {
        string word = " ";
        while (word != "stop")
        {
            Console.WriteLine("Ещё карту?");
            word = Console.ReadLine();
            if (sourceCard[numberCard] == 0){continue; numberCard++;}
            else
            {
                resultTables[i,numberCardPlayer] = sourceCard[numberCard];
                sourceCard[numberCard] = 0;
                numberCard++;
            }
        }
    }
}

int[] deck = {2,3,4,5,6,7,8,9,1,2,3,4,5,6};
int[,] plcard = new int[3,10];
PrintCard(DistributionOfCard(plcard,deck));
