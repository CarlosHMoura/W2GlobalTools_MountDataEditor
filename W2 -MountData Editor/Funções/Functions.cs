using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W2___MountData_Editor.Funções
{
    class Functions : Structs
    {
        public static BinaryType LoadFile<BinaryType>(byte[] rawData) where BinaryType : struct
        {
            var pinnedRawData = GCHandle.Alloc(rawData, GCHandleType.Pinned);
            try
            {
                var pinnedRawDataPtr = pinnedRawData.AddrOfPinnedObject();
                return (BinaryType)Marshal.PtrToStructure(pinnedRawDataPtr, typeof(BinaryType));
            }
            finally
            {
                pinnedRawData.Free();
            }
        }
        
        public static void SaveFile<BinaryType>(BinaryType MountData)
        {
            try
            { 
                byte[] arr = new byte[Marshal.SizeOf(MountData)];

                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(MountData));
                Marshal.StructureToPtr(MountData, ptr, false);
                Marshal.Copy(ptr, arr, 0, Marshal.SizeOf(MountData));
                Marshal.FreeHGlobal(ptr);


                for (int i = 0; i < arr.Length; i++)
                    arr[i] ^= 0x5A;

                File.WriteAllBytes("MountData.bin", arr);
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static bool ReadMountData()
        {
            try
            {
                Byte[] data;

                if (File.Exists("./MountData.bin"))
                    data = File.ReadAllBytes("./MountData.bin");
               else
                {
                    MessageBox.Show("MountData não foi encontrado", "W2 - MountData Editor", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    return false;
                }

                for (int i = 0; i < data.Length; i++)
                    data[i] ^= 0x5A;

                External.g_pMountData = LoadFile<STRUCT_MOUNTDATA>(data);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}

