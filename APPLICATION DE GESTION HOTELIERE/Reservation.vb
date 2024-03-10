Public Class Reservation

    Dim NumeroReservation As String
    Dim DateReservation As Date
    Dim Categorie As String
    Dim ClientId As String

    Public Property Client As Client

    Public Property ClientId1 As String
        Get
            Return ClientId
        End Get
        Set(value As String)
            ClientId = value
        End Set
    End Property

    Public Property NumeroReservation1 As String
        Get
            Return NumeroReservation
        End Get
        Set(value As String)
            NumeroReservation = value
        End Set
    End Property

    Public Property DateReservation1 As Date
        Get
            Return DateReservation
        End Get
        Set(value As Date)
            DateReservation = value
        End Set
    End Property

    Public Property Categorie1 As String
        Get
            Return Categorie
        End Get
        Set(value As String)
            Categorie = value
        End Set
    End Property
End Class
