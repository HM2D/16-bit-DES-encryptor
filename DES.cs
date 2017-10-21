using System;

using System.Collections;
using System.Text;
namespace DES
{
	class MainClass
	{

	public static	int[,] s1Box = {{14,4,13,1,2,15,11,8,3,10,6,12,5,9,0,7},
			{0,15,7,4,14,2,13,1,10,6,12,11,9,5,3,8},
			{4,1,14,8,13,6,2,11,15,12,9,7,3,10,5,0},
			{15,12,8,2,4,9,1,7,5,11,3,14,10,0,6,13}};
		
	public static	int[,] s2Box = {{15,1,8,14,6,11,3,4,9,7,2,13,12,0,5,10},
			{3,13,4,7,15,2,8,14,12,0,1,10,6,9,11,5},
			{0,14,7,11,10,4,13,1,5,8,12,6,9,3,2,15},
			{13,8,10,1,3,15,4,2,11,6,7,12,0,5,14,9}};
		
	public static	int[,] s3Box = {{10,0,9,14,6,3,15,5,1,13,12,7,11,4,2,8},
			{13,7,0,9,3,4,6,10,2,8,5,14,12,11,15,1},
			{13,6,4,9,8,15,3,0,11,1,2,12,5,10,14,7},
			{1,10,13,0,6,9,8,7,4,15,14,3,11,5,2,12}};
		
 public static		int[,] s4Box = {{7,13,14,3,0,6,9,10,1,2,8,5,11,12,4,15},
			{13,8,11,5,6,15,0,3,4,7,2,12,1,10,14,9},
			{10,6,9,0,12,11,7,13,15,1,3,14,5,2,8,4},
			{3,15,0,6,10,1,13,8,9,4,5,11,12,7,2,14}};
		
		public static int[,] s5Box = {{2,12,4,1,7,10,11,6,8,5,3,15,13,0,14,9},
			{14,11,2,12,4,7,13,1,5,0,15,10,3,9,8,6},
			{4,2,1,11,10,13,7,8,15,9,12,5,6,3,0,14},
			{11,8,12,7,1,14,2,13,6,15,0,9,10,4,5,3}};
		
		public static int[,] s6Box = {{12,1,10,15,9,2,6,8,0,13,3,4,14,7,5,11},
			{10,15,4,2,7,12,9,5,6,1,13,14,0,11,3,8},
			{9,14,15,5,2,8,12,3,7,0,4,10,1,13,11,6},
			{4,3,2,12,9,5,15,10,11,14,1,7,6,0,8,13}};
		
		public static int[,] s7Box = {{4,11,2,14,15,0,8,13,3,12,9,7,5,10,6,1},
			{13,0,11,7,4,9,1,10,14,3,5,12,2,15,8,6},
			{1,4,11,13,12,3,7,14,10,15,6,8,0,5,9,2},
			{6,11,13,8,1,4,10,7,9,5,0,15,14,2,3,12}};
		
		public static int[,] s8Box = {{13,2,8,4,6,15,11,1,10,9,3,14,5,0,12,7},
			{1,15,13,8,10,3,7,4,12,5,6,11,0,14,9,2},
			{7,11,4,1,9,12,14,2,0,6,10,13,15,3,5,8},
			{2,1,14,7,4,10,8,13,15,12,9,0,3,5,6,11}};














