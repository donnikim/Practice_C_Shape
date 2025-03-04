using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39_Study_User32_CopyAndPaste
{
    class CGlobalKeyboardHook
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, keyboardHookProc callback, IntPtr hInstance, uint threadId);
        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref keyboardHookStruct IParam);
        
        [DllImport("user32.dll")]
        static extern short GetKeyState(int nCode);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string IpFileName);   // 라이브러리 등록

        public delegate int keyboardHookProc(int code, int wParam, ref keyboardHookStruct lParam);     // callback Delegate 

        //keyboardHookStruct  구조체 정의
        public struct keyboardHookStruct
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }
        // 정의 되어 있는 상수 값        

        // 1.키보드 키코드 : Window에서 키보드를 다룰 때 가상 키코드(Virual-key code)
        const int VK_SHIFT = 0x10; // shift 키
        const int VK_CONTROL = 0x11;// control 키
        const int VK_MENU = 0x12;// alt 키

        // 2. 키보드 후킹 관련 상수 : 키보드 입력을 가로채느 방법으로 후킹을 사용
        const int WH_KEYBOARD_LL = 13; //LL : Low-Level

        // 3. 키보드 메세지 상수
        const int WM_KEYDOWN = 0x100; // 일반 키가 눌릴 때 발생하는 메세지
        const int WM_KEYUP = 0x101;   // 일반 키가 떼어질 때 발생하는 메세지
        const int WM_SYSKEYDOWN = 0x104; // 시스템 키가 눌릴때 발생하는 메세지
        const int WM_SYSKEYUP = 0x105; // 시스템 키가 떼어질때 발생하는 메세지

        private keyboardHookProc khp;
        IntPtr hhook = IntPtr.Zero; // IntPtr : C#에서 포인터(메모리 주소)를 안전하게 다룰 수 있도록 제공하는 구조체

        //delegate 이벤트 추가
        public event KeyEventHandler KeyDown;
        public event KeyEventHandler KeyUp;


        public CGlobalKeyboardHook()
        {
            khp = new keyboardHookProc(hookproc);
        }


        public void hook()
        {
            IntPtr hinstance = LoadLibrary("User32");

            // SetWindowsHookEx는 Windows API에서 시스템 또는 특정 애플리케이션의 이벤트(예: 키보드, 마우스 입력)를 가로채는 후킹(Hooking) 기능을 제공하는 함수
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, // 후킹 할 이벤트 유형 
                                     khp,            // 후킹 처리 함수(콜백 함수)
                                     hinstance,      // DLL 핸들
                                     0               // 특정 스레드 후킹할 경우 지정
                                     );
        }

        public void unhook()
        {
            UnhookWindowsHookEx(hhook);
        }

        // wParam : 메세지의 주요 동작을 설명(int, UIntPtr) ex.WM_KEYDOWN(0x100) WM_KEYUP(0x101)
        // lParam : 메세지의 추가 정보 포함(IntPtr, long, 구조체) ex. 키보드 입력 세부 정보, 마우스 좌표 등...
        public int hookproc(int code, int wParam, ref keyboardHookStruct lParam)
        {
            if (code >= 0)
            {
                Keys key = (Keys)lParam.vkCode;
                // Ctrl키의 현재 상태를 가져옴(비트 연산자 AND & 1개)
                // 최상위 비트(7번째 비트 = 0x80)을 확인
                // != 0 7번쨰 비트가 1이면 Ctrl키가 눌린 상태
                if ((GetKeyState(VK_CONTROL) & 0x80) != 0)
                {
                    // 비트연산자 |(OR) : control키를 할당 시킴
                    key |= Keys.Control;
                }
                if ((GetKeyState(VK_MENU) & 0x80) != 0)
                {
                    // 비트연산자 |(OR) : Alt키를 할당 시킴
                    key |= Keys.Alt;
                }
                if ((GetKeyState(VK_SHIFT) & 0x80) != 0)
                {
                    // 비트연산자 |(OR) : Shift키를 할당 시킴
                    key |= Keys.Shift;
                }

                // KeyEventArgs 클래스 -> 키보드 입력이벤트 키정보를 제공 => WPF 또는 Winform에서 사용
                KeyEventArgs kea = new KeyEventArgs(key);

                if ((wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN) && (KeyDown != null))
                {
                    KeyDown(this, kea);
                }
                else if ((wParam == WM_KEYUP || wParam == WM_SYSKEYUP) && (KeyUp != null))
                {
                    KeyUp(this, kea);
                }

                if (kea.Handled) return 1;
            }
            return CallNextHookEx(hhook, code, wParam, ref lParam);
        }
    }
}
