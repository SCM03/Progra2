<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="WeBcalculadora.Calculadora" %>

<!DOCTYPE html>
<html lang="es" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Calculadora</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: black;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .calculator {
            background-color: #b3e5fc;
            padding: 20px;
            border-radius: 10px;
            width: 280px;
            box-shadow: 0 0 10px rgba(0,0,0,0.2);
        }
        h1 {
            text-align: center;
            color: #01579b;
            margin-top: 0;
            font-size: 24px;
        }
        .display {
            background-color: #ffffff;
            padding: 15px;
            font-size: 24px;
            text-align: right;
            border-radius: 5px;
            margin-bottom: 15px;
            min-height: 40px;
            color: #d32f2f;
            font-weight: bold;
            word-wrap: break-word;
        }
        .buttons {
            display: grid;
            grid-template-columns: repeat(4, 1fr);
            gap: 10px;
        }
        .button {
            padding: 15px;
            background-color: #ffffff;
            border: none;
            border-radius: 5px;
            font-size: 16px;
            cursor: pointer;
            transition: background-color 0.2s;
        }
        .button:hover {
            background-color: #f5f5f5;
        }
        .button:active {
            background-color: #e0e0e0;
        }
        .button.red {
            background-color: #f44336;
            color: white;
        }
        .button.red:hover {
            background-color: #d32f2f;
        }
        .button.operator {
            background-color: #81d4fa;
        }
        .button.operator:hover {
            background-color: #4fc3f7;
        }
        .button.equals {
            background-color: #4caf50;
            color: white;
        }
        .button.equals:hover {
            background-color: #388e3c;
        }
        .button.special {
            background-color: #fff59d;
        }
        .button.special:hover {
            background-color: #fff176;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="calculator">
            <h1>Calculadora ST V1</h1>
            <div class="display">
                <asp:Label ID="lresultado" runat="server"></asp:Label>
            </div>
            <div class="buttons">
                <!-- Fila 1 -->
                <asp:Button ID="b7" class="button" Text="7" runat="server" OnClick="b7_Click" />
                <asp:Button ID="b8" class="button" Text="8" runat="server" OnClick="b8_Click" />
                <asp:Button ID="b9" class="button" Text="9" runat="server" OnClick="b9_Click" />
                <asp:Button ID="bdividir" class="button operator" Text="÷" runat="server" OnClick="bdividir_Click" />
                
                <!-- Fila 2 -->
                <asp:Button ID="b4" class="button" Text="4" runat="server" OnClick="b4_Click" />
                <asp:Button ID="b5" class="button" Text="5" runat="server" OnClick="b5_Click" />
                <asp:Button ID="b6" class="button" Text="6" runat="server" OnClick="b6_Click" />
                <asp:Button ID="bmultiplicar" class="button operator" Text="×" runat="server" OnClick="bmultiplicar_Click" />
                
                <!-- Fila 3 -->
                <asp:Button ID="b1" class="button" Text="1" runat="server" OnClick="b1_Click" />
                <asp:Button ID="b2" class="button" Text="2" runat="server" OnClick="b2_Click" />
                <asp:Button ID="b3" class="button" Text="3" runat="server" OnClick="b3_Click" />
                <asp:Button ID="bresta" class="button operator" Text="-" runat="server" OnClick="bresta_Click" />
                
                <!-- Fila 4 -->
                <asp:Button ID="b0" class="button" Text="0" runat="server" OnClick="b0_Click" />
                <asp:Button ID="bpunto" class="button" Text="." runat="server" OnClick="bpunto_Click" />
                <asp:Button ID="braiz" class="button special" Text="√" runat="server" OnClick="braiz_Click" />
                <asp:Button ID="bsuma" class="button operator" Text="+" runat="server" OnClick="bsuma_Click" />
                
                <!-- Fila 5 -->
                <asp:Button ID="bclear" class="button red" Text="C" runat="server" OnClick="bclear_Click" />
                <asp:Button ID="bpot2" class="button special" Text="x²" runat="server" OnClick="bpot2_Click" />
                <asp:Button ID="bresultado" class="button equals" Text="=" runat="server" OnClick="bresultado_Click" />
                <asp:Button ID="bpot3" class="button special" Text="x³" runat="server" OnClick="bpot3_Click" />
                
                <!-- Fila 6 -->
                <asp:Button ID="bfactorial" class="button special" Text="n!" runat="server" OnClick="bfactorial_Click" />
                <asp:Button ID="bfibonacci" class="button special" Text="Fibo" runat="server" OnClick="bfibonacci_Click" />
            </div>
        </div>
    </form>
</body>
</html>
