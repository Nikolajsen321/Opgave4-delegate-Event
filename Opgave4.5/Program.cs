// See https://aka.ms/new-console-template for more information
using Opgave4._5;
public delegate bool FilterCardDelegate(Card card);
public class Start
{
    
    public static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");


        SpilleKort spilleKort = new SpilleKort();

        spilleKort.AddCard(Suit.Spar, Number.Fem);
        spilleKort.AddCard(Suit.Hjerter, Number.Es);
        spilleKort.AddCard(Suit.Kulør, Number.Otte);

        List<Card> cards = spilleKort.FilterCardGame(FilterByKlør);


        foreach(Card element in cards)
        {
            Console.WriteLine($"{element.CardSuit} {element.NumberSuit}");
        }
        
    }
    //static  bool FilterByKlør(Card card) 
    //{
    //    if (card.CardSuit == Suit.Kulør)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    static bool FilterByKlør(Card card) => card.CardSuit == Suit.Kulør;


}
