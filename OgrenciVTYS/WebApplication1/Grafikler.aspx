<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="Grafikler.aspx.cs" Inherits="WebApplication1.Grafikler" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<%@ Register assembly="DevExpress.XtraCharts.v22.2.Web, Version=22.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts.Web" tagprefix="dx" %>
<%@ Register assembly="DevExpress.XtraCharts.v22.2, Version=22.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <table class="table table-bordered table-hover">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <dx:WebChartControl ID="WebChartControl1" runat="server" Height="300px" Width="500px" CrosshairEnabled="True">
                        <DiagramSerializable>
                            <dx:SimpleDiagram3D RotationMatrixSerializable="1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1">
                            </dx:SimpleDiagram3D>
                        </DiagramSerializable>
                        <SeriesSerializable>
                            <dx:Series Name="Dersler">
                                <ViewSerializable>
                                    <dx:Pie3DSeriesView>
                                    </dx:Pie3DSeriesView>
                                </ViewSerializable>
                            </dx:Series>
                        </SeriesSerializable>
                    </dx:WebChartControl>
                </td>
                <td>
                    <dx:WebChartControl ID="WebChartControl2" runat="server" Height="300px" Width="500px" CrosshairEnabled="True">
                        <DiagramSerializable>
                            <dx:XYDiagram>
                                <AxisX VisibleInPanesSerializable="-1">
                                </AxisX>
                                <AxisY VisibleInPanesSerializable="-1">
                                </AxisY>
                            </dx:XYDiagram>
                        </DiagramSerializable>
                        <SeriesSerializable>
                            <dx:Series Name="Öğretmen">
                            </dx:Series>
                        </SeriesSerializable>
                    </dx:WebChartControl>
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
