﻿using CryptoAPI.BLL.Services;
using CryptoAPI.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CryptingAppController : ControllerBase
	{
		private readonly CryptingAppAPI _cryptingAppAPI;
		private readonly ILogger<CryptingAppController> _logger;
		public CryptingAppController(CryptingAppAPI cryptingAppAPI, ILogger<CryptingAppController> logger)
		{
			_cryptingAppAPI = cryptingAppAPI;
			_logger = logger;
		}

		[HttpGet]

		public async Task<Root> GetProductComposition()
		{
			var crypt = await _cryptingAppAPI.GetAll();
			if (crypt == null)
			{
				return null;
			}
			return crypt;
		}


		[HttpGet("{size}")]

		public async Task<Root> GetProductComposition(int size)
		{
			var crypt = await _cryptingAppAPI.GetBySize(size);
			if (crypt == null)
			{
				return null;
			}
			return crypt;
		}

	}

}
