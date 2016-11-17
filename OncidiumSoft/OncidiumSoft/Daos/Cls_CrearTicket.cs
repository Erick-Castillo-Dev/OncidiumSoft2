﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace OncidiumSoft.Daos
{
    class Cls_CrearTicket
    {
        /// <summary>
        /// Creamos un objeto de la clase StringBuilder, en 
        /// este objeto agregamos las lineas del ticket
        /// </summary>
        StringBuilder linea = new StringBuilder();
        /// <summary>
        /// numero maximo de caracteres que permite imprimir en el ticket
        /// </summary>
        int maxCar = 40;
        /// <summary>
        /// Variable para cortar cuando son mas de 40 caracteres
        /// </summary>
        int cortar;
        /// <summary>
        /// Este metodo para dibujas las lineas guion
        /// </summary>
        /// <returns></returns>
        public string lineasGuion()
        {
            string lineasGuion = "";
            for (int i = 0; i < maxCar; i++)
            {
                //Agregar un guion hasta llegar al maximo de caracteres.
                lineasGuion += "-";
            }
            //devolvemos la limeaGuion
            return linea.AppendLine(lineasGuion).ToString();
        }
        /// <summary>
        /// Metodo para dibujar una linea de asteriscos
        /// </summary>
        /// <returns></returns>
        public string lineasAsteriscos()
        {
            string lineasAsterisco = "";
            for (int i = 0; i < maxCar; i++)
            {
                //Agregar un asterisco hasta llegar al maximo de caracteres.
                lineasAsterisco += "*";
            }
            //devolvemos la limeaGuion
            return linea.AppendLine(lineasAsterisco).ToString();
        }
        /// <summary>
        /// Metodo para dibujar una linea de iguales
        /// </summary>
        /// <returns></returns>
        public string lineasIgual()
        {
            string lineasIguals = "";
            for (int i = 0; i < maxCar; i++)
            {
                //Agregar un asterisco hasta llegar al maximo de caracteres.
                lineasIguals += "=";
            }
            //devolvemos la limeaGuion
            return linea.AppendLine(lineasIguals).ToString();
        }
        /// <summary>
        /// Metodo para crear el encabezado para los articulos
        /// </summary>
        public void EncabezadoVenta()
        {
            linea.AppendLine("ARTICULO            |CANT|PRECIO|IMPORTE");
        }
        /// <summary>
        /// Metodo para poner texto a la izquierda
        /// </summary>
        /// <param name="texto"></param>
        public void TextoIzquierda(string texto)
        {
            // si la longitud del texto es mayor al maximo de caracteres permitidos
            //realizar la suiente prosedimiento
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                linea.AppendLine(texto);
            }
        }
        /// <summary>
        /// Metodo para poner texto a la derecha
        /// </summary>
        /// <param name="texto"></param>
        public void textoDerecha(string texto)
        {
            // si la longitud del texto es mayor al maximo de caracteres permitidos
            //realizar la suiente prosedimiento
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }

                string espacios = "";

                for (int i = 0; i < (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length); i++)
                {
                    espacios += " ";
                }

                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                for (int i = 0; i < (maxCar - texto.Length); i++)
                {
                    espacios += " ";
                }
                linea.AppendLine(espacios + texto);
            }
        }
        /// <summary>
        /// Metodo para centrar el texto
        /// </summary>
        /// <param name="texto"></param>
        public void TextoCentro(string texto)
        {
            // si la longitud del texto es mayor al maximo de caracteres permitidos
            //realizar la suiente prosedimiento
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }

                string espacios = "";
                int centrar = (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length) / 2;
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";
                }

                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                int centrar = (maxCar - texto.Length) / 2;
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";
                }

                linea.AppendLine(espacios + texto);
            }
        }
        /// <summary>
        /// Metodo para poner texto en los estremos
        /// </summary>
        public void TextoExtremos(string textoIzquierdo, string textoDerecho)
        {
            string textIzq, textoDer, textCompleto = "", espacios = "";

            if (textoIzquierdo.Length > 18)
            {
                cortar = textoIzquierdo.Length - 18;
                textIzq = textoIzquierdo.Remove(18, cortar);
            }
            else
            {
                textIzq = textoIzquierdo;
            }

            textCompleto = textIzq;

            if (textoDerecho.Length > 20)
            {
                cortar = textoDerecho.Length - 20;
                textoDer = textoDerecho.Remove(20, cortar);
            }
            else
            {
                textoDer = textoDerecho;
            }

            int nroEspacios = maxCar - (textIzq.Length + textoDer.Length);
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";
            }

            textCompleto += espacios + textoDerecho;
            linea.AppendLine(textCompleto);
        }
        /// <summary>
        /// Metodo para agregra totales de la venta
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="total"></param>
        public void AgregarTotales(string texto, decimal total)
        {
            string resumen, valor, textoCompleto, espacios = "";

            if (texto.Length > 25)
            {
                cortar = texto.Length - 25;
                resumen = texto.Remove(25, cortar);
            }
            else
            {
                resumen = texto;
            }

            textoCompleto = resumen;
            valor = total.ToString("$ #,##0.00");

            int nroEspacios = maxCar - (resumen.Length + valor.Length);

            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";
            }

            textoCompleto += espacios + valor;
            linea.AppendLine(textoCompleto);
        }
        /// <summary>
        /// Metodo para agregar productoal ticket
        /// </summary>
        /// <param name="articulo"></param>
        /// <param name="cantidad"></param>
        /// <param name="precio"></param>
        /// <param name="importe"></param>
        public void AgregarArticulo(string articulo, int cant, decimal precio, decimal importe)
        {

            if (cant.ToString().Length <= 5 && precio.ToString().Length <= 2 && importe.ToString().Length <= 8)
            {
                string elemento = "", espacios = "";
                bool bandeera = false;
                int nroEspacios = 0;

                if (articulo.Length > 20)
                {
                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + cant.ToString();

                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + precio.ToString();

                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + importe.ToString();

                    int caracterActual = 0;
                    for (int longitudTexto = articulo.Length; longitudTexto > 20; longitudTexto -= 20)
                    {
                        if (bandeera == false)
                        {
                            linea.AppendLine(articulo.Substring(caracterActual, 20) + elemento);
                            bandeera = true;
                        }
                        else
                        {
                            linea.AppendLine(articulo.Substring(caracterActual, 20));
                        }
                        caracterActual += 20;
                    }

                    linea.AppendLine(articulo.Substring(caracterActual, articulo.Length - caracterActual));
                }
                else
                {
                    for (int i = 0; i < (20 - articulo.Length); i++)
                    {
                        espacios += " ";
                    }
                    elemento = articulo + espacios;

                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + cant.ToString();

                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + precio.ToString();

                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + importe.ToString();

                    linea.AppendLine(elemento);

                }
            }
            else
            {
                linea.AppendLine("Los valores ingresados para esta fila");
                linea.AppendLine("superan las columnas soportadas por este.");
                throw new Exception("Los valores ingresados para algunas filas del ticket\nsuperan las columnas soportadas por este");
            }

        }
        /// <summary>
        /// Metodo para enviar secuenca de escape de la impresora
        /// para cortar el ticket
        /// </summary>
        public void CargarTicket()
        {
            //seciencias de caracteres de corte
            linea.AppendLine("\x1B" + "m");
            //avance de 9 renglones
            linea.AppendLine("\x1B" + "d" + "\x09");
        }
        /// <summary>
        /// Para abrir el cajon
        /// </summary>
        public void AbreCAjon()
        {
            //caracteres de apertura del cajon 
            linea.AppendLine("\x1B" + "p" + "\x00" + "\x0F" + "\x96");
        }
        /// <summary>
        /// Metodo para imprimir, el texto es 
        /// para indicar la impresora a imprimir
        /// </summary>
        /// <param name="impresora"></param>
        public void ImprimirTicket(string impresora)
        {
            RawPrinterHelper.SendStringToPrinter(impresora, linea.ToString());
            linea.Clear();
        }

    }

    
    /// <summary>
    /// Clase para mandara a imprimir texto plano a la impresora
    /// </summary>
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

            di.pDocName = "Ticket de Venta";//Este es el nombre con el que guarda el archivo en caso de no imprimir a la impresora fisica.
            di.pDataType = "RAW";//de tipo texto plano

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

}
