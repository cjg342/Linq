<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm14.aspx.cs" Inherits="Linq.WebForm14" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Part 14 LINQ query deferred execution
            <br />
            LINQ operators can be broadly classified into 2 categories based on the behaviour of query execution
            <br />
            1. Deferred or Lazy Operators -  These query operators use deferred execution. Examples - select, where, Take, Skip etc
            <br />
            2. Immediate or Greedy Operators - These query operators use immediate execution. Examples - count, average, min, max, ToList etc

        </div>
    </form>
</body>
</html>
