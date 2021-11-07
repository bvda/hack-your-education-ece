Set-Location -Path /Users/bvd/Workspace/hack-your-cs-education/code/scripting/data
# $array = Get-ChildItem
# for ($count = 0; $count -lt $array.Count; $count++) {
#   Write-Host $array[$count]
# }

# Print file paths and write them file
$merged = New-Item -Path '../merged.txt' -ItemType File -Force
foreach($file in Get-ChildItem) {
  Write-Host $file
  $file.FullName | Out-File $merged -Append
}

# Write file content to out_file
$out_file = New-Item -Path '../out_file.txt' -Force
foreach($file in Get-ChildItem) {
  Get-Content $file | Out-File -Path $out_file -Append
}
