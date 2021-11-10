Set-Location -Path /Users/bvd/Workspace/hack-your-cs-education/code/scripting/data

# Write file content to out_file
# $out_file = New-Item -Path '../out_file.txt' -Force
# foreach($file in Get-ChildItem) {
#   Get-Content $file | Out-File -Path $out_file -Append
# }

foreach($file in Get-ChildItem) {
  $json = Get-Content $file | ConvertFrom-Json
  foreach($person in $json) {
    Write-Host $person
  }
}