﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="profiel.aspx.cs" Inherits="ouder_profiel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div id="omslag_center">
    <div id="center">
        <div id="links-profiel">
            <img src="<%= Page.ResolveUrl("~/images/headshot.jpg")%>" alt="Profile Picture" style="max-height: 205px; max-width: 267px;"  />
        </div>
        <div id="rechts-profiel">
        <h1>General information:</h1>
            <!--<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>-->
            <table>
                <tbody>
                    <tr><td><asp:Label ID="NaamLbl" runat="server" Text="Naam:"></asp:Label></td>
                    <td><asp:TextBox ID="NaamTxt" runat="server"></asp:TextBox>
                    
                    </td></tr>

                    <tr><td><asp:Label ID="VoornaamLbl" runat="server" Text="Voornaam:"></asp:Label></td>
                    <td><asp:TextBox ID="VoornaamTxt" runat="server"></asp:TextBox>
                    <!--<img class="editpijltje" src="../images/pencil-icon.png" alt="edit pencile" />--></td></tr>

                    <tr><td><asp:Label ID="TelLbl" runat="server" Text="Tel:"></asp:Label></td>
                    <td><asp:TextBox ID="TelTxt" runat="server"></asp:TextBox>
                    <!--<img class="editpijltje" src="../images/pencil-icon.png" alt="edit pencile" />--></td></tr>

                    <tr><td><asp:Label ID="MutLbl" runat="server" Text="Mutualiteits nr:"></asp:Label></td>
                    <td><asp:TextBox ID="MutTxt" runat="server"></asp:TextBox>
                    <!--<img class="editpijltje" src="../images/pencil-icon.png" alt="edit pencile" />--></td></tr>

                    <tr><td><asp:Label ID="GebDatLbl" runat="server" Text="Geboorte datum:"></asp:Label></td>
                    <td><asp:TextBox ID="GebDatTxt" runat="server"></asp:TextBox>
                    <!--<img class="editpijltje" src="../images/pencil-icon.png" alt="edit pencile" />--></td></tr>

                    <tr><td><asp:Label ID="BloedgroepLbl" runat="server" Text="Bloedgroep:"></asp:Label></td>
                    <td><asp:TextBox ID="BloedgroepTxt" runat="server"></asp:TextBox>
                    <!--<img class="editpijltje" src="../images/pencil-icon.png" alt="edit pencile" />--></td></tr>

                    <tr><td><asp:Label ID="AdresLbl" runat="server" Text="Adres:"></asp:Label></td>
                    <td><asp:TextBox ID="AdresTxt" runat="server"></asp:TextBox>
                    <!--<img class="editpijltje" src="../images/pencil-icon.png" alt="edit pencile" />--></td></tr>


                    <tr><td>
                        <asp:Label ID="EditLbl" runat="server" Text="Edit Fields: "></asp:Label>
                        <asp:ImageButton ID="EditBtn"  runat="server" OnClick="EditBtn_Click" class="editpijltje" src="../images/pencil-icon.png" /></td>
                        <td>
                        <asp:Label ID="SaveLbl" runat="server" Text="Save Fields: "></asp:Label>
                        <asp:ImageButton ID="SaveBtn" runat="server" OnClick="SaveBtn_Click" class="editpijltje" src="../images/checkmark-icon.png" /></td>
                    </tr>
                </tbody>
           </table>

            

            
        </div>
        
   </div>
</div>
</asp:Content>