		public static void Main (string[] args)
		{
			string plainText = "123456789ADEDABD";
			string key = "133457799BBCDFF1";

			Console.WriteLine ("PlainText: " + plainText);
			Console.WriteLine ("key:" + key);
			string left;
			string right;

			string binaryText = Convert.ToString(Convert.ToInt64(plainText, 16), 2).PadLeft(64, '0');;
			string binaryKey = Convert.ToString(Convert.ToInt64(key, 16), 2).PadLeft(64, '0');;
			//Console.WriteLine(binaryText.Length);
			Console.WriteLine ();
			//Splitting the text
			left = binaryText.Substring (0, 32);
			right = binaryText.Substring (32, 32);



			Console.WriteLine ("left: " +left );

			Console.WriteLine ("right: " +right);


			///Step One convert 64bit key to 56bit
			char[] Key56 = new char[56];

			Key56 [0] = binaryKey [56];
			Key56 [1] = binaryKey [48];
			Key56 [2] = binaryKey [40];
			Key56 [3] = binaryKey [32];
			Key56 [4] = binaryKey [24];
			Key56 [5] = binaryKey [16];
			Key56 [6] = binaryKey [8];
			Key56 [7] = binaryKey [0];
			Key56 [8] = binaryKey [57];
			Key56 [9] = binaryKey [49];
			Key56 [10] = binaryKey [41];
			Key56 [11] = binaryKey [33];
			Key56 [12] = binaryKey [25];
			Key56 [13] = binaryKey [17];
			Key56 [14] = binaryKey [9];
			Key56 [15] = binaryKey [1];
			Key56 [16] = binaryKey [58];
			Key56 [17] = binaryKey [50];
			Key56 [18] = binaryKey [42];
			Key56 [19] = binaryKey [34];
			Key56 [20] = binaryKey [26];
			Key56 [21] = binaryKey [18];
			Key56 [22] = binaryKey [10];
			Key56 [23] = binaryKey [2];
			Key56 [24] = binaryKey [59];
			Key56 [25] = binaryKey [51];
			Key56 [26] = binaryKey [43];
			Key56 [27] = binaryKey [35];
			Key56 [28] = binaryKey [62];
			Key56 [29] = binaryKey [54];
			Key56 [30] = binaryKey [46];
			Key56 [31] = binaryKey [38];
			Key56 [32] = binaryKey [30];
			Key56 [33] = binaryKey [22];
			Key56 [34] = binaryKey [14];
			Key56 [35] = binaryKey [6];
			Key56 [36] = binaryKey [61];
			Key56 [37] = binaryKey [53];
			Key56 [38] = binaryKey [45];
			Key56 [39] = binaryKey [37];
			Key56 [40] = binaryKey [29];
			Key56 [41] = binaryKey [21];
			Key56 [42] = binaryKey [13];
			Key56 [43] = binaryKey [5];
			Key56 [44] = binaryKey [60];
			Key56 [45] = binaryKey [52];
			Key56 [46] = binaryKey [44];
			Key56 [47] = binaryKey [36];
			Key56 [48] = binaryKey [28];
			Key56 [49] = binaryKey [20];
			Key56 [50] = binaryKey [12];
			Key56 [51] = binaryKey [4];
			Key56 [52] = binaryKey [27];
			Key56 [53] = binaryKey [19];
			Key56 [54] = binaryKey [11];
			Key56 [55] = binaryKey [3];

			Console.Write ("56bit Key: ");
			Console.WriteLine (Key56);

			//Spliting the 56bit Key

			string temp = new string (Key56);
			string left28 = temp.Substring (0, 28);

			string right28 = temp.Substring (28, 28);
			Console.WriteLine ("left28: " + left28);
			Console.WriteLine ("right28: " + right28);


			string[] leftKeys = new string[17];

			string[] rightKeys = new string[17];

			leftKeys[0] = left28;
			rightKeys[0] = right28;


			//16 itterations
			for (int i =1; i<17; i++) {
			
				//Shift Once for the following itterations and shift twice for others
				if(i == 0 || i == 1 || i== 8 || i== 16)
				{leftKeys[i] = leftRotateShift(leftKeys[i-1],1);
				rightKeys[i] = leftRotateShift(rightKeys[i-1],1);
				}else {

					leftKeys[i] = leftRotateShift(leftKeys[i-1],2);
					rightKeys[i] = leftRotateShift(rightKeys[i-1],2);

				}
			
		//		Console.WriteLine("\nitteration " + i + " Left Key: " + leftKeys[i]);
		//		Console.WriteLine("\nitteration " + i + " Right Key: " + rightKeys[i]);

			}


			string[] keys48 = new string[16];

			//converting each key to 48-bit
			for (int i=1; i<17; i++) {
	
				string temp2 = leftKeys[i]+rightKeys[i];
				char[] keyTemp = new char[48];
				keyTemp[0] = temp2[13];
				keyTemp[1] = temp2[16];
				keyTemp[2] = temp2[10];
				keyTemp[3] = temp2[23];
				keyTemp[4] = temp2[0];
				keyTemp[5] = temp2[4];
				keyTemp[6] = temp2[2];
				keyTemp[7] = temp2[27];
				keyTemp[8] = temp2[14];
				keyTemp[9] = temp2[5];
				keyTemp[10] = temp2[20];
				keyTemp[11] = temp2[7];
				keyTemp[12] = temp2[22];
				keyTemp[13] = temp2[18];
				keyTemp[14] = temp2[11];
				keyTemp[15] = temp2[3];
				keyTemp[16] = temp2[25];
				keyTemp[17] = temp2[7];
				keyTemp[18] = temp2[15];
				keyTemp[19] = temp2[6];
				keyTemp[20] = temp2[26];
				keyTemp[21] = temp2[19];
				keyTemp[22] = temp2[12];
				keyTemp[23] = temp2[1];
				keyTemp[24] = temp2[40];
				keyTemp[25] = temp2[51];
				keyTemp[26] = temp2[30];
				keyTemp[27] = temp2[36];
				keyTemp[28] = temp2[46];
				keyTemp[29] = temp2[54];
				keyTemp[30] = temp2[29];
				keyTemp[31] = temp2[39];
				keyTemp[32] = temp2[50];
				keyTemp[33] = temp2[44];
				keyTemp[34] = temp2[32];
				keyTemp[35] = temp2[47];
				keyTemp[36] = temp2[43];
				keyTemp[37] = temp2[48];
				keyTemp[38] = temp2[38];
				keyTemp[39] = temp2[55];
				keyTemp[40] = temp2[44];
				keyTemp[41] = temp2[52];
				keyTemp[42] = temp2[45];
				keyTemp[43] = temp2[41];
				keyTemp[44] = temp2[49];
				keyTemp[45] = temp2[35];
				keyTemp[46] = temp2[28];
				keyTemp[47] = temp2[31];


				keys48[i-1] = new string(keyTemp);
			
			}
			Console.WriteLine ();

			/*
			for (int i =0; i<16; i++) {
			
			
			
				Console.WriteLine("48-bit keys["+i +"]: "+ keys48[i]);
			
			
			}

*/
			/////STEP TWO

			//initial permutation
			char[] IP = new char[64];

			IP[0] = binaryText[57];
			IP[1] = binaryText[49];
			IP[2] = binaryText[41];
			IP[3] = binaryText[33];
			IP[4] = binaryText[25];
			IP[5] = binaryText[17];
			IP[6] = binaryText[9];
			IP[7] = binaryText[1];
			IP[8] = binaryText[59];
			IP[9] = binaryText[51];
			IP[10] = binaryText[43];
			IP[11] = binaryText[35];
			IP[12] = binaryText[27];
			IP[13] = binaryText[19];
			IP[14] = binaryText[11];
			IP[15] = binaryText[3];
			IP[16] = binaryText[61];
			IP[17] = binaryText[53];
			IP[18] = binaryText[45];
			IP[19] = binaryText[37];
			IP[20] = binaryText[29];
			IP[21] = binaryText[21];
			IP[22] = binaryText[13];
			IP[23] = binaryText[5];
			IP[24] = binaryText[63];
			IP[25] = binaryText[55];
			IP[26] = binaryText[47];
			IP[27] = binaryText[39];
			IP[28] = binaryText[31];
			IP[29] = binaryText[23];
			IP[30] = binaryText[15];
			IP[31] = binaryText[7];
			IP[32] = binaryText[56];
			IP[33] = binaryText[48];
			IP[34] = binaryText[40];
			IP[35] = binaryText[32];
			IP[36] = binaryText[24];
			IP[37] = binaryText[16];
			IP[38] = binaryText[8];
			IP[39] = binaryText[0];
			IP[40] = binaryText[58];
			IP[41] = binaryText[50];
			IP[42] = binaryText[42];
			IP[43] = binaryText[34];
			IP[44] = binaryText[26];
			IP[45] = binaryText[18];
			IP[46] = binaryText[10];
			IP[47] = binaryText[2];
			IP[48] = binaryText[60];
			IP[49] = binaryText[52];
			IP[50] = binaryText[44];
			IP[51] = binaryText[36];
			IP[52] = binaryText[28];
			IP[53] = binaryText[20];
			IP[54] = binaryText[12];
			IP[55] = binaryText[4];
			IP[56] = binaryText[62];
			IP[57] = binaryText[54];
			IP[58] = binaryText[46];
			IP[59] = binaryText[38];
			IP[60] = binaryText[30];
			IP[61] = binaryText[22];
			IP[62] = binaryText[14];
			IP[63] = binaryText[6];

			string temp3 = new string (IP);
			string leftIP = temp3.Substring (0, 32);
			string rightIP = temp3.Substring (32, 32);


			string[] Ln = new string[17];
			string[] Rn = new string[17];
			Ln [0] = leftIP;
			Rn [0] = rightIP;

			for (int i =1; i < 17; i++) {
			
				Ln[i] = Rn[i-1];
				//Rn and Ln are 1 index further thats why keys48[i-1] is like K[i]
				Rn[i]= xorIt(Ln[i-1], myFunc(Rn[i-1],keys48[i-1]));
			
				Console.WriteLine("R"+i +" : " + Rn[i]); 
				Console.WriteLine("L"+i +" : " + Ln[i]);
			
			}
			Console.WriteLine ();
			//For the final Step
			char[] final = new char[64];
			string LR = Ln [16] + Rn [16];

			final [0] = LR [39];
			final [1] = LR [7];
			final [2] = LR [47];
			final [3] = LR [15];
			final [4] = LR [55];
			final [5] = LR [23];
			final [6] = LR [63];
			final [7] = LR [31];
			final [8] = LR [38];
			final [9] = LR [6];
			final [10] = LR [46];
			final [11] = LR [14];
			final [12] = LR [54];
			final [13] = LR [22];
			final [14] = LR [62];
			final [15] = LR [30];
			final [16] = LR [37];
			final [17] = LR [5];
			final [18] = LR [45];
			final [19] = LR [13];
			final [20] = LR [53];
			final [21] = LR [21];
			final [22] = LR [61];
			final [23] = LR [29];
			final [24] = LR [36];
			final [25] = LR [4];
			final [26] = LR [44];
			final [27] = LR [12];
			final [28] = LR [52];
			final [29] = LR [20];
			final [30] = LR [60];
			final [31] = LR [28];
			final [32] = LR [35];
			final [33] = LR [3];
			final [34] = LR [43];
			final [35] = LR [11];
			final [36] = LR [51];
			final [37] = LR [19];
			final [38] = LR [59];
			final [39] = LR [27];
			final [40] = LR [34];
			final [41] = LR [2];
			final [42] = LR [42];
			final [43] = LR [10];
			final [44] = LR [50];
			final [45] = LR [18];
			final [46] = LR [58];
			final [47] = LR [26];
			final [48] = LR [33];
			final [49] = LR [1];
			final [50] = LR [41];
			final [51] = LR [9];
			final [52] = LR [49];
			final [53] = LR [17];
			final [54] = LR [57];
			final [55] = LR [25];
			final [56] = LR [32];
			final [57] = LR [0];
			final [58] = LR [40];
			final [59] = LR [8];
			final [60] = LR [48];
			final [61] = LR [16];
			final [62] = LR [56];
			final [63] = LR [24];
			string finalBinary = new string (final);
			string strHex = Convert.ToInt32(finalBinary,2).ToString("X");
			Console.WriteLine ("Final Hex:" + strHex);

		
		}

