﻿Public Class Familia

    Public Sub New()
        MyBase.New()
    End Sub

    Private _idFamilia As Integer
    Private _nombre As String
    Private _descripcion As String
    Private _fechaCreacion As Date
    Private _fechaUltimaModificacion As Date

    Public Sub New(ByVal idFamilia As Integer, ByVal nombre As String, ByVal descripcion As String _
                   , ByVal fechaCreacion As Date, ByVal fechaUltimaModificacion As Date)
        _idFamilia = idFamilia
        _nombre = nombre
        _descripcion = descripcion
        _fechaCreacion = fechaCreacion
        _fechaUltimaModificacion = fechaUltimaModificacion
    End Sub


    Public Property IdFamilia() As Integer
        Get
            ' Gets the property value.
            Return _idFamilia
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            _idFamilia = Value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            ' Gets the property value.
            Return _nombre
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _nombre = Value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            ' Gets the property value.
            Return _descripcion
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            _descripcion = Value
        End Set
    End Property

    Public Property FechaCreacion() As Date
        Get
            ' Gets the property value.
            Return _fechaCreacion
        End Get
        Set(ByVal Value As Date)
            ' Sets the property value.
            _fechaCreacion = Value
        End Set
    End Property

    Public Property FechaUltimaModificacion() As Date
        Get
            ' Gets the property value.
            Return _fechaUltimaModificacion
        End Get
        Set(ByVal Value As Date)
            ' Sets the property value.
            _fechaUltimaModificacion = Value
        End Set
    End Property

End Class