Public Class Combustible
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private WithEvents xrTable2 As DevExpress.XtraReports.UI.XRTable
    Private WithEvents xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Private WithEvents xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Private WithEvents reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Private WithEvents xrTable1 As DevExpress.XtraReports.UI.XRTable
    Private WithEvents xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Private WithEvents xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DetailCaption3 As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DetailData3 As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents DetailCaptionBackground3 As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Private WithEvents parameter1 As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents parameter2 As DevExpress.XtraReports.Parameters.Parameter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "Combustible.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.Combustible.ResourceManager
        Me.components = New System.ComponentModel.Container()
        Dim storedProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim queryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim queryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaption3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaptionBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.parameter2 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 3.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrPageInfo2})
        Me.BottomMargin.HeightF = 73.95834!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'sqlDataSource1
        '
        Me.sqlDataSource1.ConnectionName = "DASH_DESIGNER.My.MySettings.sisacsa"
        Me.sqlDataSource1.Name = "sqlDataSource1"
        storedProcQuery1.Name = "seguimiento"
        queryParameter1.Name = "@fecha_inicial"
        queryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        queryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter1]", GetType(Date))
        queryParameter2.Name = "@fecha_final"
        queryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        queryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.parameter2]", GetType(Date))
        storedProcQuery1.Parameters.Add(queryParameter1)
        storedProcQuery1.Parameters.Add(queryParameter2)
        storedProcQuery1.StoredProcName = "seguimiento"
        Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {storedProcQuery1})
        Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 6.00001!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.xrPageInfo1.StyleName = "PageInfo"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(492.0!, 6.00001!)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.xrPageInfo2.StyleName = "PageInfo"
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.xrPageInfo2.TextFormatString = "Página {0} de {1}"
        '
        'reportHeaderBand1
        '
        Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel5, Me.xrLabel4, Me.xrLabel3, Me.xrLabel2, Me.xrPictureBox1, Me.xrLabel1})
        Me.reportHeaderBand1.HeightF = 174.5833!
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        '
        'xrLabel1
        '
        Me.xrLabel1.BackColor = System.Drawing.Color.Orange
        Me.xrLabel1.ForeColor = System.Drawing.Color.White
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 94.54168!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(191.9743!, 26.0!)
        Me.xrLabel1.StyleName = "Title"
        Me.xrLabel1.StylePriority.UseBackColor = False
        Me.xrLabel1.StylePriority.UseForeColor = False
        Me.xrLabel1.Text = "Base de combustible"
        '
        'groupHeaderBand1
        '
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPanel1})
        Me.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.groupHeaderBand1.HeightF = 49.04168!
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        '
        'xrPanel1
        '
        Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
        Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.xrPanel1.Name = "xrPanel1"
        Me.xrPanel1.SizeF = New System.Drawing.SizeF(814.9999!, 48.0!)
        Me.xrPanel1.StyleName = "DetailCaptionBackground3"
        '
        'xrTable1
        '
        Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 20.0!)
        Me.xrTable1.Name = "xrTable1"
        Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
        Me.xrTable1.SizeF = New System.Drawing.SizeF(805.0!, 28.0!)
        '
        'xrTableRow1
        '
        Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9})
        Me.xrTableRow1.Name = "xrTableRow1"
        Me.xrTableRow1.Weight = 1.0R
        '
        'xrTableCell1
        '
        Me.xrTableCell1.BackColor = System.Drawing.Color.Orange
        Me.xrTableCell1.ForeColor = System.Drawing.Color.White
        Me.xrTableCell1.Name = "xrTableCell1"
        Me.xrTableCell1.StyleName = "DetailCaption3"
        Me.xrTableCell1.StylePriority.UseBackColor = False
        Me.xrTableCell1.StylePriority.UseForeColor = False
        Me.xrTableCell1.StylePriority.UseTextAlignment = False
        Me.xrTableCell1.Text = "idtransacion"
        Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell1.Weight = 0.13162118765024039R
        '
        'xrTableCell2
        '
        Me.xrTableCell2.BackColor = System.Drawing.Color.Orange
        Me.xrTableCell2.ForeColor = System.Drawing.Color.White
        Me.xrTableCell2.Name = "xrTableCell2"
        Me.xrTableCell2.StyleName = "DetailCaption3"
        Me.xrTableCell2.StylePriority.UseBackColor = False
        Me.xrTableCell2.StylePriority.UseForeColor = False
        Me.xrTableCell2.Text = "vehiculo"
        Me.xrTableCell2.Weight = 0.11553642028416837R
        '
        'xrTableCell3
        '
        Me.xrTableCell3.BackColor = System.Drawing.Color.Orange
        Me.xrTableCell3.ForeColor = System.Drawing.Color.White
        Me.xrTableCell3.Name = "xrTableCell3"
        Me.xrTableCell3.StyleName = "DetailCaption3"
        Me.xrTableCell3.StylePriority.UseBackColor = False
        Me.xrTableCell3.StylePriority.UseForeColor = False
        Me.xrTableCell3.Text = "fecha"
        Me.xrTableCell3.Weight = 0.16837984532764255R
        '
        'xrTableCell4
        '
        Me.xrTableCell4.BackColor = System.Drawing.Color.Orange
        Me.xrTableCell4.ForeColor = System.Drawing.Color.White
        Me.xrTableCell4.Name = "xrTableCell4"
        Me.xrTableCell4.StyleName = "DetailCaption3"
        Me.xrTableCell4.StylePriority.UseBackColor = False
        Me.xrTableCell4.StylePriority.UseForeColor = False
        Me.xrTableCell4.StylePriority.UseTextAlignment = False
        Me.xrTableCell4.Text = "Horas Actuales"
        Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell4.Weight = 0.1433727805176144R
        '
        'xrTableCell5
        '
        Me.xrTableCell5.BackColor = System.Drawing.Color.Orange
        Me.xrTableCell5.ForeColor = System.Drawing.Color.White
        Me.xrTableCell5.Name = "xrTableCell5"
        Me.xrTableCell5.StyleName = "DetailCaption3"
        Me.xrTableCell5.StylePriority.UseBackColor = False
        Me.xrTableCell5.StylePriority.UseForeColor = False
        Me.xrTableCell5.StylePriority.UseTextAlignment = False
        Me.xrTableCell5.Text = "Horometro anterior"
        Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell5.Weight = 0.14083916923902606R
        '
        'xrTableCell6
        '
        Me.xrTableCell6.BackColor = System.Drawing.Color.Orange
        Me.xrTableCell6.ForeColor = System.Drawing.Color.White
        Me.xrTableCell6.Name = "xrTableCell6"
        Me.xrTableCell6.StyleName = "DetailCaption3"
        Me.xrTableCell6.StylePriority.UseBackColor = False
        Me.xrTableCell6.StylePriority.UseForeColor = False
        Me.xrTableCell6.StylePriority.UseTextAlignment = False
        Me.xrTableCell6.Text = "delta"
        Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell6.Weight = 0.10106716035619054R
        '
        'xrTableCell7
        '
        Me.xrTableCell7.BackColor = System.Drawing.Color.Orange
        Me.xrTableCell7.ForeColor = System.Drawing.Color.White
        Me.xrTableCell7.Name = "xrTableCell7"
        Me.xrTableCell7.StyleName = "DetailCaption3"
        Me.xrTableCell7.StylePriority.UseBackColor = False
        Me.xrTableCell7.StylePriority.UseForeColor = False
        Me.xrTableCell7.StylePriority.UseTextAlignment = False
        Me.xrTableCell7.Text = "cantidad"
        Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell7.Weight = 0.13156682719849672R
        '
        'xrTableCell8
        '
        Me.xrTableCell8.BackColor = System.Drawing.Color.Orange
        Me.xrTableCell8.ForeColor = System.Drawing.Color.White
        Me.xrTableCell8.Name = "xrTableCell8"
        Me.xrTableCell8.StyleName = "DetailCaption3"
        Me.xrTableCell8.StylePriority.UseBackColor = False
        Me.xrTableCell8.StylePriority.UseForeColor = False
        Me.xrTableCell8.StylePriority.UseTextAlignment = False
        Me.xrTableCell8.Text = "proyecto"
        Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell8.Weight = 0.16201611279968253R
        '
        'xrTableCell9
        '
        Me.xrTableCell9.BackColor = System.Drawing.Color.Orange
        Me.xrTableCell9.ForeColor = System.Drawing.Color.White
        Me.xrTableCell9.Name = "xrTableCell9"
        Me.xrTableCell9.StyleName = "DetailCaption3"
        Me.xrTableCell9.StylePriority.UseBackColor = False
        Me.xrTableCell9.StylePriority.UseForeColor = False
        Me.xrTableCell9.Text = "estacion"
        Me.xrTableCell9.Weight = 0.14406188972368172R
        '
        'xrTable2
        '
        Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.xrTable2.Name = "xrTable2"
        Me.xrTable2.OddStyleName = "DetailData3_Odd"
        Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
        Me.xrTable2.SizeF = New System.Drawing.SizeF(805.0!, 25.0!)
        '
        'xrTableRow2
        '
        Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell10, Me.xrTableCell11, Me.xrTableCell12, Me.xrTableCell13, Me.xrTableCell14, Me.xrTableCell15, Me.xrTableCell16, Me.xrTableCell17, Me.xrTableCell18})
        Me.xrTableRow2.Name = "xrTableRow2"
        Me.xrTableRow2.Weight = 11.5R
        '
        'xrTableCell10
        '
        Me.xrTableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[idtransacion]")})
        Me.xrTableCell10.Name = "xrTableCell10"
        Me.xrTableCell10.StyleName = "DetailData3"
        Me.xrTableCell10.StylePriority.UseTextAlignment = False
        Me.xrTableCell10.Text = "xrTableCell10"
        Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell10.Weight = 0.13162119938777042R
        '
        'xrTableCell11
        '
        Me.xrTableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vehiculo]")})
        Me.xrTableCell11.Name = "xrTableCell11"
        Me.xrTableCell11.StyleName = "DetailData3"
        Me.xrTableCell11.Text = "xrTableCell11"
        Me.xrTableCell11.Weight = 0.11553651724106592R
        '
        'xrTableCell12
        '
        Me.xrTableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[fecha]")})
        Me.xrTableCell12.Name = "xrTableCell12"
        Me.xrTableCell12.StyleName = "DetailData3"
        Me.xrTableCell12.Text = "xrTableCell12"
        Me.xrTableCell12.TextFormatString = "{0:d/M/yyyy HH:mm}"
        Me.xrTableCell12.Weight = 0.168379783611559R
        '
        'xrTableCell13
        '
        Me.xrTableCell13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Horas_Actuales]")})
        Me.xrTableCell13.Name = "xrTableCell13"
        Me.xrTableCell13.StyleName = "DetailData3"
        Me.xrTableCell13.StylePriority.UseTextAlignment = False
        Me.xrTableCell13.Text = "xrTableCell13"
        Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell13.TextFormatString = "{0:#.00}"
        Me.xrTableCell13.Weight = 0.14337280241980013R
        '
        'xrTableCell14
        '
        Me.xrTableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Horometro_anterior]")})
        Me.xrTableCell14.Name = "xrTableCell14"
        Me.xrTableCell14.StyleName = "DetailData3"
        Me.xrTableCell14.StylePriority.UseTextAlignment = False
        Me.xrTableCell14.Text = "xrTableCell14"
        Me.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell14.TextFormatString = "{0:#.00}"
        Me.xrTableCell14.Weight = 0.14083918488187508R
        '
        'xrTableCell15
        '
        Me.xrTableCell15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[delta]")})
        Me.xrTableCell15.Name = "xrTableCell15"
        Me.xrTableCell15.StyleName = "DetailData3"
        Me.xrTableCell15.StylePriority.UseTextAlignment = False
        Me.xrTableCell15.Text = "xrTableCell15"
        Me.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell15.TextFormatString = "{0:#.00}"
        Me.xrTableCell15.Weight = 0.10106718313529917R
        '
        'xrTableCell16
        '
        Me.xrTableCell16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cantidad]")})
        Me.xrTableCell16.Name = "xrTableCell16"
        Me.xrTableCell16.StyleName = "DetailData3"
        Me.xrTableCell16.StylePriority.UseTextAlignment = False
        Me.xrTableCell16.Text = "xrTableCell16"
        Me.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell16.Weight = 0.13156692016758809R
        '
        'xrTableCell17
        '
        Me.xrTableCell17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[proyecto]")})
        Me.xrTableCell17.Name = "xrTableCell17"
        Me.xrTableCell17.StyleName = "DetailData3"
        Me.xrTableCell17.StylePriority.UseTextAlignment = False
        Me.xrTableCell17.Text = "xrTableCell17"
        Me.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell17.Weight = 0.1620161398110847R
        '
        'xrTableCell18
        '
        Me.xrTableCell18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[estacion]")})
        Me.xrTableCell18.Name = "xrTableCell18"
        Me.xrTableCell18.StyleName = "DetailData3"
        Me.xrTableCell18.Text = "xrTableCell18"
        Me.xrTableCell18.Weight = 0.14406184414669476R
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Title.Name = "Title"
        '
        'DetailCaption3
        '
        Me.DetailCaption3.BackColor = System.Drawing.Color.Transparent
        Me.DetailCaption3.BorderColor = System.Drawing.Color.Transparent
        Me.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailCaption3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.DetailCaption3.Name = "DetailCaption3"
        Me.DetailCaption3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData3
        '
        Me.DetailData3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DetailData3.ForeColor = System.Drawing.Color.Black
        Me.DetailData3.Name = "DetailData3"
        Me.DetailData3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailData3_Odd
        '
        Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
        Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailData3_Odd.BorderWidth = 1.0!
        Me.DetailData3_Odd.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
        Me.DetailData3_Odd.Name = "DetailData3_Odd"
        Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DetailCaptionBackground3
        '
        Me.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent
        Me.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.DetailCaptionBackground3.BorderWidth = 2.0!
        Me.DetailCaptionBackground3.Name = "DetailCaptionBackground3"
        '
        'PageInfo
        '
        Me.PageInfo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.PageInfo.Name = "PageInfo"
        Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'parameter1
        '
        Me.parameter1.Description = "Fecha_inicial"
        Me.parameter1.Name = "parameter1"
        Me.parameter1.Type = GetType(Date)
        '
        'parameter2
        '
        Me.parameter2.Description = "fecha_final"
        Me.parameter2.Name = "parameter2"
        Me.parameter2.Type = GetType(Date)
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Image = CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image)
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 23.62501!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(191.9743!, 70.91666!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrLabel2
        '
        Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[parameter1]")})
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(110.6524!, 141.5833!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrLabel2.Text = "xrLabel2"
        Me.xrLabel2.TextFormatString = "{0:d/M/yyyy}"
        '
        'xrLabel3
        '
        Me.xrLabel3.BackColor = System.Drawing.Color.Orange
        Me.xrLabel3.ForeColor = System.Drawing.Color.White
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 141.5833!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrLabel3.StylePriority.UseBackColor = False
        Me.xrLabel3.StylePriority.UseForeColor = False
        Me.xrLabel3.Text = "Generado del:"
        '
        'xrLabel4
        '
        Me.xrLabel4.BackColor = System.Drawing.Color.Orange
        Me.xrLabel4.ForeColor = System.Drawing.Color.White
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(227.391!, 141.5833!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(28.125!, 23.0!)
        Me.xrLabel4.StylePriority.UseBackColor = False
        Me.xrLabel4.StylePriority.UseForeColor = False
        Me.xrLabel4.Text = "Al:"
        '
        'xrLabel5
        '
        Me.xrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[parameter2]")})
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(270.0994!, 141.5833!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrLabel5.Text = "xrLabel5"
        Me.xrLabel5.TextFormatString = "{0:d/M/yyyy}"
        '
        'Combustible
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.reportHeaderBand1, Me.groupHeaderBand1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
        Me.DataMember = "seguimiento"
        Me.DataSource = Me.sqlDataSource1
        Me.Margins = New System.Drawing.Printing.Margins(100, 14, 3, 74)
        Me.PageHeight = 1268
        Me.PageWidth = 929
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4Extra
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.parameter1, Me.parameter2})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.DetailCaption3, Me.DetailData3, Me.DetailData3_Odd, Me.DetailCaptionBackground3, Me.PageInfo})
        Me.Version = "17.2"
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

End Class