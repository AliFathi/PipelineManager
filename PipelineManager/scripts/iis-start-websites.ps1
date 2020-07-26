$siteNamesPattern = '';

Get-Website | Where-Object { $_.Name -match $siteNamesPattern } | Start-WebSite