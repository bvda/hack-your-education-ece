param ($src_path, $dest_path)

Write-Host($args)

# Print provided arguments to console
foreach($arg in $args) {
  Write-Host $arg
}

# Named parameters
Set-Location $src_path
foreach($file in Get-ChildItem) {
  Write-Host $file
}

Invoke-Item "../out_file.txt"
