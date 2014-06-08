<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!--Begin van middeblok-->
        <div class="inner">
            <!--Begin van links middeblok-->
            <div class="left-block">
                <img src="images/cs.png" alt="xx" />
                <p>
                    
                    Een handige vind je kind web applicatie
                </p>
            </div>
            <!--Begin van rechts middeblok-->
            <div class="right-block">
                <img src="<%= Page.ResolveUrl("~/images/Voorprent4500.png")%>" />
                
            </div>
        </div>
    <!--<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>-->
</asp:Content>

