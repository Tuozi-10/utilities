using System;
using System.Diagnostics;
using UnityEngine;
using static UnityEngine.Debug;

namespace Core.Scripts.Utils
{
    public static class Logs
    {

        public enum LogColors
        {
           None, 
           Red, 
           Blue, 
           Yellow, 
           Green, 
           Black
        }

        private static string GetColorByLogColor(LogColors logColors)
        {
            return logColors switch
            {
                LogColors.None => "",
                LogColors.Red => "#FF0000",
                LogColors.Blue => "#0000FF",
                LogColors.Yellow =>"#FFEB04",
                LogColors.Green => "#00FF00",
                LogColors.Black => "#000000",
                _ => throw new ArgumentOutOfRangeException(nameof(logColors), logColors, null)
            };
        }
        
        [Conditional("DEBUG")]
        public static void Log(string log, LogType logType = LogType.Log, LogColors logColors = LogColors.None)
        {
            if (logColors != LogColors.None)
            {
                log = $"<color={GetColorByLogColor(logColors)}>{log}</color>";
            }

            unityLogger.Log(logType, log);
        }
        
    }
}