		public static string myFunc(string R,string K){

			//first we xor the right and the Key
			string temp =  xorIt(myFunc2 (R),K);


			//we turn it into 8, 6bits.
			string[] B = new string[8];
			B [0] = temp.Substring (0, 6);
			string SboxOutput = "";
			B [1] = temp.Substring (6, 6);
			B [2] = temp.Substring (12, 6);
			B [3] = temp.Substring (18, 6);
			B [4] = temp.Substring (24, 6);
			B [5] = temp.Substring (30, 6);
			B [6] = temp.Substring (36, 6);
			B [7] = temp.Substring (42, 6);


			//give each 6 to the  appropriate Sbox and each gives us 4 digits which we concat into a 32 bit and give it out to the Pbox
			SboxOutput = SBox (B [0], 0) + SBox (B [1], 1) + SBox (B [2], 2) + SBox (B [3], 3) + SBox (B [4], 4) + SBox (B [5], 5) + SBox (B [6], 6) + SBox (B [7], 7);






			return Pbox (SboxOutput); 


		}

		public static string Pbox(string S){
		
			char[] p = new char[32];

			p [0] = S [15];
			p [1] = S [6];
			p [2] = S [19];
			p [3] = S [20];
			p [4] = S [28];
			p [5] = S [11];
			p [6] = S [27];
			p [7] = S [16];
			p [8] = S [0];
			p [9] = S [14];
			p [10] = S [22];
			p [11] = S [25];
			p [12] = S [4];
			p [13] = S [17];
			p [14] = S [30];
			p [15] = S [9];
			p [16] = S [1];
			p [17] = S [7];
			p [18] = S [23];
			p [19] = S [13];
			p [20] = S [31];
			p [21] = S [26];
			p [22] = S [2];
			p [23] = S [8];
			p [24] = S [18];
			p [25] = S [12];
			p [26] = S [29];
			p [27] = S [5];
			p [28] = S [21];
			p [29] = S [10];
			p [30] = S [3];
			p [31] = S [24];

			return new string (p);


		}







