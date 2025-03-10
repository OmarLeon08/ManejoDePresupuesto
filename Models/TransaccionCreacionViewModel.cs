﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ManejoProesupuesto.Models
{
	public class TransaccionCreacionViewModel : Transaccion
	{
		public IEnumerable<SelectListItem> Cuentas { get; set; }
		public IEnumerable<SelectListItem> Categorias { get; set; }
    }
}
