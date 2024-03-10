Public Class Client

    Dim Matricule As String
    Dim Nom As String
    Dim Prenom As String
    Dim Sexe As String
    Dim CNI As Integer
    Dim Telephone As Integer

    Public Property Matricule1() As String
        Get
            Return Matricule
        End Get
        Set(value As String)
            Matricule = value
        End Set
    End Property

    Public Property Nom1() As String
        Get
            Return Nom
        End Get
        Set(value As String)
            Nom = value
        End Set
    End Property

    Public Property Prenom1() As String
        Get
            Return Prenom
        End Get
        Set(value As String)
            Prenom = value
        End Set
    End Property

    Public Property Sexe1() As String
        Get
            Return Sexe
        End Get
        Set(value As String)
            Sexe = value
        End Set
    End Property

    Public Property CNI1() As Integer
        Get
            Return CNI
        End Get
        Set(value As Integer)
            CNI = value
        End Set
    End Property

    Public Property Telephone1() As Integer
        Get
            Return Telephone
        End Get
        Set(value As Integer)
            Telephone = value
        End Set
    End Property

    Public Function CreerMatricule(count As Integer) As String


    End Function



End Class
