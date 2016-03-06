using System;
using System.Configuration;

namespace MISMVC.Web.Models {
	public class Logger {
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger( "WebLogger" );

		private Logger( ) {
			SetConfig( );
		}

		public static Logger GetInstance( ) {
			return new Logger( );
		}

		private static void SetConfig( ) {
			object o = ConfigurationManager.GetSection( "log4net" );
			log4net.Config.XmlConfigurator.Configure( o as System.Xml.XmlElement );
		}

		public void WriteLog( String message , LogType type ) {
			try {
				switch( type ) {
					case LogType.Debug:
						if( !log.IsDebugEnabled ) {
							SetConfig( );
						}
						log.Debug( message );
						break;
					case LogType.Error:
						if( !log.IsErrorEnabled ) {
							SetConfig( );
						}
						log.Error( message );
						break;
					case LogType.Info:
						if( !log.IsInfoEnabled ) {
							SetConfig( );
						}
						log.Info( message );
						break;
					case LogType.Warn:
						if( !log.IsWarnEnabled ) {
							SetConfig( );
						}
						log.Warn( message );
						break;
					case LogType.Fatal:
						if( !log.IsFatalEnabled ) {
							SetConfig( );
						}
						log.Fatal( message );
						break;
					default:
						if( !log.IsInfoEnabled ) {
							SetConfig( );
						}
						log.Info( message );
						break;
				}
			} catch( log4net.Core.LogException ex ) {
				throw ex;
			} catch( Exception ex ) {
				throw ex;
			}
		}

	}

	public enum LogType : int {
		Info,
		Error,
		Warn,
		Debug,
		Fatal
	}
}