/// Copyright 2016 by Samsung Electronics, Inc.,
///
/// This software is the confidential and proprietary information
/// of Samsung Electronics, Inc. ("Confidential Information"). You
/// shall not disclose such Confidential Information and shall use
/// it only in accordance with the terms of the license agreement
/// you entered into with Samsung.


using System.Runtime.InteropServices;
using System.Text;

internal static partial class Interop
{
    internal static partial class Aul
    {
        private const int MaxMimeLength = 128;
        private const string FileSchemaPrefix = "file://";

        internal static string GetMimeFromUri(string uri)
        {
            StringBuilder sb = new StringBuilder(MaxMimeLength);
            int err = aul_get_mime_from_file(uri.StartsWith(FileSchemaPrefix) ? uri.Substring(FileSchemaPrefix.Length) : uri, sb, MaxMimeLength);
            if (err == 0)
            {
                return sb.ToString();
            }
            else
            {
                return null;
            }
        }

        [DllImport(Libraries.Aul, CallingConvention = CallingConvention.Cdecl)]
        private static extern int aul_get_mime_from_file(string filename, StringBuilder mimetype, int len);
    }
}
