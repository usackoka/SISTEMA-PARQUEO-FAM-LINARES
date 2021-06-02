using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Sistema_parque_fam_linares.Modulos.reportes
{
    public class clsFunciones
    {
        public class CreaTicket
        {
            public static StringBuilder line = new StringBuilder();
            string ticket = "";
            string parte1;

            public static int max = 40;
            int cort;
            public static int maxCaracteresPorLinea = 31;

            public static string LineasGuion()
            {
                string LineaGuion = ""; // agrega lineas separadoras -
                for(int i=0; i< maxCaracteresPorLinea; i++)
                {
                    LineaGuion += "-";
                }

                return line.AppendLine(LineaGuion).ToString();
            }

            public void TextoIzquierda(string par1)                          // agrega texto a la izquierda
            {
                max = par1.Length;
                if (max > maxCaracteresPorLinea)                                 // **********
                {
                    cort = max - maxCaracteresPorLinea;
                    parte1 = par1.Remove(maxCaracteresPorLinea, cort);        // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                line.AppendLine(ticket = parte1);



                //si fue mayor agrego lo que falta como otra línea
                if (par1.Length > maxCaracteresPorLinea)                                 // **********
                {
                    TextoIzquierda(par1.Substring(maxCaracteresPorLinea, par1.Length - maxCaracteresPorLinea));
                }

            }
            public void TextoDerecha(string par1)
            {
                ticket = "";
                max = par1.Length;
                if (max > maxCaracteresPorLinea)                                 // **********
                {
                    cort = max - maxCaracteresPorLinea;
                    parte1 = par1.Remove(maxCaracteresPorLinea, cort);           // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                max = maxCaracteresPorLinea - par1.Length;                     // obtiene la cantidad de espacios para llegar a 40
                for (int i = 0; i < max; i++)
                {
                    ticket += " ";                          // agrega espacios para alinear a la derecha
                }
                line.AppendLine(ticket += parte1);                //Agrega el texto

            }
            public void TextoCentro(string par1)
            {
                ticket = "";
                max = par1.Length;
                if (max > maxCaracteresPorLinea)                                 // **********
                {
                    cort = max - maxCaracteresPorLinea;
                    parte1 = par1.Remove(maxCaracteresPorLinea, cort);          // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                max = (int)(maxCaracteresPorLinea - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios antes del texto a centrar
                }                                            // **********

                line.AppendLine(ticket += parte1);

                //si fue mayor agrego lo que falta como otra línea
                if (par1.Length > maxCaracteresPorLinea)                                 // **********
                {
                    TextoCentro(par1.Substring(maxCaracteresPorLinea, par1.Length - maxCaracteresPorLinea));
                }

            }

            public void ImprimirTiket(string stringimpresora)
            {
                RawPrinterHelper.SendStringToPrinter(stringimpresora, line.ToString());
                line = new StringBuilder();
            }
        }

        #region Clase para enviar a imprsora texto plano
        public class RawPrinterHelper
        {
            // Structure and API declarions:
            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
            public class DOCINFOA
            {
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDocName;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pOutputFile;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDataType;
            }
            [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

            [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool ClosePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

            [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndDocPrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

            // SendBytesToPrinter()
            // When the function is given a printer name and an unmanaged array
            // of bytes, the function sends those bytes to the print queue.
            // Returns true on success, false on failure.
            public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
            {
                Int32 dwError = 0, dwWritten = 0;
                IntPtr hPrinter = new IntPtr(0);
                DOCINFOA di = new DOCINFOA();
                bool bSuccess = false; // Assume failure unless you specifically succeed.

                di.pDocName = "ticketFaustino";
                di.pDataType = "RAW";
                // di.pOutputFile = @"C:\Users\Roland\Documents\Visual Studio 2015\Projects\pjtVentas\Ventas";

                // Open the printer.
                if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
                {
                    // Start a document.
                    if (StartDocPrinter(hPrinter, 1, di))
                    {
                        // Start a page.
                        if (StartPagePrinter(hPrinter))
                        {
                            // Write your bytes.
                            bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                            EndPagePrinter(hPrinter);
                        }
                        EndDocPrinter(hPrinter);
                    }
                    ClosePrinter(hPrinter);
                }
                // If you did not succeed, GetLastError may give more information
                // about why not.
                if (bSuccess == false)
                {
                    dwError = Marshal.GetLastWin32Error();
                }
                return bSuccess;
            }

            public static bool SendStringToPrinter(string szPrinterName, string szString)
            {
                IntPtr pBytes;
                Int32 dwCount;
                // How many characters are in the string?
                dwCount = szString.Length;
                // Assume that the printer is expecting ANSI text, and then convert
                // the string to ANSI text.
                pBytes = Marshal.StringToCoTaskMemAnsi(szString);
                // Send the converted ANSI string to the printer.
                SendBytesToPrinter(szPrinterName, pBytes, dwCount);
                Marshal.FreeCoTaskMem(pBytes);
                return true;
            }
        }
        #endregion
    }
}
