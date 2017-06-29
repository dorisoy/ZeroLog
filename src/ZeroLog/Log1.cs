﻿
using System;
using JetBrains.Annotations;

namespace ZeroLog
{
    internal partial class Log
    {
                
        public bool IsDebugEnabled => Level.Debug >= _logManager.Level;

        public ILogEvent Debug()
        {
            return IsDebugEnabled
                ? GetLogEventFor(Level.Debug)
                : NoopLogEvent.Instance;
        }
        
        public void Debug(string message)
        {
            if (!IsDebugEnabled)
                return;

            GetLogEventFor(Level.Debug).Append(message).Log();
        }

        public void Debug(string message, Exception ex)
        {
            if (!IsDebugEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Debug);
            logEvent.Append(message);
            logEvent.Append(ex.ToString());
            logEvent.Log();
        }

                    
        [StringFormatMethod("format")]	
        public void DebugFormat<T0>(string format, T0 arg0)
        {
            if (!IsDebugEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Debug);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void DebugFormat<T0, T1>(string format, T0 arg0, T1 arg1)
        {
            if (!IsDebugEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Debug);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void DebugFormat<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2)
        {
            if (!IsDebugEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Debug);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void DebugFormat<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            if (!IsDebugEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Debug);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void DebugFormat<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!IsDebugEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Debug);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void DebugFormat<T0, T1, T2, T3, T4, T5>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (!IsDebugEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Debug);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.AppendGeneric(arg5);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void DebugFormat<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (!IsDebugEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Debug);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.AppendGeneric(arg5);
            logEvent.AppendGeneric(arg6);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void DebugFormat<T0, T1, T2, T3, T4, T5, T6, T7>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!IsDebugEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Debug);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.AppendGeneric(arg5);
            logEvent.AppendGeneric(arg6);
            logEvent.AppendGeneric(arg7);
            logEvent.Log();
        }
                    
        public bool IsInfoEnabled => Level.Info >= _logManager.Level;

        public ILogEvent Info()
        {
            return IsInfoEnabled
                ? GetLogEventFor(Level.Info)
                : NoopLogEvent.Instance;
        }
        
        public void Info(string message)
        {
            if (!IsInfoEnabled)
                return;

            GetLogEventFor(Level.Info).Append(message).Log();
        }

