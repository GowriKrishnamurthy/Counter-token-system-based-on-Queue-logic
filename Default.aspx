<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CounterQueueImp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <table style="border: 1px solid black; font-family: Arial; text-align: center">
            <tr>
                <td><b>Counter 1 </b></td>
                <td></td>
                <td><b>Counter 2 </b></td>
                <td></td>
                <td><b>Counter 3 </b></td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtCounter1" Width="150px" Font-Size="Large" runat="server"
                        BackColor="#000099" ForeColor="White">
                    </asp:TextBox>
                </td>
                <td></td>
                <td>
                    <asp:TextBox ID="txtCounter2" Width="150px" Font-Size="Large" runat="server" BackColor="#000099" ForeColor="White">
                    </asp:TextBox>
                </td>
                <td></td>
                <td>
                    <asp:TextBox ID="txtCounter3" Font-Size="Large" runat="server"
                        BackColor="#000099" ForeColor="White" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnCounter1" Width="150px" runat="server" Text="Next" />
                </td>
                <td></td>
                <td>
                    <asp:Button ID="btnCounter2" Width="150px" runat="server" Text="Next" />
                </td>
                <td></td>
                <td>
                    <asp:Button ID="btnCounter3" Width="150px" runat="server" Text="Next" /></td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:TextBox ID="txtCounterStatus" Font-Size="small" runat="server" BackColor="#000099" ForeColor="White" Width="500px"> </asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:ListBox ID="listTokens" Width="100px" Font-Size="Medium" runat="server"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Button ID="btnPrintToken" Text="Print Tokens" runat="server" /></td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label ID="lblCurrentStatus" Font-Size="small" runat="server"
                        BackColor="#000099" ForeColor="White" Text="Status">     </asp:Label>
                </td>
            </tr>
        </table>
</asp:Content>
