/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 26/02/2022
 * Time: 11:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NumDecomposto
{
	class Program
	{
		public static void Main(string[] args)
		{
			int v200,v100,v50,v20,v10,v5,v2,centavos,dinheiro;
			Console.Write("Escreva o número em dinheiro: ");
			dinheiro = int.Parse(Console.ReadLine());
			
			
			
		    if (dinheiro > 0){
			v200 = (dinheiro / 200);
			dinheiro = (dinheiro % 200);
			    }
			
		    else{
			 v200 = 0;
			}
		    if (dinheiro > 0){
		    v100 = (dinheiro / 100);
			dinheiro = (dinheiro % 100);
			 }
		   else{
			v100 = 0;
				}
					
           if (dinheiro > 0){
		   v50 = (dinheiro / 50);
		   dinheiro = (dinheiro % 50);
				}
				
	      else{
		  v50 =0;
				}
				
		   if (dinheiro > 0){
		   v20 = (dinheiro / 20);
		   dinheiro = (dinheiro % 20);
					}
			
	      else{
		  v20 =0;
					}
					
		  if (dinheiro > 0){
		  v10 = (dinheiro / 10);
		  dinheiro = (dinheiro % 10);
					}
	     else{
		 v10 = 0;
					}
					
		 if (dinheiro > 0){
		 v5 = (dinheiro / 5);
		 dinheiro = (dinheiro % 5);
					}
	     else{
		 v5 =0;
			    }
					
		 if (dinheiro > 0){
		 v2 = (dinheiro / 2);
		 dinheiro = (dinheiro % 2);
					}
	     else{
		 v2 = 0;
					}
					
		if (dinheiro > 0){
		 centavos = (dinheiro / 1);
				}
			 else {
			centavos = 0;
			 }
			 
				Console.WriteLine ("Notas de R$200: " + v200);
			    Console.WriteLine ("Notas de R$100: " + v100);
				Console.WriteLine ("Notas de R$50: " + v50);
				Console.WriteLine ("Notas de R$20: " + v20);
				Console.WriteLine ("Notas de R$10: " + v10);
				Console.WriteLine ("Notas de R$5: " + v5);
				Console.WriteLine ("Notas de R$2: " + v2);
			 
			if (centavos >= 1){
					Console.WriteLine ("Não é possível sacar R$ " + centavos );
				}
			else{
			centavos = 0;
				}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}