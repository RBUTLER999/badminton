<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BadmintonContact.aspx.cs" Inherits="Contact" Title="Contact" %>

<%@ Register Assembly="RBGP.WebControls.EmailLink" Namespace="RBGP.WebControls" TagPrefix="rbgp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ph_Centre" runat="Server">
    <h1>Contact Details</h1>
    <p>Email :
        <rbgp:EmailLink ID="emailId" runat="server" NavigateUrl="mailto:angelcentre.badders.club@hotmail.co.uk">angelcentre.badders.club@hotmail.co.uk</rbgp:EmailLink></p>
    <p>
        Angel Centre, Angel Lane, Tonbridge,Kent TN9 1SF
        <span>
            <a href="http://maps.google.co.uk/maps?hl=en&source=hp&um=1&ie=UTF-8&q=angel+centre+tonbridge&fb=1&gl=uk&hq=angel+centre&hnear=tonbridge&cid=0,0,3603687750212524964&ei=T8cXS9efDc604Qb1nunlAg&sa=X&oi=local_result&ct=image&resnum=1&ved=0CAgQnwIwAA">Google map link</a>
        </span>
    </p>
    <p>Tel. 01732 359966</p>
</asp:Content>
