﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Volo.Abp.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string phoneNumber, string text, IDictionary<string, object> extraParameter);
    }
}
