#region License
 /*	  xacc                																											*
 	*		Copyright (C) 2003-2006  Llewellyn@Pritchard.org                          *
 	*																																							*
	*		This program is free software; you can redistribute it and/or modify			*
	*		it under the terms of the GNU Lesser General Public License as            *
  *   published by the Free Software Foundation; either version 2.1, or					*
	*		(at your option) any later version.																				*
	*																																							*
	*		This program is distributed in the hope that it will be useful,						*
	*		but WITHOUT ANY WARRANTY; without even the implied warranty of						*
	*		MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the							*
	*		GNU Lesser General Public License for more details.												*
	*																																							*
	*		You should have received a copy of the GNU Lesser General Public License	*
	*		along with this program; if not, write to the Free Software								*
	*		Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA */
#endregion
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: CLSCompliant(true)]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("leppie")]
[assembly: AssemblyCopyright("2003-2009 llewellyn@pritchard.org")]
[assembly: AssemblyProduct("xacc")]
[assembly: AssemblyTrademark("GNU LGPL")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyVersion("0.2.0.89")]
[assembly: ComVisibleAttribute(true)]

#if !DEBUG
#pragma warning disable 1699
 // to create a release build, generate a key called 'xacc.key' in the source root
[assembly: AssemblyKeyFile("../../../xacc.key")]
#pragma warning restore 1699
#endif