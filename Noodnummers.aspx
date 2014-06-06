<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Noodnummers.aspx.cs" Inherits="Noodnummers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--Begin van middeblok-->
    <div class="inner">
        <!--Begin van middeblok-->
        <div class="center-block">
            <p>
                <a href="tel:100" title="brandweer">
                    <img src="<%= Page.ResolveUrl("~/images/Untitled-6-05.png")%>" alt="brandweer" /></a><p class="mobilesOnly">Algemeen telefoonnummer voor hulpdiensten: 100</p></p>
            
            
            <div class="clear">
            </div>
            <p>
                <a href="tel:070245245" title="anti gif centrum">
                    <img src="<%= Page.ResolveUrl("~/images/Untitled-6-02.png")%>" alt="anti gif centrum" /></a></p>
            
            <p class="mobilesOnly">Telefoon nummer voor het antigif centrum: </p>
            <div class="clear">
            </div>
            <p>
                <a href="tel:116000" title="child focus">
                    <img src="<%= Page.ResolveUrl("~/images/Untitled-6-04.png")%>" alt="child focus" /></a></p>
           
            <p class="mobilesOnly">Europees telefoon nummer voor Child Focus: 116 000 </p>
            <div class="clear">
            </div>
            <p>
                <a href="tel:100" title="politie">
                    <img src="<%= Page.ResolveUrl("~/images/Untitled-6-03.png")%>" alt="politie" /></a></p>
            <p class="mobilesOnly">Algemeen telefoonnummer voor hulpdiensten: 100</p>
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
