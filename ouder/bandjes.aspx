<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="bandjes.aspx.cs" Inherits="ouder_bandjes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" src="<%= Page.ResolveUrl("~/styles/app.js")%>"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="omslag_center">
        <div onload="load()">
            <div id="myform">
                <b>Simple form with name and age ...</b>
                <table>
                    <tr>
                        <td>Name:</td>
                        <td>
                            <input type="text" id="name"></td>
                    </tr>
                    <tr>
                        <td>Age:</td>
                        <td>
                            <input type="text" id="age">
                            <input type="button" id="add" value="Add" onclick="Javascript: addRow()"></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
            <div id="mydata">
                <b>Current data in the system ...</b>
                <table id="myTableData" border="1" cellpadding="2">
                    <tr>
                        <td>&nbsp;</td>
                        <td><b>Name</b></td>
                        <td><b>Age</b></td>
                    </tr>
                </table>
                &nbsp;<br />
            </div>
            <div id="myDynamicTable">
                <input type="button" id="create" value="Click here" onclick="Javascript: addTable()">
                to create a Table and add some data using JavaScript
            </div>
        </div>
    </div>
</asp:Content>

