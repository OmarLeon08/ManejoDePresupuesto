﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace ManejoProesupuesto.Models
{
	public class CuentaCreacionViewModel : Cuenta
	{

		public IEnumerable<SelectListItem> TiposCuentas { get; set; }

	}
}
