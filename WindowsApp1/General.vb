Module General
    Public g_EmployeeForm As EmployeeForm
    Public g_ShippingForm As ShippingForm

    Public m_ConStr As String
    Public m_EmailAPIHost As String
    Public m_EmailAPIPath As String
    Public m_FileDateRangeDays As String
    Public m_MonitoringEmail As String
    Public m_TestEmail As String
    Public m_TestMode As Boolean

    Public Sub Initialize()
        Dim m_Ini As New NarsilWorks.DevLib.INIManager(My.Application.Info.DirectoryPath & "\launch.ini")
        Dim m_LocalServer As String = m_Ini.GetSetting("DATABASE", "Server")
        Dim m_LocalUserID As String = m_Ini.GetSetting("DATABASE", "UserId")
        Dim m_LocalPassword As String = m_Ini.GetSetting("DATABASE", "Password")
        Dim m_LocalDatabase As String = m_Ini.GetSetting("DATABASE", "Database")
        m_ConStr = String.Format("Server={0};User Id={1};Password={2};Database={3};", m_LocalServer, m_LocalUserID, m_LocalPassword, m_LocalDatabase)
    End Sub
End Module
