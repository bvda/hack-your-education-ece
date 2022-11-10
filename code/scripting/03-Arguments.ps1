param ($Prefix='')

Write-Host($args)

$src_path = $args[0]
$dest_path = $args[1]

New-Item -Path $dest_path -ItemType Directory -Force | Out-Null
Push-Location $src_path
foreach($file in Get-ChildItem) {
  Write-Host "Copying $file to $dest_path"
  Copy-Item $file -Destination $dest_path
}
Write-Host($dest_path)

Pop-Location