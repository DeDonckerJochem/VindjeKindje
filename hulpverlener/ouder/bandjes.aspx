<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="bandjes.aspx.cs" Inherits="ouder_bandjes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" src="<%= Page.ResolveUrl("~/styles/app.js")%>"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="omslag_center">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <div class="center-bandjes" style="width:1024px; margin:auto;" >
           <!-- <p>Informatie over het 1ste kindje:</p>-->
            <div class="links-profiel-bandjes" style="float:left; margin-left:220px;">
                <div id="image1">
                </div>
            </div>
            <div class="rechts-profiel-bandjes" style="float:left">

                <div id="myDynamicTable1" style="float:left; margin-top:25px;" >
                </div>
                <div class="clear">
                </div>
                <div id="button1" style="float:left">
                </div>

            </div>

        </div>
         <div class="clear">
        </div>
        <div class="center-bandjes" style="width:1024px; margin:auto;">

            <div class="links-profiel-bandjes" style="float:left; margin-left:220px;">
                <div id="image2">
                </div>
            </div>
            <div class="rechts-profiel-bandjes" style="float:left">

                <div id="myDynamicTable2" style="float:left; margin-top:25px;">
                </div>
                
                <div class="clear">
                </div>
                <div id="button2" style="float:left">
                </div>

            </div>

        </div>
         <div class="clear">
        </div>
        <div class="center-bandjes" style="width:1024px; margin:auto;">

            <div class="links-profiel-bandjes" style="float:left; margin-left:220px;">
                <div id="image3">
                </div>
            </div>
            <div class="rechts-profiel-bandjes" style="float:left">

                <div id="myDynamicTable3" style="float:left; margin-top:25px;">
                </div>
                <div class="clear">
                </div>
                <div id="button3" style="float:left">
                </div>

            </div>

        </div>
         <div class="clear">
        </div>
        <div class="center-bandjes" style="width:1024px; margin:auto;">

            <div class="links-profiel-bandjes" style="float:left; margin-left:220px;">
                <div id="image4">
                </div>
            </div>
            <div class="rechts-profiel-bandjes" style="float:left">

                <div id="myDynamicTable4" style="float:left; margin-top:25px;">
                </div>
                <div class="clear">
                </div>
                <div id="button4" style="float:left">
                </div>

            </div>

        </div>
         <div class="clear">
        </div>
        <div class="center-bandjes" style="width:1024px; margin:auto;">

            <div class="links-profiel-bandjes" style="float:left; margin-left:220px;">
                <div id="image5">
                </div>
            </div>
            <div class="rechts-profiel-bandjes" style="float:left">

                <div id="myDynamicTable5" style="float:left; margin-top:25px;">
                </div>
                <div class="clear">
                </div>
                <div id="button5" style="float:left">
                </div>

            </div>

        </div>
         <div class="clear">
        </div>
        <!--tot 5 kinderen hebben css opmaak verder uitwerken indien nodig-->
        <div class="center-bandjes">

            <div class="links-profiel-bandjes">
                <div id="image6">
                </div>
            </div>
            <div class="rechts-profiel-bandjes">

                <div id="myDynamicTable6">
                </div>

                <div id="button6">
                </div>

            </div>

        </div>
         <div class="clear">
        </div>
        <div class="center-bandjes">

            <div class="links-profiel-bandjes">
                <div id="image7">
                </div>
            </div>
            <div class="rechts-profiel-bandjes">

                <div id="myDynamicTable7">
                </div>

                <div id="button7">
                </div>

            </div>

        </div>
         <div class="clear">
        </div>
        <div class="center-bandjes">

            <div class="links-profiel-bandjes">
                <div id="image8">
                </div>
            </div>
            <div class="rechts-profiel-bandjes">

                <div id="myDynamicTable8">
                </div>

                <div id="button8">
                </div>

            </div>

        </div>
         <div class="clear">
        </div>
        <div class="center-bandjes">

            <div class="links-profiel-bandjes">
                <div id="image9">
                </div>
            </div>
            <div class="rechts-profiel-bandjes">

                <div id="myDynamicTable9">
                </div>

                <div id="button9">
                </div>

            </div>

        </div>
         <div class="clear">
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

