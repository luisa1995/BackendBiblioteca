﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="prueba")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Datos.Properties.Settings.Default.pruebaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cambiarautores")]
		public int cambiarautores([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(250)")] string identificacion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(250)")] string nombreCompleto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> fechaNacimiento, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(300)")] string ciudad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(150)")] string email)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, identificacion, nombreCompleto, fechaNacimiento, ciudad, email);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cambiarlibros")]
		public int cambiarlibros([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string titulo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string years, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> noPaginas, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(250)")] string identificacion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, titulo, years, noPaginas, identificacion);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insertaautores")]
		public ISingleResult<insertaautoresResult> insertaautores([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(250)")] string identificacion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(250)")] string nombreCompleto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> fechaNacimiento, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(300)")] string ciudad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(150)")] string email)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), identificacion, nombreCompleto, fechaNacimiento, ciudad, email);
			return ((ISingleResult<insertaautoresResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insertalibros")]
		public ISingleResult<insertalibrosResult> insertalibros([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string titulo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string years, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> noPaginas, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(250)")] string identificacion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), titulo, years, noPaginas, identificacion);
			return ((ISingleResult<insertalibrosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.obtenerautores")]
		public ISingleResult<obtenerautoresResult> obtenerautores()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<obtenerautoresResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.obtenerlibros")]
		public ISingleResult<obtenerlibrosResult> obtenerlibros()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<obtenerlibrosResult>)(result.ReturnValue));
		}
	}
	
	public partial class insertaautoresResult
	{
		
		private System.Nullable<decimal> _Column1;
		
		public insertaautoresResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="", Storage="_Column1", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> Column1
		{
			get
			{
				return this._Column1;
			}
			set
			{
				if ((this._Column1 != value))
				{
					this._Column1 = value;
				}
			}
		}
	}
	
	public partial class insertalibrosResult
	{
		
		private System.Nullable<decimal> _Column1;
		
		public insertalibrosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="", Storage="_Column1", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> Column1
		{
			get
			{
				return this._Column1;
			}
			set
			{
				if ((this._Column1 != value))
				{
					this._Column1 = value;
				}
			}
		}
	}
	
	public partial class obtenerautoresResult
	{
		
		private int _id;
		
		private string _identificacion;
		
		private string _nombreCompleto;
		
		private System.DateTime _fechaNacimiento;
		
		private string _ciudad;
		
		private string _email;
		
		public obtenerautoresResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_identificacion", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string identificacion
		{
			get
			{
				return this._identificacion;
			}
			set
			{
				if ((this._identificacion != value))
				{
					this._identificacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreCompleto", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string nombreCompleto
		{
			get
			{
				return this._nombreCompleto;
			}
			set
			{
				if ((this._nombreCompleto != value))
				{
					this._nombreCompleto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaNacimiento", DbType="Date NOT NULL")]
		public System.DateTime fechaNacimiento
		{
			get
			{
				return this._fechaNacimiento;
			}
			set
			{
				if ((this._fechaNacimiento != value))
				{
					this._fechaNacimiento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ciudad", DbType="VarChar(300) NOT NULL", CanBeNull=false)]
		public string ciudad
		{
			get
			{
				return this._ciudad;
			}
			set
			{
				if ((this._ciudad != value))
				{
					this._ciudad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this._email = value;
				}
			}
		}
	}
	
	public partial class obtenerlibrosResult
	{
		
		private int _id;
		
		private string _titulo;
		
		private string _years;
		
		private short _noPaginas;
		
		private string _identificacion;
		
		public obtenerlibrosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_titulo", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string titulo
		{
			get
			{
				return this._titulo;
			}
			set
			{
				if ((this._titulo != value))
				{
					this._titulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_years", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string years
		{
			get
			{
				return this._years;
			}
			set
			{
				if ((this._years != value))
				{
					this._years = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noPaginas", DbType="SmallInt NOT NULL")]
		public short noPaginas
		{
			get
			{
				return this._noPaginas;
			}
			set
			{
				if ((this._noPaginas != value))
				{
					this._noPaginas = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_identificacion", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string identificacion
		{
			get
			{
				return this._identificacion;
			}
			set
			{
				if ((this._identificacion != value))
				{
					this._identificacion = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
