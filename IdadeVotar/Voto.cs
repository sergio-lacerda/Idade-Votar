using System;
using System.Collections.Generic;
using System.Text;

namespace IdadeVotar
{
    public static class Voto
    {
        public static string podeVotar(int vIdade) 
        {
			/*   Código inicial - Antes de executar os testes 
			String voto = "";
			if (vIdade < 16)
				voto = "Não pode votar";
			else
			if ((vIdade > 16) && (vIdade < 18))
				voto = "Voto opcional";
			else
				if (vIdade > 18)
					voto = "Pode votar";
				return voto;
			*/

			/* Código refatorado - Após executar os testes */
			String voto = "";
			if ( vIdade < 0 || vIdade > 130 )
				voto = "Valor inválido";
			else 
			if (vIdade < 16)
				voto = "Não pode votar";
			else
			if ((vIdade >= 16) && (vIdade < 18))
				voto = "Voto opcional";
			else
				if (vIdade >= 18)
				voto = "Pode votar";
			return voto;
		}
	}
}
