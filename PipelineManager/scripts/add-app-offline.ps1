$html ='<!DOCTYPE html>
<html>
<head>
<title>Service Unavailable</title>
</head>
<body>
<h3>Service Unavailable</h3>
<p>Please try again later.</p>
</body>
</html>
';

$siteNamesPattern = '';

Get-Website | Where-Object {
    $_.Name -match $siteNamesPattern
} | ForEach-Object {
    New-Item -Path $_.PhysicalPath -Name 'app_offline.htm' -ItemType 'File' -Value $html
}
