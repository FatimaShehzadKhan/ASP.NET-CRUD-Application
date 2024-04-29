<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUDApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <!-- Page Header -->
        <h1 style="font-size: 19pt" align="center">Patient Information</h1>
        <br />

        <!-- Table for user input and buttons -->
        <table class="w-100">
            <!-- Row for Patient ID with TextBox and Get button -->
            <tr>
                <td class="text-center" style="width: 381px">Patient ID</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Get" BorderColor="#CCCCFF" ForeColor="#660033" Width="70px" />
                </td>
            </tr>

            <!-- Row for Patient Name -->
            <tr>
                <td class="text-center" style="height: 21px; width: 381px">Patient Name</td>
                <td style="height: 21px">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>

            <!-- Row for Age -->
            <tr>
                <td class="text-center" style="width: 381px">Age</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>

            <!-- Row for Address with DropDownList -->
            <tr>
                <td class="text-center" style="width: 381px; height: 21px">Address</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="125px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>Karachi</asp:ListItem>
                        <asp:ListItem>Lahore</asp:ListItem>
                        <asp:ListItem>Hyderabad</asp:ListItem>
                        <asp:ListItem>Islamabad</asp:ListItem>
                        <asp:ListItem>Peshawar</asp:ListItem>
                        <asp:ListItem>Sukkar</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>

            <!-- Row for Contact -->
            <tr>
                <td class="text-center" style="width: 381px">Contact</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>

            <!-- Row for After Submission buttons -->
            <tr>
                <td class="text-center" style="width: 381px">After Submission: </td>
                <td>
                    <!-- Buttons for Insert, Update, Delete, Search, and Sort operations -->
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" BorderColor="#CCCCFF" ForeColor="#660033" Width="70px" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" BorderColor="#CCCCFF" ForeColor="#660033" Width="70px" />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" OnClientClick="return confirm('Are you sure you want to delete?')" Text="Delete" BorderColor="#CCCCFF" ForeColor="#660033" Width="70px" />
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Search" BorderColor="#CCCCFF" ForeColor="#660033" Width="70px" />
                    <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Sort" BorderColor="#CCCCFF" ForeColor="#660033" Width="70px" />
                </td>
            </tr>

            <!-- Row for Patient Records with GridView -->
            <tr>
                <td class="text-center" style="width: 381px">Patient Records: </td>
                <td>
                    <!-- GridView for displaying patient records with paging support -->
                    <asp:GridView ID="GridView1" runat="server" Width="575px" AllowPaging="true" OnPageIndexChanging="OnPageIndexchanging" PageSize="2">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
