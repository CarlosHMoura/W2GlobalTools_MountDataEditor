using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace W2___MountData_Editor.Funções
{
    class Structs
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct STRUCT_MOUNTDATA
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 200)]
            public MOUNTDATA[] MountInfo;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct MOUNTDATA
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 13)]
            public int[] UnkValues;
            

        }
    }
}
