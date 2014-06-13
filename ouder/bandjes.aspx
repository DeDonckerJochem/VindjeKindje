<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="bandjes.aspx.cs" Inherits="ouder_bandjes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" src="<%= Page.ResolveUrl("~/styles/app.js")%>"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="omslag_center">

        <div id="content">
            
                <asp:Repeater ID="RepKinderen" runat="server">

                    <ItemTemplate>
                        <table cellspacing="0">
                        <tr class="benaming">
                            <td><span>Naam:</span></td>
                            <td><%# Eval("Naam") %></td>
                        </tr>
                        <tr>
                            <td><span>Voornaam:</span></td>
                            <td><%# Eval("Voornaam") %></td>
                        </tr>
                        <tr class="benaming">
                            <td><span>Geboorte datum:</span></td>
                            <td><%# Eval("GebDate","{0:MMMM d, yyyy}")%></td>
                        </tr>
                        </table>
                        <table>
                        <tr class="detail">
                           <td><a href="Kindprofiel.aspx/?id=<%# Eval("KindId") %>">Detail</a></td>

                        </tr>
                        </table>
                        
                        
                    </ItemTemplate>

                   
                </asp:Repeater>
            

        </div>
    </div>
    <script type="text/javascript">
        var id = '<%# id%>';


        for (var i = 1; i <= id; i++) {
            //adddiv(i)
            addTable(i);
            addImage(i);
            //for (var j = 1; j <= 1; j++) {

            addButton(i);
            //  }

        }

        //var element = document.getElementById('Button');
        var button1 = document.getElementById('Button1');
        var button2 = document.getElementById('Button2');
        var button3 = document.getElementById('Button3');
        var button4 = document.getElementById('Button4');
        var button5 = document.getElementById('Button5');
        var button6 = document.getElementById('Button6');

        function buttonfunction() {
            // onclick stuff
            //alert('het werkt!.');
            window.location = "../ouder/Kindprofiel.aspx"
        }

        button1.onclick = buttonfunction;
        button2.onclick = buttonfunction;
        button3.onclick = buttonfunction;
        button4.onclick = buttonfunction;
        button5.onclick = buttonfunction;
        button6.onclick = buttonfunction;




    </script>

</asp:Content>

