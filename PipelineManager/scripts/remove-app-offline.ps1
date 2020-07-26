$siteNamesPattern = '';

Get-Website | Where-Object {
    $_.Name -match $siteNamesPattern
} | ForEach-Object {
    Get-ChildItem -Path $_.PhysicalPath -Filter 'app_offline.htm' | Remove-Item
}
