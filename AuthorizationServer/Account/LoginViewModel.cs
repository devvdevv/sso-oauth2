﻿using System.Collections.Specialized;

namespace AuthorizationServer.Account;

public class LoginViewModel : LoginInputModel
{
    public bool AllowRememberLogin { get; set; } = true;
    
    public bool EnableLocalLogin { get; set; } = true;

    // public IEnumerable<ExternalProvider> ExternalProviders { get; set; }
    // public IEnumerable<ExternalProvider> VisibleExternalProviders => ExternalProviders.Where(x => !string.IsNullOrWhiteSpace(x.DisplayName));

    // public bool IsExternalLoginOnly => EnableLocalLogin == false && ExternalProviders?.Count() == 1;
    // public string ExternalLoginScheme => IsExternalLoginOnly ? ExternalProviders?.SingleOrDefault()?.AuthenticationScheme : null;
    //
    public NameValueCollection? Parameters { get; set; }
}