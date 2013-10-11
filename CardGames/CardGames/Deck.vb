Imports CardGames.Card
Public Class Deck
    Protected cards As New List(Of Card)

    Default Public ReadOnly Property _position(ByVal position As Integer) As Card
        Get
            Return cards(position)
        End Get
    End Property

    Public Sub New()
        For Each suit As Suit In System.Enum.GetValues(GetType(Suit))
            For Each faceVal As FaceValue In System.Enum.GetValues(GetType(FaceValue))
                cards.Add(New Card(suit, faceVal, True))
            Next
        Next
    End Sub

    Public Function Draw() As Card
        Dim card As Card = cards(0)
        cards.RemoveAt(0)
        Return card
    End Function

    Public Sub Shuffle()
        Dim random As New Random
        Dim i As Integer = 0
        While i < cards.Count
            Dim index1 As Integer = i
            Dim index2 As Integer = random.Next(cards.Count)
            SwapCard(index1, index2)
            i = i + 1
        End While
    End Sub

    Private Sub SwapCard(ByVal index1 As Integer, ByVal index2 As Integer)
        Dim card As Card = cards(index1)
        cards(index1) = cards(index2)
        cards(index2) = card
    End Sub
End Class