		public static string SBox(string B,int index){
		
			int i = 0;
			int j = 0;
			//Console.Write (B);
			string temp = ""+ B[0] +B[5];
			i = Convert.ToInt32(temp, 2);
			j = Convert.ToInt32(""+B[1]+B[2]+B[3]+B[4],2);

			switch (index) {
			
			case 0: { 
				return Convert.ToString(s1Box[i,j], 2).PadLeft(4, '0');
				//break;
			}
			case 1:{

				return Convert.ToString(s2Box[i,j], 2).PadLeft(4, '0');
				//break;



			}
			case 2:{
				return Convert.ToString(s3Box[i,j], 2).PadLeft(4, '0');
				//break;
				
				
				
			}
			case 3:{
				return Convert.ToString(s4Box[i,j], 2).PadLeft(4, '0');
			//	break;
				
				
				
			}
			case 4:{
				return Convert.ToString(s5Box[i,j], 2).PadLeft(4, '0');
			//	break;
				
				
				
			}
			case 5:{
				return Convert.ToString(s6Box[i,j], 2).PadLeft(4, '0');
			//	break;
				
				
				
			}
			case 6:{
				return Convert.ToString(s7Box[i,j], 2).PadLeft(4, '0');



			}
			case 7:{
				return Convert.ToString(s8Box[i,j], 2).PadLeft(4, '0');
			//	break;
				
				
				
			}	
			
			default: return "";
			
			
			
			
			
			
			
			}

		
		
		
		
		}


