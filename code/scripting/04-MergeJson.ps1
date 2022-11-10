# Set current working directory
Set-Location -Path /Users/au299473/Workspace/hack-your-education-ece/code/scripting/data

# Create ArrayList
$result_base = New-Object System.Collections.ArrayList

# Loop through files in current working directory
foreach($file in Get-ChildItem) {

  Write-Host "Reading $file"

  # Convert file content to JSON
  $json = Get-Content -Raw $file | ConvertFrom-Json

  # Loop through each entry in JSON array
  foreach($person in $json) {
    $result_base.Add($person) | Out-Null
  }
}

# Convert Array to JSON and write to file
$result_base | ConvertTo-Json | Out-File (New-Item -Path ../out/merged-chunks.json -Force)

Set-Location -Path /Users/au299473/Workspace/hack-your-education-ece/code/scripting
