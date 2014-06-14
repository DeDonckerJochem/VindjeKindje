<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kindprofiel.aspx.cs" Inherits="ouder_Kindprofiel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="omslag_center">
    <div id="center">
        <div id="links-profiel">
           
            <asp:GridView ID="gvDetails" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="Profiel foto">                   
                        <ItemTemplate>
                            <asp:Image ID="ImageName" ImageUrl='<%# "Handler.ashx?ProfielFotoId="+ Eval("ProfielFotoId") %>' runat="server"
                                Height="200px" Width="200px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
     <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
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

                    

                    

                    <tr><td><asp:Label ID="GebDatLbl" runat="server" Text="Geboorte datum:"></asp:Label></td>
                    <td><asp:TextBox ID="GebDatTxt" runat="server"></asp:TextBox>
                    <!--<img class="editpijltje" src="../images/pencil-icon.png" alt="edit pencile" />--></td></tr>

                    <tr><td><asp:Label ID="BloedgroepLbl" runat="server" Text="Bloedgroep:"></asp:Label></td>
                    <td><asp:TextBox ID="BloedgroepTxt" runat="server"></asp:TextBox>
                    <!--<img class="editpijltje" src="../images/pencil-icon.png" alt="edit pencile" />--></td></tr>

                    <tr><td><asp:Label ID="AdresLbl" runat="server" Text="Adres:"></asp:Label></td>
                    <td><asp:TextBox ID="AdresTxt" runat="server"></asp:TextBox>
                    <!--<img class="editpijltje" src="../images/pencil-icon.png" alt="edit pencile" />--></td></tr>

                    <asp:HiddenField ID="KindIdlbl" runat="server" Value="" />
                    <tr><td>
                        <asp:Label ID="EditLbl" runat="server" Text="Edit Fields: "></asp:Label>
                        <asp:ImageButton ID="EditBtn"  runat="server" OnClick="EditBtn_Click" class="editpijltje" src="../../images/pencil-icon.png" /></td>
                        <td>
                        <asp:Label ID="SaveLbl" runat="server" Text="Save Fields: "></asp:Label>
                        <asp:ImageButton ID="SaveBtn" runat="server" OnClick="SaveBtn_Click" class="editpijltje" src="../../images/checkmark-icon.png" /></td>
                    </tr>
                </tbody>
           </table>

            

            
        </div>
        
   </div>
</div>
</asp:Content>