		public static string myFunc2(string R){
		//Input 32bits, Output 48bits
			char[] Rx = new char[48];
			Rx [0] = R [31];
			Rx [1] = R [0];
			Rx [2] = R [1];
			Rx [3] = R [2];
			Rx [4] = R [3];
			Rx [5] = R [4];
			Rx [6] = R [3];
			Rx [7] = R [4];
			Rx [8] = R [5];
			Rx [9] = R [6];
			Rx [10] = R [7];
			Rx [11] = R [8];
			Rx [12] = R [7];
			Rx [13] = R [8];
			Rx [14] = R [9];
			Rx [15] = R [10];
			Rx [16] = R [11];
			Rx [17] = R [12];
			Rx [18] = R [11];
			Rx [19] = R [12];
			Rx [20] = R [13];
			Rx [21] = R [14];
			Rx [22] = R [15];
			Rx [23] = R [16];
			Rx [24] = R [15];
			Rx [25] = R [16];
			Rx [26] = R [17];
			Rx [27] = R [18];
			Rx [28] = R [19];
			Rx [29] = R [20];
			Rx [30] = R [19];
			Rx [31] = R [20];
			Rx [32] = R [21];
			Rx [33] = R [22];
			Rx [34] = R [23];
			Rx [35] = R [24];
			Rx [36] = R [23];
			Rx [37] = R [24];
			Rx [38] = R [25];
			Rx [39] = R [26];
			Rx [40] = R [27];
			Rx [41] = R [28];
			Rx [42] = R [27];
			Rx [43] = R [28];
			Rx [44] = R [29];
			Rx [45] = R [30];
			Rx [46] = R [31];
			Rx [47] = R [0];
		
		
		//	Console.WriteLine ("myfunc2");

			return new String (Rx);
		
		
		}

		public static string xorIt(string a, string b)
		{
			char[] charAArray = a.ToCharArray();
			char[] charBArray = b.ToCharArray();

			int[] result = new int[64];
			//int len = 0;
			
			string temp = "";
			for (int i = 0; i < a.Length; i++) {
				result[i] = charAArray[i] ^ charBArray[i]; // Error here
				temp += result[i]+"";
			
			}

			return temp;
		}
		public static string leftRotateShift(string key, int shift)
		{
			shift %= key.Length;
			return key.Substring(shift) + key.Substring(0, shift);
		}
		
		public static string rightRotateShift(string key, int shift)
		{
			shift %= key.Length;
			return key.Substring(key.Length - shift) + key.Substring(0, key.Length - shift);
		}

	}
}
