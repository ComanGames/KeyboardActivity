using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	 public	static class Convertor
	{
		public static Keyboard.ScanCodeShort ChatToCode(char c)
		{

			switch (c){


				case 'a':
					return Keyboard.ScanCodeShort.KEY_A;
					 
				case 'b':
					return Keyboard.ScanCodeShort.KEY_B;
					 
				case 'c':
					return Keyboard.ScanCodeShort.KEY_C;
					 
				case 'd':
					return Keyboard.ScanCodeShort.KEY_D;
					 
				case 'e':
					return Keyboard.ScanCodeShort.KEY_E;
					 
				case 'f':
					return Keyboard.ScanCodeShort.KEY_F;
					 
				case 'g':
					return Keyboard.ScanCodeShort.KEY_G;
					 
				case 'h':
					return Keyboard.ScanCodeShort.KEY_H;
					 
				case 'i':
					return Keyboard.ScanCodeShort.KEY_I;
					 
				case 'j':
					return Keyboard.ScanCodeShort.KEY_J;
					 
				case 'k':
					return Keyboard.ScanCodeShort.KEY_K;
					 
				case 'l':
					return Keyboard.ScanCodeShort.KEY_L;
					 
				case 'm':
					return Keyboard.ScanCodeShort.KEY_M;
					 
				case 'n':
					return Keyboard.ScanCodeShort.KEY_N;
				case 'o':
					return Keyboard.ScanCodeShort.KEY_O;
					 
				case 'p':
					return Keyboard.ScanCodeShort.KEY_P;
					 
				case 'q':
					return Keyboard.ScanCodeShort.KEY_Q;
					 
				case 'r':
					return Keyboard.ScanCodeShort.KEY_R;
					 
				case 's':
					return Keyboard.ScanCodeShort.KEY_S;
					 
				case 't':
					return Keyboard.ScanCodeShort.KEY_T;
					 
				case 'u':
					return Keyboard.ScanCodeShort.KEY_U;
					 
				case 'v':
					return Keyboard.ScanCodeShort.KEY_V;
					 
				case 'w':
					return Keyboard.ScanCodeShort.KEY_W;
					 
				case 'x':
					return Keyboard.ScanCodeShort.KEY_X;
					 
				case 'y':
					return Keyboard.ScanCodeShort.KEY_Y;
					 
				case 'z':
					return Keyboard.ScanCodeShort.KEY_Z;
			}

			throw new ArgumentException("Can't convert");
		}
	}
}
