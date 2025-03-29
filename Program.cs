double total, total1, pagamento, juros, mim, valorNao, mensal, diario, credito;

Console.Clear();
Console.WriteLine("--- Crédito Rotativo de Cartão de Crédito ---");

   Console.WriteLine("Valor total da fatura (R$)...:");
      total1 = Convert.ToDouble(Console.ReadLine());
         
    Console.WriteLine("Pagamento mínimo (%).........:");
       mim = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Taxa de juros mensais (%)....:");
       juros = Convert.ToDouble(Console.ReadLine());

       total= total1 * (mim /100);

Console.WriteLine($"Pagamento mínimo.............: {total}"); 

    Console.WriteLine();
    Console.WriteLine("Caso seja pago o valor mínimo:");

    valorNao = total1 - total ;
    Console.WriteLine($"Valor não pago....................:{valorNao}");

    juros = valorNao * (juros / 100);
    Console.WriteLine($"Juros.............................:{juros}");

    mensal = 0.38;
    mensal = mensal * valorNao ;
    mensal = mensal /100;
    Console.WriteLine($"IOF mensal........................: {mensal}");

    diario = 0.246;
    diario = diario * valorNao;
    diario = diario / 100;
    Console.WriteLine($"OF diário........................:{diario:N2}");

    pagamento = valorNao + juros + mensal + diario; 
       Console.WriteLine();
          Console.WriteLine($"Valor a pagar na próxima fatura...:{pagamento:N2}");

credito = juros + mensal + diario;

  Console.WriteLine($"Custo do crédito rotativo........{credito:N2}");
