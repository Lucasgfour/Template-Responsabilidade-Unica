using System;
using System.IO;
using System.Text;

namespace LG4.Common.Utils {
    public static class ErrorUtils {

        public static void SaveErrorMessage(Exception e) {

            String Message = $"Source: {e.Source}{Environment.NewLine}Message: {e.Message}{Environment.NewLine}StackTrace: {e.StackTrace}";

            String Nome = $"{e.Source}_{DateTime.Now.ToString("dd_MMMM_yyyy HH_mm_ss")}.txt";

            File.WriteAllText(CommonParameters.ErrorDirectory + Nome, Message, Encoding.UTF8);

        }


    }
}
