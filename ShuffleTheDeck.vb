Option Strict On
Option Explicit On

'Sean Gingerich
'RCET0265
'Spring 2021
'Roll the Dice
'https://github.com/gingsean5/ShuffleTheDeck
Module ShuffleTheDeck

    Sub Main()
        Dim Deck(3, 12) As String

        Deck(0, 0) = "Ace of Spades"
        Deck(0, 1) = "2 of Spades"
        Deck(0, 2) = "3 of Spades"
        Deck(0, 3) = "4 of Spades"
        Deck(0, 4) = "5 of Spades"
        Deck(0, 5) = "6 of Spades"
        Deck(0, 6) = "7 of Spades"
        Deck(0, 7) = "8 of Spades"
        Deck(0, 8) = "9 of Spades"
        Deck(0, 9) = "10 of Spades"
        Deck(0, 10) = "Jack of Spades"
        Deck(0, 11) = "Queen of Spades"
        Deck(0, 12) = "King of Spades"

        Deck(1, 0) = "Ace of Diamonds"
        Deck(1, 1) = "2 of Diamonds"
        Deck(1, 2) = "3 of Diamonds"
        Deck(1, 3) = "4 of Diamonds"
        Deck(1, 4) = "5 of Diamonds"
        Deck(1, 5) = "6 of Diamonds"
        Deck(1, 6) = "7 of Diamonds"
        Deck(1, 7) = "8 of Diamonds"
        Deck(1, 8) = "9 of Diamonds"
        Deck(1, 9) = "10 of Diamonds"
        Deck(1, 10) = "Jack of Diamonds"
        Deck(1, 11) = "Queen of Diamonds"
        Deck(1, 12) = "King of Diamonds"

        Deck(2, 0) = "Ace of Clubs"
        Deck(2, 1) = "2 of Clubs"
        Deck(2, 2) = "3 of Clubs"
        Deck(2, 3) = "4 of Clubs"
        Deck(2, 4) = "5 of Clubs"
        Deck(2, 5) = "6 of Clubs"
        Deck(2, 6) = "7 of Clubs"
        Deck(2, 7) = "8 of Clubs"
        Deck(2, 8) = "9 of Clubs"
        Deck(2, 9) = "10 of Clubs"
        Deck(2, 10) = "Jack of Clubs"
        Deck(2, 11) = "Queen of Clubs"
        Deck(2, 12) = "King of Clubs"

        Deck(3, 0) = "Ace of Hearts"
        Deck(3, 1) = "2 of Hearts"
        Deck(3, 2) = "3 of Hearts"
        Deck(3, 3) = "4 of Hearts"
        Deck(3, 4) = "5 of Hearts"
        Deck(3, 5) = "6 of Hearts"
        Deck(3, 6) = "7 of Hearts"
        Deck(3, 7) = "8 of Hearts"
        Deck(3, 8) = "9 of Hearts"
        Deck(3, 9) = "10 of Hearts"
        Deck(3, 10) = "Jack of Hearts"
        Deck(3, 11) = "Queen of Hearts"
        Deck(3, 12) = "King of Hearts"

        Dim BoolDeck(3, 12) As Boolean
        'every value in BoolDeck is initialized as False
        Dim BoolValue As Boolean
        For BoolSuitValue = 0 To 3
            For BoolCardValue = 0 To 12
                BoolDeck(BoolSuitValue, BoolCardValue) = BoolValue
                BoolValue = False
            Next
        Next

        Dim ChooseSuit As Integer
        Dim ChooseCard As Integer
        Dim userInput As String
        Dim problem As Boolean
        Dim RedoRandomCard As Boolean
        Dim ShuffleTime As Boolean = False

        While userInput <> "Q" And userInput <> "q"
            Console.WriteLine("Enter a blank string to draw a card.
Enter ""Q"" at any time to quit.
Enter ""Shuffle"" to shuffle the deck at any time.")
            problem = True
            While problem = True And userInput <> "Q" And userInput <> "q"

                If userInput = "Shuffle" Then
                    ShuffleTime = True
                End If

                userInput = Console.ReadLine()
                If userInput = "" Then
                    RedoRandomCard = True
                    While RedoRandomCard = True
                        ChooseSuit = MakeRandoNumber(3)
                        ChooseCard = MakeRandoNumber(12)

                        If ShuffleTime = True Then
                            Console.WriteLine("Shuffle the deck!")
                            Console.WriteLine(StrDup(20, "-") & vbNewLine)

                            For BoolSuitValue = 0 To 3
                                For BoolCardValue = 0 To 12
                                    BoolDeck(BoolSuitValue, BoolCardValue) = BoolValue
                                    BoolValue = False
                                Next
                            Next
                            ShuffleTime = False
                        End If

                        'If every value in BoolDeck is true
                        If BoolDeck(0, 0) And BoolDeck(0, 1) And BoolDeck(0, 2) And BoolDeck(0, 3) And BoolDeck(0, 4) And BoolDeck(0, 5) And BoolDeck(0, 6) And BoolDeck(0, 7) And BoolDeck(0, 8) And BoolDeck(0, 9) And BoolDeck(0, 10) And BoolDeck(0, 11) And BoolDeck(0, 12) _
                           And BoolDeck(1, 0) And BoolDeck(1, 1) And BoolDeck(1, 2) And BoolDeck(1, 3) And BoolDeck(1, 4) And BoolDeck(1, 5) And BoolDeck(1, 6) And BoolDeck(1, 7) And BoolDeck(1, 8) And BoolDeck(1, 9) And BoolDeck(1, 10) And BoolDeck(1, 11) And BoolDeck(1, 12) _
                            And BoolDeck(2, 0) And BoolDeck(2, 1) And BoolDeck(2, 2) And BoolDeck(2, 3) And BoolDeck(2, 4) And BoolDeck(2, 5) And BoolDeck(2, 6) And BoolDeck(2, 7) And BoolDeck(2, 8) And BoolDeck(2, 9) And BoolDeck(2, 10) And BoolDeck(2, 11) And BoolDeck(2, 12) _
                            And BoolDeck(3, 0) And BoolDeck(3, 1) And BoolDeck(3, 2) And BoolDeck(3, 3) And BoolDeck(3, 4) And BoolDeck(3, 5) And BoolDeck(3, 6) And BoolDeck(3, 7) And BoolDeck(3, 8) And BoolDeck(3, 9) And BoolDeck(3, 10) And BoolDeck(3, 11) And BoolDeck(3, 12) _
                            = True Then
                            ShuffleTime = True
                        Else
                            If BoolDeck(ChooseSuit, ChooseCard) = True Then
                                RedoRandomCard = True
                            Else
                                Console.WriteLine(Deck(ChooseSuit, ChooseCard))
                                BoolDeck(ChooseSuit, ChooseCard) = True
                                RedoRandomCard = False
                            End If
                        End If



                    End While
                End If


            End While
        End While


    End Sub
    Function MakeRandoNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))
    End Function

End Module
