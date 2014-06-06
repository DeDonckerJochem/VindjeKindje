<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="bandjes.aspx.cs" Inherits="ouder_bandjes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" src="<%= Page.ResolveUrl("~/styles/app.js")%>"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="omslag_center">

        <div id="center">
            <div id="links-profiel">
                <div id="image">
                </div>

            </div>
            <div id="rechts-profiel">

                <div id="myDynamicTable">
                </div>

                <div id="button">
                </div>

            </div>
        </div>
    </div>
    <script type="text/javascript">
        var id = '<%# id%>';
        for (var i = 1; i <= id; i++) {
            addTable();
            addImage();
            for (var j = 1; j <= 1; j++) {

                addButton();
            }

        }
    </script>
   
</asp:Content>

