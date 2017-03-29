using System;
using ObjCRuntime;

namespace RMessageBinding
{
	[Native]
	public enum RMessageType : nint
	{
		Normal = 0,
		Warning,
		Error,
		Success,
		Custom
	}

	[Native]
	public enum RMessagePosition : nint
	{
		Top = 0,
		NavBarOverlay,
		Bottom
	}

	[Native]
	public enum RMessageDuration : nint
	{
		Automatic = 0,
		Endless = -1
	}
}
