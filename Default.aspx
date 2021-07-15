<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs"  MaintainScrollPositionOnPostback="true" Inherits="webappPolutionIndex._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Panel ID="PanelHeadImage" runat="server">
             </asp:Panel> 
    </div>
     <div class="row">
        <div class="col-md-12">
                <asp:Panel ID="PanelHeader" runat="server">
             </asp:Panel>     
            </div>
      </div>
    <div class="row">
        <div class="col-md-12" id="MainDiv">
            <h2>SELECT YOUR CITY<h2>
               <asp:Panel ID="btnPanel" runat="server">
                </asp:Panel>

        </div>
        <div class="col-md-6">
            <p>AIR QUALITY INDEX</p>
            <p >
                <asp:Panel ID="PanelAirQualityIndex" runat="server">

                </asp:Panel>
            </p>
            
        </div>
        <div class="col-md-6">
             <asp:Panel ID="PanelCity" runat="server">
                 

             </asp:Panel>
             <asp:Panel ID="PanelCig" runat="server">
                 

             </asp:Panel>
        </div>
        <br />
    </div>
     <div class="row">
        <div class="col-md-12">
                <asp:Panel ID="PanelFooter" runat="server">
             </asp:Panel>     
            </div>
      </div>
</asp:Content>
