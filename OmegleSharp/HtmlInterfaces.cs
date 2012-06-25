using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

/*
 * HTMLScriptElemnt
 *
 * See:
 * http://stackoverflow.com/questions/622281/insert-some-java-script-using-htmldocumentclass
 *
 */

namespace OmegleSharp
{
    /// <summary>
    /// A COM interface is needed because .NET does not provide a way
    /// to set the properties of a HTML script element.
    /// This class negates the need to refrence mshtml in its entirety
    /// </summary>
    [ComImport, Guid("3050F536-98B5-11CF-BB82-00AA00BDCE0B"),
    InterfaceType((short)2),
    TypeLibType((short)0x4112)]
    public interface IHTMLScriptElement
    {
        /// <summary>
        /// Sets the text property
        /// </summary>
        [DispId(1006)]
        string Text
        {
            [param: MarshalAs(UnmanagedType.BStr)]
            [PreserveSig,
            MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime),
            DispId(-2147417085)]
            set;
            get;
        }

        /// <summary>
        /// Sets the src property
        /// </summary>
        [DispId(1001)]
        string Src
        {
            [param: MarshalAs(UnmanagedType.BStr)]
            [PreserveSig,
            MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime),
            DispId(-1001)]
            set;
            get;
        }
    }

    [TypeLibType(4160)]
    [Guid("163BB1E0-6E00-11CF-837A-48DC04C10000")]
    public interface IHTMLLocation
    {
        [DispId(7)]
        string hash { get; set; }

        [DispId(2)]
        string host { get; set; }

        [DispId(3)]
        string hostname { get; set; }

        [DispId(0)]
        string href { get; set; }

        [DispId(5)]
        string pathname { get; set; }

        [DispId(4)]
        string port { get; set; }

        [DispId(1)]
        string protocol { get; set; }

        [DispId(6)]
        string search { get; set; }

        [DispId(10)]
        void assign(string bstr);

        [DispId(8)]
        void reload(bool flag = false);

        [DispId(9)]
        void replace(string bstr);

        [DispId(11)]
        string toString();
    }

    [Guid("163BB1E0-6E00-11CF-837A-48DC04C10000")]
    public interface HTMLLocation : IHTMLLocation
    {
    }

    [Guid("332C4427-26CB-11D0-B483-00C04FD90119")]
    [TypeLibType(4160)]
    public interface IHTMLWindow2
    {
        [DispId(14)]
        HTMLLocation location { get; }
    }
}