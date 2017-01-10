<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UploadFixtureList.aspx.cs" Inherits="UploadFixtureList" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ph_Centre" Runat="Server">

      <table cellpadding="10" cellspacing="0" border="2" width="70%">

        <tr>
        <td style="width: 15%;">&nbsp;</td>
        <td style="padding-top:20px; background-color: #666699; height: 173px; width: 85%;">

           <asp:FileUpload ID="FileUpload1" runat="server" BorderColor="Red" /><br />
            
            <br />
            <asp:TextBox id="password" runat="server" TextMode="Password"></asp:TextBox>
            <span style="color: Yellow">&nbsp;Please enter password</span>
            <br />
            <asp:RequiredFieldValidator id="passwordRequiredValidator" runat="server" 
                     ErrorMessage="Password required" ControlToValidate="password"></asp:RequiredFieldValidator>
            <br />
           <asp:Button ID="Button1" runat="server" Onclick="Button_click" Text="Upload fixtureList.xls" BackColor="White" BorderStyle="Outset" />

         </td>

        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><a href="Fixtures.aspx" id="badminton">Back to fixture list</a></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><asp:Label runat="server" ID="lblInfo" style="color: Red"></asp:Label> </td>
        </tr>

      </table>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ph_RightColumn" Runat="Server">
</asp:Content>

