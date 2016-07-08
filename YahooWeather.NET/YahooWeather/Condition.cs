﻿using System;
using Newtonsoft.Json;

namespace YahooWeather.NET
{
	[JsonObject()]
	public class Condition
	{
		[JsonProperty(PropertyName = "code")]
		public int Code { get; set; }

		[JsonProperty(PropertyName = "date")]
		public string Date { get; set; }

		[JsonProperty(PropertyName = "temp")]
		public string Temperature { get; set; }

		[JsonProperty(PropertyName = "text")]
		public string StatusText { get; set; }
	}
}

