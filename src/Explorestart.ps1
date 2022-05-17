Stop-Process -Name "explorer" -Force -ErrorAction SilentlyContinue
if($null -eq (Get-Process -Name "explorer" -ErrorAction SilentlyContinue)){
    Start-Process -FilePath "explorer" -ErrorAction SilentlyContinue
}
