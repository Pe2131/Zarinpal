﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Zarinpal.Models
{
    public class PaymentVerificationWithExtraResponse
    {
        public int Status { get; set; }
        [JsonProperty("RefID")]
        public int RefId { get; set; }
        public string ExtraDetail { get; set; }
    }
}
