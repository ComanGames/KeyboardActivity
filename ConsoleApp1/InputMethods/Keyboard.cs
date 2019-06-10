﻿using System;
using System.Runtime.InteropServices;

public partial class Keyboard
{ public static void Send(ScanCodeShort a)
	{
		INPUT[] Inputs = new INPUT[1];
		INPUT Input = new INPUT();
		Input.type = 1; // 1 = Keyboard Input
		Input.U.ki.wScan = a;
		Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
		Inputs[0] = Input;
		SendInput(1, Inputs, INPUT.Size);
	}

	/// <summary>
	/// Declaration of external SendInput method
	/// </summary>
	[DllImport("user32.dll")]
	internal static extern uint SendInput(
		uint nInputs,
		[MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs,
		int cbSize);


	// Declare the INPUT struct
	[StructLayout(LayoutKind.Sequential)]
	public struct INPUT
	{
		public uint type;
		public InputUnion U;
		public static int Size
		{
			get { return Marshal.SizeOf(typeof(INPUT)); }
		}
	}

	// Declare the InputUnion struct
	[StructLayout(LayoutKind.Explicit)]
	public struct InputUnion
	{
		[FieldOffset(0)]
		internal MOUSEINPUT mi;
		[FieldOffset(0)]
		internal KEYBDINPUT ki;
		[FieldOffset(0)]
		internal HARDWAREINPUT hi;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MOUSEINPUT
	{
		internal int dx;
		internal int dy;
		internal MouseEventDataXButtons mouseData;
		internal MOUSEEVENTF dwFlags;
		internal uint time;
		internal UIntPtr dwExtraInfo;
	}

	[Flags]
	public enum MouseEventDataXButtons : uint
	{
		Nothing = 0x00000000,
		XBUTTON1 = 0x00000001,
		XBUTTON2 = 0x00000002
	}

	[Flags]
	public enum MOUSEEVENTF : uint
	{
		ABSOLUTE = 0x8000,
		HWHEEL = 0x01000,
		MOVE = 0x0001,
		MOVE_NOCOALESCE = 0x2000,
		LEFTDOWN = 0x0002,
		LEFTUP = 0x0004,
		RIGHTDOWN = 0x0008,
		RIGHTUP = 0x0010,
		MIDDLEDOWN = 0x0020,
		MIDDLEUP = 0x0040,
		VIRTUALDESK = 0x4000,
		WHEEL = 0x0800,
		XDOWN = 0x0080,
		XUP = 0x0100
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct KEYBDINPUT
	{
		internal VirtualKeyShort wVk;
		internal ScanCodeShort wScan;
		internal KEYEVENTF dwFlags;
		internal int time;
		internal UIntPtr dwExtraInfo;
	}

	[Flags]
	public enum KEYEVENTF : uint
	{
		EXTENDEDKEY = 0x0001,
		KEYUP = 0x0002,
		SCANCODE = 0x0008,
		UNICODE = 0x0004
	}

	public enum ScanCodeShort : short
	{
		LBUTTON = 0,
		RBUTTON = 0,
		CANCEL = 70,
		MBUTTON = 0,
		XBUTTON1 = 0,
		XBUTTON2 = 0,
		BACK = 14,
		TAB = 15,
		CLEAR = 76,
		RETURN = 28,
		SHIFT = 42,
		CONTROL = 29,
		MENU = 56,
		PAUSE = 0,
		CAPITAL = 58,
		KANA = 0,
		HANGUL = 0,
		JUNJA = 0,
		FINAL = 0,
		HANJA = 0,
		KANJI = 0,
		ESCAPE = 1,
		CONVERT = 0,
		NONCONVERT = 0,
		ACCEPT = 0,
		MODECHANGE = 0,
		SPACE = 57,
		PRIOR = 73,
		NEXT = 81,
		END = 79,
		HOME = 71,
		LEFT = 75,
		UP = 72,
		RIGHT = 77,
		DOWN = 80,
		SELECT = 0,
		PRINT = 0,
		EXECUTE = 0,
		SNAPSHOT = 84,
		INSERT = 82,
		DELETE = 83,
		HELP = 99,
		KEY_0 = 11,
		KEY_1 = 2,
		KEY_2 = 3,
		KEY_3 = 4,
		KEY_4 = 5,
		KEY_5 = 6,
		KEY_6 = 7,
		KEY_7 = 8,
		KEY_8 = 9,
		KEY_9 = 10,
		KEY_A = 30,
		KEY_B = 48,
		KEY_C = 46,
		KEY_D = 32,
		KEY_E = 18,
		KEY_F = 33,
		KEY_G = 34,
		KEY_H = 35,
		KEY_I = 23,
		KEY_J = 36,
		KEY_K = 37,
		KEY_L = 38,
		KEY_M = 50,
		KEY_N = 49,
		KEY_O = 24,
		KEY_P = 25,
		KEY_Q = 16,
		KEY_R = 19,
		KEY_S = 31,
		KEY_T = 20,
		KEY_U = 22,
		KEY_V = 47,
		KEY_W = 17,
		KEY_X = 45,
		KEY_Y = 21,
		KEY_Z = 44,
		LWIN = 91,
		RWIN = 92,
		APPS = 93,
		SLEEP = 95,
		NUMPAD0 = 82,
		NUMPAD1 = 79,
		NUMPAD2 = 80,
		NUMPAD3 = 81,
		NUMPAD4 = 75,
		NUMPAD5 = 76,
		NUMPAD6 = 77,
		NUMPAD7 = 71,
		NUMPAD8 = 72,
		NUMPAD9 = 73,
		MULTIPLY = 55,
		ADD = 78,
		SEPARATOR = 0,
		SUBTRACT = 74,
		DECIMAL = 83,
		DIVIDE = 53,
		F1 = 59,
		F2 = 60,
		F3 = 61,
		F4 = 62,
		F5 = 63,
		F6 = 64,
		F7 = 65,
		F8 = 66,
		F9 = 67,
		F10 = 68,
		F11 = 87,
		F12 = 88,
		F13 = 100,
		F14 = 101,
		F15 = 102,
		F16 = 103,
		F17 = 104,
		F18 = 105,
		F19 = 106,
		F20 = 107,
		F21 = 108,
		F22 = 109,
		F23 = 110,
		F24 = 118,
		NUMLOCK = 69,
		SCROLL = 70,
		LSHIFT = 42,
		RSHIFT = 54,
		LCONTROL = 29,
		RCONTROL = 29,
		LMENU = 56,
		RMENU = 56,
		BROWSER_BACK = 106,
		BROWSER_FORWARD = 105,
		BROWSER_REFRESH = 103,
		BROWSER_STOP = 104,
		BROWSER_SEARCH = 101,
		BROWSER_FAVORITES = 102,
		BROWSER_HOME = 50,
		VOLUME_MUTE = 32,
		VOLUME_DOWN = 46,
		VOLUME_UP = 48,
		MEDIA_NEXT_TRACK = 25,
		MEDIA_PREV_TRACK = 16,
		MEDIA_STOP = 36,
		MEDIA_PLAY_PAUSE = 34,
		LAUNCH_MAIL = 108,
		LAUNCH_MEDIA_SELECT = 109,
		LAUNCH_APP1 = 107,
		LAUNCH_APP2 = 33,
		OEM_1 = 39,
		OEM_PLUS = 13,
		OEM_COMMA = 51,
		OEM_MINUS = 12,
		OEM_PERIOD = 52,
		OEM_2 = 53,
		OEM_3 = 41,
		OEM_4 = 26,
		OEM_5 = 43,
		OEM_6 = 27,
		OEM_7 = 40,
		OEM_8 = 0,
		OEM_102 = 86,
		PROCESSKEY = 0,
		PACKET = 0,
		ATTN = 0,
		CRSEL = 0,
		EXSEL = 0,
		EREOF = 93,
		PLAY = 0,
		ZOOM = 98,
		NONAME = 0,
		PA1 = 0,
		OEM_CLEAR = 0,
	}

	/// <summary>
	/// Define HARDWAREINPUT struct
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct HARDWAREINPUT
	{
		internal int uMsg;
		internal short wParamL;
		internal short wParamH;
	}
}