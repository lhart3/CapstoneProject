Public Enum Suit
    Diamonds
    Spades
    Clubs
    Hearts
End Enum

Public Enum FaceValue
    Two = 2
    Three = 3
    Four = 4
    Five = 5
    Six = 6
    Seven = 7
    Eight = 8
    Nine = 9
    Ten = 10
    Jack = 11
    Queen = 12
    King = 13
    Ace = 14
End Enum

Public Class Card
    Private suitCard As Suit
    Private faceValueCard As FaceValue
    Private cardIsUp As Boolean
    Private _suit As CardGames.Suit
    Private _faceVal As FaceValue
    Private _p3 As Boolean

    Public Property Suit() As Suit
        Get
            Return suitCard
        End Get
        Set(ByVal value As Suit)
            suitCard = value
        End Set
    End Property

    Public Property FaceVal() As FaceValue
        Get
            Return faceValueCard
        End Get
        Set(ByVal value As FaceValue)
            faceValueCard = value
        End Set
    End Property

    Public Property IsCardUp() As Boolean
        Get
            Return cardIsUp
        End Get
        Set(ByVal value As Boolean)
            cardIsUp = value
        End Set
    End Property
    Public Sub New(ByVal suitCard As Suit, ByVal faceValueCard As FaceValue, ByVal cardIsUp As Boolean)
        Me.suitCard = suitCard
        Me.faceValueCard = faceValueCard
        Me.cardIsUp = cardIsUp
    End Sub

    Public Overloads Overrides Function ToString() As String
        Return "The" & faceValueCard.ToString & "of" & suitCard.ToString
    End Function
End Class
