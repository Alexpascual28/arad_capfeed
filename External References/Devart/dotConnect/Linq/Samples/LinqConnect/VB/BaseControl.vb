Public Class BaseControl
  Inherits UserControl

  ' Methods
  Public Sub New(ByVal formName As String)
    Me.isActive = False
    Me.InitializeComponent()
    Me.mainFormName = formName
  End Sub

  Public Sub New()
    Me.InitializeComponent()
  End Sub

  Friend Overridable Sub CloseClick()
    Me.isActive = False
  End Sub

  Friend Overridable Sub OpenClick()
    Me.isActive = True
  End Sub

  Friend Overridable Sub ControlsEnabled(ByVal state As Boolean)

  End Sub

  ' Properties
  Friend ReadOnly Property Active() As Boolean
    Get
      Return Me.isActive
    End Get
  End Property

  Friend Shared Property CrmDataContext() As CrmDataContext.CrmDataContext
    Get
      Return myCrmDataContext
    End Get
    Set(ByVal value As CrmDataContext.CrmDataContext)
      myCrmDataContext = value
    End Set
  End Property

  Friend ReadOnly Property FormName() As String
    Get
      Return Me.mainFormName
    End Get
  End Property

  ' Fields
  Private isActive As Boolean
  Protected Shared myCrmDataContext As CrmDataContext.CrmDataContext
  Private ReadOnly mainFormName As String
End Class

