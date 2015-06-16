<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        output.Text = "Hello world";
    }

</script>

<%@ Control Language="C#" AutoEventWireup="true" %>
<asp:Literal ID="output" runat="server"></asp:Literal>