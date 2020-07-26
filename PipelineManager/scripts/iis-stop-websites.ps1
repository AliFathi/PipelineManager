$siteNamesPattern = '';

Get-Website | Where-Object { $_.Name -match $siteNamesPattern } | Stop-WebSite