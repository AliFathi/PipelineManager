$path = 'path\to\archives\folder';
$archiveNamesPattern = '*.zip'

Get-ChildItem -Path $path -Filter $archiveNamesPattern | ForEach-Object { 
    Expand-Archive -LiteralPath $_.FullName -DestinationPath ($path + $_.BaseName) -Force
}
