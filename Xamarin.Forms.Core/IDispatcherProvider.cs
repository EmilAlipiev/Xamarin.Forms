﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms
{
	public interface IDispatcherProvider
	{
		IDispatcher GetDispatcher(object context);
	}
}
