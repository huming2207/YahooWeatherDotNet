﻿using System;
using Newtonsoft.Json;

namespace YahooWeatherParser.Shared
{
	[JsonObject()]
	public class Query
	{
		[JsonProperty(PropertyName = "count")]
		public int Count { get; set; }

		[JsonProperty(PropertyName = "created")]
		public DateTime CreatedTime { get; set; }

		[JsonProperty(PropertyName = "lang")]
		public string Language { get; set; }

		[JsonProperty(PropertyName = "results")]
		public Results Results { get; set; }

	}
}

