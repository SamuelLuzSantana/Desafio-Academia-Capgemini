int Anagrama(string text) {
    string[] rascunho = new string[2];
    char rascunho2;
    int saida = 0;

    for (int i = 0; i < text.Count(); i++) {
        for (int i2 = 1; i2 < text.Count(); i2++)
        {
            if (i2 > i)
            {
                for (int i3 = 1; i3 < text.Substring(i2 - 1).Count(); i3++)
                {
                    rascunho[0] = text.Substring(i, i3);
                    rascunho[1] = text.Substring(i2, i3);

                    char[] carac = rascunho[0].ToCharArray();
                    char[] carac2 = rascunho[1].ToCharArray();

                    for(int c = 1; c < carac.Length; c++) {  
                        for(int c2 = 0; c2 < carac.Length - 1; c2++) {  
                            if(carac[c2] > carac[c2 + 1]) {  
                                rascunho2 = carac[c2];  
                                carac[c2] = carac[c2 + 1];  
                                carac[c2 + 1] = rascunho2;  
                            }  
                        }  
                    }  

                    for(int c = 1; c < carac2.Length; c++) {  
                        for(int c2 = 0; c2 < carac2.Length - 1; c2++) {  
                            if(carac2[c2] > carac2[c2 + 1]) {  
                                rascunho2 = carac2[c2];  
                                carac2[c2] = carac2[c2 + 1];  
                                carac2[c2 + 1] = rascunho2;  
                            }  
                        }  
                    }

                    bool igual = true;

                    for(int c = 0; c < carac.Length; c++)
                    {
                        if (carac[c] != carac2[c]) {
                            igual = false;
                        }
                    }

                    if (igual) {
                        saida ++;
                    }
                }
            }
        }
    } 

    return saida;
}

Console.WriteLine("Digite a string");
Console.WriteLine(Anagrama(Console.ReadLine()));