        public void Info(string message, Exception ex)
        {
            if (!IsInfoEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Info);
            logEvent.Append(message);
            logEvent.Append(ex.ToString());
            logEvent.Log();
        }

                    
        [StringFormatMethod("format")]	
        public void InfoFormat<T0>(string format, T0 arg0)
        {
            if (!IsInfoEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Info);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void InfoFormat<T0, T1>(string format, T0 arg0, T1 arg1)
        {
            if (!IsInfoEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Info);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void InfoFormat<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2)
        {
            if (!IsInfoEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Info);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void InfoFormat<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            if (!IsInfoEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Info);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void InfoFormat<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!IsInfoEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Info);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void InfoFormat<T0, T1, T2, T3, T4, T5>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (!IsInfoEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Info);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.AppendGeneric(arg5);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void InfoFormat<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (!IsInfoEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Info);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.AppendGeneric(arg5);
            logEvent.AppendGeneric(arg6);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void InfoFormat<T0, T1, T2, T3, T4, T5, T6, T7>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!IsInfoEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Info);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.AppendGeneric(arg5);
            logEvent.AppendGeneric(arg6);
            logEvent.AppendGeneric(arg7);
            logEvent.Log();
        }
                    
        public bool IsWarnEnabled => Level.Warn >= _logManager.Level;

        public ILogEvent Warn()
        {
            return IsWarnEnabled
                ? GetLogEventFor(Level.Warn)
                : NoopLogEvent.Instance;
        }
        
        public void Warn(string message)
        {
            if (!IsWarnEnabled)
                return;

            GetLogEventFor(Level.Warn).Append(message).Log();
        }

        public void Warn(string message, Exception ex)
        {
            if (!IsWarnEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Warn);
            logEvent.Append(message);
            logEvent.Append(ex.ToString());
            logEvent.Log();
        }

                    
        [StringFormatMethod("format")]	
        public void WarnFormat<T0>(string format, T0 arg0)
        {
            if (!IsWarnEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Warn);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void WarnFormat<T0, T1>(string format, T0 arg0, T1 arg1)
        {
            if (!IsWarnEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Warn);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void WarnFormat<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2)
        {
            if (!IsWarnEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Warn);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void WarnFormat<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            if (!IsWarnEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Warn);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void WarnFormat<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!IsWarnEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Warn);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void WarnFormat<T0, T1, T2, T3, T4, T5>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (!IsWarnEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Warn);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.AppendGeneric(arg5);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void WarnFormat<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (!IsWarnEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Warn);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.AppendGeneric(arg5);
            logEvent.AppendGeneric(arg6);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void WarnFormat<T0, T1, T2, T3, T4, T5, T6, T7>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!IsWarnEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Warn);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.AppendGeneric(arg5);
            logEvent.AppendGeneric(arg6);
            logEvent.AppendGeneric(arg7);
            logEvent.Log();
        }
                    
        public bool IsErrorEnabled => Level.Error >= _logManager.Level;

        public ILogEvent Error()
        {
            return IsErrorEnabled
                ? GetLogEventFor(Level.Error)
                : NoopLogEvent.Instance;
        }
        
        public void Error(string message)
        {
            if (!IsErrorEnabled)
                return;

            GetLogEventFor(Level.Error).Append(message).Log();
        }

        public void Error(string message, Exception ex)
        {
            if (!IsErrorEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Error);
            logEvent.Append(message);
            logEvent.Append(ex.ToString());
            logEvent.Log();
        }

                    
        [StringFormatMethod("format")]	
        public void ErrorFormat<T0>(string format, T0 arg0)
        {
            if (!IsErrorEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Error);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void ErrorFormat<T0, T1>(string format, T0 arg0, T1 arg1)
        {
            if (!IsErrorEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Error);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void ErrorFormat<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2)
        {
            if (!IsErrorEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Error);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void ErrorFormat<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            if (!IsErrorEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Error);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void ErrorFormat<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!IsErrorEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Error);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void ErrorFormat<T0, T1, T2, T3, T4, T5>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (!IsErrorEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Error);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.AppendGeneric(arg5);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void ErrorFormat<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (!IsErrorEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Error);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.AppendGeneric(arg5);
            logEvent.AppendGeneric(arg6);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void ErrorFormat<T0, T1, T2, T3, T4, T5, T6, T7>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!IsErrorEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Error);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.AppendGeneric(arg5);
            logEvent.AppendGeneric(arg6);
            logEvent.AppendGeneric(arg7);
            logEvent.Log();
        }
                    
        public bool IsFatalEnabled => Level.Fatal >= _logManager.Level;

        public ILogEvent Fatal()
        {
            return IsFatalEnabled
                ? GetLogEventFor(Level.Fatal)
                : NoopLogEvent.Instance;
        }
        
        public void Fatal(string message)
        {
            if (!IsFatalEnabled)
                return;

            GetLogEventFor(Level.Fatal).Append(message).Log();
        }

        public void Fatal(string message, Exception ex)
        {
            if (!IsFatalEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Fatal);
            logEvent.Append(message);
            logEvent.Append(ex.ToString());
            logEvent.Log();
        }

                    
        [StringFormatMethod("format")]	
        public void FatalFormat<T0>(string format, T0 arg0)
        {
            if (!IsFatalEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Fatal);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void FatalFormat<T0, T1>(string format, T0 arg0, T1 arg1)
        {
            if (!IsFatalEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Fatal);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void FatalFormat<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2)
        {
            if (!IsFatalEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Fatal);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void FatalFormat<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            if (!IsFatalEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Fatal);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void FatalFormat<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!IsFatalEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Fatal);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void FatalFormat<T0, T1, T2, T3, T4, T5>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (!IsFatalEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Fatal);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.AppendGeneric(arg5);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void FatalFormat<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (!IsFatalEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Fatal);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.AppendGeneric(arg5);
            logEvent.AppendGeneric(arg6);
            logEvent.Log();
        }
            
        [StringFormatMethod("format")]	
        public void FatalFormat<T0, T1, T2, T3, T4, T5, T6, T7>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!IsFatalEnabled)
                return;

            var logEvent = GetLogEventFor(Level.Fatal);
            logEvent.AppendFormat(format);
            logEvent.AppendGeneric(arg0);
            logEvent.AppendGeneric(arg1);
            logEvent.AppendGeneric(arg2);
            logEvent.AppendGeneric(arg3);
            logEvent.AppendGeneric(arg4);
            logEvent.AppendGeneric(arg5);
            logEvent.AppendGeneric(arg6);
            logEvent.AppendGeneric(arg7);
            logEvent.Log();
        }
                    
    }
}